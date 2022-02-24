using Serilog;

namespace Rocco.Web.API.Extensions;

public static class SerilogHelper
{
    public static void AddSerilog(this WebApplicationBuilder builder)
    {
        var logger = new LoggerConfiguration()
            .ReadFrom.Configuration(builder.Configuration).WriteTo
            .File("Logs/log-.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();
        builder.Logging.ClearProviders();
        builder.Logging.AddSerilog(logger);
    }
}
