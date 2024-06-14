using HouseOnSale.Staff.Domain.Model.Commands;
using HouseOnSale.Staff.Interfaces.REST.Resources;

namespace HouseOnSale.Staff.Interfaces.REST.Transform;

public static class CreateSalesAgentCommandFromResourceAssembler
{
    public static CreateSalesAgentCommand ToCommandFromResource(CreateSalesAgentResource resource)
    {
        return new CreateSalesAgentCommand(
            resource.Name,
            resource.Commission,
            resource.SalesCount,
            resource.LicenseId
            );
    }
}