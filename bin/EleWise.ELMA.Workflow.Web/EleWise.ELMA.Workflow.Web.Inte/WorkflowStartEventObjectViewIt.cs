using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Integration;

[Component]
public class WorkflowStartEventObjectViewItemProvider : IObjectViewItemProvider
{
	public static readonly Guid UID = new Guid("{3466FE5F-25C8-4cea-9571-70F442618FB2}");

	public Guid ProviderUid => UID;

	public ViewItem GetViewItem(string viewItemId)
	{
		long id = long.Parse(viewItemId);
		IWorkflowProcess workflowProcess = WorkflowProcessManager.Instance.LoadOrNull(id);
		if (workflowProcess == null)
		{
			return null;
		}
		if (workflowProcess.Diagram.GetStartElement() is StartEventElement startElement)
		{
			IWorkflowInstance workflowInstance = WorkflowInstanceManager.Instance.Create();
			workflowInstance.Process = workflowProcess;
			return GetViewItem(startElement, workflowInstance);
		}
		return null;
	}

	public static FormView GetViewItem(StartEventElement startElement, IWorkflowInstance instance)
	{
		IWorkflowProcess process = instance.Process;
		FormView formView = ((startElement != null && ((IElementWithFormConstructorView)startElement).FormUid != Guid.Empty) ? process.Forms.CreateFormViewItem(((IElementWithFormConstructorView)startElement).FormUid, process, checkExists: false) : null);
		if (formView == null)
		{
			formView = startElement.View;
		}
		return formView;
	}
}
