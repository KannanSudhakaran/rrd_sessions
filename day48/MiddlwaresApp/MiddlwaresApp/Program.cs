var webAppBuilder = WebApplication.CreateBuilder(args);
var webApp = webAppBuilder.Build();

webApp.Use(async (context, next) =>
{
    Console.WriteLine("Inside Common headers Logging  middleware");
    Console.WriteLine(context.Request.Path);
    Console.WriteLine(context.Request.Method);

    foreach (var item in context.Request.Headers)
        Console.WriteLine(item.Key + " " + item.Value);
    await next();
});
////webApp.UseMyRddMiddleWare();
webApp.Use(async (context, next) =>
{
    //prepoossing

    Console.WriteLine("Middleware 1(pre)");
    await next();
    Console.WriteLine("Middleware 1(post)");
    //post postpressing
});

webApp.Use(async (context, next) =>
{
    //prepoossing
    Console.WriteLine("Middleware 2(pre)");
    await next();
    Console.WriteLine("Middleware 2(post)");
    //post postpressing
});

webApp.Map("/howdy", (appbuilder) =>
{
    appbuilder.Run(async (context) =>
    {

       
        
        await context.Response.WriteAsync("<h1>Welcome to Howdy!!</h1>");
    });

});

webApp.MapGet("/", () => "Hello World!");

webApp.Run();
