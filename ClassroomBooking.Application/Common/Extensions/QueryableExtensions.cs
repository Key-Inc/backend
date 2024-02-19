using AutoMapper;
using AutoMapper.QueryableExtensions;
using ClassroomBooking.Application.Common.Exceptions.Base;
using ClassroomBooking.Application.DTOs.Requests;
using ClassroomBooking.Application.DTOs.Responses;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Application.Common.Extensions;

public static class QueryableExtensions
{
    public static async Task<PagedListDto<TD>> ToPagedListAsync<TS, TD>(
        this IQueryable<TS> query,
        PaginationParameters parameters, 
        IConfigurationProvider configurationProvider)
    {
        var totalPages = (int)Math.Ceiling(query.Count() / (parameters.Size * 1.0));
        if (parameters.Page > totalPages && query.Any()) throw new BadRequestException("Invalid value for attribute page");

        var paged = query
            .Skip((parameters.Page - 1) * parameters.Size)
            .Take(parameters.Size);
        
        var pagedList = await paged
            .ProjectTo<TD>(configurationProvider)
            .ToListAsync();
        
        var pageInfo = new PageInfoDto
        {
            Size = Math.Min(parameters.Size, pagedList.Count),
            Count = totalPages,
            Current = parameters.Page
        };

        return new PagedListDto<TD> { Items = pagedList, Pagination = pageInfo };
    }
}