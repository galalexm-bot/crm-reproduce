using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

public abstract class ReplacementEditViewBase : IReplacementEditViewExtension
{
	public virtual string Id => "additionalProperties";

	public virtual string Name => SR.T("Дополнительно");

	public virtual bool SaveState => false;

	public virtual bool Expanded => true;

	public abstract MvcHtmlString Render(HtmlHelper html, ReplacementModel model);
}
