using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            //Adding Singleton
            //services.AddSingleton<ICounter, Counter>();
            //var serviceProvider = services.BuildServiceProvider();


            //// Singleton Lifetime
            //Console.WriteLine("Singleton Lifetime:");
            //var singletonCounter1 = serviceProvider.GetService<ICounter>();
            //singletonCounter1.Increment();
            //var singletonCounter2 = serviceProvider.GetService<ICounter>();
            //Console.WriteLine($"Counter Count 1: {singletonCounter1.Count}");
            //Console.WriteLine($"Counter Count 2: {singletonCounter2.Count}");
            //Console.WriteLine();

            // Adding Scoped
            //services.AddScoped<ICounter, Counter>();
            //var serviceProvider = services.BuildServiceProvider();
            //// Scoped Lifetime
            //Console.WriteLine("Scoped Lifetime:");
            //using (var scope = serviceProvider.CreateScope())
            //{
            //    var scopedCounter1 = scope.ServiceProvider.GetService<ICounter>();
            //    scopedCounter1.Increment();
            //    var scopedCounter2 = scope.ServiceProvider.GetService<ICounter>();
            //    Console.WriteLine($"Counter Count 1: {scopedCounter1.Count}");
            //    Console.WriteLine($"Counter Count 2: {scopedCounter2.Count}");
            //}
            //Console.WriteLine();

            // Adding Transient
            services.AddTransient<ICounter, Counter>();
            var serviceProvider = services.BuildServiceProvider();
            // Transient Lifetime
            Console.WriteLine("Transient Lifetime:");
            var transientCounter1 = serviceProvider.GetService<ICounter>();
            transientCounter1.Increment();
            var transientCounter2 = serviceProvider.GetService<ICounter>();
            Console.WriteLine($"Counter Count 1: {transientCounter1.Count}");
            Console.WriteLine($"Counter Count 2: {transientCounter2.Count}");

            Console.ReadLine();
        }
    }
}
