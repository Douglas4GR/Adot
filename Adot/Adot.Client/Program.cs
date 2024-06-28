using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Adot.Client.Services;
using Adot.Shared.Interfaces;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<IAnuncioRepository, AnuncioService>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioService>();

builder.Services.AddScoped(sp => new HttpClient
{ 
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) 
});
await builder.Build().RunAsync();
