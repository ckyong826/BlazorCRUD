using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ProductSystem.Shared.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(http=> new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IProductService, ClientProductService>();

await builder.Build().RunAsync();
