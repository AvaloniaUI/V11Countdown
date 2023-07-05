using System.Runtime.InteropServices.JavaScript;

public static partial class BrowserFunctions
{
    [JSImport("globalThis.window.open")]
    public static partial void WindowOpen(string url, string param = "_blank");


    [JSImport("getUserAgent", "embed.js")]
    public static partial string GetUserAgent();
 
}