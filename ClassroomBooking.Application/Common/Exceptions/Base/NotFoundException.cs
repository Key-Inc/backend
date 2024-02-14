namespace ClassroomBooking.Application.Common.Exceptions.Base;

public class NotFoundException : Exception
{
    public NotFoundException() {}
    
    public NotFoundException(string message) : base(message) {}
    
    public NotFoundException(string name, object key)
        : base($"Entity {name} ({key}) was not found.") {}
}