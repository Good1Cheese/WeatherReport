using Data.Interfaces;
using Data.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UI;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
var services = builder.Services;

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

services.AddScoped<IUserLocationService, UserLocationService>();
services.AddScoped<IWeatherForecastService, WeatherForecastService>();

await builder.Build().RunAsync();
