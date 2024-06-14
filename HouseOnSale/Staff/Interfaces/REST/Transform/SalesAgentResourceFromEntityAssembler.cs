using HouseOnSale.Staff.Domain.Model.Aggregates;
using HouseOnSale.Staff.Interfaces.REST.Resources;

namespace HouseOnSale.Staff.Interfaces.REST.Transform;

public static class SalesAgentResourceFromEntityAssembler
{
    public static SalesAgentResource ToResourceFromEntity(SalesAgent entity)
    {
        return new SalesAgentResource(
            entity.Id,
            entity.Name,
            entity.Commission.Value,
            entity.SalesCount.Value,
            entity.LicenseId.Id
            );
    }
}