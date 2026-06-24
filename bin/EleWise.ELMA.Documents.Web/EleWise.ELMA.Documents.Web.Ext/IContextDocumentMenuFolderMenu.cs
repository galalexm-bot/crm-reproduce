using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Menu;

namespace EleWise.ELMA.Documents.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IContextDocumentMenuFolderMenuButton
{
	string BeforeButton { get; }

	string AfterButton { get; }

	List<ActionMenuItem> Buttons(HtmlHelper html);

	List<string> NotVisibleItems(HtmlHelper html, IDmsObject dmsObject);

	void RenderExtendedViews(HtmlHelper html);
}
