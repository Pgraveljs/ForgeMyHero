namespace ForgeMyHero.Application.Warhammer.Interfaces;

public interface IQueryRepository<T>
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
}
