using EleWise.ELMA.Logging;

namespace EleWise.ELMA.Core.Logging;

public static class Logger
{
	private static ILogger _003CLog_003Ek__BackingField = new ConsoleLogger();

	public static ILogger Log
	{
		get
		{
			return _003CLog_003Ek__BackingField;
		}
		private set
		{
			_003CLog_003Ek__BackingField = value;
		}
	}
}
