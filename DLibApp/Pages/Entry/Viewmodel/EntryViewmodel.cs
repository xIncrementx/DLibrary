using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DLibApp.Pages.Entry.Viewmodel;

public class EntryViewmodel : INotifyPropertyChanged
{
    private int count;
    public int Count
    {
        get { return Count; }
        set
        {
            Count = value; 
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}