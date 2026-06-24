using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.Messages.Managers;

public interface IMessageQueueItemManager : IEntityManager<IMessageQueueItem, long>, IEntityManager<IMessageQueueItem>, IEntityManager
{
	void DeleteProcessedQueueItems();
}
