using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using CarManager.Data;

namespace CarManager.Autofac
{
    public class DataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DummyCarRepository>().As<ICarRepository>().SingleInstance();

            base.Load(builder);
        }
    }
}