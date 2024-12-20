using Application.Features.Brands.Commands.Create;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBrandCommandReuqest reuqest)
        {
            var response = await Mediator.Send(reuqest);
            return Ok(response);
        }
    }
}
