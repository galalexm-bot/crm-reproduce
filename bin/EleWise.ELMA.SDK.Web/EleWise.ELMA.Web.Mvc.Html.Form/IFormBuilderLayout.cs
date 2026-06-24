using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public interface IFormBuilderLayout
{
	MvcHtmlString RenderForm(HtmlHelper html, FormBuilderModel formModel);
}
