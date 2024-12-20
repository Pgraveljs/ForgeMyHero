using ForgeMyHero.Infrastructure.Warhammer;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddCarter();
builder.Services.AddSingleton<DapperDbContext>();
builder.Services.AddScoped<IQueryRepository<WarhammerRace>, RaceRepository>();

builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(GetRacesQueryHandler).Assembly); // Assembly of the handler
    config.RegisterServicesFromAssembly(typeof(Program).Assembly); // Current assembly
});

var app = builder.Build();

app.MapCarter();

app.Run();
