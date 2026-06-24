using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Orchard.Mvc.Html;

public class MvcFormAntiForgeryPost : MvcForm
{
	private readonly HtmlHelper _htmlHelper;

	public MvcFormAntiForgeryPost(HtmlHelper htmlHelper)
		: base(htmlHelper.get_ViewContext())
	{
		_htmlHelper = htmlHelper;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			_htmlHelper.get_ViewContext().get_Writer().Write(_htmlHelper.AntiForgeryTokenOrchard());
		}
		((MvcForm)this).Dispose(disposing);
	}
}
