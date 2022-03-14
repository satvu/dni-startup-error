using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.Reflection;

var host = new HostBuilder()
                .ConfigureAppConfiguration(builder =>
                {
                    builder.AddJsonFile("fakefile.json")
                        .AddUserSecrets(Assembly.GetExecutingAssembly());
                })
                .ConfigureFunctionsWorkerDefaults()
                .ConfigureServices(services =>
                {
/*                    services.AddOptions<ExampleServiceOptions>().Configure<IConfiguration>((settings, configuration) =>
                    {
                        configuration.GetSection(nameof(ExampleServiceOptions)).Bind(settings);
                    });*/
                })
                .Build();

host.Run();