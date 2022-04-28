using BlazorWasm;
using BlazorWasm.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<StateContainer>();
builder.Services.AddSingleton<UserState>();

var host = builder.Build();

var userState = host.Services.GetRequiredService<UserState>();
userState.Application = new();
var stateContainer = host.Services.GetService<StateContainer>();
stateContainer.Application = new(); 
    
await host.RunAsync();
