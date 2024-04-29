using Hostel_Manager.Web;
using Hostel_Manager.Web.Services;
using Hostel_Manager.Web.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7231/") });
builder.Services.AddScoped<IHostelService, HostelService>();

await builder.Build().RunAsync();
