using System;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services.Scope;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Results;
using EleWise.ELMA.UI.Services;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Web.Mvc.Models.UI;

public class UIPortletRenderer
{
	private PortletDescriptor _portletDescriptor;

	private BaseController _controller;

	private UIPortletPersonalization _settings;

	private Guid _portletId;

	private Guid _instanceId;

	private PersonalizationScope _portletManagerScope;

	private string _portletManagerPath;

	private string _path;

	private readonly IExecutionScopeFactory executionScopeFactory;

	private static readonly string Method_Content_Load = "Content_Load";

	private static readonly ILogger ScriptLog = Logger.GetLogger("ScriptLog");

	public UIPortletRenderer(PortletDescriptor portletDescriptor, UIPortletPersonalization settings, BaseController controller, PersonalizationScope portletManagerScope, string portletManagerPath, Guid portletId, Guid instanceId, string path, IExecutionScopeFactory executionScopeFactory)
	{
		Contract.ArgumentNotNull(portletDescriptor, "portletDescriptor");
		Contract.ArgumentNotNull(controller, "controller");
		Contract.ArgumentNotNull(settings, "settings");
		_portletDescriptor = portletDescriptor;
		_controller = controller;
		_settings = settings;
		_portletManagerScope = portletManagerScope;
		_portletManagerPath = portletManagerPath;
		_portletId = portletId;
		_instanceId = instanceId;
		_path = path;
		this.executionScopeFactory = executionScopeFactory;
	}

	public FormResult GetContentLoadResult()
	{
		Type type = typeof(PortletContentLoadViewModel<, >).MakeGenericType(_portletDescriptor.Content.ContextType, _portletDescriptor.PersonalizationType);
		IPortletContentLoadViewModel viewModel = (IPortletContentLoadViewModel)Activator.CreateInstance(type, _portletDescriptor.Content, _settings);
		object controllerInstance = null;
		if (_portletDescriptor.ControllerType != null)
		{
			using IExecutionScope executionScope = executionScopeFactory.CreateScope().AddRegistration(_portletDescriptor.ControllerType).StartScope();
			controllerInstance = executionScope.Resolve(_portletDescriptor.ControllerType);
		}
		DynamicFormSettings dynamicFormSettings = new DynamicFormSettings
		{
			DynamicFormsProviderUid = PortletDynamicFormProvider.UID,
			DynamicFormsProviderData = PortletDynamicFormProvider.CreateData(_portletDescriptor, _portletDescriptor.Content.Metadata, (int)_portletManagerScope, _portletManagerPath, _portletId, _instanceId, _path),
			ViewProviderUid = PortletViewItemProvider.UID,
			ViewItemId = PortletViewItemProvider.CreateViewItemId(_portletDescriptor, _portletDescriptor.Content.Metadata, (int)_portletManagerScope, _portletManagerPath, _portletId, _instanceId, _path)
		};
		if (controllerInstance != null)
		{
			MethodInfo indexMethod = controllerInstance.GetType().GetMethod(Method_Content_Load);
			if (indexMethod != null && indexMethod.GetParameters().Length == 1 && indexMethod.GetParameters()[0].ParameterType == type)
			{
				IDynamicFormsProvider provider = ComponentManager.Current.GetExtensionPoints<IDynamicFormsProvider>().FirstOrDefault((IDynamicFormsProvider p) => p.Uid == dynamicFormSettings.DynamicFormsProviderUid);
				DynamicFormResult dynamicFormResult = DynamicFormHelper.ExecuteScript(viewModel.Context, dynamicFormSettings, viewModel.View, null, delegate(RootViewItem v, DynamicFormResultData resultData)
				{
					try
					{
						viewModel.View = (FormViewItem)v;
						indexMethod.Invoke(controllerInstance, new object[1] { viewModel });
						string onLoadScriptName = viewModel.View.OnLoadScriptName;
						if (!string.IsNullOrEmpty(onLoadScriptName) && provider != null)
						{
							provider.ExecuteScript(viewModel.Context, v, dynamicFormSettings, onLoadScriptName, resultData);
						}
					}
					catch (Exception ex)
					{
						Exception ex2 = ex.InnerException ?? ex;
						string text = SR.T("Ошибка исполнения сценария в портлете \"{0}\": {1}", _portletDescriptor.Metadata.Name, ex2);
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
			formResult = new PortletContentLoadResult(viewModel);
		}
		if (formResult is PortletContentLoadResult result)
		{
			return new PortletContentLoadResultWrapper(result, dynamicFormSettings);
		}
		return formResult;
	}
}
