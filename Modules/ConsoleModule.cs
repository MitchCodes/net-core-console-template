using System;
namespace net_core_console_template.Modules
{
    using Autofac;
    using AutofacSerilogIntegration;
    using net_core_console_template.AutoMapper;
    using global::AutoMapper.Contrib.Autofac.DependencyInjection;
    using System.Linq;

    public class ConsoleModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // To register dependencies
            builder.AddAutoMapper(x=>x.AddProfile<MyAutoMapperProfile>());
         }
    }
}
