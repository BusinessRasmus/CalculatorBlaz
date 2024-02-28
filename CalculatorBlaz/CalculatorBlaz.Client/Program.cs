using CalculatorBlaz.Client.Pages;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Shared;
using MudBlazor.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<CalculatorService>();
builder.Services.AddSingleton<CalcHistoryService>();

builder.Services.AddMudServices();

await builder.Build().RunAsync();
