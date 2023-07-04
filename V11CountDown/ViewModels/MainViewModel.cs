using System;
using System.Diagnostics;
using System.Reactive.Linq;
using CommunityToolkit.Mvvm.ComponentModel;

namespace V11CountDown.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private string _timeRemaining;
    [ObservableProperty] private bool _countdownNowVisible; // Adds some sweet effect when users visits after the countdown is already finished.
    [ObservableProperty] private bool _timesUp;
    
    public MainViewModel()
    {
        Observable.Interval(TimeSpan.FromSeconds(0.5)).Subscribe(x =>
        {
            Tick();
        });
    }

    void Tick()
    {
        // Corrected to UTC+2 July 5 2023 12 and a half noon   
        var targetTime = new DateTimeOffset(2023, 07, 05, 12,30,0, TimeSpan.FromHours(2));
        var currentTime = DateTimeOffset.Now.UtcDateTime;
        var remTime = targetTime - currentTime;

        if (remTime.TotalSeconds <= 0)
        {
            TimesUp = true;
            return;
        }
            
        TimeRemaining = (targetTime - currentTime).ToString(@"hh\:mm\:ss");
        CountdownNowVisible = true;
    }
}
