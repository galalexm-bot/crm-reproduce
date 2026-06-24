using System;
using System.Reflection;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services.Scope;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Results;
using EleWise.ELMA.UI.Services;
using EleWise.ELMA.Web.Mvc.Controllers;

namespace EleWise.ELMA.Web.Mvc.Models.UI;

public class UIPageRenderer
{
	private PageDescriptor _pageDescriptor;

	private BaseController _controller;

	private readonly IExecutionScopeFactory executionScopeFactory;

	private static readonly string Method_Index_Load = "Index_Load";

	private static readonly ILogger ScriptLog = Logger.GetLogger("ScriptLog");

	public UIPageRenderer(PageDescriptor pageDescriptor, BaseController controller, IExecutionScopeFactory executionScopeFactory)
	{
		Contract.ArgumentNotNull(pageDescriptor, "pageDescriptor");
		Contract.ArgumentNotNull(controller, "controller");
		_pageDescriptor = pageDescriptor;
		_controller = controller;
		this.executionScopeFactory = executionScopeFactory;
	}

	public FormResult GetPageLoadResult()
	{
		return GetPageLoadResult(null, null, null);
	}

	public FormResult GetPageLoadResult(IEntity entity, PropertyMap map, string parentFormId)
	{
		return GetPageLoadResult(entity, map, parentFormId, null);
	}

	public FormResult GetPageLoadResult(IEntity entity, PropertyMap map, string parentFormId, string formId)
	{
		Type type = typeof(PageLoadViewModel<>).MakeGenericType(_pageDescriptor.Content.ContextType);
		IPageLoadViewModel viewModel = (IPageLoadViewModel)Activator.CreateInstance(type, _pageDescriptor.Content);
		object controllerInstance = null;
		if (_pageDescriptor.ControllerType != null)
		{
			using IExecutionScope executionScope = executionScopeFactory.CreateScope().AddRegistration(_pageDescriptor.ControllerType).StartScope();
			controllerInstance = executionScope.Resolve(_pageDescriptor.ControllerType);
		}
		DynamicFormSettings dynamicFormSettings = new DynamicFormSettings
		{
			DynamicFormsProviderUid = PageDynamicFormProvider.UID,
			DynamicFormsProviderData = PageDynamicFormProvider.CreateData(_pageDescriptor, _pageDescriptor.Content.Metadata),
			ViewProviderUid = PageViewItemProvider.UID,
			ViewItemId = UIViewItemProvider.CreateViewItemId(_pageDescriptor, _pageDescriptor.Content.Metadata)
		};
		if (!string.IsNullOrEmpty(parentFormId))
		{
			dynamicFormSettings.ParentFormId = parentFormId;
		}
		if (!string.IsNullOrEmpty(formId))
		{
			dynamicFormSettings.FormId = formId;
		}
		if (entity != null && map != null)
		{
			PropertyMapHelper.Map(entity, viewModel.Context, map.Reverse());
		}
		if (controllerInstance != null)
		{
			MethodInfo indexMethod = controllerInstance.GetType().GetMethod(Method_Index_Load);
			if (indexMethod != null && indexMethod.GetParameters().Length == 1 && indexMethod.GetParameters()[0].ParameterType == type)
			{
				DynamicFormResult dynamicFormResult = DynamicFormHelper.ExecuteScript(viewModel.Context, dynamicFormSettings, viewModel.View, null, delegate(RootViewItem v, DynamicFormResultData resultData)
				{
					try
					{
						viewModel.View = (FormViewItem)v;
						indexMethod.Invoke(controllerInstance, new object[1] { viewModel });
					}
					catch (Exception ex)
					{
						Exception ex2 = ex.InnerException ?? ex;
						string text = SR.T("Ошибка исполнения сценария на странице \"{0}\": {1}", _pageDescriptor.Metadata.Name, ex2);
						ScriptLog.Error(text, ex);
						throw new ScriptExecuteException(text + ex2.Message, ex2);
					}
				});
				dynamicFormSettings.ModelJsonState = dynamicFormResult.ModelJsonState;
				dynamicFormSettings.ViewTransformation = dynamicFormResult.ViewTransformation;
				if (dynamicFormResult.ChangedView != null)
				{
					viewModel.View = (FormViewItem)dynamicFormResult.ChangedView;
				}
			}
		}
		FormResult formResult = viewModel.Result;
		if (formResult == null)
		{
			formResult = new PageLoadResult(viewModel);
		}
		if (formResult is PageLoadResult result)
		{
			return new PageLoadResultWrapper(result, dynamicFormSettings);
		}
		return formResult;
	}
}
