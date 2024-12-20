using Carter;
using ForgeMyHero.Application.Warhammer.Dtos;
using ForgeMyHero.Application.Warhammer.Race.Queries;
using Mapster;
using MediatR;

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
    }
}
