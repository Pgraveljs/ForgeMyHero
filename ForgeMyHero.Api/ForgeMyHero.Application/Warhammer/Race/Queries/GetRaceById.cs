using ForgeMyHero.Application.Warhammer.Interfaces;
using ForgeMyHero.Domain.Warhammer.Entity;
using MediatR;

namespace ForgeMyHero.Application.Warhammer.Race.Queries;

public record GetRaceByIdQuery(int Id) : IRequest<WarhammerRace> { };
public class GetRaceByIdQueryHandler : IRequestHandler<GetRaceByIdQuery, WarhammerRace>
{
    private readonly IQueryRepository<WarhammerRace> _repository;

    public GetRaceByIdQueryHandler(IQueryRepository<WarhammerRace> repository) => _repository = repository;

    public async Task<WarhammerRace> Handle(GetRaceByIdQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetByIdAsync(request.Id);
    }
}