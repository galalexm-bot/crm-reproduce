using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Enums;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Common.Services;

[DeveloperApi(DeveloperApiType.Service)]
public interface IScheduledRestartService
{
	ScheduledRestart LoadOrNull(Guid id);

	Guid Create(DateTime restartDate, long author, string reason, bool sendNotifications);

	bool TryUpdate(ScheduledRestart restart);

	bool TryUpdateMachineState(ScheduledRestart restart, MachineRestartState newState, DateTime? newRestartDate);

	ICollection<ScheduledRestart> GetRestarts();

	ICollection<ScheduledRestart> GetRestarts(Func<ScheduledRestart, bool> predicate);

	void AddToHistory(ScheduledRestartHistoryEntry entry);

	ICollection<ScheduledRestartHistoryEntry> GetHistory();
}
