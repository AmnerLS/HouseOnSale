namespace HouseOnSale.Staff.Domain.Model.ValueObjects;

public record LicenseId
{
    public int Id { get; }
    

    public LicenseId(int id)
    {
        if (id <= 0)
            throw new Exception("License Id cannot be negative");
        Id = id;
    }
       
}