using System.Web.Mvc;
using System.Web.WebPages;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Html.Selectors;

namespace EleWise.ELMA.Web.Mvc.Views.ViewItem;

public abstract class TabViewItemControl<TViewItem, TBaseModel, TModel> : ViewItemControl<TViewItem, TBaseModel, TModel> where TViewItem : TabViewItem where TBaseModel : class
{
	internal const string TabPanelItemsBuilderCallContextDataName = "TabPanelItemsBuilder";

	internal const string IndexCallContextDataName = "IndexTabViewItemObject";

	internal const string TabCallContextDataModelName = "TabViewItemModel";

	internal const string TabCallContextDataPrefixName = "TabViewItemPrefix";

	protected TabPanelItemsBuilder Tabs => ContextVars.GetOrDefault<TabPanelItemsBuilder>("TabPanelItemsBuilder");

	protected int? Index => ContextVars.GetOrDefault<int?>("IndexTabViewItemObject");

	protected bool Selected
	{
		get
		{
			if (!string.IsNullOrWhiteSpace(ViewItemControl<TViewItem, TBaseModel, TModel>.ViewItem.Name))
			{
				return (string)(((WebPageRenderingBase)this).get_Request().Params["SelectedTab"] ?? ((WebPageRenderingBase)this).get_Request().Params["SeletedTab"] ?? ((ViewDataDictionary)((WebViewPage<_003F>)(object)this).get_ViewData()).get_Item("SelectedTab") ?? ((ViewDataDictionary)((WebViewPage<_003F>)(object)this).get_ViewData()).get_Item("SeletedTab")) == ViewItemControl<TViewItem, TBaseModel, TModel>.ViewItem.Name;
			}
			return false;
		}
	}

	public static object ParentModel
	{
		get
		{
			return ContextVars.GetOrDefault<object>("TabViewItemModel");
		}
		set
		{
			ContextVars.Set("TabViewItemModel", value);
		}
	}

	public static string ParentPrefix
	{
		get
		{
			return ContextVars.GetOrDefault<string>("TabViewItemPrefix");
		}
		set
		{
			ContextVars.Set("TabViewItemPrefix", value);
		}
	}
}
public abstract class TabViewItemControl<TViewItem, TBaseModel> : TabViewItemControl<TViewItem, TBaseModel, object> where TViewItem : TabViewItem where TBaseModel : class
{
}
public abstract class TabViewItemControl<TViewItem> : TabViewItemControl<TViewItem, object> where TViewItem : TabViewItem
{
}
