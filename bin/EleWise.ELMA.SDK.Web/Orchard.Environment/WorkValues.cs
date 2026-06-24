using System.Collections.Generic;
using Autofac;

namespace Orchard.Environment;

internal class WorkValues<T> where T : class
{
	public IComponentContext ComponentContext { get; private set; }

	public IDictionary<Work<T>, T> Values { get; private set; }

	public WorkValues(IComponentContext componentContext)
	{
		ComponentContext = componentContext;
		Values = new Dictionary<Work<T>, T>();
	}
}
