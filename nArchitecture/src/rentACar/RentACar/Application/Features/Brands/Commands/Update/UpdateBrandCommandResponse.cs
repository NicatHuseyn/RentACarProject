using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Update;

public class UpdateBrandCommandResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }
}
