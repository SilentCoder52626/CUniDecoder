using Microsoft.Extensions.Logging;
using Plainer.Maui;
using UraniumUI;

namespace CUniDecoder
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddMaterialIconFonts();
                })
                .UseUraniumUI();
            builder.ConfigureMauiHandlers(handlers =>
            {
                handlers.AddPlainer();
            });
            builder.Services.AutoRegister();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
