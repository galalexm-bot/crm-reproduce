using EleWise.ELMA.History.Models;

namespace EleWise.ELMA.History.Services;

internal interface IHistoryUpdateService
{
	void UpdateHistory(HistoryUpdateQueueItem queueItem);
}
