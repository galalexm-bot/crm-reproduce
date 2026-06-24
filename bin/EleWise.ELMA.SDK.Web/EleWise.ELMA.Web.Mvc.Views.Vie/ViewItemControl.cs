using System;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.Views.ViewItem;

public abstract class ViewItemControl<TViewItem, TBaseModel, TModel> : WebViewPage<TModel> where TViewItem : EleWise.ELMA.Model.Views.ViewItem where TBaseModel : class
{
	public const string CallContextViewTypeDataName = "FormViewItemViewType";

	public const string CallContextViewTypeDataNameExternal = "FormViewItemViewTypeExternal";

	public const string CallContexParentDataName = "ViewItemParentObject";

	public const string CallContextDataName = "ViewItemObject";

	internal const string ActionRouteCallContextDataName = "ViewItemActionRoute";

	internal const string CallContextDataModelName = "ViewItemModel";

	internal const string CallContextDataPrefixName = "ViewItemPrefix";

	internal const string CallContextDataHideCountName = "ViewItemHideCount";

	internal const string CallContextDataIsAsync = "ViewItemIsAsync";

	internal const string CallContextViewItemHideMode = "ViewItemHideMode";

	private string asyncUrl = "";

	protected internal static ViewType ViewType => ContextVars.GetOrAdd("FormViewItemViewType", () => ViewType.Custom);

	protected RootViewItem ParentViewItem => ContextVars.GetOrDefault<RootViewItem>("ViewItemParentObject");

	protected internal static TViewItem ViewItem => ContextVars.GetOrDefault<TViewItem>("ViewItemObject");

	public static ViewItemHideMode HideMode
	{
		get
		{
			return ContextVars.GetOrAdd("ViewItemHideMode", () => ViewItemHideMode.Main);
		}
		internal set
		{
			ContextVars.Set("ViewItemHideMode", value);
		}
	}

	public static TBaseModel OriginalModel => ContextVars.GetOrDefault<object>("ViewItemModel") as TBaseModel;

	protected string Prefix => ContextVars.GetOrDefault<string>("ViewItemPrefix");

	public static int HideCount
	{
		get
		{
			return ContextVars.GetOrAdd("ViewItemHideCount", () => 0);
		}
		set
		{
			ContextVars.Set("ViewItemHideCount", value);
		}
	}

	public static bool IsAsync
	{
		get
		{
			return ContextVars.GetOrAdd("ViewItemIsAsync", () => false);
		}
		internal set
		{
			ContextVars.Set("ViewItemIsAsync", value);
		}
	}

	protected string AsyncUrl
	{
		get
		{
			if (asyncUrl == "")
			{
				if (ViewItemControl<FormViewItem, object, object>.ViewType != ViewType.Display)
				{
					FormViewItem formViewItem = ViewItem.FormViewItem;
					if (formViewItem == null || !formViewItem.IsReadOnly())
					{
						RootViewItem rootViewItem = ViewItem as RootViewItem;
						ObjectViewData data = ObjectViewData.GetCurrent();
						if (rootViewItem != null && (rootViewItem.GetAllItems().OfType<DefaultContainerViewItem>().Any((DefaultContainerViewItem d) => (!d.ReadOnly || (data != null && data.ViewProviderUid != Guid.Empty)) && d.NotIncludedProperies(formViewItem, ViewItemControl<FormViewItem, object, object>.ViewType, FormViewItemControl.ItemType, FormViewItemControl.Entity).Any()) || rootViewItem.GetAllItems().OfType<PanelViewItem>().Any((PanelViewItem i) => !string.IsNullOrWhiteSpace(i.CustomViewName)) || rootViewItem.GetAllItems().OfType<PropertyViewItem>().Any((PropertyViewItem i) => !i.IsReadOnly() || (data != null && data.ViewProviderUid != Guid.Empty))))
						{
							return asyncUrl = null;
						}
					}
				}
				ActionRoute actionRoute = ContextVars.GetOrDefault<ActionRoute>("ViewItemActionRoute");
				if (actionRoute == null)
				{
					return asyncUrl = null;
				}
				string text = "ViewItemUid";
				Type typeFromHandle = typeof(IBaseController<, >);
				string controllerName = $"{actionRoute.Controller}Controller";
				Type type = ComponentManager.Current.GetExtensionPointTypes(typeFromHandle).FirstOrDefault((Type t) => t.Name == controllerName);
				if (type != null)
				{
					MethodInfo methodInfo = type.GetMethods().FirstOrDefault((MethodInfo m) => m.Name == actionRoute.Action);
					if (methodInfo != null && methodInfo.GetCustomAttributes(typeof(AsyncViewItemActionAttribute), inherit: false).FirstOrDefault() is AsyncViewItemActionAttribute asyncViewItemActionAttribute)
					{
						text = asyncViewItemActionAttribute.ParametrName ?? text;
					}
				}
				RouteValueDictionary routeValueDictionary = new RouteValueDictionary(actionRoute.Routes);
				routeValueDictionary[text] = ViewItem.Uid;
				asyncUrl = ((WebViewPage)this).get_Url().Action(actionRoute.Action, actionRoute.Controller, routeValueDictionary);
			}
			return asyncUrl;
		}
	}

	protected ViewItemControl()
	{
		((WebViewPage<_003F>)(object)this)._002Ector();
	}
}
public abstract class ViewItemControl<TViewItem, TBaseModel> : ViewItemControl<TViewItem, TBaseModel, object> where TViewItem : EleWise.ELMA.Model.Views.ViewItem where TBaseModel : class
{
}
public abstract class ViewItemControl<TViewItem> : ViewItemControl<TViewItem, object> where TViewItem : EleWise.ELMA.Model.Views.ViewItem
{
}
