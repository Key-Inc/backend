using AutoMapper;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Application.DTOs.Responses;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Application.Features.Classroom.Queries.GetClassrooms;

public sealed record GetClassroomsQueryHandler: IRequestHandler<GetClassroomsQuery, ClassroomPagedListDto>
{
    private readonly IClassroomRepository _classroomRepository;
    private readonly IMapper _mapper;

    public GetClassroomsQueryHandler(IClassroomRepository classroomRepository, IMapper mapper)
    {
        _classroomRepository = classroomRepository;
        _mapper = mapper;
    }

    public async Task<ClassroomPagedListDto> Handle(GetClassroomsQuery request, CancellationToken cancellationToken)
    {
        var parameters = request.Parameters;
        var allPosts = _classroomRepository.Entities
            .Where(c => (parameters.Number == null || c.Number == parameters.Number) &&
                        (parameters.Building == null || c.Building == parameters.Building));
        
        var count = await allPosts.CountAsync(cancellationToken);
            
        var classrooms = await allPosts           
            .Skip((parameters.Page - 1) * parameters.Size)
            .Take(parameters.Size)
            .ToListAsync(cancellationToken);
        
        return new ClassroomPagedListDto
        {
            Classrooms = _mapper.Map<IEnumerable<ClassroomDto>>(classrooms),
            Pagination = new PageInfoDto
            {
                Count = (int)Math.Ceiling((double)count / parameters.Size),
                Current = parameters.Page,
                Size = parameters.Size
            }
        };
    }
}
