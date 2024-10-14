using CommunityToolkit.Maui.Views;
using NeurolepticAppV3.MVVM.ViewModels;


namespace NeurolepticAppV3.MVVM.Views;

public partial class LibraryView : ContentPage
{
	public LibraryView()
	{
		InitializeComponent();
       // BindingContext = new LibraryViewModel();

    }
    
    //private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    //{
        
    //    var viewModel = (LibraryViewModel)BindingContext;
        
    //    this.ShowPopup(new Popupview());
    //    viewModel.GetEntry();
    //}
    //protected override void OnNavigatedTo(NavigatedToEventArgs args)
    //{
    //    base.OnNavigatedTo(args);
    //}

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var viewModel = (LibraryViewModel)BindingContext;
        
        viewModel.GetEntry();
    }
}