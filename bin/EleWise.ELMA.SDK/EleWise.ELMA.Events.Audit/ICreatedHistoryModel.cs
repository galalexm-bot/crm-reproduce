using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Events.Audit;

public interface ICreatedHistoryModel<TEntity> : IHistoryBaseModel where TEntity : class, IEntity
{
	TEntity Entity { get; set; }
}
