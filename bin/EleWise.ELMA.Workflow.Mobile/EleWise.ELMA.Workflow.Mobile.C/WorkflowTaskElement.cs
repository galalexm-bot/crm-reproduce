using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Mobile.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Mobile.Components;

[Component(Order = 50)]
internal sealed class WorkflowTaskElement : IWorkflowTaskElement
{
	private readonly MetadataItemHeaderManager metadataItemHeaderManager;

	private readonly WorkflowInstanceContextService workflowInstanceContextService;

	public WorkflowTaskElement(MetadataItemHeaderManager metadataItemHeaderManager, WorkflowInstanceContextService workflowInstanceContextService)
	{
		this.metadataItemHeaderManager = metadataItemHeaderManager;
		this.workflowInstanceContextService = workflowInstanceContextService;
	}

	public bool CanUse(Element element)
	{
		return element is UserTaskElement;
	}

	public bool HasCustomView(Element element, IWorkflowInstance instance)
	{
		UserTaskElement userTaskElement = (UserTaskElement)element;
		bool flag = (from m in metadataItemHeaderManager.Load(new List<Guid> { InterfaceActivator.UID<IWorkflowTaskBase>() })
			where m.Published != null
			select m).Any((IMetadataItemHeader m) => m.Published.Metadata is EntityMetadata entityMetadata && (entityMetadata.FormsScheme == ClassFormsScheme.FormConstructor || entityMetadata.GetAllTableParts().Any()));
		if (flag || !userTaskElement.FormUid.Equals(Guid.Empty))
		{
			return true;
		}
		UserTaskFormSettings formSettings = userTaskElement.FormSettings;
		if (formSettings != null)
		{
			flag = formSettings.UseCustomView || !string.IsNullOrEmpty(formSettings.CustomViewName);
		}
		if (flag)
		{
			return true;
		}
		foreach (PropertyViewItem item in userTaskElement.View.GetAllItems().OfType<PropertyViewItem>().ToList())
		{
			flag = item.IsCustom || !string.IsNullOrEmpty(item.CustomViewName);
			if (flag)
			{
				break;
			}
		}
		if (!flag)
		{
			return HasScriptsOnView(element, instance);
		}
		return true;
	}

	private bool HasScriptsOnView(Element element, IWorkflowInstance instance)
	{
		bool result = false;
		IElementWithFormConstructorView elementWithFormConstructorView = element as IElementWithFormConstructorView;
		IElementWithView elementWithView = element as IElementWithView;
		FormView formView = null;
		if (elementWithFormConstructorView != null)
		{
			formView = ((elementWithFormConstructorView.FormUid != Guid.Empty) ? instance.Process.Forms.CreateFormViewItem(elementWithFormConstructorView.FormUid, instance.Process, checkExists: false) : elementWithFormConstructorView.View);
		}
		else if (elementWithView != null)
		{
			formView = elementWithView.View;
		}
		if (formView != null)
		{
			result = HasScriptsOnView(instance, formView);
		}
		return result;
	}

	private bool HasScriptsOnView(IWorkflowInstance instance, FormView view)
	{
		bool flag = !string.IsNullOrEmpty(view.OnLoadScriptName);
		if (!flag)
		{
			foreach (PropertyMetadata property in workflowInstanceContextService.GetInstanceContextMetadata(instance.Process).Properties)
			{
				PropertyViewItem propertyViewItem = view.FindItem((PropertyViewItem p) => p.PropertyUid == property.Uid);
				if (propertyViewItem != null && (!string.IsNullOrEmpty(propertyViewItem.Attributes.OnChangeScriptName) || !string.IsNullOrEmpty(propertyViewItem.Attributes.OnViewLoadScriptName) || !string.IsNullOrEmpty(property.OnChangeScriptName)))
				{
					return true;
				}
			}
			return flag;
		}
		return flag;
	}
}
