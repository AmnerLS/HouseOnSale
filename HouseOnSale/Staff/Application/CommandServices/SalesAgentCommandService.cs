using HouseOnSale.Shared.Domain.Repositories;
using HouseOnSale.Staff.Domain.Model.Aggregates;
using HouseOnSale.Staff.Domain.Model.Commands;
using HouseOnSale.Staff.Domain.Model.ValueObjects;
using HouseOnSale.Staff.Domain.Repositories;
using HouseOnSale.Staff.Domain.Services;

namespace HouseOnSale.Staff.Application.CommandServices;

public class SalesAgentCommandService(ISalesAgentRepository salesAgentRepository, IUnitOfWork unitOfWork) : ISalesAgentCommandService
{
    public async Task<SalesAgent?> Handle(CreateSalesAgentCommand command)
    {
        Console.WriteLine(command);
        var licenceId = new LicenseId(command.LicenseId);
        Console.WriteLine(licenceId);
        if(salesAgentRepository.ExistsWithNameAndLicenseId(command.Name, licenceId ))
            throw new Exception("Sales Agent with the same name and license id already exists");
        var salesAgent = new SalesAgent(command);
        try
        {
            await salesAgentRepository.AddAsync(salesAgent);
            await unitOfWork.CompleteAsync();
            return salesAgent;
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred while creating the Sales Agent: {e.Message}");
            return null;
        }
    }
}