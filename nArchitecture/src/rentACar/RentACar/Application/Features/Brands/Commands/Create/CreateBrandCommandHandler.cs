using MediatR;

namespace Application.Features.Brands.Commands.Create;

public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommandReuqest, CreateBrandCommandResponse>
{
    public Task<CreateBrandCommandResponse> Handle(CreateBrandCommandReuqest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
