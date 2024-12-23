using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Commands.Create;

public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommandReuqest, CreateBrandCommandResponse>
{
    private readonly IBrandRepository _brandRepository;
    private readonly IMapper _mapper;

    public CreateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper)
    {
        _brandRepository = brandRepository;
        _mapper = mapper;
    }

    public async Task<CreateBrandCommandResponse> Handle(CreateBrandCommandReuqest request, CancellationToken cancellationToken)
    {
        var brand = _mapper.Map<Brand>(request);
        brand.Id = Guid.NewGuid();

        var result = await _brandRepository.AddAsync(brand);
        var responseMapping = _mapper.Map<CreateBrandCommandResponse>(result);

        return responseMapping;
    }
}
