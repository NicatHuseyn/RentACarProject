using MediatR;

namespace Application.Features.Brands.Commands.Create;

public class CreateBrandCommandReuqest:IRequest<CreateBrandCommandResponse>
{
    public string Name { get; set; }
}
