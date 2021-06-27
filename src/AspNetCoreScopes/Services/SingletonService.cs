using System;
using DependencyInjection.Interfaces;


namespace DependencyInjection.Services
{
    public class SingletonService : ISingletonService
    {
        public Guid Id { get; private set; }

        public SingletonService()
        {
            Id = Guid.NewGuid();
        }
    }
}
