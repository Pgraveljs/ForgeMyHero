using ForgeMyHero.Application.Warhammer.Interfaces;
using ForgeMyHero.Domain.Warhammer.Entity;
using MediatR;

namespace ForgeMyHero.Application.Warhammer.Class.Queries;
public class GetClassesQuery: IRequest<IEnumerable<WarhammerClass>> { }
public class GetClassesQueryHandler : IRequestHandler<GetClassesQuery, IEnumerable<WarhammerClass>>
{
    private readonly IQueryRepository<WarhammerClass> _repository;

    public GetClassesQueryHandler(IQueryRepository<WarhammerClass> repository) => _repository = repository;

    public async Task<IEnumerable<WarhammerClass>> Handle(GetClassesQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}
