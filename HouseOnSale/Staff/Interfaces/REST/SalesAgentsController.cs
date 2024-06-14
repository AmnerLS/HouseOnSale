using System.Net.Mime;
using HouseOnSale.Staff.Domain.Services;
using HouseOnSale.Staff.Interfaces.REST.Resources;
using HouseOnSale.Staff.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;


namespace HouseOnSale.Staff.Interfaces.REST;


[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class SalesAgentsController(ISalesAgentCommandService salesAgentCommandService, ISalesAgentQueryService salesAgentQueryService) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult> CreateSalesAgent([FromBody] CreateSalesAgentResource resource)
    {
        Console.WriteLine(resource);
        var createSalesAgentCommand = CreateSalesAgentCommandFromResourceAssembler.ToCommandFromResource(resource);
        Console.WriteLine(createSalesAgentCommand);
        var salesAgent = await salesAgentCommandService.Handle(createSalesAgentCommand);
        if (salesAgent is null) return BadRequest();
        var salesAgentResource = SalesAgentResourceFromEntityAssembler.ToResourceFromEntity(salesAgent);
        return Ok(salesAgentResource);
    }
}