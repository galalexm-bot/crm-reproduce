using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.Grids;
using EleWise.ELMA.Web.Mvc.Html.Selectors;
using EleWise.ELMA.Web.Mvc.Html.Wizard;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Web.Mvc;

public abstract class DynamicViewControl<T> : BaseViewPage<T>
{
	private object viewId;

	protected string ViewId
	{
		get
		{
			if (viewId == null)
			{
				if (((ControllerContext)((WebViewPage)this).get_ViewContext()).get_IsChildAction())
				{
					((ControllerContext)((WebViewPage)this).get_ViewContext()).get_RouteData().Values.TryGetValue("ViewId", out viewId);
				}
				else
				{
					viewId = ((ControllerContext)((WebViewPage)this).get_ViewContext()).get_HttpContext().Request["ViewId"];
				}
				if (viewId == null)
				{
					viewId = GetDefaultViewId(new string[3] { "area", "controller", "action" });
				}
			}
			return viewId.ToString();
		}
	}

	protected bool NeedWriteContainerDiv
	{
		get
		{
			if (((ControllerContext)((WebViewPage)this).get_ViewContext()).get_IsChildAction())
			{
				return true;
			}
			return ((ControllerContext)((WebViewPage)this).get_ViewContext()).get_HttpContext().Request["NeedWriteContainerDiv"] == "1";
		}
	}

	protected DynamicGridBuilder<TData> DynamicGrid<TData>(string uniqueName, IGridData<TData> gridData, Guid? stateProvider) where TData : class
	{
		return new DynamicGridBuilder<TData>((HtmlHelper)(object)((WebViewPage<T>)this).get_Html(), uniqueName, ViewId, gridData, stateProvider);
	}

	protected DynamicGridBuilder<TData> DynamicGrid<TData>(string uniqueName, IGridData<TData> gridData) where TData : class
	{
		return new DynamicGridBuilder<TData>((HtmlHelper)(object)((WebViewPage<T>)this).get_Html(), uniqueName, ViewId, gridData);
	}

	protected DynamicPanelBuilder<TData> DynamicPanel<TData>(string uniqueName, IGridData<TData> gridData) where TData : class
	{
		return new DynamicPanelBuilder<TData>((HtmlHelper)(object)((WebViewPage<T>)this).get_Html(), uniqueName, ViewId, gridData);
	}

	protected DynamicGridBuilder<TData> DynamicGrid<TData>(IGridData<TData> gridData) where TData : class
	{
		return new DynamicGridBuilder<TData>((HtmlHelper)(object)((WebViewPage<T>)this).get_Html(), ViewId, gridData);
	}

	protected DynamicPanelBuilder<TData> DynamicPanel<TData>(IGridData<TData> gridData) where TData : class
	{
		return new DynamicPanelBuilder<TData>((HtmlHelper)(object)((WebViewPage<T>)this).get_Html(), ViewId, gridData);
	}

	protected DynamicGridBuilder<TData> DynamicGrid<TData>(string uniqueName, IEnumerable<TData> gridDataSource) where TData : class
	{
		return new DynamicGridBuilder<TData>((HtmlHelper)(object)((WebViewPage<T>)this).get_Html(), uniqueName, ViewId, gridDataSource.CreateGridData());
	}

	protected TabPanelBuilder TabPanel(string name)
	{
		return new TabPanelBuilder((HtmlHelper)(object)((WebViewPage<T>)this).get_Html(), name);
	}

	protected WizardBuilder Wizard(string name)
	{
		return new WizardBuilder((HtmlHelper)(object)((WebViewPage<T>)this).get_Html(), name);
	}

	private RouteValueDictionary ExtractRouteValues(IEnumerable<string> valueNames)
	{
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary();
		foreach (string item in valueNames.Where((string valueName) => ((ControllerContext)((WebViewPage)this).get_ViewContext()).get_RouteData().Values.ContainsKey(valueName)))
		{
			routeValueDictionary.Add(item, ((ControllerContext)((WebViewPage)this).get_ViewContext()).get_RouteData().Values[item]);
		}
		return routeValueDictionary;
	}

	private string GetDefaultViewId(IEnumerable<string> valueNames)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string item in valueNames.Where((string valueName) => ((ControllerContext)((WebViewPage)this).get_ViewContext()).get_RouteData().Values.ContainsKey(valueName)))
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append("_");
			}
			stringBuilder.Append(((ControllerContext)((WebViewPage)this).get_ViewContext()).get_RouteData().Values[item]);
		}
		if (stringBuilder.Length == 0)
		{
			stringBuilder.Append(Guid.NewGuid().ToString("d"));
		}
		return stringBuilder.ToString();
	}

	public override void Execute()
	{
		throw new NotImplementedException();
	}

	public override void ExecutePageHierarchy()
	{
		DynamicViewHelper dynamicViewHelper = new DynamicViewHelper((ControllerContext)(object)((WebViewPage)this).get_ViewContext());
		if (NeedWriteContainerDiv)
		{
			((WebViewPage)this).get_ViewContext().get_Writer().Write("<div id=\"");
			((WebViewPage)this).get_ViewContext().get_Writer().Write(ViewId);
			((WebViewPage)this).get_ViewContext().get_Writer().Write("\" class=\"dynamic\" dynamicUrl=\"");
			RouteValueDictionary routeValueDictionary = ExtractRouteValues(new string[5] { "area", "controller", "action", "path", "ViewId" });
			VirtualPathData virtualPathForArea = RouteCollectionExtensions.GetVirtualPathForArea(((HtmlHelper)((WebViewPage<T>)this).get_Html()).get_RouteCollection(), ((ControllerContext)((WebViewPage)this).get_ViewContext()).get_RequestContext(), routeValueDictionary);
			string text = ((HtmlHelper)(object)((WebViewPage<T>)this).get_Html()).Url().Content(virtualPathForArea.VirtualPath);
			((WebViewPage)this).get_ViewContext().get_Writer().Write(((HtmlHelper)((WebViewPage<T>)this).get_Html()).AttributeEncode(text));
			((WebViewPage)this).get_ViewContext().get_Writer().Write("\" dynamicLoadMode=\"");
			((WebViewPage)this).get_ViewContext().get_Writer().Write((int)dynamicViewHelper.LoadMode);
			if (dynamicViewHelper.NeedRenderView)
			{
				((WebViewPage)this).get_ViewContext().get_Writer().Write("\" loaded=\"1");
			}
			((WebViewPage)this).get_ViewContext().get_Writer().Write("\">");
		}
		if (!dynamicViewHelper.NeedRenderView)
		{
			((WebViewPage)this).get_ViewContext().get_Writer().Write("<span style='color:green'>");
			((WebViewPage)this).get_ViewContext().get_Writer().Write(SR.T("Пожалуйста, подождите..."));
			((WebViewPage)this).get_ViewContext().get_Writer().Write("</span>");
		}
		else
		{
			((WebViewPage)this).ExecutePageHierarchy();
		}
		if (NeedWriteContainerDiv)
		{
			((WebViewPage)this).get_ViewContext().get_Writer().Write("</div>");
		}
	}
}
