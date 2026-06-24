using System;
using EleWise.ELMA.Logging;
using Microsoft.Extensions.Logging;

namespace EleWise.ELMA.Orleans.Logging;

internal sealed class MicrosoftLoggerFactoryAdapter : ILoggerFactory, IDisposable
{
	private readonly ILoggerFactory loggerFactory;

	public MicrosoftLoggerFactoryAdapter(ILoggerFactory loggerFactory)
	{
		this.loggerFactory = loggerFactory;
	}

	public void AddProvider(ILoggerProvider provider)
	{
		throw new NotImplementedException();
	}

	public ILogger CreateLogger(string categoryName)
	{
		return (ILogger)(object)new MicrosoftLoggerAdapter(loggerFactory.CreateLogger(categoryName));
	}

	public void Dispose()
	{
	}
}
