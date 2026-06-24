using System.Web;
using System.Web.Mvc;

namespace Orchard.DisplayManagement.Shapes;

public class OrchardTagBuilder : TagBuilder
{
	public IHtmlString StartElement => new HtmlString(((TagBuilder)this).ToString((TagRenderMode)1));

	public IHtmlString EndElement => new HtmlString(((TagBuilder)this).ToString((TagRenderMode)2));

	public OrchardTagBuilder(string tagName)
		: base(tagName)
	{
	}

	public IHtmlString ToHtmlString(TagRenderMode renderMode = 0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return new HtmlString(((TagBuilder)this).ToString(renderMode));
	}
}
