using System.ComponentModel;
using DLibApp.Pages.Entry.Viewmodel;
using DLibApp.Viewmodels;

namespace DLibApp.Pages.Entry.View;

public partial class EntryPage : ContentPage
{
    private EntryViewmodel entryViewmodel;
    public EntryPage()
    {
        InitializeComponent();
        entryViewmodel = new();
        BindingContext = entryViewmodel;
    }

    private void OnRegisterButtonClicked(object sender, EventArgs e)
    {
        entryViewmodel.Count++;
    }

    private void OnLoginButtonClicked(object sender, EventArgs e)
    {
        entryViewmodel.Count += 2;
    }
}