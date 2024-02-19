using ClassroomBooking.Application.Common.Exceptions.Base;

namespace ClassroomBooking.Application.Common.Exceptions;

public sealed class RegistrationRequestConsideredException : BadRequestException
{
    public RegistrationRequestConsideredException(Guid applicantId) : 
        base($"Registration request of user ({applicantId}) has already been considered") {}
}