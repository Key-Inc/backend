using System.ComponentModel.DataAnnotations;
using AutoMapper;
using ClassroomBooking.Application.Common.Mappings;
using ClassroomBooking.Application.DTOs.Enums;
using ClassroomBooking.Domain.Entities;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class ScheduleDto: IMapFrom<KeyRequest>
{
    [Required]
    public required TimeOnly StartDate { get; set; }
    
    [Required]
    public required TimeOnly EndDate { get; set; }
    
    [Required]
    public required ScheduleStatus Status { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<KeyRequest, ScheduleDto>()
            .ForMember(dest => dest.Status,
                opt => opt.MapFrom(src => ScheduleStatus.Busy))
            .ForMember(dest => dest.StartDate,
                opt => opt.MapFrom(src => TimeOnly.FromDateTime(src.StartDate)))
            .ForMember(dest => dest.EndDate,
            opt => opt.MapFrom(src => TimeOnly.FromDateTime(src.EndDate)));
    }
}