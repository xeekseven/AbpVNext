using System;
using Volo.Abp.DependencyInjection;

namespace ConsoleAbpDemo{
    public class HelloWorldService : ITransientDependency
    {
        public void SayHello(){
            Console.WriteLine("Hello World!");
        }
    }
}