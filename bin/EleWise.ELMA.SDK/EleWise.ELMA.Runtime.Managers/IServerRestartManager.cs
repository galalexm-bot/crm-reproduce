using System;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Runtime.Managers;

public interface IServerRestartManager : IConfigurationService
{
	Guid Schedule(long userId, DateTime targetDate, string reason, bool sendNotifications);

	void CancelRestart(Guid restartId);

	TimeSpan GetMinimumRestartTime();
}
