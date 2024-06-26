using Application.Features.MaterialProperties.Commands.Create;
using Application.Features.MaterialProperties.Commands.Delete;
using Application.Features.MaterialProperties.Commands.Update;
using Application.Features.MaterialProperties.Queries.GetById;
using Application.Features.MaterialProperties.Queries.GetList;
using Application.Features.MaterialProperties.Queries.GetList.GetListAll;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Application.Features.Languages.Queries.GetList.GetAll;
using Application.Features.MaterialProperties.Queries.GetList.GetAll;

namespace WebAPI.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class MaterialPropertiesController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateMaterialPropertyCommand createMaterialPropertyCommand)
    {
        CreatedMaterialPropertyResponse response = await Mediator.Send(createMaterialPropertyCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateMaterialPropertyCommand updateMaterialPropertyCommand)
    {
        UpdatedMaterialPropertyResponse response = await Mediator.Send(updateMaterialPropertyCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedMaterialPropertyResponse response = await Mediator.Send(new DeleteMaterialPropertyCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdMaterialPropertyResponse response = await Mediator.Send(new GetByIdMaterialPropertyQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListMaterialPropertyQuery getListMaterialPropertyQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListMaterialPropertyListItemDto> response = await Mediator.Send(getListMaterialPropertyQuery);
        return Ok(response);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetListAll([FromQuery] GetListAllMaterialPropertyQuery getListAllMaterialPropertyQuery)
    { 
        List<GetListAllMaterialPropertyDto> response = await Mediator.Send(getListAllMaterialPropertyQuery);
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] GetAllMaterialPropertiesQuery getAllMaterialPropertiesQuery)
    {
        List<GetAllMaterialPropertiesDto> response = await Mediator.Send(getAllMaterialPropertiesQuery);
        return Ok(response);
    }
}