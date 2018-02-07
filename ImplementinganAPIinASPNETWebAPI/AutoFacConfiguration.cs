using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using ImplementinganAPIinASPNETWebAPI.Data;

namespace ImplementinganAPIinASPNETWebAPI
{
    public class AutoFacConfiguration
    {
        public static void AutoFacBootstraper()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            AutoFacRegisterType(builder);

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static void AutoFacRegisterType(ContainerBuilder builder)
        {
            builder.Register(m => new CountingKsRepository(new CountingKsContext())).As<ICountingKsRepository>();
        }
    }
}