using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Commands.Delete;

public class DeleteBrandCommandHandler(IBrandRepository repository, IMapper mapper) : IRequestHandler<DeleteBrandCommandRequest, DeleteBrandCommandResponse>
{
    public async Task<DeleteBrandCommandResponse> Handle(DeleteBrandCommandRequest request, CancellationToken cancellationToken)
    {
        Brand? brand = await repository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken:cancellationToken);

        brand = mapper.Map(request,brand);

        await repository.DeleteAsync(brand!);

        var response = mapper.Map<DeleteBrandCommandResponse>(brand);
        return response;

    }
}
