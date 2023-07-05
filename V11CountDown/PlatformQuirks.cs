using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace V11CountDown;

public partial class PlatformQuirks : ObservableObject
{
    public static PlatformQuirks Instance { get; } = new PlatformQuirks();

    public Action<Uri> OpenURLAction;
    
    [ObservableProperty] private bool _useVisualBrushFallback;
    [ObservableProperty] private string _userAgent;
}