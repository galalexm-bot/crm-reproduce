using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling;
using NHibernate;

namespace EleWise.ELMA.Documents.Services;

[Component]
internal sealed class DmsObjectsPermissionQueueHandler : ISweepHandler
{
	private readonly IDmsObjectPermissionUpdateQueueItemRepository dmsObjectPermissionUpdateQueueItemManager;

	private readonly DmsObjectPermissionPatcherService dmsObjectPermissionPatcherService = DmsObjectPermissionPatcherService.Instance;

	private readonly ISessionProvider sessionProvider;

	private readonly IFeatureFlagService featureFlagService;

	private DateTime lastRun = DateTime.MinValue;

	private DateTime lastFree = DateTime.MinValue;

	private int activeUpdateOperations;

	public DmsObjectsPermissionQueueHandler(IDmsObjectPermissionUpdateQueueItemRepository dmsObjectPermissionUpdateQueueItemManager, ISessionProvider sessionProvider, IFeatureFlagService featureFlagService)
	{
		this.dmsObjectPermissionUpdateQueueItemManager = dmsObjectPermissionUpdateQueueItemManager;
		this.sessionProvider = sessionProvider;
		this.featureFlagService = featureFlagService;
	}

	public void Execute()
	{
		if (!featureFlagService.Enabled("DmsObjectPermissionUpdateQueueItem.Enabled", defaultEnabled: true))
		{
			return;
		}
		DateTime now = DateTime.Now;
		if ((now - lastFree).TotalSeconds > (double)SR.GetSetting("DmsObjectPermissionUpdateQueueItem.ReleaseItemsInterval", 60))
		{
			dmsObjectPermissionUpdateQueueItemManager.ReleaseItems();
			lastFree = now;
		}
		if ((now - lastRun).TotalMilliseconds < (double)SR.GetSetting("DmsObjectPermissionUpdateQueueItem.Interval", 5000))
		{
			return;
		}
		int num = SR.GetSetting("DmsObjectPermissionUpdateQueueItem.DmsObjectsCount", 5000) - activeUpdateOperations;
		if (num > 0)
		{
			ISession session = sessionProvider.GetSession(string.Empty);
			try
			{
				IEnumerable<DmsObjectPermissionUpdateQueueItem> items = dmsObjectPermissionUpdateQueueItemManager.GetItems(num);
				activeUpdateOperations += items.Count();
				foreach (DmsObjectPermissionUpdateQueueItem item in items)
				{
					dmsObjectPermissionPatcherService.UpdatePermission(item);
					activeUpdateOperations--;
				}
				IEnumerable<long> enumerable = items.Select((DmsObjectPermissionUpdateQueueItem i) => i.User).Distinct();
				long count;
				IEnumerable<long> source = from f in items.Select((DmsObjectPermissionUpdateQueueItem i) => i.FolderId).Distinct()
					where dmsObjectPermissionUpdateQueueItemManager.TryGetDocumentsCount(f, out count) && count == 0
					select f;
				foreach (long user in enumerable)
				{
					string text = string.Join(", ", from f in source
						where items.Any((DmsObjectPermissionUpdateQueueItem i) => i.User == user && i.FolderId == f)
						select items.FirstOrDefault((DmsObjectPermissionUpdateQueueItem i) => i.FolderId == f).FolderName);
					if (!string.IsNullOrEmpty(text))
					{
						dmsObjectPermissionPatcherService.NotifyPermissionsUpdated(user, text);
					}
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
