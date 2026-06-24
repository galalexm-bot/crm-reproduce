using EleWise.ELMA.Logging;
using EleWise.ELMA.WebCompiler;

namespace EleWise.ELMA.Web.Mvc.Util;

public class WebCompilerConsole : ICompilerConsole
{
	private ILogger Logger = EleWise.ELMA.Logging.Logger.GetLogger("WebCompiler");

	public void WriteError(string message)
	{
		Logger.Error(message);
	}

	public void WriteInfo(string message)
	{
		Logger.Info(message);
	}

	public void WriteWarning(string message)
	{
		Logger.Warn(message);
	}

	public void WriteDebug(string message)
	{
		Logger.Debug(message);
	}
}
