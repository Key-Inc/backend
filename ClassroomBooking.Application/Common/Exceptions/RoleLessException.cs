using ClassroomBooking.Application.Common.Exceptions.Base;

namespace ClassroomBooking.Application.Common.Exceptions;

public sealed class RoleLessException : ForbiddenException
{
    public RoleLessException() : base("The role is less than required") {}
}