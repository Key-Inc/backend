using System.ComponentModel.DataAnnotations;

namespace ClassroomBooking.Application.Common.ValidationAttributes;

public sealed class DateLessThanTodayAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext) =>
        value == null || (DateOnly)value < DateOnly.FromDateTime(DateTime.UtcNow)
            ? ValidationResult.Success
            : new ValidationResult("Birth date can't be later than today");
}