var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next) =>
{
    Console.WriteLine("Before request");
    await next();
    Console.WriteLine("After request");
});

app.Run(async context =>
{
    await context.Response.WriteAsync("Hello from Middleware!");
});

app.Run();
