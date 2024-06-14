using HouseOnSale.Staff.Domain.Model.Aggregates;
using HouseOnSale.Staff.Domain.Model.Queries;

namespace HouseOnSale.Staff.Domain.Services;

public interface ISalesAgentQueryService
{
    Task<SalesAgent?> Handle(GetSalesAgentByIdQuery query);
}