using System.Collections.Generic;
using EleWise.ELMA.DynamicProxy;

namespace EleWise.ELMA.Core.Composite;

public interface IApplication
{
	System.Collections.Generic.IEnumerable<IMiddleware> Handlers { get; }

	void Use(IMiddleware middleware);

	void Run();
}
