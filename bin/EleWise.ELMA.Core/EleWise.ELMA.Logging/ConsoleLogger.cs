using System;
using Bridge.Utils;
using EleWise.ELMA.Core.Logging;

namespace EleWise.ELMA.Logging;

internal sealed class ConsoleLogger : ILogger
{
	public void Log(LogLevel level, System.Exception exception, string format, params object[] args)
	{
		string text = ((args != null) ? string.Format(format, args) : format);
		string text2 = $"{System.DateTime.get_Now()} - {text} {exception}";
		switch (level)
		{
		case LogLevel.Error:
			Console.Error(text2);
			break;
		case LogLevel.Debug:
			Console.Debug(text2);
			break;
		default:
			Console.Log((object)text2, true);
			break;
		}
	}
}
