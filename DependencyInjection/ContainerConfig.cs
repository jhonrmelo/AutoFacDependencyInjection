using Autofac;
using ClassLibrary;
using ClassLibrary.Utilities;
using System.Linq;
using System.Reflection;

namespace DependencyInjection
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<BetterBusinessLogic>().As<IBusinessLogic>();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(ClassLibrary))).Where(T => T.Namespace.Contains("Utilities")).As(T => T.GetInterfaces().FirstOrDefault(i => i.Name == "I" + T.Name));

            return builder.Build();
        }
    }
}
