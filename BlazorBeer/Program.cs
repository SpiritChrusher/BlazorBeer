using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorBeer;
using BlazorBeer.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
//builder.Services.AddHttpClient<IBeerServices, BeerServices>(client =>
//{
//    client.BaseAddress = new Uri("https://localhost:5001");
//});

builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
    });

builder.Services.AddTransient<IBeerServices, BeerServices>();

await builder.Build().RunAsync();