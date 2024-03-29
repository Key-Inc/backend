﻿using AutoMapper;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Application.DTOs.Responses;
using MediatR;

namespace ClassroomBooking.Application.Features.Key.Queries.GetMyKeys;

public class GetMyKeysQueryHandler: IRequestHandler<GetMyKeysQuery, IEnumerable<KeyDto>>
{
    private readonly IKeyRepository _keyRepository;
    private readonly IMapper _mapper;

    public GetMyKeysQueryHandler(IKeyRepository keyRepository, IMapper mapper)
    {
        _keyRepository = keyRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<KeyDto>> Handle(GetMyKeysQuery request, CancellationToken cancellationToken)
    {
        var keys = await _keyRepository.GetKeyByUserIdAsync(request.UserId);
        return _mapper.Map<IEnumerable<KeyDto>>(keys);
    }
}