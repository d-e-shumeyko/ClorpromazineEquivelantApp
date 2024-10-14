using NeurolepticAppV3.MVVM.ViewModels;
using NeurolepticAppV3.MVVM.Views;

namespace NeurolepticAppV3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MenuView());
        }
    }
}
