using System;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Browser;
using Avalonia.Controls;
using Avalonia.Threading;
using V11CountDown;

[assembly: SupportedOSPlatform("browser")]

internal partial class Program
{
    private static async Task Main(string[] args) => await BuildAvaloniaApp()
        .StartBrowserAppAsync("out");

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>().AfterSetup((a) =>
        {
            
            // Dispatcher.UIThread.Post(() =>
            // {
            //     JSHost.ImportAsync("embed.js", "./embed.js");
            //     Console.WriteLine(BrowserFunctions.GetUserAgent());
            // });
            
            PlatformQuirks.Instance.OpenURLAction = x => { BrowserFunctions.WindowOpen(x.ToString()); };
        });
}