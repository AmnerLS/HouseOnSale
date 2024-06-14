using HouseOnSale.Shared.Domain.Repositories;
using HouseOnSale.Staff.Domain.Model.Aggregates;
using HouseOnSale.Staff.Domain.Model.ValueObjects;

namespace HouseOnSale.Staff.Domain.Repositories;

public interface ISalesAgentRepository : IBaseRepository<SalesAgent>
{
    bool ExistsWithNameAndLicenseId(string name, LicenseId licenseId);
}