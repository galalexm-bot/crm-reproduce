using log4net;
using log4net.Core;

namespace EleWise.ELMA.Logging;

public static class Log4NetExtensions
{
	internal static Log4NetExtensions kAXlmXhlEs7N8q1hXtCU;

	public static bool IsVerboseEnabled(ILog log)
	{
		return mlcTqxhlviBitJNUMphP(rZLFCjhlCrkrFO1yPRl1(log), Level.Verbose);
	}

	public static bool IsTraceEnabled(ILog log)
	{
		return ((ILogger)rZLFCjhlCrkrFO1yPRl1(log)).IsEnabledFor(Level.Trace);
	}

	internal static object rZLFCjhlCrkrFO1yPRl1(object P_0)
	{
		return ((ILoggerWrapper)P_0).get_Logger();
	}

	internal static bool mlcTqxhlviBitJNUMphP(object P_0, object P_1)
	{
		return ((ILogger)P_0).IsEnabledFor((Level)P_1);
	}

	internal static bool SGh9MuhlfUanq3RD70UJ()
	{
		return kAXlmXhlEs7N8q1hXtCU == null;
	}

	internal static Log4NetExtensions fG4f5nhlQN7K3DpZ2fjy()
	{
		return kAXlmXhlEs7N8q1hXtCU;
	}
}
