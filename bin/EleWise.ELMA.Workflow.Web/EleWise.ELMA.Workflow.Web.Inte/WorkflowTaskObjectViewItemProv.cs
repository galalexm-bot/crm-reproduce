using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.Components;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Integration;

[Component]
public class WorkflowTaskObjectViewItemProvider : IObjectViewItemProvider
{
	public static readonly Guid UID = new Guid("{D01385B2-F867-4E31-9E60-78DB1E69B62B}");

	public Guid ProviderUid => UID;

	public static FormView GetViewItem(IWorkflowTaskBase task)
	{
		return WorkflowTaskFormViewTransformate.GetViewItem(task);
	}

	public static FormView GetViewItem(IWorkflowTaskBase task, Guid formUid)
	{
		return WorkflowTaskFormViewTransformate.GetViewItem(task, formUid);
	}

	public ViewItem GetViewItem(string viewItemId)
	{
		if (string.IsNullOrEmpty(viewItemId))
		{
			return null;
		}
		if (viewItemId.Contains(";"))
		{
			string[] source = viewItemId.Split(';');
			long num = long.Parse(source.First());
			IWorkflowTaskBase workflowTaskBase = EntityManager<IWorkflowTaskBase>.Instance.LoadOrNull(num);
			if (workflowTaskBase == null || workflowTaskBase.WorkflowBookmark == null)
			{
				return null;
			}
			Guid formUid = Guid.Parse(source.Last());
			return WorkflowTaskFormViewTransformate.GetViewItem(workflowTaskBase, formUid);
		}
		long num2 = long.Parse(viewItemId);
		IWorkflowTaskBase workflowTaskBase2 = EntityManager<IWorkflowTaskBase>.Instance.LoadOrNull(num2);
		if (workflowTaskBase2 == null || workflowTaskBase2.WorkflowBookmark == null)
		{
			return null;
		}
		return GetViewItem(workflowTaskBase2);
	}
}
