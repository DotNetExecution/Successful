using System;
using Autofac;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.DependencyInjection.Autofac;
using Successful.Core.Ioc.Modules;

namespace Successful.Planr.Web
{
    public class Startup
    {
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // Create the Autofac container builder.
            var builder = new ContainerBuilder();

            // Add any Autofac modules or registrations.
            builder.RegisterModule(new PlanrModule());

            // Populate the services.
            builder.Populate(services);

            // Build the container.
            var container = builder.Build();

            // Resolve and return the service provider.
            return container.Resolve<IServiceProvider>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseIISPlatformHandler();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
