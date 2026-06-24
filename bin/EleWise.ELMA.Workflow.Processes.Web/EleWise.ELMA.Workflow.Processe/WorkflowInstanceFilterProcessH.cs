using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component]
public class WorkflowInstanceFilterProcessHeaderPropertyExtension : IFilterPropertiesExtension
{
	public bool Resolve(PropertyMetadata prop, ClassMetadata metadata)
	{
		return prop.Uid == InterfaceActivator.PropertyUid((IWorkflowInstanceFilter f) => f.ContextFilter);
	}

	public IEnumerable<FilterMetadataProperty> GetFilterMetadataProperties(IEntityFilter obj, PropertyMetadata prop, ClassMetadata metadata, string prefix, Guid? filterObjectTypeUid, Guid? filterCode, out bool addProperty)
	{
		addProperty = true;
		if (obj is IWorkflowInstanceFilter workflowInstanceFilter)
		{
			if (workflowInstanceFilter.ProcessHeader != null && workflowInstanceFilter.ProcessHeader.Published != null)
			{
				Type instanceContextFilterType = Locator.GetServiceNotNull<WorkflowInstanceContextService>().GetInstanceContextFilterType(workflowInstanceFilter.ProcessHeader.Published);
				if (instanceContextFilterType != null)
				{
					if (!instanceContextFilterType.IsInstanceOfType(workflowInstanceFilter.ContextFilter))
					{
						workflowInstanceFilter.ContextFilter = (Filter)Activator.CreateInstance(instanceContextFilterType);
					}
					return null;
				}
			}
			if (workflowInstanceFilter.ContextFilter == null || workflowInstanceFilter.ContextFilter.GetType() != typeof(Filter))
			{
				workflowInstanceFilter.ContextFilter = new Filter();
			}
		}
		return null;
	}

	public void UpdateProperties(Type type, Guid? filterObjectTypeUid, Guid? filterCode, List<FilterMetadataProperty> properties)
	{
	}
}
[Component(Order = 200)]
public class WorkflowInstanceFilterProcessHeaderPropertyEditorExtension : IFilterPropertyEditorExtension
{
	public virtual bool Resolve(FilterMetadataProperty property, FilterModel filterModel)
	{
		return property.PropertyUid == InterfaceActivator.PropertyUid((IWorkflowInstanceFilter f) => f.ProcessHeader);
	}

	public virtual MvcHtmlString PropertyEditor(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel)
	{
		return null;
	}

	public virtual void PropertyAction(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel, WebViewAttributes a)
	{
		object obj = (((ViewDataDictionary)html.get_ViewData()).ContainsKey("filterGridId") ? ((ViewDataDictionary)html.get_ViewData()).get_Item("filterGridId") : string.Empty);
		string text = ((obj != null) ? obj.ToString().Replace("-", "m") : "");
		a.Html.onchange = "function(e){FilterFieldsRefresh" + text + "(e.value, this);}";
		a.Html["localize"] = true;
	}
}
