using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using NeurolepticAppV3.MVVM.ViewModels;
using NeurolepticAppV3.MVVM.Views;

namespace NeurolepticAppV3
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<LibraryService>();
            builder.Services.AddSingleton<LibraryViewModel>();
            builder.Services.AddSingleton<MenuView>();
            
            return builder.Build();
        }
    }
}
