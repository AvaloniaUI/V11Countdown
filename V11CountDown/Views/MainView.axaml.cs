using System;
using Avalonia.Controls;
using Avalonia.Input;

namespace V11CountDown.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        LaunchPanel.PointerPressed += delegate { PlatformQuirks.Instance.OpenURLAction(new Uri("https://github.com/AvaloniaUI/Avalonia/releases")); };
    }
}