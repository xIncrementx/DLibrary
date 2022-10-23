using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DLibApp.Viewmodels;

public class MainViewmodel : INotifyPropertyChanged
{
    private int count;
    public int Count
    {
        get { return count; }
        set
        {
            count = value;
            OnPropertyChanged();
        }
    }

    public MainViewmodel()
    {
        Count = 0;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}