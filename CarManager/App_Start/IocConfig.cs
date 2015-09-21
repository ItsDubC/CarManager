using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using CarManager.Autofac;

namespace CarManager.App_Start
{
    public class IocConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterFilterProvider();
            builder.RegisterSource(new ViewRegistrationSource());
            builder.RegisterModule(new DataModule());
            builder.RegisterModule(new ServiceModule());

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}