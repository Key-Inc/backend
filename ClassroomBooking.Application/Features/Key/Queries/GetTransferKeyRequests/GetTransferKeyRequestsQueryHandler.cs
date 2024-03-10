using AutoMapper;
using ClassroomBooking.Application.Common.Extensions;
using ClassroomBooking.Application.Common.Interfaces.Repositories;
using ClassroomBooking.Application.DTOs.Responses;
using ClassroomBooking.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClassroomBooking.Application.Features.Key.Queries.GetTransferKeyRequests;

public sealed class GetTransferKeyRequestsQueryHandler : IRequestHandler<GetTransferKeyRequestsQuery, PagedListDto<TransferKeyRequestDto>>
{
    private readonly IMapper _mapper;
    private readonly ITransferKeyRequestRepository _transferKeyRequestRepository;

    public GetTransferKeyRequestsQueryHandler(IMapper mapper, ITransferKeyRequestRepository transferKeyRequestRepository)
    {
        _mapper = mapper;
        _transferKeyRequestRepository = transferKeyRequestRepository;
    }

    public async Task<PagedListDto<TransferKeyRequestDto>> Handle(GetTransferKeyRequestsQuery request,
        CancellationToken cancellationToken)
    {
        IQueryable<TransferKeyRequest> transferRequests = _transferKeyRequestRepository.Entities
            .Where(req => req.RecipientId == request.RecipientId)
            .Include(req => req.Recipient)
            .Include(req => req.Key);

        if (request.SearchParameters.ApplicantName != null)
            transferRequests = transferRequests.Where(req => 
                req.Key != null
                && req.Key.User != null
                && req.Key.User.FullName.ToUpper().Contains(request.SearchParameters.ApplicantName.ToUpper()));

        if (request.SearchParameters.Status != null)
            transferRequests = transferRequests.Where(req => req.Status == request.SearchParameters.Status);
        
        var pagedList = await transferRequests.ToPagedListAsync<TransferKeyRequest, TransferKeyRequestDto>(
            request.SearchParameters,
            _mapper.ConfigurationProvider);

        return pagedList;
    }
}