using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IRenderTemplateAttachment
{
	bool CheckType(object obj);

	MvcHtmlString GetTemplate(HtmlHelper htmlHelper, object obj);
}
