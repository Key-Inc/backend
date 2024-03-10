using System.ComponentModel.DataAnnotations;
using AutoMapper;
using ClassroomBooking.Application.Common.Mappings;
using ClassroomBooking.Domain.Entities;

namespace ClassroomBooking.Application.DTOs.Responses;

public sealed class TransferKeyRequestDto : IMapFrom<TransferKeyRequest>
{
    [Required]
    public required Guid ApplicantId { get; set; }
    
    [Required]
    public required string ApplicantName { get; set; }

    [Required] public required KeyDto Key { get; set; }
    
    public void Mapping(Profile profile)
    {
        profile.CreateMap<TransferKeyRequest, TransferKeyRequestDto>()
            .ForMember(dest => dest.ApplicantId, opt => opt.MapFrom(src => src.Key!.UserId))
            .ForMember(dest => dest.ApplicantName, opt => opt.MapFrom(src => src.Key!.User!.FullName));
    }
}