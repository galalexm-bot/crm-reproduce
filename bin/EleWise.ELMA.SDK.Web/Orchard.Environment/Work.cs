using System;

namespace Orchard.Environment;

public class Work<T> where T : class
{
	private readonly Func<Work<T>, T> _resolve;

	public T Value => _resolve(this);

	public Work(Func<Work<T>, T> resolve)
	{
		_resolve = resolve;
	}
}
