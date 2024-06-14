namespace HouseOnSale.Staff.Domain.Model.ValueObjects;

public record SalesCount
{
    public int Value { get; }
    

    public SalesCount(int value)
    {
        if (value < 0)
            throw new Exception( "The sales count cannot be negative.");
        Value = value;
    }
}