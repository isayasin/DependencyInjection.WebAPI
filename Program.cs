var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


var app = builder.Build();

//app.Use((context, next) =>
//{
//    context.Response.StatusCode = 500;
//    return next();
//});

//app.Use((context, next) =>
//{
//    context.Response.StatusCode = 200;
//    return next();
//});

app.MapControllers();

app.Run();
