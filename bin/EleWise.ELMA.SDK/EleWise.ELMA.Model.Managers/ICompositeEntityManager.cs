using System;

namespace EleWise.ELMA.Model.Managers;

public interface ICompositeEntityManager
{
	IEntityManager GetPartialManager(Type entityType);
}
