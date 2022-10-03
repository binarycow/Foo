using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WpfApp1;



public class AppViewModel : ObservableObject
{
    public AppViewModel()
    {
        this.IncrementCommand = new RelayCommand<string>(Increment, CanIncrement);
    }
    public IRelayCommand<string> IncrementCommand { get; }
    private void Increment(string? parameter)
    {
        if (int.TryParse(parameter, out var amount))
            Value += amount;
    }

    private bool CanIncrement(string? arg)
    {
        return int.TryParse(arg, out var amount)
            && this.Value + amount < 10;
    }

    private int value;
    public int Value
    {
        get => this.value;
        set
        {
            if (this.SetProperty(ref this.value, value))
            {
                this.IncrementCommand.NotifyCanExecuteChanged();
            }
        }
    }
}