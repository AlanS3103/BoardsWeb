var builder = WebApplication.CreateBuilder(args);

// inclusão de middlewares
builder.Services.AddControllersWithViews();

var app = builder.Build();

// uso dos middlewares adicionados:
// controller == class
// action == method
// exemplo: http://localhost:5253/controller/action
// exemplo: http://localhost:5253/class/method
app.MapControllerRoute("default", "{controller}/{action}/{id?}");

app.Run();
