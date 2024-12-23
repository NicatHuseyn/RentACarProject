using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Commands.Delete;
using Application.Features.Brands.Commands.Update;
using Application.Features.Brands.Queries.GetById;
using Application.Features.Brands.Queries.GetList;
using Core.Application.Requests;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController(IMediator mediator) : BaseController
    {

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery]PageRequest request)
        {
            GetListBrandQueryRequest getListBrandQueryRequest = new() { PageRequest = request};
            var response = await mediator.Send(getListBrandQueryRequest);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdBrandQueryRequest request) => Ok(await mediator.Send(request));


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBrandCommandReuqest reuqest) => Ok(await mediator.Send(reuqest));

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateBrandCommandRequest request) => Ok(await mediator.Send(request));

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteBrandCommandRequest request) => Ok(await mediator.Send(request));
    }
}
