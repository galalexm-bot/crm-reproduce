using System.Collections.Generic;

namespace EleWise.ELMA.Diagnostics.Metrics;

public interface IExpandableMetric : IMetric
{
	IEnumerable<IMetric> AdditionalParameters { get; }

	void AddAdditionalParameters(IMetric metric);
}
