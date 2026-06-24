using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Views.ViewItem;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.Constants;
using EleWise.ELMA.Workflow.Helpers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Web.Components;
using EleWise.ELMA.Workflow.Web.Models;

namespace EleWise.ELMA.Workflow.Web.Extensions;

public static class HtmlExtensions
{
	private static bool? canRenderWorkflowInstanceLink;

	public static MvcHtmlString StartRouteToolbarButton(this HtmlHelper html, StartRouteButtonInfo model)
	{
		return html.StartRouteButton(model, "WorkflowInstance/StartRouteWindowButton");
	}

	public static MvcHtmlString StartRouteToolbarPopup(this HtmlHelper html, StartRouteButtonInfo model)
	{
		return html.StartRouteButton(model, "WorkflowInstance/StartRouteWindowPopup");
	}

	public static MvcHtmlString StartRouteCatalogViewPopup(this HtmlHelper html, StartRouteButtonInfo model)
	{
		return html.StartRouteButton(model, "WorkflowInstance/StartRouteCatalogViewPopup");
	}

	public static MvcHtmlString StartRouteButton(this HtmlHelper html, StartRouteButtonInfo model)
	{
		return html.StartRouteButton(model, "WorkflowInstance/StartRouteWindow");
	}

	private static MvcHtmlString StartRouteButton(this HtmlHelper html, StartRouteButtonInfo model, string partial)
	{
		if (IsWorkflowEnabled())
		{
			return PartialExtensions.Partial(html, partial, (object)model);
		}
		return MvcHtmlString.Empty;
	}

	public static void RenderStartRouteButton(this HtmlHelper html, StartRouteButtonInfo model)
	{
		if (IsWorkflowEnabled())
		{
			RenderPartialExtensions.RenderPartial(html, "WorkflowInstance/StartRouteWindow", (object)model);
		}
	}

	private static bool IsWorkflowEnabled()
	{
		IModule module = (ComponentManager.Initialized ? (ComponentManager.Current.ModuleManager.FindUnitByUid(__ModuleInfo.UID) as IModule) : null);
		if (module != null)
		{
			return module.Status == ModuleStatus.Enabled;
		}
		return false;
	}

	public static void RouteSelector(this HtmlHelper html, IStartRouteInfo model)
	{
		if (IsWorkflowEnabled())
		{
			RenderPartialExtensions.RenderPartial(html, "WorkflowInstance/RouteSelector", (object)model);
		}
	}

	public static MvcHtmlString WorkflowInstanceLink(this HtmlHelper html, IWorkflowInstance instance)
	{
		if (!canRenderWorkflowInstanceLink.HasValue)
		{
			canRenderWorkflowInstanceLink = ComponentManager.Current.GetExtensionPoints<IEntityLink>().Any((IEntityLink l) => l.EntityType == typeof(IWorkflowInstance));
		}
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		if (canRenderWorkflowInstanceLink.Value && serviceNotNull.HasPermission(CommonPermissions.View, instance))
		{
			return html.DisplayValue(instance);
		}
		return MvcHtmlString.Create(html.Encode(instance.InstanceName()));
	}

	public static MvcHtmlString ProcessHeaderEditor<TModel, TProcessHeader>(this HtmlHelper<TModel> html, Expression<Func<TModel, IEnumerable<TProcessHeader>>> expression, Guid objectType, RelationType? relationType = null, Action<WebViewAttributes> viewAttributesAction = null, Guid? objectSubType = null) where TProcessHeader : IProcessHeader
	{
		return ((HtmlHelper)(object)html).ProcessHeaderEditor(LinqUtils.FullNameOf(expression), objectType, relationType, viewAttributesAction, objectSubType);
	}

	public static MvcHtmlString ProcessHeaderEditor<TModel>(this HtmlHelper<TModel> html, Expression<Func<TModel, IProcessHeader>> expression, Guid objectType, RelationType? relationType = null, Action<WebViewAttributes> viewAttributesAction = null, Guid? objectSubType = null)
	{
		return ((HtmlHelper)(object)html).ProcessHeaderEditor(LinqUtils.FullNameOf(expression), objectType, relationType, viewAttributesAction, objectSubType);
	}

	public static MvcHtmlString ProcessHeaderEditor(this HtmlHelper html, string expression, Guid objectType, RelationType? relationType = null, Action<WebViewAttributes> viewAttributesAction = null, Guid? objectSubType = null)
	{
		html.get_ViewData().set_Item("ObjectType", (object)objectType);
		if (relationType.HasValue)
		{
			html.get_ViewData().set_Item("RelationType", (object)relationType);
		}
		if (objectSubType.HasValue)
		{
			html.get_ViewData().set_Item("ObjectSubType", (object)objectSubType);
		}
		return html.Editor(expression, delegate(WebViewAttributes a)
		{
			a.TemplateName = "ProcessHeaderEditor";
			if (viewAttributesAction != null)
			{
				viewAttributesAction(a);
			}
		});
	}

	public static MvcHtmlString ProcessContexVarEditor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, Guid objectType, Expression<Func<TModel, IProcessHeader>> processHeaderExpression, string contextVarContainer = null, bool countConditionContextVar = true, RelationType? relationType = null, Action<WebViewAttributes> viewAttributesAction = null)
	{
		return ((HtmlHelper)(object)html).ProcessContexVarEditor(LinqUtils.FullNameOf(expression), objectType, LinqUtils.FullNameOf(processHeaderExpression), contextVarContainer, countConditionContextVar, relationType, viewAttributesAction);
	}

	public static MvcHtmlString ProcessContexVarEditor(this HtmlHelper html, string expression, Guid objectType, string processHeaderExpression, string contextVarContainer = null, bool countConditionContextVar = true, RelationType? relationType = null, Action<WebViewAttributes> viewAttributesAction = null)
	{
		html.get_ViewData().set_Item("ObjectType", (object)objectType);
		html.get_ViewData().set_Item("ProcessHeaderId", (object)html.get_ViewContext().get_ViewData().get_TemplateInfo()
			.GetFullHtmlFieldId(processHeaderExpression));
		ModelMetadata val = ModelMetadata.FromStringExpression(processHeaderExpression, html.get_ViewData());
		html.get_ViewData().set_Item("ProcessHeader", val.get_Model());
		html.get_ViewData().set_Item("ContextVarContainer", (object)contextVarContainer);
		html.get_ViewData().set_Item("CountConditionContextVar", (object)countConditionContextVar);
		if (relationType.HasValue)
		{
			html.get_ViewData().set_Item("RelationType", (object)relationType);
		}
		return html.Editor(expression, delegate(WebViewAttributes a)
		{
			a.TemplateName = "ProcessContexVarEditor";
			if (viewAttributesAction != null)
			{
				viewAttributesAction(a);
			}
		});
	}

	public static MvcHtmlString FormViewItem<TModel>(this HtmlHelper<TModel> html, FormView formViewItem, Expression<Func<TModel, object>> modelExpression, Expression<Func<TModel, object>> entityExpression, ActionRoute actionRoute = null, ViewType viewType = ViewType.Custom, string formId = null)
	{
		object model = ContextPropertyViewItemRenderer.Model;
		string htmlFieldPrefix = ContextPropertyViewItemRenderer.HtmlFieldPrefix;
		object entityModel = (ContextPropertyViewItemRenderer.Model = entityExpression?.Compile()(html.get_ViewData().get_Model()));
		ContextPropertyViewItemRenderer.HtmlFieldPrefix = ((entityExpression != null) ? ((ViewDataDictionary)html.get_ViewData()).get_TemplateInfo().GetFullHtmlFieldName(LinqUtils.FullNameOf(entityExpression)) : null);
		try
		{
			object obj2 = modelExpression?.Compile()(html.get_ViewData().get_Model());
			if (obj2 != null && formViewItem is FormViewItem formViewItem2 && FormRenderHelper.CanRenderRuntimeVersion2(formViewItem2))
			{
				MvcHtmlString val = RenderRuntimeVersion2((HtmlHelper)(object)html, obj2, entityModel, formViewItem2);
				if (val != null)
				{
					return val;
				}
			}
			return ((HtmlHelper)(object)html).FormViewItem(formViewItem, obj2, (modelExpression != null) ? LinqUtils.FullNameOf(modelExpression) : null, actionRoute, viewType, ItemType.Default, null, null, null, null, formId);
		}
		finally
		{
			ContextPropertyViewItemRenderer.Model = model;
			ContextPropertyViewItemRenderer.HtmlFieldPrefix = htmlFieldPrefix;
		}
	}

	public static ConnectorActionsModel GenerateConnectorClickCode(this HtmlHelper helper, WorkflowTaskInfo info, FlowConnectorElement connector, string dynamicFormId = "", string executeUserFunc = "", string prefix = "", bool doSubmit = true, string subTasksMsg = "")
	{
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(dynamicFormId))
		{
			dynamicFormId = $"ContextDynamicForm_{info.TypeUid:N}";
		}
		ConnectorSettingsExtension connectorSettingsExtension = null;
		if (info.Element is IConnectorSettingsExtensionElement connectorSettingsExtensionElement && connectorSettingsExtensionElement.ConnectorSettings.Any())
		{
			connectorSettingsExtension = connectorSettingsExtensionElement.ConnectorSettings.FirstOrDefault((ConnectorSettingsExtension q) => q.ConnectorUid == connector.Uid && q.StartElement == connector.StartElement.Uid && q.EndElement == connector.EndElement.Uid);
		}
		string text = $"$('#{dynamicFormId}')";
		string text2 = (doSubmit ? connector.OutputCancel.ToString().ToLower() : "false");
		string displayConnectorName = info.GetDisplayConnectorName(connector);
		string text3;
		if (!string.IsNullOrEmpty(executeUserFunc))
		{
			text3 = string.Format("{0}('{1}',{2},{3},'{4}');", executeUserFunc, connector.Uid, connector.OutputCancel.ToString().ToLower(), connector.ValidateContextVariables.ToString().ToLower(), displayConnectorName.Replace("\r", "\\r").Replace("\n", "\\n"));
		}
		else
		{
			string arg = $"$({text}).closest('form')";
			text3 = $"checkAndSubmit({arg}, {text2});";
		}
		string text4 = string.Format("$('#{0}SelectedConnectorUid').val('{1}');", (!string.IsNullOrEmpty(prefix)) ? $"{prefix}_" : "", connector.Uid);
		string text5 = "con" + connector.Uid.ToString("n");
		text4 = ((connectorSettingsExtension == null || string.IsNullOrEmpty(connectorSettingsExtension.ScriptName)) ? (text4 + text3) : ((!(info.View is FormViewItem formViewItem) || formViewItem.RuntimeVersion != RuntimeVersion.Version2) ? (text4 + string.Format("elma.dynamicForms.onClick($('#{0}'), null, '{1}', {2}, '{3}', {4}, {5});", text5, connectorSettingsExtension.ScriptName, text, "SDK.Action/DynamicForms/ProcessConnectorClick/", text2, $"function () {{ {text3} }}")) : (text4 + $"elma.dynamicForms.executeScript($('#{text5}'), '{connectorSettingsExtension.ScriptName}', {text}, {text2}, {$"function () {{ {text3} }}"});")));
		text4 = $"var clickCode = function () {{ {text4} }}; elma.SubTaskActions.CheckActiveSubTasks({info.TaskId}, clickCode, [], '{((!string.IsNullOrEmpty(subTasksMsg)) ? subTasksMsg : null)}');";
		MvcHtmlString formPopup = MvcHtmlString.Empty;
		if (connectorSettingsExtension != null && connectorSettingsExtension.FormUid.HasValue)
		{
			string text6 = $"T{Guid.NewGuid()}";
			FormBindingModel obj = new FormBindingModel
			{
				FormUid = connectorSettingsExtension.FormUid,
				PopupHeader = displayConnectorName,
				RenderMode = RenderFormMode.Edit
			};
			string arg2 = new UrlHelper(((ControllerContext)helper.get_ViewContext()).get_RequestContext()).Action("OpenForm", "DynamicForms", (object)new
			{
				area = "EleWise.ELMA.SDK.Web",
				newPopupId = text6,
				buttonUid = Guid.Empty,
				actionSettings = ClassSerializationHelper.SerializeObjectByXml(obj).RemoveLineBreaks(),
				callback = text4
			});
			formPopup = helper.PopupWindow(text6, displayConnectorName);
			string arg3 = $"elma.dynamicForms.getPostData($('#{text5}'), {text})";
			string arg4 = $"refreshPopupWithWidth(900, '{text6}', \"{arg2}\", postData, '', '');";
			text4 = $"var postData = {arg3};{arg4}";
		}
		MvcHtmlString confirmPopup = MvcHtmlString.Empty;
		if (connector.UseConfirmConnector)
		{
			string confirmPopupId = "confirm" + text5;
			string popupCallback = text4;
			string confirmation = info.GenerateTextConnector(connector.LocalizableConfirmConnectorText, connector.FormingConfirmConnector) ?? connector.LocalizableConfirmConnectorText;
			confirmPopup = helper.PopupWindow(confirmPopupId, SR.T("Подтверждение"), (object m) => PartialExtensions.Partial(helper, "WorkflowTask/ConfirmTask", (object)new ConfirmButtonModel
			{
				ConfirmConnectorText = confirmation,
				PopupId = confirmPopupId,
				returnFunction = popupCallback
			}), 400);
			text4 = $"openWindow('{confirmPopupId}');";
		}
		return new ConnectorActionsModel
		{
			ConnectorCode = text4,
			ConfirmPopup = confirmPopup,
			FormPopup = formPopup,
			ConnectorName = displayConnectorName,
			ConnectorId = text5,
			ColorConnectorButton = connector.ColorConnectorButton
		};
	}

	private static MvcHtmlString RenderRuntimeVersion2(HtmlHelper html, object taskModel, object entityModel, FormViewItem formViewItem)
	{
		if (!(taskModel is IWorkflowTaskBase workflowTaskBase))
		{
			return null;
		}
		Guid uid = MetadataLoader.LoadMetadata(workflowTaskBase.CastAsRealType().GetType()).Uid;
		ViewItemHideMode hideMode = ViewItemControl<ViewItem, object, object>.HideMode;
		Dictionary<string, object> dictionary = new Dictionary<string, object>
		{
			{ "WorkflowTaskId", workflowTaskBase.Id },
			{ "WorkflowTaskTypeUid", uid },
			{ "FormUid", formViewItem.Uid },
			{ "HideMode", hideMode }
		};
		if (entityModel != null)
		{
			string text2 = (string)(dictionary["Entity"] = new EntityJsonSerializer().Serialize(entityModel, new EntitySerializationSettings
			{
				WriteReferences = true
			}));
		}
		PageApplicationData applicationData = new PageApplicationData(WorkflowSystemComponentConstants.WorkflowTaskUid, dictionary);
		return html.RenderPageV2(applicationData);
	}
}
