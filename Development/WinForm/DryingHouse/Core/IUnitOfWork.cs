using DryingHouse.Core.Repositories;
using System;
using DryingHouse.Persistence;

namespace DryingHouse.Core
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}