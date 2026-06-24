using log4net;
using log4net.Core;

namespace EleWise.ELMA.Packaging.Logging;

public static class Log4NetExtensions
{
	public static bool IsVerboseEnabled(this ILog log)
	{
		return ((ILoggerWrapper)log).get_Logger().IsEnabledFor(Level.Verbose);
	}

	public static bool IsTraceEnabled(this ILog log)
	{
		return ((ILoggerWrapper)log).get_Logger().IsEnabledFor(Level.Trace);
	}
}
