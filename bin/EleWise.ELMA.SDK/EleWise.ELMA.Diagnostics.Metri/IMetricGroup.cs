namespace EleWise.ELMA.Diagnostics.Metrics.Internal;

public interface IMetricGroup
{
	void Merge(IMetricGroup metricGroup);
}
public interface IMetricGroup<T> : IMetricGroup where T : IMetric
{
	T GetOrAdd(string name);
}
