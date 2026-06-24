using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Components;
using EleWise.ELMA.Common.Enums;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Services;

[Service(Type = ComponentType.WebServer)]
internal class ScheduledRestartService : IScheduledRestartService
{
	private const string BlobStoreKey = "ScheduledRestartService_Data";

	private const string LockKey = "ScheduledRestartService_Lock";

	private const string BlobStoreHistoryKey = "ScheduledRestartService_HistoryData";

	private const string HistoryLockKey = "ScheduledRestartService_HistoryLock";

	private BlobStore blobStore;

	private ILockManager lockManager;

	private ServerRestartSettingsModule settingsModule;

	private ServerRestartSettingsModule SettingsModule
	{
		get
		{
			if (settingsModule == null)
			{
				return settingsModule = Locator.GetServiceNotNull<ServerRestartSettingsModule>();
			}
			return settingsModule;
		}
	}

	public ScheduledRestartService(BlobStore blobStore, ILockManager lockManager)
	{
		Contract.ArgumentNotNull(blobStore, "blobStore");
		Contract.ArgumentNotNull(lockManager, "lockManager");
		this.blobStore = blobStore;
		this.lockManager = lockManager;
	}

	public ScheduledRestart LoadOrNull(Guid id)
	{
		using (lockManager.Lock("ScheduledRestartService_Lock"))
		{
			return LoadRestartsNoLock().FirstOrDefault((ScheduledRestart r) => r.Id == id)?.Clone();
		}
	}

	public Guid Create(DateTime restartDate, long author, string reason, bool sendNotifications)
	{
		Contract.ArgumentNotNull(reason, "reason");
		Contract.CheckArgument(restartDate != default(DateTime), "restartDate != default(DateTime)");
		Contract.CheckArgument(author > 0, "author > 0");
		using (lockManager.Lock("ScheduledRestartService_Lock"))
		{
			List<ScheduledRestart> list = LoadRestartsNoLock(saveManually: true);
			ScheduledRestart scheduledRestart = new ScheduledRestart
			{
				Id = Guid.NewGuid(),
				Reason = reason,
				RestartDate = restartDate,
				CreationDate = DateTime.Now,
				Author = author,
				State = RestartState.Waiting,
				SendNotifications = sendNotifications
			};
			list.Add(scheduledRestart);
			SaveRestartsNoLock(list);
			Logger.Log.Error(SR.T("Создан запланированный перезапуск (Id={0}) на {1} по серверному времени пользователем (Id=\"{2}\"), причина: \"{3}\".", scheduledRestart.Id, scheduledRestart.RestartDate.ToServerDateTime(), author, (reason.Length > 32) ? (reason.Substring(0, 32) + "...") : reason));
			return scheduledRestart.Id;
		}
	}

	public bool TryUpdate(ScheduledRestart restart)
	{
		Contract.ArgumentNotNull(restart, "restart");
		Contract.CheckArgument(restart.Id != Guid.Empty, "restart.Id != Guid.Empty");
		Contract.CheckArgument(restart.RestartDate != default(DateTime), "restart.RestartDate == default(DateTime)");
		Contract.CheckArgument(restart.CreationDate != default(DateTime), "restart.CreationDate != default(DateTime)");
		using (lockManager.Lock("ScheduledRestartService_Lock"))
		{
			List<ScheduledRestart> list = LoadRestartsNoLock(saveManually: true);
			ScheduledRestart scheduledRestart = list.FirstOrDefault((ScheduledRestart r) => r.Id == restart.Id);
			if (scheduledRestart == null)
			{
				return false;
			}
			scheduledRestart.AssignFrom(restart);
			SaveRestartsNoLock(list);
			return true;
		}
	}

	public bool TryUpdateMachineState(ScheduledRestart restart, MachineRestartState newState, DateTime? newRestartDate)
	{
		Contract.ArgumentNotNull(restart, "restart");
		Contract.CheckArgument(restart.Id != Guid.Empty, "restart.Id != Guid.Empty");
		Contract.CheckArgument(restart.RestartDate != default(DateTime), "restart.RestartDate != default(DateTime)");
		Contract.CheckArgument(restart.CreationDate != default(DateTime), "restart.CreationDate != default(DateTime)");
		using (lockManager.Lock("ScheduledRestartService_Lock"))
		{
			List<ScheduledRestart> list = LoadRestartsNoLock(saveManually: true);
			ScheduledRestart scheduledRestart = list.FirstOrDefault((ScheduledRestart r) => r.Id == restart.Id);
			if (scheduledRestart == null)
			{
				return false;
			}
			MachineRestart obj = scheduledRestart.MachineRestartStates.FirstOrDefault((MachineRestart s) => s.MachineName == Environment.MachineName) ?? throw new InvalidOperationException($"MachineRestartState for MachineName = {Environment.MachineName} is not found (restart.Id = {restart.Id})");
			obj.State = newState;
			obj.RestartDate = newRestartDate;
			if (scheduledRestart.MachineRestartStates.All((MachineRestart s) => s.State != MachineRestartState.Acknowledged))
			{
				scheduledRestart.State = RestartState.Finishing;
			}
			else if (scheduledRestart.State == RestartState.Waiting && newState != 0)
			{
				scheduledRestart.State = RestartState.Restarting;
			}
			SaveRestartsNoLock(list);
			return true;
		}
	}

	public ICollection<ScheduledRestart> GetRestarts()
	{
		using (lockManager.Lock("ScheduledRestartService_Lock"))
		{
			return (from r in LoadRestartsNoLock()
				select r.Clone()).ToArray();
		}
	}

	public ICollection<ScheduledRestart> GetRestarts(Func<ScheduledRestart, bool> predicate)
	{
		using (lockManager.Lock("ScheduledRestartService_Lock"))
		{
			return (from r in LoadRestartsNoLock().Where(predicate)
				select r.Clone()).ToArray();
		}
	}

	public void AddToHistory(ScheduledRestartHistoryEntry entry)
	{
		Contract.ArgumentNotNull(entry, "entry");
		using (lockManager.Lock("ScheduledRestartService_HistoryLock"))
		{
			List<ScheduledRestartHistoryEntry> list = LoadHistoryNoLock();
			list.Add(entry);
			int maxHistoryEntries = SettingsModule.GetSettingsCopyThreadSafe().MaxHistoryEntries;
			if (list.Count > maxHistoryEntries)
			{
				list = list.OrderBy((ScheduledRestartHistoryEntry x) => x.CreationDate).Skip(list.Count - maxHistoryEntries).ToList();
			}
			byte[] value = ClassSerializationHelper.SerializeObject(list);
			blobStore.Save("ScheduledRestartService_HistoryData", value);
		}
	}

	public ICollection<ScheduledRestartHistoryEntry> GetHistory()
	{
		using (lockManager.Lock("ScheduledRestartService_HistoryLock"))
		{
			return LoadHistoryNoLock();
		}
	}

	private List<ScheduledRestart> LoadRestartsNoLock(bool saveManually = false)
	{
		List<ScheduledRestart> list = null;
		bool flag = false;
		byte[] array = blobStore.LoadOrNull("ScheduledRestartService_Data");
		if (array != null)
		{
			list = ClassSerializationHelper.DeserializeObject(array) as List<ScheduledRestart>;
			if (list == null)
			{
				Logger.Log.ErrorFormat("ScheduledRestartService.LoadRestartNoLock(): Invalid data in BlobStore by key \"{0}\", expected object of type List<ScheduledRestart>.", "ScheduledRestartService_Data");
			}
		}
		if (list == null)
		{
			list = new List<ScheduledRestart>();
		}
		foreach (ScheduledRestart item in list)
		{
			if (item.State == RestartState.Waiting && item.MachineRestartStates.FirstOrDefault((MachineRestart s) => s.MachineName == Environment.MachineName) == null)
			{
				item.MachineRestartStates.Add(new MachineRestart
				{
					MachineName = Environment.MachineName,
					State = MachineRestartState.Acknowledged,
					RestartDate = null
				});
				flag = true;
			}
		}
		if (!saveManually && flag)
		{
			SaveRestartsNoLock(list);
		}
		return list;
	}

	private void SaveRestartsNoLock(List<ScheduledRestart> restarts)
	{
		byte[] value = ClassSerializationHelper.SerializeObject(restarts.Where((ScheduledRestart r) => r.State != RestartState.Finished).ToList());
		blobStore.Save("ScheduledRestartService_Data", value);
	}

	private List<ScheduledRestartHistoryEntry> LoadHistoryNoLock()
	{
		List<ScheduledRestartHistoryEntry> list = null;
		byte[] array = blobStore.LoadOrNull("ScheduledRestartService_HistoryData");
		if (array != null)
		{
			list = ClassSerializationHelper.DeserializeObject(array) as List<ScheduledRestartHistoryEntry>;
			if (list == null)
			{
				Logger.Log.ErrorFormat("ScheduledRestartService.GetHistory(): Invalid data in BlobStore by key \"{0}\", expected object of type List<ScheduledRestartHistoryEntry>.", "ScheduledRestartService_HistoryData");
			}
			else
			{
				int maxHistoryEntries = SettingsModule.GetSettingsCopyThreadSafe().MaxHistoryEntries;
				if (list.Count > maxHistoryEntries)
				{
					list.RemoveRange(maxHistoryEntries, list.Count - maxHistoryEntries);
				}
			}
		}
		if (list == null)
		{
			list = new List<ScheduledRestartHistoryEntry>();
		}
		return list;
	}
}
