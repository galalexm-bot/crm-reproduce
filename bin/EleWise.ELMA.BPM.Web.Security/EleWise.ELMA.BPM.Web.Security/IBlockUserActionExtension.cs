using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IBlockUserActionExtension
{
	void HandleModel(IBlockUserModel model);

	MvcHtmlString RenderFormInputs(HtmlHelper helper, IUser user);
}
