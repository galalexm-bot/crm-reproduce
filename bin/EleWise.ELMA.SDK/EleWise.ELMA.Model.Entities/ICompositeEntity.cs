using System.Collections.Generic;

namespace EleWise.ELMA.Model.Entities;

public interface ICompositeEntity : IEntity, IIdentified
{
	IEnumerable<IEntity> GetCompositeEntities();
}
public interface ICompositeEntity<IdT> : IEntity<IdT>, IEntity, IIdentified, ICompositeEntity
{
}
