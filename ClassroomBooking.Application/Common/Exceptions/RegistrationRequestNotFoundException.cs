using ClassroomBooking.Application.Common.Exceptions.Base;

namespace ClassroomBooking.Application.Common.Exceptions;

public sealed class RegistrationRequestNotFoundException : NotFoundException
{
    public RegistrationRequestNotFoundException(Guid userId) :
        base($"Registration request of user ({userId}) was not found") {}
}