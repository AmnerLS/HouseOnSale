namespace HouseOnSale.Staff.Domain.Model.Commands;

public record CreateSalesAgentCommand(string Name, int Commission, int SalesCount, int LicenseId);