using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;

namespace PortfolioApi.Tests;

public sealed class PortfolioApiFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        var testConnectionString = new ConfigurationBuilder()
            .AddUserSecrets<Program>()
            .Build()
            .GetConnectionString("PortfolioTestDatabase");

        if (string.IsNullOrWhiteSpace(testConnectionString))
        {
            throw new InvalidOperationException(
                "ConnectionStrings:PortfolioTestDatabase ontbreekt in User Secrets.");
        }

        builder.ConfigureAppConfiguration((_, configuration) =>
        {
            configuration.AddInMemoryCollection(
                new Dictionary<string, string?>
                {
                    ["ConnectionStrings:PortfolioDatabase"] = testConnectionString
                });
        });
    }
}