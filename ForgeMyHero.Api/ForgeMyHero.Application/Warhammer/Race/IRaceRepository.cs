using ForgeMyHero.Domain.Warhammer.Entity;

namespace ForgeMyHero.Application.Warhammer.Race;

public interface IRaceRepository
{
    Task<IEnumerable<WarhammerRace>> GetAllRacesAsync();
}
