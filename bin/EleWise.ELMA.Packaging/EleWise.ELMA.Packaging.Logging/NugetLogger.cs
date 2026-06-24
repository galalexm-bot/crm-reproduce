using System;
using NuGet;

namespace EleWise.ELMA.Packaging.Logging;

public class NugetLogger : ILogger
{
	private ILogger _baseLogger;

	public NugetLogger(ILogger baseLogger)
	{
		if (baseLogger == null)
		{
			throw new ArgumentNullException("baseLogger");
		}
		_baseLogger = baseLogger;
	}

	public virtual bool IsEnabled(LogLevel level)
	{
		return true;
	}

	public virtual void Log(LogLevel level, Exception exception, string format, params object[] args)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		MessageLevel val = (MessageLevel)2;
		switch (level)
		{
		case LogLevel.Verbose:
		case LogLevel.Trace:
		case LogLevel.Debug:
			val = (MessageLevel)2;
			break;
		case LogLevel.Error:
		case LogLevel.Fatal:
			val = (MessageLevel)3;
			break;
		case LogLevel.Information:
			val = (MessageLevel)0;
			break;
		case LogLevel.Warning:
			val = (MessageLevel)1;
			break;
		}
		string text = ((args != null) ? string.Format(format, args) : format);
		if (exception != null)
		{
			text = text + "\r\n" + exception.ToString();
		}
		_baseLogger.Log(val, format, args);
	}
}
