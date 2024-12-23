using Core.Application.Requests;
using Core.Application.Responses;
using MediatR;

namespace Application.Features.Brands.Queries.GetList;

public class GetListBrandQueryRequest:IRequest<GetListResponse<GetListBrandQueryResponse>>
{
    public PageRequest PageRequest { get; set; }
}
