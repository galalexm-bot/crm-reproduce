using EleWise.ELMA.Core.Diagnostics;
using EleWise.ELMA.Core.Services;

namespace EleWise.ELMA.Services;

internal static class NotificationService
{
	private static INotificationService instance = new InternalNotificationService();

	internal static void SetImpl(INotificationService impl)
	{
		Contract.ArgumentNotNull(impl, "impl");
		instance = impl;
	}

	internal static void Error(string title, string message, bool autoClosed = true)
	{
		instance.Error(title, message, autoClosed);
	}

	internal static void Success(string title, string message, bool autoClosed = true)
	{
		instance.Success(title, message, autoClosed);
	}

	internal static void Warning(string title, string message, bool autoClosed = true)
	{
		instance.Warning(title, message, autoClosed);
	}

	internal static void Info(string title, string message, bool autoClosed = true)
	{
		instance.Info(title, message, autoClosed);
	}
}
