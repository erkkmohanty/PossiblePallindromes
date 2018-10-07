using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace PossiblePallindromes
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<PossiblePallindromes>().As<IPossiblePallindromes>();
            builder.RegisterType<Application>().As<IApplication>();
            return builder.Build();
        }
    }
}
