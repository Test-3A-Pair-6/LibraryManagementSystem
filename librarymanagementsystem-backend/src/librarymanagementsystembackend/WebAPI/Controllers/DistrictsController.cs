using Application.Features.Districts.Commands.Create;
using Application.Features.Districts.Commands.Delete;
using Application.Features.Districts.Commands.Update;
using Application.Features.Districts.Queries.GetById;
using Application.Features.Districts.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Application.Features.Districts.Queries.GetDynamic;
using NArchitecture.Core.Persistence.Dynamic;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DistrictsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateDistrictCommand createDistrictCommand)
    {
        CreatedDistrictResponse response = await Mediator.Send(createDistrictCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateDistrictCommand updateDistrictCommand)
    {
        UpdatedDistrictResponse response = await Mediator.Send(updateDistrictCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedDistrictResponse response = await Mediator.Send(new DeleteDistrictCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdDistrictResponse response = await Mediator.Send(new GetByIdDistrictQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListDistrictQuery getListDistrictQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListDistrictListItemDto> response = await Mediator.Send(getListDistrictQuery);
        return Ok(response);
    }


    [HttpPost("Dynamic")]
    public async Task<IActionResult> GetDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery dynamic)
    {
        GetDynamicQuery getDynamicQuery = new()
        {
            PageRequest = pageRequest,
            Dynamic = dynamic
        };
        GetListResponse<GetDynamicDistrictResponse> response = await Mediator.Send(getDynamicQuery);
        return Ok(response);
    }
}