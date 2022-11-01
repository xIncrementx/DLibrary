using DLibApp.Viewmodels;

namespace DLibApp;

public partial class MainPage : ContentPage
{
    private MainViewmodel mainViewmodel;

    public MainPage()
    {
        InitializeComponent();
        mainViewmodel = new MainViewmodel();
        BindingContext = mainViewmodel;
    }

    /*private void OnLoginButtonClicked(object sender, EventArgs e) => ((MainViewmodel)BindingContext).Count++;*/

    private void OnBeginButtonClicked(object sender, EventArgs e)
    {
        mainViewmodel.LaunchEntryPage();
    }
}