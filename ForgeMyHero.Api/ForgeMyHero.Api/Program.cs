using ForgeMyHero.Application.Warhammer.Class.Queries;
using ForgeMyHero.Infrastructure.Warhammer;
using ForgeMyHero.Infrastructure.Warhammer.Class;
using ForgeMyHero.Infrastructure.Warhammer.Race;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddCarter();
builder.Services.AddSingleton<DapperDbContext>();
builder.Services.AddScoped<IQueryRepository<WarhammerRace>, RaceRepository>();
builder.Services.AddScoped<IQueryRepository<WarhammerClass>, ClassRepository>();

builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(GetRacesQueryHandler).Assembly); // Assembly of the handler
    config.RegisterServicesFromAssembly(typeof(GetClassesQueryHandler).Assembly); // Assembly of the handler
    config.RegisterServicesFromAssembly(typeof(Program).Assembly); // Current assembly
});

var app = builder.Build();

app.MapCarter();

app.Run();
