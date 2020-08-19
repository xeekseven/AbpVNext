using System;
using Volo.Abp;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleAbpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var app = AbpApplicationFactory.Create<AppModule>(options=>{
                options.UseAutofac(); //Autofac integration
            }))
            {
                app.Initialize();
                var service = app.ServiceProvider.GetService<HelloWorldService>();
                service.SayHello();
                Console.WriteLine("Press ENTER to stop application...");
                Console.ReadLine();
            }
        }
    }
}
