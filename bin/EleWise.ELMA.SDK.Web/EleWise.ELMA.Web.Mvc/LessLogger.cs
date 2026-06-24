using dotless.Core.Loggers;
using EleWise.ELMA.Logging;

namespace EleWise.ELMA.Web.Mvc;

internal class LessLogger : ILogger
{
	private static readonly ILogger Logger = EleWise.ELMA.Logging.Logger.GetLogger("LessLogger");

	public void Debug(string message)
	{
		Logger.Debug(message);
	}

	public void Debug(string message, params object[] args)
	{
		Logger.DebugFormat(message, args);
	}

	public void Error(string message)
	{
		Logger.Error(message);
	}

	public void Error(string message, params object[] args)
	{
		Logger.ErrorFormat(message, args);
	}

	public void Info(string message)
	{
		Logger.Info(message);
	}

	public void Info(string message, params object[] args)
	{
		Logger.InfoFormat(message, args);
	}

	public void Log(LogLevel level, string message)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected I4, but got Unknown
		switch (level - 1)
		{
		case 1:
			Logger.Log(LogLevel.Debug, message);
			break;
		case 3:
			Logger.Log(LogLevel.Error, message);
			break;
		case 0:
			Logger.Log(LogLevel.Information, message);
			break;
		default:
			Logger.Log(LogLevel.Warning, message);
			break;
		}
	}

	public void Warn(string message)
	{
		Logger.Warn(message);
	}

	public void Warn(string message, params object[] args)
	{
		Logger.WarnFormat(message, args);
	}
}
