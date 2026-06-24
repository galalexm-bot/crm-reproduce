using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Integration;

[Component]
public class WorkflowInstanceObjectViewItemProvider : IObjectViewItemProvider
{
	public static readonly Guid UID = new Guid("{413238DF-823E-49F3-BA5B-7A6493FB3C50}");

	public Guid ProviderUid => UID;

	public ViewItem GetViewItem(string viewItemId)
	{
		if (string.IsNullOrEmpty(viewItemId))
		{
			return null;
		}
		string[] array = viewItemId.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
		long num = long.Parse(array[0]);
		ViewType viewType = (ViewType)Enum.Parse(typeof(ViewType), array[1]);
		IWorkflowInstance workflowInstance = EntityManager<IWorkflowInstance>.Instance.LoadOrNull(num);
		if (workflowInstance == null)
		{
			return null;
		}
		return Locator.GetServiceNotNull<WorkflowInstanceManager>().GetContextView(workflowInstance, viewType);
	}
}
