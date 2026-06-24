using System;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Services;

[DeveloperApi(DeveloperApiType.Service)]
public interface IServerRestartService
{
	Guid Schedule(long userId, DateTime restartDate, string reason, bool sendNotifications);

	void CancelRestart(Guid restartId);

	TimeSpan GetMinimumRestartTime();
}
