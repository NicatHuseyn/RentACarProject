using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Commands.Update;

public class UpdateBrandCommandHandler(IBrandRepository repository, IMapper mapper) : IRequestHandler<UpdateBrandCommandRequest, UpdateBrandCommandResponse>
{
    public async Task<UpdateBrandCommandResponse> Handle(UpdateBrandCommandRequest request, CancellationToken cancellationToken)
    {
        Brand? brand = await repository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

        brand = mapper.Map(request,brand);

        brand.Name = request.Name;

        await repository.UpdateAsync(brand);
        var response = mapper.Map<UpdateBrandCommandResponse>(brand);
        return response;
    }
}
