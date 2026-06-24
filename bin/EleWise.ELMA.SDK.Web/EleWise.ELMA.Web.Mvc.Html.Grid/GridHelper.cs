using System.Web;
using System.Web.Routing;

namespace EleWise.ELMA.Web.Mvc.Html.Grids;

public class GridHelper
{
	public static string GetGridId(RouteData routeData)
	{
		return ((string)routeData.Values["gridId"]) ?? ((HttpContext.Current != null) ? HttpContext.Current.Request.Params.Get("gridId") : null) ?? string.Concat("Grid", routeData.Values["controller"], routeData.Values["action"], routeData.Values["area"]);
	}
}
