using System;
using EleWise.ELMA.Workflow.BPMN.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Managers;

public interface IWorkflowProcessManager<TProcess> : IWorkflowProcessManager where TProcess : class, IWorkflowProcess
{
	new TProcess Load(long id);

	new TProcess LoadOrNull(long id);

	void Save(TProcess process);

	void Publish(TProcess process, long versionNumber, IWorkflowProcess parentProcess, string comment, bool isEmulation);
}
public interface IWorkflowProcessManager
{
	IWorkflowProcess Load(long id);

	IWorkflowProcess LoadOrNull(long id);

	void Save(IWorkflowProcess process);

	void Publish(IWorkflowProcess process, long versionNumber, IWorkflowProcess parentProcess, string comment, bool isEmulation);

	void Publish(IWorkflowProcess process, long versionNumber, IWorkflowProcess parentProcess, string comment, bool isEmulation, WorkflowProcessPublishingData data);

	ChangeProcessVersionValidationResult ValidateChangeVersion(IWorkflowProcess oldProcess, IWorkflowProcess newProcess, Guid[] activeElementUids);
}
