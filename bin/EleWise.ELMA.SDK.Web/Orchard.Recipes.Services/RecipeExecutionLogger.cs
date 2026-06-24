using System;
using EleWise.ELMA.Logging;

namespace Orchard.Recipes.Services;

public class RecipeExecutionLogger : ITransientDependency, IDependency, ILogger
{
	public Type ComponentType { get; internal set; }

	public ILogger Logger { get; set; }

	public event EventHandler ConfigurationChanged;

	public RecipeExecutionLogger()
	{
		Logger = NullLogger.Instance;
	}

	public bool IsEnabled(LogLevel level)
	{
		return Logger.IsEnabled(level);
	}

	public void Log(LogLevel level, Exception exception, string format, params object[] args)
	{
		string text = string.Format(format, args);
		Logger.Log(level, exception, "{0}: {1}", ComponentType.Name, text);
	}
}
