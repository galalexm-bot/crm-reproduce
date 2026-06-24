using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard;
using Orchard.Themes;

namespace EleWise.ELMA.Web.Mvc;

public static class ControllerContextCreator
{
	public static ControllerContext Create(Controller controller)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		using (SafeHttpContext.Create())
		{
			HttpContextWrapper httpContextWrapper = new HttpContextWrapper(HttpContext.Current);
			RouteData routeData = RouteTable.Routes.GetRouteData(httpContextWrapper);
			routeData.Values["action"] = "Action";
			string text = ((object)controller).GetType().Name;
			if (text.EndsWith("Controller"))
			{
				text = text.Remove(text.Length - 10);
			}
			routeData.Values["controller"] = text;
			((IWorkContextAccessor)routeData.DataTokens["IWorkContextAccessor"]).CreateWorkContextScope(httpContextWrapper);
			ControllerContext val = new ControllerContext((HttpContextBase)httpContextWrapper, routeData, (ControllerBase)(object)controller);
			WorkContext workContext = val.GetWorkContext();
			IThemeManager themeManager = workContext.Resolve<IThemeManager>();
			workContext.CurrentTheme = themeManager.GetRequestTheme(val.get_RequestContext());
			return val;
		}
	}
}
