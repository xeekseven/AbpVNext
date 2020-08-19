using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ConsoleAbpDemo
{
    [DependsOn(typeof(AbpAutofacModule))] //Add dependency to the AbpAutofacModule
    public class AppModule : AbpModule
    {

    }
}