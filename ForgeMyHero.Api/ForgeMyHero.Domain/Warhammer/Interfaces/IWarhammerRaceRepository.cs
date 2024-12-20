using ForgeMyHero.Domain.Warhammer.Entity;

namespace ForgeMyHero.Domain.Warhammer.Interfaces;

public interface IWarhammerRaceRepository
{
    Task<IEnumerable<WarhammerRace>> GetAllRacesAsync();
}
