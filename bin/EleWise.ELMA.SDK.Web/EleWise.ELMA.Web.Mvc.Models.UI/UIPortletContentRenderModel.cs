using System;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.Web.Mvc.Models.UI;

public class UIPortletContentRenderModel
{
	public PortletContentDescriptor Descriptor { get; private set; }

	public IPortletContentLoadViewModel ViewModel { get; private set; }

	public DynamicFormSettings DynamicFormSettings { get; set; }

	public string DynamicFormId { get; set; }

	public Guid ContextGuid { get; set; }

	public UIPortletContentRenderModel(PortletContentLoadResultWrapper result)
	{
		Contract.ArgumentNotNull(result, "result");
		ViewModel = result.Result.ViewModel;
		Descriptor = result.Result.ViewModel.PortletContentDescriptor;
		DynamicFormSettings = result.DynamicFormSettings;
		ContextGuid = InterfaceActivator.UID(ViewModel.Context.GetType());
		DynamicFormId = $"PortletDynamicForm_{ContextGuid:N}";
		DynamicFormSettings.FormId = DynamicFormId + "-form";
	}
}
