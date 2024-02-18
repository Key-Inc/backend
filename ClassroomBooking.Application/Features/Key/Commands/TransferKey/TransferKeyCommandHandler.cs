using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using MediatR;

namespace ClassroomBooking.Application.Features.Key.Commands.TransferKey;

public class TransferKeyCommandHandler: IRequestHandler<TransferKeyCommand>
{
    private readonly IKeyRepository _keyRepository;

    public TransferKeyCommandHandler(IKeyRepository keyRepository)
    {
        _keyRepository = keyRepository;
    }

    public async Task Handle(TransferKeyCommand request, CancellationToken cancellationToken)
    {
        var key = await _keyRepository.GetByIdAsync(request.KeyId);
        if (key == null) throw new NotFoundException(nameof(Domain.Entities.Key), request.KeyId);
        if (key.UserId != request.OwnerId) throw new BadRequestException($"User with id={request.OwnerId} is not owner");

        key.UserId = request.UserId;
        await _keyRepository.UpdateAsync(key);
    }
}