namespace ForgeMyHero.Infrastructure.Warhammer;
public class BaseRepository
{
    protected readonly DapperDbContext _context;

    public BaseRepository(DapperDbContext context)
    {
        _context = context;
    }

}
