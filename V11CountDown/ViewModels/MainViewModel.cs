using System;
using System.Reactive.Linq;
using CommunityToolkit.Mvvm.ComponentModel;

namespace V11CountDown.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private string _timeRemaining;
    [ObservableProperty] private bool _timesUp;

    public MainViewModel()
    {
        Tick();
        Observable.Interval(TimeSpan.FromSeconds(0.5)).Subscribe(x =>
        {
            Tick();
        });
    }

    void Tick()
    {
        
        var targetTime = DateTimeOffset.Parse("07/05/2023 12:30:00 PM +02:00").UtcDateTime;
        var currentTime = DateTimeOffset.Now.UtcDateTime;
        var remTime = targetTime - currentTime;

        if (remTime.TotalSeconds <= 0)
        {
            TimesUp = true;
            return;
        }
            
        TimeRemaining = (targetTime - currentTime).ToString(@"hh\:mm\:ss");
    }
}
