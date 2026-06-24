using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Diagnostics.Metrics;

[ExtensionPoint(ComponentType.Server)]
public interface IMetricProcessor
{
	Type[] AggregatorTypes { get; }

	void Process(object callInfo, IMetric currentMetric);
}
