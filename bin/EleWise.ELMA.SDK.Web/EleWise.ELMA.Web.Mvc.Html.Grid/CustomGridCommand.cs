using System.Web;

namespace EleWise.ELMA.Web.Mvc.Html.Grids;

public class CustomGridCommand
{
	public string CommandName { get; set; }

	public long[] Ids { get; set; }

	public object GetParameter(HttpContextBase context, string name)
	{
		return context.Request.Params.Get(name);
	}
}
