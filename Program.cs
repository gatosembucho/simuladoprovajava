using Simuladoprovajava.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Simuladoprovajava.UseCases.CreateUser;
using Simuladoprovajava.UseCases.CreateShelf;
using Simuladoprovajava.UseCases.WriteFanfiction;
using Simuladoprovajava.UseCases.AddToShelf;
using Simuladoprovajava.UseCases.DeleteFanfiction;
using Simuladoprovajava.UseCases.ViewShelves;
using Simuladoprovajava.UseCases.ViewFanfiction;



var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<SimuladoprovajavaDbContext>(options =>
{
    var sqlConn = Environment.GetEnvironmentVariable("SQL_CONNECTION");

    options.UseSqlServer(sqlConn);
});

builder.Services.AddScoped<CreateUserUseCase>();
builder.Services.AddScoped<CreateShelfUseCase>();
builder.Services.AddScoped<WriteFanfictionUseCase>();
builder.Services.AddScoped<AddToShelfUseCase>();
builder.Services.AddScoped<DeleteFanfictionUseCase>();
builder.Services.AddScoped<ViewShelvesUseCase>();
builder.Services.AddScoped<ViewFanfictionUseCase>();



var app = builder.Build();





app.Run();