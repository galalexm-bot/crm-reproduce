using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Logging;

namespace EleWise.ELMA.Common.BulkDataImport;

internal class SmartLogger : IDisposable
{
	private const int paddingConst = 2;

	private readonly bool disabled;

	private static readonly ConcurrentDictionary<string, ILogger> loggers = new ConcurrentDictionary<string, ILogger>();

	private ILogger logger;

	private readonly string partName;

	private readonly string action;

	private readonly DateTime startDate;

	private readonly string loggerName;

	private readonly List<SmartLogger> innerLoggerList = new List<SmartLogger>();

	private bool isDisposed;

	private readonly int padding;

	public Guid Key { get; private set; }

	public SmartLogger(string partName, string action, string description, Guid logKey = default(Guid))
		: this(string.Empty, partName, action, description, logKey)
	{
	}

	public SmartLogger(string loggerName, string partName, string action, string description = null, Guid logKey = default(Guid))
		: this(disabled: false, loggerName, partName, action, description, logKey)
	{
	}

	public override string ToString()
	{
		return action;
	}

	public SmartLogger(bool disabled, string loggerName, string partName, string action, string description = null, Guid logKey = default(Guid))
		: this(0, disabled, loggerName, partName, action, description, logKey)
	{
	}

	private SmartLogger(int padding, bool disabled, string loggerName, string partName, string action, string description = null, Guid logKey = default(Guid))
	{
		SmartLogger smartLogger = this;
		this.padding = padding;
		if (logKey == Guid.Empty)
		{
			logKey = Guid.NewGuid();
		}
		this.disabled = disabled;
		Key = logKey;
		logger = loggers.GetOrAdd(string.IsNullOrEmpty(loggerName) ? "" : loggerName, (string name) => smartLogger.logger = (string.IsNullOrEmpty(name) ? Logger.Log : Logger.GetLogger(loggerName)));
		this.partName = partName;
		this.action = action;
		this.loggerName = loggerName;
		LogInfo(0, disabled, string.Format("{0} => Start{1}", action, string.IsNullOrEmpty(description) ? "" : $" ({description})"));
		startDate = DateTime.Now;
	}

	public SmartLogger InnerLogger(string action, string description = null)
	{
		return InnerLogger(disabled, action, description);
	}

	public SmartLogger InnerLogger(bool disabled, string action, string description = null)
	{
		SmartLogger smartLogger = new SmartLogger(padding + 2, disabled, loggerName, partName, action, description, Key);
		innerLoggerList.Insert(0, smartLogger);
		return smartLogger;
	}

	public void Dispose()
	{
		foreach (SmartLogger item in innerLoggerList.Where((SmartLogger l) => !l.isDisposed))
		{
			item.Dispose();
		}
		isDisposed = true;
		LogInfo(0, disabled, $"{action} => End", startDate);
	}

	public void Info(string description, DateTime? dateStart = null)
	{
		InfoInnerlogic(disabled: false, description, dateStart);
	}

	public void InfoIfEnabled(string description, DateTime? dateStart = null)
	{
		InfoInnerlogic(disabled, description, dateStart);
	}

	private void InfoInnerlogic(bool disabled, string description, DateTime? dateStart = null)
	{
		LogInfo(2, disabled, $"{action} ... {description}", dateStart);
	}

	public void Warn(string description)
	{
		WarnInnerlogic(disabled: false, description);
	}

	public void WarnIfEnabled(string description)
	{
		WarnInnerlogic(disabled, description);
	}

	private void WarnInnerlogic(bool disabled, string description)
	{
		LogWarn(2, disabled, $"{action} ... {description}");
	}

	public void Error(Exception exception)
	{
		LogError(2, exception);
	}

	private void LogInfo(int padding, bool disabled, string desciption, DateTime? dateStart = null)
	{
		if (!logger.IsEnabled(LogLevel.Information) || disabled)
		{
			return;
		}
		string text = (string.IsNullOrEmpty(desciption) ? "" : desciption);
		if (!string.IsNullOrEmpty(text))
		{
			if (dateStart.HasValue)
			{
				text = SR.T("{0} (время выполнения: {1})", text, DateTime.Now - dateStart.Value);
			}
			int num = padding + this.padding;
			string text2 = ((num > 0) ? new string(' ', num) : "");
			logger.Info($"{partName} ({Key}):{text2} {text}");
		}
	}

	private void LogWarn(int padding, bool disabled, string desciption)
	{
		if (!(!logger.IsEnabled(LogLevel.Warning) || disabled) && !string.IsNullOrEmpty(string.IsNullOrEmpty(desciption) ? "" : desciption))
		{
			int num = padding + this.padding;
			string text = ((num > 0) ? new string(' ', num) : "");
			logger.Warn($"{partName} ({Key}):{text} {action} => ");
		}
	}

	private void LogError(int padding, Exception exception)
	{
		if (logger.IsEnabled(LogLevel.Error) && !disabled)
		{
			int num = padding + this.padding;
			string text = ((num > 0) ? new string(' ', num) : "");
			logger.Error($"{partName} ({Key}):{text} {action} => ", exception);
		}
	}
}
