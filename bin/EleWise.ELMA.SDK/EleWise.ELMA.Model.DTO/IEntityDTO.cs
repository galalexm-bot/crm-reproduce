using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Model.DTO;

public interface IEntityDTO<TId, TEntity> : IEntityDTO<TId>, IEntityDTO where TEntity : IEntity
{
}
public interface IEntityDTO<TId> : IEntityDTO
{
	new TId Id { get; set; }
}
[ExtensionPoint(false, ComponentType.All, ServiceScope.Application)]
public interface IEntityDTO
{
	object Id { get; set; }
}
