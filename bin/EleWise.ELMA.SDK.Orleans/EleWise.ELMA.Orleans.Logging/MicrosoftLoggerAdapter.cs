using System;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Context;
using Microsoft.Extensions.Logging;

namespace EleWise.ELMA.Orleans.Logging;

internal sealed class MicrosoftLoggerAdapter : ILogger
{
	private class ScopeStub : IDisposable
	{
		public void Dispose()
		{
		}
	}

	private static readonly ScopeStub scopeStub = new ScopeStub();

	private readonly ILogger logger;

	public MicrosoftLoggerAdapter(ILogger logger)
	{
		this.logger = logger;
	}

	public IDisposable BeginScope<TState>(TState state)
	{
		return scopeStub;
	}

	public bool IsEnabled(LogLevel logLevel)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		using (ELMAContext.Create())
		{
			return logger.IsEnabled(GetLogLevel(logLevel));
		}
	}

	public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		LogLevel logLevel2 = GetLogLevel(logLevel);
		string message = formatter(state, exception);
		using (ELMAContext.Create())
		{
			logger.Log(logLevel2, message, exception);
		}
	}

	private LogLevel GetLogLevel(LogLevel logLevel)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
		return (int)logLevel switch
		{
			0 => LogLevel.Trace, 
			1 => LogLevel.Debug, 
			2 => LogLevel.Information, 
			3 => LogLevel.Warning, 
			4 => LogLevel.Error, 
			5 => LogLevel.Fatal, 
			6 => LogLevel.Fatal, 
			_ => LogLevel.Verbose, 
		};
	}
}
