using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HouseOnSale.Shared.Interfaces.Extensions;

public static class ModelStateExtensions
{   
    public static List<string> GetErrorMessages(this ModelStateDictionary dictionary)
    {
        return dictionary
            .SelectMany(m => m.Value!.Errors)
            .Select(m => m.ErrorMessage)
            .ToList();
    }
}