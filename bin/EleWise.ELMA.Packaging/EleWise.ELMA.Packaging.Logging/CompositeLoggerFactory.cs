using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Packaging.Logging;

public class CompositeLoggerFactory : ILoggerFactory
{
	public IEnumerable<ILoggerFactory> Factories { get; set; }

	public CompositeLoggerFactory(IEnumerable<ILoggerFactory> factories)
	{
		if (factories == null)
		{
			throw new ArgumentNullException("factories");
		}
		Factories = factories;
	}

	public ILogger CreateLogger(Type type)
	{
		return new CompositeLogger((Factories != null) ? Factories.Select((ILoggerFactory f) => f.CreateLogger(type)).ToArray() : new ILogger[0]);
	}
}
