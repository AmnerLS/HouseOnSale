using HouseOnSale.Staff.Domain.Model.Commands;
using HouseOnSale.Staff.Domain.Model.ValueObjects;

namespace HouseOnSale.Staff.Domain.Model.Aggregates;

public class SalesAgent
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public Commision Commission { get; private set; }
    public SalesCount SalesCount { get; private set; }
    public LicenseId LicenseId { get; private set; }

    public SalesAgent()
    {
        Name = string.Empty;
        Commission = new Commision(0);
        SalesCount = new SalesCount(0);
        LicenseId = new LicenseId(0);
    }
    public SalesAgent(string name, int commission, int salesCount, int licenseId)
    {
        Name = name;
        Commission = new Commision(commission);
        SalesCount = new SalesCount(salesCount);
        LicenseId = new LicenseId(licenseId);
    }
    
    public SalesAgent(CreateSalesAgentCommand command) : this(command.Name, command.Commission, command.SalesCount, command.LicenseId)
    {
    }
    
}