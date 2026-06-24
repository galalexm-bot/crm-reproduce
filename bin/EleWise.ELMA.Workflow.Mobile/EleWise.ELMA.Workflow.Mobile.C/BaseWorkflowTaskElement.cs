using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.Mobile.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Mobile.Components;

[Component(Order = int.MaxValue)]
internal sealed class BaseWorkflowTaskElement : IWorkflowTaskElement
{
	public bool CanUse(Element element)
	{
		return true;
	}

	public bool HasCustomView(Element element, IWorkflowInstance instance)
	{
		return true;
	}
}
