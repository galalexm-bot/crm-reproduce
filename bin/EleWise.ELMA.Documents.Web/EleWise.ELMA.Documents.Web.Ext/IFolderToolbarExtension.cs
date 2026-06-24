using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Web.Mvc.Html.Toolbar;

namespace EleWise.ELMA.Documents.Web.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFolderToolbarExtension
{
	void BackToExt(IFolder folder, ToolbarGroupBuilder groupBuilder);
}
