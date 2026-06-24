using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Security.Components;

[Component(Order = 0)]
public class SecurityReplacementEditView : ReplacementEditViewBase
{
	public override string Id => "GeneralPanel";

	public override string Name => SR.T("Общая информация");

	public override MvcHtmlString Render(HtmlHelper html, ReplacementModel model)
	{
		if (model == null)
		{
			return MvcHtmlString.Empty;
		}
		return PartialExtensions.Partial(html, "Replacement/GeneralInfoReplacement", (object)model);
	}
}
