using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Application.Features.Brands.Commands.Delete;

public class DeleteBrandCommandRequest:IRequest<DeleteBrandCommandResponse>
{
    public Guid Id { get; set; }
}
