using Microsoft.AspNetCore.Components.WebView.Maui;
using MauiChartApp.Data;
using Syncfusion.Blazor;

namespace MauiChartApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseMauiApp<App>().ConfigureFonts(fonts =>{fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");});
		builder.Services.AddMauiBlazorWebView();
        
	//var app = builder.Build();
        //Register Syncfusion license
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTk5NTc4NkAzMjMxMmUzMjJlMzNtbnNUc0JIMGtWdjVpaEE2UkppelRIaWhVM2FHOG1iZG9RQVEwb2N3aStnPQ==;MTk5NTc4N0AzMjMxMmUzMjJlMzNUTFl5YjkrYUZBYWozdzZTbWc0RUNpUjEvak1LNUxqMWs3WlBTekVPM01nPQ==");

        // Set IgnoreScriptIsolation as true to load scripts externally.
        builder.Services.AddSyncfusionBlazor(options => { //options.IgnoreScriptIsolation = true; 
		});

		#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		builder.Services.AddSingleton<WeatherForecastService>();
		return builder.Build();
	}
}
