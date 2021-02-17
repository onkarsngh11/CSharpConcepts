using System;
using DependencyInjection.Interfaces;


namespace DependencyInjection.Services
{
    public class ScopedService : IScopedService
    {
        public Guid Id { get; private set; }

        public ScopedService()
        {
            Id = Guid.NewGuid();
        }
    }
}
