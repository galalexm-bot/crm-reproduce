using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IProfileBlockInfoProvider
{
	string Title { get; }

	bool IsVisible(IUser user);

	MvcHtmlString Render(HtmlHelper helper, IUser user);
}
