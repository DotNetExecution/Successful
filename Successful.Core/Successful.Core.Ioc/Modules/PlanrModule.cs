using Autofac;

namespace Successful.Core.Ioc.Modules
{
    public class PlanrModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.Register(c => new Logger())
            //    .As<ILogger>()
            //    .InstancePerLifetimeScope();
        }
    }
}
