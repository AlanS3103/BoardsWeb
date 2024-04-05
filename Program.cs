var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IBoarRepository, BoardMemoryRepository>();

var app = builder.Build();

app.MapControllerRoute("default", "/{controller=Board}/{action=Index}/{id?}");

app.Run();