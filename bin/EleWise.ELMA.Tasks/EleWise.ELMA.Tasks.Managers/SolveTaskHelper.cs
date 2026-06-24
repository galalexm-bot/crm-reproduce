using System;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Tasks.Managers;

public static class SolveTaskHelper
{
	public static readonly ILogger SolveTaskLog = Logger.GetLogger("ElmaSolveTask");

	public static void RunWithDebug(string method, bool debugMode, Action action)
	{
		if (!debugMode)
		{
			action();
			return;
		}
		IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>();
		DateTime now = DateTime.Now;
		SolveTaskLog.Debug($"Start execute {method}. User: {currentUser.UserName}");
		action();
		SolveTaskLog.Debug($"Executed {method}. User: {currentUser.UserName} Time: {(DateTime.Now - now).Milliseconds} ms");
	}
}
