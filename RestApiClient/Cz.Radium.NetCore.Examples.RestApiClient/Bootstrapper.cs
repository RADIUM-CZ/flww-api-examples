using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace Cz.Radium.NetCore.Examples.RestApiClient
{
    public class Bootstrapper
    {

        public static ServiceProvider Container { get; private set; }

        public static void Start()
        {
            var configuration = new ConfigurationBuilder()
                //order does matters
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            IServiceCollection services = new ServiceCollection();
            services.AddLogging((builder) =>
            {
                builder.AddConfiguration(configuration);
                builder.AddConsole((cnf) => { cnf.IncludeScopes = true; });
            });

            services.AddTransient<RestSharp.RestClient>(c =>
            {

                var client = new RestSharp.RestClient(configuration.GetValue<string>("ApiUrl"));
                client.Authenticator = new RestSharp.Authenticators.HttpBasicAuthenticator(
                    configuration.GetValue<string>("ApiUsername"),
                    configuration.GetValue<string>("ApiPassword"));
                client.AddDefaultHeader("X-Company", configuration.GetValue<string>("ApiCompanyAlias"));
                return client;
            });
            services.AddTransient<IRestClientService, RestClientService>();
            Container = services.BuildServiceProvider();


            /* Start services */
            var data = Container.GetService<IRestClientService>().GetObjectsFilter("KarelEXT");


            var data2 = Container.GetService<IRestClientService>().GetObjects(0, 500);
        }
    }
}
