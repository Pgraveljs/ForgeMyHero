using ForgeMyHero.Application.Warhammer.Class.Queries;

namespace ForgeMyHero.Api.Warhammer.Modules;

public class ClassesModule : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/classes", async (IMediator mediator) =>
        {
            var classes = await mediator.Send(new GetClassesQuery());
            var classDtos = classes.Adapt<IEnumerable<WarhammerClassDto>>();
            return Results.Ok(classDtos);
        });

        app.MapGet("/api/classes/{id:int}", async (IMediator mediator, int id) =>
        {
            var wClass = await mediator.Send(new GetClassByIdQuery(id));

            if (wClass == null)
                return Results.NotFound(new { Message = $"Class with Id {id} not found." });

            var classDto = wClass.Adapt<WarhammerClassDto>();
            return Results.Ok(classDto);
        });
    }
}
