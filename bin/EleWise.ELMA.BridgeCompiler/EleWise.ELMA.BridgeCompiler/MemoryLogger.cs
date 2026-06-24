using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Bridge.Contract;

namespace EleWise.ELMA.BridgeCompiler;

internal sealed class MemoryLogger : ILogger
{
	private ConcurrentDictionary<LoggerLevel, ConcurrentBag<string>> memoryLog;

	public bool AlwaysLogErrors => true;

	public bool BufferedMode { get; set; }

	public LoggerLevel LoggerLevel { get; set; }

	public MemoryLogger()
	{
		memoryLog = new ConcurrentDictionary<LoggerLevel, ConcurrentBag<string>>();
	}

	public void Flush()
	{
		memoryLog.Clear();
	}

	public void Error(string message)
	{
		OutputMessage(message, (LoggerLevel)10);
	}

	public void Error(string message, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber)
	{
		Error(message);
	}

	public void Warn(string message)
	{
		OutputMessage(message, (LoggerLevel)11);
	}

	public void Info(string message)
	{
		OutputMessage(message, (LoggerLevel)12);
	}

	public void Trace(string message)
	{
		OutputMessage(message, (LoggerLevel)13);
	}

	public IEnumerable<string> GetMessages(LoggerLevel level)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (memoryLog.TryGetValue(level, out var value))
		{
			return value;
		}
		return Enumerable.Empty<string>();
	}

	private void OutputMessage(string message, LoggerLevel level)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		memoryLog.GetOrAdd(level, new ConcurrentBag<string>()).Add(message);
	}
}
