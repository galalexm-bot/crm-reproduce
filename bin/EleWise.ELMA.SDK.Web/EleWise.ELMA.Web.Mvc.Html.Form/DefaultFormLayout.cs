using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public class DefaultFormLayout : IFormBuilderLayout
{
	private bool _renderTable = true;

	public virtual bool RenderTable
	{
		get
		{
			return _renderTable;
		}
		set
		{
			_renderTable = value;
		}
	}

	public virtual MvcHtmlString RenderForm(HtmlHelper html, FormBuilderModel formModel)
	{
		return PartialExtensions.Partial(html, "Templates/DefaultFormLayout", (object)formModel);
	}
}
