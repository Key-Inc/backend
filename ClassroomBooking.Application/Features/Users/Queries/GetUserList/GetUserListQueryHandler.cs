using AutoMapper;
using ClassroomBooking.Application.Common.Extensions;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Application.DTOs.Responses;
using MediatR;

namespace ClassroomBooking.Application.Features.Users.Queries.GetUserList;

public sealed class GetUserListQueryHandler : IRequestHandler<GetUserListQuery, PagedListDto<UserFullDto>>
{
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public GetUserListQueryHandler(IMapper mapper, IUserRepository userRepository)
    {
        _mapper = mapper;
        _userRepository = userRepository;
    }
    
    public async Task<PagedListDto<UserFullDto>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
    {
        var users = _userRepository.Entities;

        if (request.SearchParameters.NameQuery != null)
            users = users.Where(user => user.FullName.ToUpper().Contains(request.SearchParameters.NameQuery.ToUpper()));

        var pagedList = await users.ToPagedListAsync<Domain.Entities.User, UserFullDto>(
            request.SearchParameters,
            _mapper.ConfigurationProvider);

        return pagedList;
    }
}