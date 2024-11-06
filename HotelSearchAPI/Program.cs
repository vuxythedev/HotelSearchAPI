using HotelSearchAPI.StartupExtensions.cs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
builder.Services.ConfigureServices(builder.Configuration);
builder.Services.AddHttpClient();


app.Run();
