using System.Collections.Generic;
using System.Diagnostics;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Diagnostics.Counters;

[ExtensionPoint(ComponentType.Server)]
public interface IPerformanceCounter
{
	string Name { get; }

	string Description { get; }

	IEnumerable<CounterCreationData> GetCreationData();

	void Init(string category);
}
