// Startup.cs
using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace YourNamespace
{
    public class Startup : IStartup
    {
        public void ConfigureMauiHandlers(MauiHandlersCollection handlers)
        {
            // Configure handlers
        }

        public void ConfigureServices(HostBuilderContext context, IServiceCollection services)
        {
            services.AddBlazorWebView();
        }

        public void Configure(HostBuilderContext context, IAppHostBuilder appBuilder)
        {
            appBuilder
                .UseMauiApp<App>()
                .ConfigureMauiHandlers(handlers => handlers.AddHandler<RFIDScannerBase, RFIDScannerBaseHandler>());
        }
    }
}
