using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Queries.GetById;

public class GetByIdBrandQueryHandler(IBrandRepository repository, IMapper mapper) : IRequestHandler<GetByIdBrandQueryRequest, GetByIdBrandQueryResponse>
{
    public async Task<GetByIdBrandQueryResponse> Handle(GetByIdBrandQueryRequest request, CancellationToken cancellationToken)
    {
        Brand? brand = await repository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

        var response = mapper.Map<GetByIdBrandQueryResponse>(brand);
        return response;
    }
}
