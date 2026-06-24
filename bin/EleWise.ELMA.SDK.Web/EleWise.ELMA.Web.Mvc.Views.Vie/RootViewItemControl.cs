using System.Web.Mvc;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Views.ViewItem;

public abstract class RootViewItemControl<TModel, TViewItem> : WebViewPage<TModel> where TViewItem : RootViewItem
{
	internal const string CallContextDataRoonName = "ViewItemRoot";

	protected TViewItem ViewItem => ContextVars.GetOrDefault<TViewItem>("ViewItemRoot");
}
public abstract class RootViewItemControl<TModel> : RootViewItemControl<TModel, RootViewItem>
{
}
