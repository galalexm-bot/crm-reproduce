using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Models;

public class StartEmulationProcess
{
	public long EmulationonreminderTimeType { get; set; }

	public Guid Uid { get; set; }

	public IWorkflowInstance Instance { get; set; }

	public bool Permission { get; set; }

	public bool openMonitor { get; set; }

	public WorkflowInstanceContext Context { get; set; }

	public Guid TypeUid { get; set; }

	public Guid elementId { get; set; }

	public string ConsoleMessages { get; set; }

	public Exception ExecutingException { get; set; }

	public IProcessHeader ProcessHeader { get; set; }

	public long SubProcessHeaderId { get; set; }

	public string StartActivityName { get; set; }

	public long TemplateId { get; set; }

	public string TemplateName { get; set; }

	public bool Bloks { get; set; }

	public StartEmulationProcess()
	{
		Uid = Guid.NewGuid();
	}

	public StartEmulationProcess(long id)
	{
		IWorkflowInstance workflowInstance = WorkflowInstanceManager.Instance.LoadOrNull(id);
		WorkflowInstanceContext context = workflowInstance.Context;
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(context.GetType());
		Uid = Guid.NewGuid();
		Instance = workflowInstance;
		Context = context;
		ProcessHeader = workflowInstance.Process.Header;
		TypeUid = classMetadata.Uid;
	}

	public StartEmulationProcess(IWorkflowInstance instance)
	{
		WorkflowInstanceContext context = instance.Context;
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(context.GetType());
		Uid = Guid.NewGuid();
		Instance = instance;
		Context = context;
		ProcessHeader = instance.Process.Header;
		TypeUid = classMetadata.Uid;
	}

	public FormView GetContextView(ViewType viewType)
	{
		return Locator.GetServiceNotNull<WorkflowInstanceManager>().GetContextViewNoBlok(Instance, viewType, block: true);
	}

	public FormView GetContextViewNoBlock(ViewType viewType)
	{
		return Locator.GetServiceNotNull<WorkflowInstanceManager>().GetContextViewNoBlok(Instance, viewType);
	}
}
