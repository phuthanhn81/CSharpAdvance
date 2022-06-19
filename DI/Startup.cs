using DI.Entities;
using DI.Interface;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DI
{
    public static class Startup
    {
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices(ConfigureServices);

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<Program>();
            services.AddSingleton<DI>();

            // services.AddTransient<IUser, User>();
            // services.AddScoped<IUser, User>();
            services.AddSingleton<IUser, User>();
        }
    }
}