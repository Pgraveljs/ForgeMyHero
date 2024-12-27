using ForgeMyHero.Application.Warhammer.Interfaces;
using ForgeMyHero.Domain.Warhammer.Entity;
using MediatR;

namespace ForgeMyHero.Application.Warhammer.Race.Queries;

public record GetRacesQuery : IRequest<IEnumerable<WarhammerRace>> { }

public class GetRacesQueryHandler : IRequestHandler<GetRacesQuery, IEnumerable<WarhammerRace>>
{
    private readonly IQueryRepository<WarhammerRace> _repository;

    public GetRacesQueryHandler(IQueryRepository<WarhammerRace> repository) => _repository = repository;

    public async Task<IEnumerable<WarhammerRace>> Handle(GetRacesQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}


