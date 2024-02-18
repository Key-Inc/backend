using AutoMapper;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Application.DTOs.Responses;
using MediatR;

namespace ClassroomBooking.Application.Features.Request.Queries.GetMyRequests;

public class GetMyRequestsQueryHandler: IRequestHandler<GetMyRequestsQuery, IEnumerable<KeyRequestDto>>
{
    private readonly IKeyRequestRepository _requestRepository;
    private readonly IMapper _mapper;

    public GetMyRequestsQueryHandler(IKeyRequestRepository requestRepository, IMapper mapper)
    {
        _requestRepository = requestRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<KeyRequestDto>> Handle(GetMyRequestsQuery request, CancellationToken cancellationToken)
    {
        var requests = await _requestRepository.GetByUserIdAsync(request.UserId);
        return _mapper.Map<IEnumerable<KeyRequestDto>>(requests);
    }
}