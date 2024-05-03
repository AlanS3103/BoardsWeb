var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IBoardRepository, BoardSqlRepository>();
builder.Services.AddSingleton<IInterationRepository, InterationMemoryRepository>();

var app = builder.Build();

app.MapControllerRoute("default", "/{controller=Board}/{action=Index}/{id?}");

app.Run();