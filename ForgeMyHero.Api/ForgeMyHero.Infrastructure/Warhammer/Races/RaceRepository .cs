using Dapper;
using ForgeMyHero.Application.Warhammer.Race;
using ForgeMyHero.Domain.Warhammer.Entity;

namespace ForgeMyHero.Infrastructure.Warhammer.Races;

public class RaceRepository : IRaceRepository
{
    private readonly DapperDbContext _context;

    public RaceRepository(DapperDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<WarhammerRace>> GetAllRacesAsync()
    {
        const string query = "SELECT [Id], [Name] FROM [ForgeMyHeroDb].[Warhammer].[Races]";
        using var connection = _context.CreateConnection();
        return await connection.QueryAsync<WarhammerRace>(query);
    }
}
