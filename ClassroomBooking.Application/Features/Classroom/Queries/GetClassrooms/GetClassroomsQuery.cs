using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using MediatR;

namespace ClassroomBooking.Application.Features.Classroom.Queries.GetClassrooms;

public sealed record GetClassroomsQuery(ClassroomSearchParameters Parameters): IRequest<ClassroomPagedListDto>;
