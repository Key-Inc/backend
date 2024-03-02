using AutoMapper;
using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using MediatR;

namespace ClassroomBooking.Application.Features.Request.Queries.GetOverlappingRequests;

public sealed class GetOverlappingRequestHandler: IRequestHandler<GetOverlappingRequestQuery, IEnumerable<KeyRequestFullDto>>
{
    private readonly IKeyRequestRepository _requestRepository;
    private readonly IMapper _mapper;

    public GetOverlappingRequestHandler(IKeyRequestRepository requestRepository, IMapper mapper)
    {
        _requestRepository = requestRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<KeyRequestFullDto>> Handle(GetOverlappingRequestQuery request, CancellationToken cancellationToken)
    {
        var keyRequest = await _requestRepository.GetByIdAsync(request.RequestId);
        if (keyRequest == null) throw new NotFoundException(nameof(KeyRequest), request.RequestId);

        if (keyRequest.Status == RequestStatus.Accepted)
            throw new BadRequestException($"Request with id={keyRequest.Id} can't be overlapping");

        var keyRequests = await _requestRepository.GetOverlappingAsync(keyRequest);

        return _mapper.Map<IEnumerable<KeyRequestFullDto>>(keyRequests);
    }
}