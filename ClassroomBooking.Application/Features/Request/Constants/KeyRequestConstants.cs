namespace ClassroomBooking.Application.Features.Request.Constants;

public static class KeyRequestConstants
{
    public static readonly TimeSpan MinPossibleStartTime = new(8, 0, 0);
    public static readonly TimeSpan MaxPossibleEndTime = new(21, 0, 0);
    public const int NumberOfDaysInAWeek = 7;
}