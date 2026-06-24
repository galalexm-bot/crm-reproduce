using System.Collections.Generic;
using EleWise.ELMA.Core.Diagnostics;
using EleWise.ELMA.DynamicProxy;

namespace EleWise.ELMA.Core.Composite;

public abstract class AbstractApplication : IApplication
{
	private readonly List<IMiddleware> handlers = new List<IMiddleware>();

	public virtual System.Collections.Generic.IEnumerable<IMiddleware> Handlers => (System.Collections.Generic.IEnumerable<IMiddleware>)handlers;

	public virtual void Use(IMiddleware middleware)
	{
		Contract.ArgumentNotNull(middleware, "middleware");
		handlers.Add(middleware);
	}

	public abstract void Run();
}
