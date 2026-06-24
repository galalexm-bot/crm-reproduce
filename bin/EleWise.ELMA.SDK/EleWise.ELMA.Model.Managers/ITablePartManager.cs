using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Model.Managers;

public interface ITablePartManager : IEntityManager
{
	void PutToContextCache(IEntity entity);
}
