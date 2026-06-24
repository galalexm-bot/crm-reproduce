using System;

namespace EleWise.ELMA.Diagnostics.Metrics;

public interface IMetric
{
	Guid Uid { get; }

	void Merge(IMetric metric);
}
