namespace ForgeMyHero.Application.Warhammer.Interfaces;

public interface ICommandRepository<T> : IQueryRepository<T>
{
    Task<int> CreateAsync(T entity);
    Task DeleteAsync(int id);
    Task<T> UpdateAsync(T entity);
}
