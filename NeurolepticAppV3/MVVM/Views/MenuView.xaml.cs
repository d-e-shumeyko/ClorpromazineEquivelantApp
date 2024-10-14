using NeurolepticAppV3.MVVM.ViewModels;

namespace NeurolepticAppV3.MVVM.Views;

public partial class MenuView : ContentPage
{
	public MenuView()
	{
		InitializeComponent();
		BindingContext = new MenuViewModel();
	
	}
	private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
		var element =
			(Grid)sender;
		var option =
			((Label)element.Children.LastOrDefault()).Text;
		var converterView = new ConverterView
		{
			BindingContext = new ConverterViewModel(option)
		};
		Navigation.PushAsync(converterView);
	}

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {

        var element =
            (Grid)sender;
        var option =
             ((Label)element.Children.LastOrDefault()).Text;
        var converterView = new LibraryView
        {
            BindingContext = new LibraryViewModel(option)
        };
        Navigation.PushAsync(converterView);
    }
}