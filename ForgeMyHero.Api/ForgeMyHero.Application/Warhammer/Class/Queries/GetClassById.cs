using ForgeMyHero.Application.Warhammer.Interfaces;
using ForgeMyHero.Domain.Warhammer.Entity;
using MediatR;

namespace ForgeMyHero.Application.Warhammer.Class.Queries;

public record GetClassByIdQuery(int Id) : IRequest<WarhammerClass> { };
public class GetClassByIdQueryHandler : IRequestHandler<GetClassByIdQuery, WarhammerClass>
{
    private readonly IQueryRepository<WarhammerClass> _repository; 
    public GetClassByIdQueryHandler(IQueryRepository<WarhammerClass> repository) => _repository = repository;

    public async Task<WarhammerClass> Handle(GetClassByIdQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetByIdAsync(request.Id);
    }
}