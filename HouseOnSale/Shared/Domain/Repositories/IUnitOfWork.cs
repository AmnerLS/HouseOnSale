﻿namespace HouseOnSale.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}