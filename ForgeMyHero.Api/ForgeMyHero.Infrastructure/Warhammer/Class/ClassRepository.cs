using Dapper;
using ForgeMyHero.Application.Warhammer.Interfaces;
using ForgeMyHero.Domain.Warhammer.Entity;

namespace ForgeMyHero.Infrastructure.Warhammer.Class;
public class ClassRepository(DapperDbContext context) : BaseRepository(context), IQueryRepository<WarhammerClass>
{
    public async Task<IEnumerable<WarhammerClass>> GetAllAsync()
    {
        const string query = "SELECT [Id], [Name] FROM [ForgeMyHeroDb].[Warhammer].[Classes]";
        using var connection = _context.CreateConnection();
        return await connection.QueryAsync<WarhammerClass>(query);
    }

    public async Task<WarhammerClass> GetByIdAsync(int id)
    {
        const string query = "SELECT [Id], [Name] FROM [ForgeMyHeroDb].[Warhammer].[Classes] WHERE [Id] = @Id";
        using var connection = _context.CreateConnection();
        return await connection.QuerySingleOrDefaultAsync<WarhammerClass>(query, new { Id = id });
    }
}
