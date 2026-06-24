using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Core.Services;

namespace EleWise.ELMA.Services;

internal class InternalNotificationService : INotificationService
{
	public virtual void Error(string title, string message, bool autoClosed = true)
	{
		Logger.Log.Error("{0} {1}", new object[2] { title, message });
	}

	public virtual void Success(string title, string message, bool autoClosed = true)
	{
		Logger.Log.Info("{0} {1}", new object[2] { title, message });
	}

	public virtual void Warning(string title, string message, bool autoClosed = true)
	{
		Logger.Log.Warn("{0} {1}", new object[2] { title, message });
	}

	public virtual void Info(string title, string message, bool autoClosed = true)
	{
		Logger.Log.Info("{0} {1}", new object[2] { title, message });
	}
}
