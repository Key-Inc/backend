using AutoMapper;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Application.DTOs.Responses;
using MediatR;

namespace ClassroomBooking.Application.Features.Key.Queries.GetKeys;

public sealed class GetKeysQueryHandler: IRequestHandler<GetKeysQuery, IEnumerable<KeyFullDto>>
{
    private readonly IKeyRepository _keyRepository;
    private readonly IMapper _mapper;

    public GetKeysQueryHandler(IKeyRepository keyRepository, IMapper mapper)
    {
        _keyRepository = keyRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<KeyFullDto>> Handle(GetKeysQuery request, CancellationToken cancellationToken)
    {
        var keys = await _keyRepository.GetKeyByStatusAsync(request.Status);
        return _mapper.Map<IEnumerable<KeyFullDto>>(keys);
    }
}