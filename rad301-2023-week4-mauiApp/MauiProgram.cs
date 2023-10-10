using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Plugin.Maui.Audio;
using ProductModel;
using rad301_2023_week3_mauiApp.DataLayer;
using rad301_2023_week3_mauiApp.Pages;
using rad301_2023_week3_mauiApp.ViewModels;

namespace rad301_2023_week3_mauiApp
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
                });
            // Add Pages
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<CategoriesListPage>();
            builder.Services.AddTransient<CategoryPage>();
            builder.Services.AddTransient<CategoryProductsPage>();
            // Add Data Services
            builder.Services.AddSingleton(AudioManager.Current);
            
            builder.Services.AddDbContext<MauiProductContext>(options 
                => options.UseSqlite($"Filename={Constants.DatabasePath}"));
            
            builder.Services.AddSingleton<ICategory<Category>, CategoryDataService>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}