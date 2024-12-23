using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Queries.GetList;


public class GetListBRandQueryHandler(IBrandRepository repository, IMapper mapper) : IRequestHandler<GetListBrandQueryRequest, GetListResponse<GetListBrandQueryResponse>>
{
    public async Task<GetListResponse<GetListBrandQueryResponse>> Handle(GetListBrandQueryRequest request, CancellationToken cancellationToken)
    {
        Paginate<Brand> brands = await repository.GetListAsync(
            index:request.PageRequest.PageIndex,
            size:request.PageRequest.PageSize,
            cancellationToken:default
            );

        GetListResponse<GetListBrandQueryResponse> response = mapper.Map<GetListResponse<GetListBrandQueryResponse>>(brands);

        return response;

    }
}
