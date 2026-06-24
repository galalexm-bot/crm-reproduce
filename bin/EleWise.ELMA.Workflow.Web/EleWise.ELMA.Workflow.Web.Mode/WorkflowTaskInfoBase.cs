using System;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;

namespace EleWise.ELMA.Workflow.Web.Models;

public class WorkflowTaskInfoBase
{
	public long Id { get; set; }

	public Guid TypeUid { get; set; }

	public Guid SelectedConnectorUid { get; set; }

	public FlowConnectorElement SelectedConnector { get; set; }

	public Entity<long> Entity { get; set; }

	public int SelectedTab { get; set; }

	public IWorkLog WorkLog { get; set; }

	public WorkflowTaskInfoBase()
	{
		WorkLog = InterfaceActivator.Create<IWorkLog>();
		WorkLog.WorkMinutes = 0L;
		WorkLog.Status = WorkLogStatus.New;
	}
}
