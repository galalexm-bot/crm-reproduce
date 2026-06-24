using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;

namespace EleWise.ELMA.Diagnostics.Reports.Performance;

[ExtensionPoint(ComponentType.Server)]
public interface ICommonInformationPart
{
	string Title { get; }

	IEnumerable<CommonInformationPartItem> GetItems(MetricsContainer metrics);
}
