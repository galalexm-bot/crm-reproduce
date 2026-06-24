using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.History.Models;
using EleWise.ELMA.History.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling;
using NHibernate;

namespace EleWise.ELMA.History.Components;

[Component]
internal sealed class HistoryUpdateQueueHandler : ISweepHandler
{
	private readonly IHistoryUpdateQueueItemRepository historyUpdateQueueItemRepository;

	private readonly IHistoryUpdateService historyUpdateService;

	private readonly ISessionProvider sessionProvider;

	private DateTime lastRun = DateTime.MinValue;

	private DateTime lastFree = DateTime.MinValue;

	private int activeUpdateOperations;

	private const string ProjectsCountSettingKey = "HistoryUpdateQueueHandler.ObjectsCount";

	private const string ReleaseItemsIntervalSettingKey = "HistoryUpdateQueueHandler.ReleaseItemsInterval";

	private const string IntervalSettingKey = "HistoryUpdateQueueHandler.Interval";

	private const int ObjectsCountDefault = 10;

	private const int ReleaseItemsIntervalDefault = 60;

	private const int IntervalDefault = 5000;

	public IHistoryRepository HistoryRepository { get; set; }

	public HistoryUpdateQueueHandler(IHistoryUpdateQueueItemRepository historyUpdateQueueItemRepository, IHistoryUpdateService historyUpdateService, ISessionProvider sessionProvider)
	{
		this.historyUpdateQueueItemRepository = historyUpdateQueueItemRepository;
		this.historyUpdateService = historyUpdateService;
		this.sessionProvider = sessionProvider;
	}

	public void Execute()
	{
		if (HistoryRepository == null)
		{
			return;
		}
		DateTime now = DateTime.Now;
		if ((now - lastFree).TotalSeconds > (double)SR.GetSetting("HistoryUpdateQueueHandler.ReleaseItemsInterval", 60))
		{
			historyUpdateQueueItemRepository.ReleaseItems();
			lastFree = now;
		}
		if ((now - lastRun).TotalMilliseconds < (double)SR.GetSetting("HistoryUpdateQueueHandler.Interval", 5000))
		{
			return;
		}
		int num = SR.GetSetting("HistoryUpdateQueueHandler.ObjectsCount", 10) - activeUpdateOperations;
		if (num > 0)
		{
			ISession session = sessionProvider.GetSession(string.Empty);
			try
			{
				foreach (HistoryUpdateQueueItem item in historyUpdateQueueItemRepository.GetItems(num))
				{
					historyUpdateService.UpdateHistory(item);
					activeUpdateOperations--;
				}
			}
			finally
			{
				session.Clear();
			}
		}
		lastRun = now;
	}
}
