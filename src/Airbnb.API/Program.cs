var builder = WebApplication.CreateBuilder(args);


builder.Logging.ClearProviders();
builder.Logging.AddSimpleConsole(simpleConsoleFormatterOptions =>
{
    simpleConsoleFormatterOptions.IncludeScopes = true;
});

builder.WebHost.UseDefaultServiceProvider(serviceProviderOptions =>
{
    serviceProviderOptions.ValidateScopes = true;
    serviceProviderOptions.ValidateOnBuild = true;
});


builder.WebHost.UseKestrel(kestrelServerOptions =>
{
    kestrelServerOptions.ListenAnyIP(9000);
});

builder.Services.AddControllersWithViews();


var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapDefaultControllerRoute();
app.Run();
