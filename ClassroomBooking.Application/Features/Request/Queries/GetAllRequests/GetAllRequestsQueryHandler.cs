using AutoMapper;
using ClassroomBooking.Application.Common.Extensions;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Application.DTOs.Enums;
using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Application.Features.Request.Queries.GetAllRequests;

public sealed class GetAllRequestsQueryHandler : IRequestHandler<GetAllRequestsQuery, PagedListDto<KeyRequestFullDto>>
{
    private readonly IMapper _mapper;
    private readonly IKeyRequestRepository _keyRequestRepository;

    public GetAllRequestsQueryHandler(IMapper mapper, IKeyRequestRepository keyRequestRepository)
    {
        _mapper = mapper;
        _keyRequestRepository = keyRequestRepository;
    }
    
    public async Task<PagedListDto<KeyRequestFullDto>> Handle(GetAllRequestsQuery request, CancellationToken cancellationToken)
    {
        IQueryable<KeyRequest> keyRequests = _keyRequestRepository.Entities.Include(keyRequest => keyRequest.User);

        keyRequests = GetFilteredRequests(keyRequests, request.SearchParameters);
        keyRequests = GetSortedRequests(keyRequests, request.SearchParameters.Sorting);

        var pagedList = await keyRequests.ToPagedListAsync<KeyRequest, KeyRequestFullDto>(
            request.SearchParameters, 
            _mapper.ConfigurationProvider);

        return pagedList;
    }

    private static IQueryable<KeyRequest> GetSortedRequests(IQueryable<KeyRequest> requests, KeyRequestSorting? sortingType)
    {
        return sortingType switch
        {
            KeyRequestSorting.CreateAsc => requests.OrderBy(request => request.CreateTime),
            KeyRequestSorting.CreateDesc => requests.OrderByDescending(request => request.CreateTime),
            _ => requests
        };
    }

    private static IQueryable<KeyRequest> GetFilteredRequests(
        IQueryable<KeyRequest> requests,
        KeyRequestSearchParameters parameters)
    {
        if (parameters.MinDate != null)
            requests = requests.Where(request => request.CreateTime >= parameters.MinDate);

        if (parameters.MaxDate != null)
            requests = requests.Where(request => request.CreateTime <= parameters.MaxDate);

        if (parameters.FullName != null)
            requests = requests.Where(request => request.User != null 
                                                 && request.User.FullName.ToUpper().Contains(parameters.FullName.ToUpper()));

        if (parameters.Role != null)
            requests = requests.Where(request => request.User != null 
                                                 && request.User.UserRole != null 
                                                 && request.User.UserRole == parameters.Role);

        return requests;
    }
}