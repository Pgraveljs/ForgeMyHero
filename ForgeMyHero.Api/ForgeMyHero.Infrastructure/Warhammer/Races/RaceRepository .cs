using Dapper;
using ForgeMyHero.Application.Warhammer.Interfaces;
using ForgeMyHero.Domain.Warhammer.Entity;

namespace ForgeMyHero.Infrastructure.Warhammer.Races;

public class RaceRepository : IQueryRepository<WarhammerRace>
{
    private readonly DapperDbContext _context;

    public RaceRepository(DapperDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<WarhammerRace>> GetAllAsync()
    {
        const string query = "SELECT [Id], [Name] FROM [ForgeMyHeroDb].[Warhammer].[Races]";
        using var connection = _context.CreateConnection();
        return await connection.QueryAsync<WarhammerRace>(query);
    }

    public async Task<WarhammerRace> GetByIdAsync(int id)
    {
        const string query = "SELECT [Id], [Name] FROM [ForgeMyHeroDb].[Warhammer].[Races] WHERE [Id] = @Id";
        using var connection = _context.CreateConnection();
        return await connection.QuerySingleOrDefaultAsync<WarhammerRace>(query, new { Id = id });
    }
}
