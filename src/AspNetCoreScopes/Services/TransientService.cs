using System;
using DependencyInjection.Interfaces;

namespace DependencyInjection.Services
{
    public class TransientService : ITransientService
    {
        public Guid Id { get; private set; }

        public TransientService()
        {
            Id = Guid.NewGuid();
        }
    }
}
