using System.Web.Mvc;
using Orchard.DisplayManagement;

namespace Orchard.Mvc.ViewEngines.Razor;

public abstract class WebViewPage<TModel> : WebViewPage<TModel>
{
	private object _display;

	private object _layout;

	private IDisplayHelperFactory _displayHelperFactory;

	public dynamic Display => _display;

	public dynamic Layout => _layout;

	public WorkContext WorkContext { get; set; }

	public IDisplayHelperFactory DisplayHelperFactory => _displayHelperFactory ?? (_displayHelperFactory = WorkContext.Resolve<IDisplayHelperFactory>());

	public override void InitHelpers()
	{
		base.InitHelpers();
		WorkContext = ((ControllerContext)(object)((WebViewPage)this).get_ViewContext()).GetWorkContext();
		_display = DisplayHelperFactory.CreateHelper(((WebViewPage)this).get_ViewContext(), (IViewDataContainer)(object)this);
		_layout = WorkContext.Layout;
	}
}
public abstract class WebViewPage : WebViewPage<object>
{
}
