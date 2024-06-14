using HouseOnSale.Staff.Domain.Model.Aggregates;
using HouseOnSale.Staff.Domain.Model.Queries;
using HouseOnSale.Staff.Domain.Repositories;
using HouseOnSale.Staff.Domain.Services;

namespace HouseOnSale.Staff.Application.QueryService;

public class SalesAgentQueryService(ISalesAgentRepository salesAgentRepository) : ISalesAgentQueryService
{
    public async Task<SalesAgent?> Handle(GetSalesAgentByIdQuery query)
    {
        return await salesAgentRepository.FindByIdAsync(query.Id);
    }
}