using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using HouseOnSale.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;
using HouseOnSale.Staff.Domain.Model.Aggregates;
using HouseOnSale.Staff.Domain.Model.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace HouseOnSale.Shared.Infrastructure.Persistence.EFC.Configuration;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        base.OnConfiguring(builder);
        // Enable Audit Fields Interceptors
        builder.AddCreatedUpdatedInterceptor();
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.Entity<SalesAgent>().ToTable("SalesAgents");
        builder.Entity<SalesAgent>().HasKey(salesAgent => salesAgent.Id);
        builder.Entity<SalesAgent>().Property(salesAgent => salesAgent.Id).ValueGeneratedOnAdd();
        builder.Entity<SalesAgent>().Property(salesAgent => salesAgent.Name).IsRequired();
        builder.Entity<SalesAgent>().Property(salesAgent => salesAgent.Commission).HasConversion(v=>v.Value, v => new Commision(v)).IsRequired();
        builder.Entity<SalesAgent>().Property(salesAgent => salesAgent.SalesCount).HasConversion(v=>v.Value,v=> new SalesCount(v)).IsRequired();
        builder.Entity<SalesAgent>().Property(salesAgent => salesAgent.LicenseId).HasConversion(v => v.Id, v=>new LicenseId(v)).IsRequired();
        
       
        
        
        
        // Apply SnakeCase Naming Convention
        builder.UseSnakeCaseWithPluralizedTableNamingConvention();
    }
}