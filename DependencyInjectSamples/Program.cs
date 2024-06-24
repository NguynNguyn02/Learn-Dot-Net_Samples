using DependencyInjectSamples;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Services.AddTransient<IMessageWriter, MessageWrite>();
builder.Services.AddTransient<INullInterface,NullInterface>();
var host = builder.Build();
host.Run();
