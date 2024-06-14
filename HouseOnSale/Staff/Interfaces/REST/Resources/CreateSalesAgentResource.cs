namespace HouseOnSale.Staff.Interfaces.REST.Resources;

public record CreateSalesAgentResource(string Name, int Commission, int SalesCount, int LicenseId);