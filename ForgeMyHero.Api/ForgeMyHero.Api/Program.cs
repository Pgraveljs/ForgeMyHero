using Carter;
using ForgeMyHero.Application.Warhammer.Race;
using ForgeMyHero.Application.Warhammer.Race.Queries;
using ForgeMyHero.Infrastructure;
using ForgeMyHero.Infrastructure.Warhammer.Races;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddCarter();
builder.Services.AddSingleton<DapperDbContext>();
builder.Services.AddScoped<IRaceRepository, RaceRepository>();

builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(GetRacesQueryHandler).Assembly); // Assembly of the handler
    config.RegisterServicesFromAssembly(typeof(Program).Assembly); // Current assembly
});

var app = builder.Build();

app.MapCarter();

app.Run();
