using MediatR;

namespace Application.Features.Brands.Queries.GetById;

public class GetByIdBrandQueryRequest:IRequest<GetByIdBrandQueryResponse>
{
    public Guid Id { get; set; }
}
