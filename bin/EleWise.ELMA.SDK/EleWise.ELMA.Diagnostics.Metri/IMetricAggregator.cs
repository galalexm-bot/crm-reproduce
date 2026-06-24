using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Diagnostics.Metrics;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(ServiceScope.Application, ComponentType.Server)]
public interface IMetricAggregator
{
	void Add(object callInfo, MetricsContainer container);
}
