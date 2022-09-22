using MauiToDoList.Pages;
using MauiToDoList.ViewModels;
namespace MauiToDoList;

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
		builder.Services.AddSingleton<PersonViewModel>();
		builder.Services.AddSingleton<HomePage>();

		builder.Services.AddTransient<DateViewModel>();
		builder.Services.AddSingleton<GiftPage>();

		builder.Services.AddSingleton<RequestPage>();
		return builder.Build();
	}
}
