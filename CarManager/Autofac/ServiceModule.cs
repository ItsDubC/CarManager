using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using CarManager.Service;

namespace CarManager.Autofac
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarService>().As<ICarService>();

            base.Load(builder);
        }
    }
}