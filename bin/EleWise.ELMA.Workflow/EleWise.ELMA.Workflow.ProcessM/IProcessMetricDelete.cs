using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.ProcessMetricExtensions;

[ExtensionPoint(ComponentType.All)]
public interface IProcessMetricDelete
{
	void AfterDeleteItem(ProcessMetric processMetric);
}
