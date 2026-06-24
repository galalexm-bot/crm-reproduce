using EleWise.ELMA.History.ExtensionPoints;

namespace EleWise.ELMA.History.Services;

internal interface IHistoryProvider
{
	IHistoryRepository HistoryRepository { get; }
}
