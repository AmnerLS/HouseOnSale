using HouseOnSale.Staff.Domain.Model.Aggregates;
using HouseOnSale.Staff.Domain.Model.Commands;

namespace HouseOnSale.Staff.Domain.Services;

public interface ISalesAgentCommandService
{
    Task<SalesAgent?> Handle(CreateSalesAgentCommand command);
}