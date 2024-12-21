namespace ForgeMyHero.Api.Warhammer.Modules;

public class RacesModule : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/races", async (IMediator mediator) =>
        {
            var races = await mediator.Send(new GetRacesQuery());
            var raceDtos = races.Adapt<IEnumerable<WarhammerRaceDto>>();
            return Results.Ok(raceDtos);
        });

        app.MapGet("/api/races/{id:int}", async (IMediator mediator, int id) =>
        {
            var race = await mediator.Send(new GetRaceByIdQuery(id));
            
            if (race == null)
                return Results.NotFound(new { Message = $"Race with Id {id} not found." });

            var raceDto = race.Adapt<WarhammerRaceDto>();
            return Results.Ok(raceDto);
        });
    }
}
