using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Knowledge.Web.Framework.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        private static IServiceProvider serviceProvider;

        /// <summary>
        /// Add services to the application and configure service provider
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        /// <param name="configuration">Configuration of the application</param>
        /// <returns>Configured service provider</returns>
        public static IServiceProvider ConfigureApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            ////add NopConfig configuration parameters
            //services.ConfigureStartupConfig<NopConfig>(configuration.GetSection("Nop"));
            ////add hosting configuration parameters
            //services.ConfigureStartupConfig<HostingConfig>(configuration.GetSection("Hosting"));
            ////add accessor to HttpContext
            //services.AddHttpContextAccessor();

            ////create, initialize and configure the engine
            //var engine = EngineContext.Create();
            //engine.Initialize(services);
            //var serviceProvider = engine.ConfigureServices(services, configuration);

            //if (DataSettingsManager.DatabaseIsInstalled)
            //{
            //    //implement schedule tasks
            //    //database is already installed, so start scheduled tasks
            //    TaskManager.Instance.Initialize();
            //    TaskManager.Instance.Start();

            //    //log application start
            //    EngineContext.Current.Resolve<ILogger>().Information("Application started", null, null);
            //}

            return serviceProvider;
        }
    }
}
