using System.Reflection;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using IsolatedStartupError;

[assembly: FunctionsStartup(typeof(Startup))]
namespace IsolatedStartupError
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("secrets.json")
               .AddUserSecrets(Assembly.GetExecutingAssembly())
               .Build();

            builder.Services.AddSingleton<IConfiguration>(config);
        }
    }
}
