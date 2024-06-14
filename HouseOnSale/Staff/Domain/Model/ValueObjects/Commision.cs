namespace HouseOnSale.Staff.Domain.Model.ValueObjects;

public record Commision
{
    public int Value { get; }
    
    
    public Commision(int value)
    {
        if (value < 1 || value > 50)
            throw new Exception("The commission value must be between 1 and 50.");
        Value = value;
    }
}