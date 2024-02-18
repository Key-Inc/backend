using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using MediatR;

namespace ClassroomBooking.Application.Features.Request.Commands.DeleteMyRequest;

public class DeleteMyRequestCommandHandler: IRequestHandler<DeleteMyRequestCommand>
{
    private readonly IKeyRequestRepository _requestRepository;

    public DeleteMyRequestCommandHandler(IKeyRequestRepository requestRepository)
    {
        _requestRepository = requestRepository;
    }

    public async Task Handle(DeleteMyRequestCommand request, CancellationToken cancellationToken)
    {
        var keyRequest = await _requestRepository.GetByIdAsync(request.RequestId);
        if (keyRequest == null) throw new NotFoundException(nameof(KeyRequest), request.RequestId);
        if (keyRequest.UserId != request.UserId)
            throw new BadRequestException($"User with id={request.UserId} is not the owner");

        await _requestRepository.DeleteAsync(keyRequest);
    }
}