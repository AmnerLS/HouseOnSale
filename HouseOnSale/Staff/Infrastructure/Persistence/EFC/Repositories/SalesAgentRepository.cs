using HouseOnSale.Shared.Infrastructure.Persistence.EFC.Configuration;
using HouseOnSale.Shared.Infrastructure.Persistence.EFC.Repositories;
using HouseOnSale.Staff.Domain.Model.Aggregates;
using HouseOnSale.Staff.Domain.Model.ValueObjects;
using HouseOnSale.Staff.Domain.Repositories;

namespace HouseOnSale.Staff.Infrastructure.Persistence.EFC.Repositories;

public class SalesAgentRepository(AppDbContext context) : BaseRepository<SalesAgent>(context), ISalesAgentRepository
{
    public bool ExistsWithNameAndLicenseId(string name, LicenseId licenseId)
    {
        return Context.Set<SalesAgent>().Any(a => a.Name == name && a.LicenseId == licenseId);
    }
}