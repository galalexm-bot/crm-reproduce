using EleWise.ELMA.Ioc.Abstract;

namespace EleWise.ELMA.Ioc;

internal class Lazy<T> : ILazy<T> where T : class
{
	private readonly IScopeContext container;

	private T resolved;

	public Lazy(IScopeContext container)
	{
		this.container = container;
	}

	public T Value()
	{
		return resolved ?? (resolved = container.Resolve<T>());
	}
}
