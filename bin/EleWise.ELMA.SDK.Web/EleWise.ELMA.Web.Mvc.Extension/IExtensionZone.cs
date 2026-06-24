using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IExtensionZone
{
	bool CanRenderInZone(string zoneId, HtmlHelper html);

	void RenderZone(string zoneId, HtmlHelper html);
}
