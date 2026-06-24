using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.ProcessMetricExtensions;

[ExtensionPoint(ComponentType.All)]
public interface IProcessMetricSaveValue
{
	void Synchronize(IWorkflowProcess process, ProcessMetric processMetric);

	void Synchronize(ProcessMetric processMetric, DateTime date, IUser executor = null);

	void Synchronize(ProcessMetric processMetric, IProcessMetricValue processMetricValue);

	void PersonalSynchronize(ProcessMetric processMetric, IProcessMetricValue processMetricValue);
}
