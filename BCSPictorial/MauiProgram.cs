using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using BCSPictorial.Models;
using BCSPictorial.ViewModel;
using BCSPictorial.Helpers;
namespace BCSPictorial
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.Services.AddTransient<Pictorial>();
            builder.Services.AddTransient<PictorialVM>();
            builder

                .UseMauiApp<App>()
                
                .UseMauiCommunityToolkitMediaElement()
               .UseMauiCommunityToolkit()
               
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
