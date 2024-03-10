using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Domain.Entities;

namespace ClassroomBooking.Application.Common.Exceptions;

public sealed class UserNotFoundException : NotFoundException
{
    public UserNotFoundException(Guid userId) : base(nameof(User), userId) {}
}