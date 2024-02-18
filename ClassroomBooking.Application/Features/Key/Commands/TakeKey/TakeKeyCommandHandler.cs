using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using MediatR;

namespace ClassroomBooking.Application.Features.Key.Commands.TakeKey;

public class TakeKeyCommandHandler: IRequestHandler<TakeKeyCommand>
{
    private readonly IKeyRepository _keyRepository;

    public TakeKeyCommandHandler(IKeyRepository keyRepository)
    {
        _keyRepository = keyRepository;
    }

    public async Task Handle(TakeKeyCommand request, CancellationToken cancellationToken)
    {
        var key = await _keyRepository.GetByIdAsync(request.KeyId);
        
        if (key == null) throw new NotFoundException(nameof(Domain.Entities.Key), request.KeyId);

        if (key.UserId == null)
            throw new BadRequestException($"The key with id={request.KeyId} is already in the dean's office");

        key.UserId = null;

        await _keyRepository.UpdateAsync(key);
    }
}