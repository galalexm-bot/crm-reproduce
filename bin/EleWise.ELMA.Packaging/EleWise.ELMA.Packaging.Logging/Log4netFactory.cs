using System;
using System.IO;
using log4net;
using log4net.Config;

namespace EleWise.ELMA.Packaging.Logging;

public class Log4netFactory : ILoggerFactory
{
	private static string configFile;

	public Log4netFactory()
		: this(configFile ?? SR.GetSetting("log4net.Config"))
	{
	}

	public Log4netFactory(string configFile)
	{
		Log4netFactory.configFile = configFile;
		string text = Logger.GetConfigFile(configFile);
		if (File.Exists(text))
		{
			XmlConfigurator.ConfigureAndWatch(new FileInfo(text));
		}
	}

	public ILogger Create(string name)
	{
		return new Log4netLogger(LogManager.GetLogger(name));
	}

	public ILogger CreateLogger(Type type)
	{
		return Create(type.FullName);
	}
}
