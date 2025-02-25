var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute(
     name: "default",
     pattern:"{controller=CustomerV2}/{action=Register}/{id?}"
    );

app.Run();
