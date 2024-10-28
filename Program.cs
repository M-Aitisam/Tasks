using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.DependencyInjection;
using Project1_Lab_Simple.Data;
using Project1_Lab_Simple.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<LoggerService>();  //A single instance is created  throughout the application
builder.Services.AddScoped<DataService>();// A new instance is created  per unit session  or per unit request server side blazer
                                          // Trasient : A new instance is created  each  time the service is required


builder.Services.AddSingleton<AuthenticationStateService>();
builder.Services.AddSingleton<NotificationConfig>(); // Register NotificationConfig
builder.Services.AddScoped<NotificationService>(); // Register NotificationService
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
