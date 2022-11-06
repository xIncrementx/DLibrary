using System.ComponentModel;
using System.Runtime.CompilerServices;
using DLibApp.Pages.Entry.Viewmodel;

namespace DLibApp.Viewmodels;

public class MainViewmodel
{
    private EntryViewmodel entryViewmodel;

    public MainViewmodel()
    {
        
    }

    public void LaunchEntryPage()
    {
        entryViewmodel = new();
    }
}