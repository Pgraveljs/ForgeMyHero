using ForgeMyHero.Domain.Warhammer.Entity;
using MediatR;

namespace ForgeMyHero.Application.Warhammer.Race.Queries;

public class GetRacesQuery : IRequest<IEnumerable<WarhammerRace>> { }

public class GetRacesQueryHandler : IRequestHandler<GetRacesQuery, IEnumerable<WarhammerRace>>
{
    private readonly IRaceRepository _repository;

    public GetRacesQueryHandler(IRaceRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<WarhammerRace>> Handle(GetRacesQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllRacesAsync();
    }
}


