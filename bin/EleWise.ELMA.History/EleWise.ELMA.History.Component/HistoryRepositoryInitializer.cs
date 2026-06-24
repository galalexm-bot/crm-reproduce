using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.History.Services;
using EleWise.ELMA.Modules;

namespace EleWise.ELMA.History.Components;

[Component]
internal sealed class HistoryRepositoryInitializer : IModuleContainerEvents
{
	private readonly ICollectorsStateService сollectorsStateManager;

	public IHistoryRepository HistoryRepository { get; set; }

	public HistoryRepositoryInitializer(ICollectorsStateService сollectorsStateManager)
	{
		this.сollectorsStateManager = сollectorsStateManager;
	}

	public void Activated()
	{
		if (HistoryRepository != null && сollectorsStateManager.CheckCollectors())
		{
			HistoryRepository.CreateTables();
		}
	}

	public void Terminating()
	{
	}
}
