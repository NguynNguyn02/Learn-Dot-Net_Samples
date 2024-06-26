using Microsoft.Extensions.Logging;

using ILoggerFactory factory = LoggerFactory.Create(builder => {

    builder.AddConsole();
    builder.SetMinimumLevel(LogLevel.Debug);
    //builder.SetMinimumLevel(LogLevel.None);
    builder.AddFilter(lever=>lever == LogLevel.Debug||lever==LogLevel.Trace);//override setmininumlevel
});
ILogger logger = factory.CreateLogger("Program");
logger.LogTrace("LogTrace");
logger.LogDebug("LogDebug");
logger.LogInformation("LogInformation");
logger.LogWarning("LogWarning");
logger.LogError("LogError");
logger.LogCritical("LogCritical");
var a = 100;
var b = 190;
if (logger.IsEnabled(LogLevel.Debug))
{
    logger.LogDebug("{x}",a*b);
}
else
{
    logger.LogInformation("{y}", a+b);

}
