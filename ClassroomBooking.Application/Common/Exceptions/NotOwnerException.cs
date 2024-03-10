using ClassroomBooking.Application.Common.Exceptions.Base;

namespace ClassroomBooking.Application.Common.Exceptions;

public sealed class NotOwnerException : BadRequestException
{
    public NotOwnerException(Guid ownerId) : base($"User ({ownerId}) is not owner") {} 
}