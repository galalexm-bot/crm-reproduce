using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Packaging.Logging;
using Microsoft.Build.Framework;

namespace EleWise.ELMA.BuildTools.MSBuild.Utils;

internal sealed class SimpleBuildProjectLogger : ILogger
{
	private LoggerVerbosity verbosity;

	public LoggerVerbosity Verbosity { get; set; }

	public string Parameters { get; set; }

	private Dictionary<LogLevel, List<string>> Messages { get; }

	public SimpleBuildProjectLogger()
	{
		Messages = new Dictionary<LogLevel, List<string>>();
	}

	public void Initialize(IEventSource eventSource)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		eventSource.add_ProjectStarted(new ProjectStartedEventHandler(EventSourceProjectStarted));
		eventSource.add_MessageRaised(new BuildMessageEventHandler(EventSourceMessageRaised));
		eventSource.add_WarningRaised(new BuildWarningEventHandler(EventSourceWarningRaised));
		eventSource.add_ErrorRaised(new BuildErrorEventHandler(EventSourceErrorRaised));
		eventSource.add_ProjectFinished(new ProjectFinishedEventHandler(EventSourceProjectFinished));
	}

	public void Shutdown()
	{
	}

	public IEnumerable<string> GetMessages(LogLevel level)
	{
		IEnumerable<string> result;
		if (!Messages.TryGetValue(level, out var value))
		{
			result = Enumerable.Empty<string>();
		}
		else
		{
			IEnumerable<string> enumerable = value;
			result = enumerable;
		}
		return result;
	}

	private void EventSourceErrorRaised(object sender, BuildErrorEventArgs e)
	{
		string line = $"{LogLevel.Error} {e.get_File()}({e.get_LineNumber()},{e.get_ColumnNumber()}): [{e.get_Code()}]";
		WriteLineWithSenderAndMessage(LogLevel.Error, line, (BuildEventArgs)(object)e);
	}

	private void EventSourceWarningRaised(object sender, BuildWarningEventArgs e)
	{
		string line = $"{LogLevel.Warning} {e.get_File()}({e.get_LineNumber()},{e.get_ColumnNumber()}): [{e.get_Code()}]";
		WriteLineWithSenderAndMessage(LogLevel.Warning, line, (BuildEventArgs)(object)e);
	}

	private void EventSourceMessageRaised(object sender, BuildMessageEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		if (((int)e.get_Importance() == 0 && IsVerbosityAtLeast((LoggerVerbosity)1)) || ((int)e.get_Importance() == 1 && IsVerbosityAtLeast((LoggerVerbosity)2)) || ((int)e.get_Importance() == 2 && IsVerbosityAtLeast((LoggerVerbosity)3)))
		{
			WriteLineWithSenderAndMessage(LogLevel.Trace, string.Empty, (BuildEventArgs)(object)e);
		}
	}

	private void EventSourceProjectStarted(object sender, ProjectStartedEventArgs e)
	{
		WriteLine(LogLevel.Information, string.Empty, (BuildEventArgs)(object)e);
	}

	private void EventSourceProjectFinished(object sender, ProjectFinishedEventArgs e)
	{
		WriteLine(LogLevel.Information, string.Empty, (BuildEventArgs)(object)e);
	}

	private void WriteLineWithSenderAndMessage(LogLevel level, string line, BuildEventArgs e)
	{
		if (string.Compare(e.get_SenderName(), "MSBuild", StringComparison.OrdinalIgnoreCase) == 0)
		{
			WriteLine(level, line, e);
		}
		else
		{
			WriteLine(level, e.get_SenderName() + " : " + line, e);
		}
	}

	private void WriteLine(LogLevel level, string line, BuildEventArgs e)
	{
		if (!Messages.ContainsKey(level))
		{
			Messages[level] = new List<string>();
		}
		Messages[level].Add(line + " " + e.get_Message());
	}

	private bool IsVerbosityAtLeast(LoggerVerbosity checkVerbosity)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return verbosity >= checkVerbosity;
	}
}
