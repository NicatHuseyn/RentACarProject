using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Application.Features.Brands.Commands.Update;

public class UpdateBrandCommandRequest:IRequest<UpdateBrandCommandResponse>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
