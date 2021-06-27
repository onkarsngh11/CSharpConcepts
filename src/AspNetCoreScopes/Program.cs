using System;
using DependencyInjection.Interfaces;
using DependencyInjection.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Register services in the DI container
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<ISingletonService, SingletonService>();
            serviceCollection.AddScoped<IScopedService, ScopedService>();
            serviceCollection.AddTransient<ITransientService, TransientService>();
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Creating two different scopes

            using (var scope1 = serviceProvider.CreateScope())
            {
                // Getting two services of each type
                var singletonReference1 = scope1.ServiceProvider.GetService<ISingletonService>();
                var singletonReference2 = scope1.ServiceProvider.GetService<ISingletonService>();
                var scopedReference1 = scope1.ServiceProvider.GetService<IScopedService>();
                var scopedReference2 = scope1.ServiceProvider.GetService<IScopedService>();
                var transientReference1 = scope1.ServiceProvider.GetService<ITransientService>();
                var transientReference2 = scope1.ServiceProvider.GetService<ITransientService>();

                Console.WriteLine($"Scope 1: SingletonService reference 1 ID: {singletonReference1.Id}");
                Console.WriteLine($"Scope 1: SingletonService reference 2 ID: {singletonReference2.Id}{Environment.NewLine}");

                Console.WriteLine($"Scope 1: ScopedService reference 1 ID: {scopedReference1.Id}");
                Console.WriteLine($"Scope 1: ScopedService reference 2 ID: {scopedReference2.Id}{Environment.NewLine}");

                Console.WriteLine($"Scope 1: TransientService reference 1 ID: {transientReference1.Id}");
                Console.WriteLine($"Scope 1: TransientService reference 2 ID: {transientReference2.Id}{Environment.NewLine}");
            }

            Console.WriteLine(Environment.NewLine);

            using (var scope2 = serviceProvider.CreateScope())
            {
                // Getting two services of each type
                var singletonReference1 = scope2.ServiceProvider.GetService<ISingletonService>();
                var singletonReference2 = scope2.ServiceProvider.GetService<ISingletonService>();
                var scopedReference1 = scope2.ServiceProvider.GetService<IScopedService>();
                var scopedReference2 = scope2.ServiceProvider.GetService<IScopedService>();
                var transientReference1 = scope2.ServiceProvider.GetService<ITransientService>();
                var transientReference2 = scope2.ServiceProvider.GetService<ITransientService>();

                Console.WriteLine($"Scope 2: SingletonService reference 1 ID: {singletonReference1.Id}");
                Console.WriteLine($"Scope 2: SingletonService reference 2 ID: {singletonReference2.Id}{Environment.NewLine}");

                Console.WriteLine($"Scope 2: ScopedService reference 1 ID: {scopedReference1.Id}");
                Console.WriteLine($"Scope 2: ScopedService reference 2 ID: {scopedReference2.Id}{Environment.NewLine}");

                Console.WriteLine($"Scope 2: TransientService reference 1 ID: {transientReference1.Id}");
                Console.WriteLine($"Scope 2: TransientService reference 2 ID: {transientReference2.Id}{Environment.NewLine}");
            }

            Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey();

            // Singleton ID remains the same everywhere. It means that the same instance is provided by dependency injection everywhere.
            // Scoped ID remains the same within a scope. It means that the same instance is provided by dependency injection within a scope.
            // Transient ID is different everywhere. It means that the a new instance is provided by dependency injection everywhere.
        }
    }
}
