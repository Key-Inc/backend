using AutoMapper;
using ClassroomBooking.Application.Common.Extensions;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Application.DTOs.Enums;
using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Application.Features.Account.Queries.GetConsideringUsers;

public sealed class GetConsideringUsersQueryHandler : IRequestHandler<GetConsideringUsersQuery, PagedListDto<UserDto>>
{
    private readonly IMapper _mapper;
    private readonly IRegistrationRequestRepository _registrationRequestRepository;

    public GetConsideringUsersQueryHandler(IMapper mapper, IRegistrationRequestRepository registrationRequestRepository)
    {
        _mapper = mapper;
        _registrationRequestRepository = registrationRequestRepository;
    }
    
    public async Task<PagedListDto<UserDto>> Handle(GetConsideringUsersQuery request, CancellationToken cancellationToken)
    {
        IQueryable<RegistrationRequest> registrationRequests = _registrationRequestRepository.Entities
            .Where(regRequest => regRequest.Status == RequestStatus.UnderConsideration)
            .Include(regRequest => regRequest.User);

        registrationRequests = GetFilteredRequests(registrationRequests, request.SearchParameters);
        registrationRequests = GetSortedRequests(registrationRequests, request.SearchParameters.Sorting);

        var users = registrationRequests
            .Select(regRequest => regRequest.User)
            .OfType<User>();

        return await users.ToPagedListAsync<User, UserDto>(request.SearchParameters, _mapper.ConfigurationProvider);
    }

    private static IQueryable<RegistrationRequest> GetSortedRequests(
        IQueryable<RegistrationRequest> requests,
        RegistrationRequestSorting? sortingType)
    {
        return sortingType switch
        {
            RegistrationRequestSorting.CreateAsc => requests.OrderBy(request => request.CreateTime),
            RegistrationRequestSorting.CreateDesc => requests.OrderByDescending(request => request.CreateTime),
            _ => requests
        };
    }

    private static IQueryable<RegistrationRequest> GetFilteredRequests(
        IQueryable<RegistrationRequest> registrationRequests,
        RegistrationRequestSearchParameters parameters)
    {
        if (parameters.NameQuery == null) return registrationRequests;
        
        registrationRequests = registrationRequests
            .Where(regRequest => regRequest.User != null 
                                 && regRequest.User.FullName.ToLower()
                                     .Contains(parameters.NameQuery.ToLower()));

        return registrationRequests;
    }
}