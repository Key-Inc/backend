using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Domain.Entities;
using ClassroomBooking.Domain.Entities.Enums;
using MediatR;

namespace ClassroomBooking.Application.Features.Key.Commands.GiveKey;

public class GiveKeyCommandHandler: IRequestHandler<GiveKeyCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly IKeyRepository _keyRepository;

    public GiveKeyCommandHandler(IUserRepository userRepository, IKeyRepository keyRepository)
    {
        _userRepository = userRepository;
        _keyRepository = keyRepository;
    }

    public async Task Handle(GiveKeyCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdAsync(request.UserId);
        if (user == null) throw new NotFoundException(nameof(User), request.UserId);
        
        var key = await _keyRepository.GetByIdAsync(request.KeyId);
        if (key == null) throw new NotFoundException(nameof(Domain.Entities.Key), request.KeyId);
        if (key.UserId == request.UserId)
            throw new BadRequestException($"User with id={request.UserId} already has key with id={request.KeyId}");
        
        key.UserId = request.UserId;
        await _keyRepository.UpdateAsync(key);
    }
}