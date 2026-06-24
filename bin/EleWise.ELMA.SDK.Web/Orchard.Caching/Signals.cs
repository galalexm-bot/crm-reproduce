using System.Collections.Generic;

namespace Orchard.Caching;

public class Signals : ISignals, IVolatileProvider, ISingletonDependency, IDependency
{
	private class Token : IVolatileToken
	{
		public bool IsCurrent { get; private set; }

		public Token()
		{
			IsCurrent = true;
		}

		public void Trigger()
		{
			IsCurrent = false;
		}
	}

	private readonly IDictionary<object, Token> _tokens = new Dictionary<object, Token>();

	public void Trigger<T>(T signal)
	{
		lock (_tokens)
		{
			if (_tokens.TryGetValue(signal, out var value))
			{
				_tokens.Remove(signal);
				value.Trigger();
			}
		}
	}

	public IVolatileToken When<T>(T signal)
	{
		lock (_tokens)
		{
			if (!_tokens.TryGetValue(signal, out var value))
			{
				value = new Token();
				_tokens[signal] = value;
			}
			return value;
		}
	}
}
