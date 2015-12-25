using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting.Internal;
using Microsoft.Extensions.DependencyInjection;
using Nancy.Owin;
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
            // TODO: Nancy support for dnxcore5 is not done yet.
            app.UseOwin().UseNancy();

        }

        // Entry point for the application.
        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}