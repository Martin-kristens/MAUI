using ContactApp.Pages;
using ContactApp.ViewModels;
using Microsoft.Extensions.Logging;

namespace ContactApp
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


    		builder.Logging.AddDebug();

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            builder.Services.AddTransient<ContactDetailPage>();
            builder.Services.AddTransient<DetailViewModel>();

            builder.Services.AddTransient<AddContactPage>();
            builder.Services.AddTransient<AddContactViewModel>();

            builder.Services.AddTransient<DeleteContactPage>();
            builder.Services.AddTransient<DeleteViewModel>();

            builder.Services.AddTransient<UpdateContactPage>();
            builder.Services.AddTransient<UpdateViewModel>();

            builder.Services.AddTransient<ViewAllContactsPage>();
            builder.Services.AddTransient<ViewAllViewModel>();

            return builder.Build();
        }
    }
}
