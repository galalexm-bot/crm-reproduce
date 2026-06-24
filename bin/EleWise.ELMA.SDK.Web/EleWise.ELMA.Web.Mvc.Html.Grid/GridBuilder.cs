using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Web.Mvc.Html.Grids;

public class GridBuilder<T> : IHtmlString
{
	protected HtmlHelper html;

	protected IGridData<T> gridData;

	protected Grid grid;

	public Grid Grid => grid;

	public HtmlHelper Html => html;

	public GridBuilder(HtmlHelper html, IGridData<T> gridData)
	{
		this.html = html;
		grid = new Grid(gridData, typeof(T));
	}

	protected virtual string Render()
	{
		return ((object)PartialExtensions.Partial(html, "Templates/Grid", (object)grid)).ToString();
	}

	public override string ToString()
	{
		return Render();
	}

	public string ToHtmlString()
	{
		return Render();
	}
}
