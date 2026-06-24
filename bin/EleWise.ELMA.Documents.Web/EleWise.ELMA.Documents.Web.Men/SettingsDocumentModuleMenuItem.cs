using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Web.Controllers;
using EleWise.ELMA.Web.Content.Menu;

namespace EleWise.ELMA.Documents.Web.Menu;

[Component]
public class SettingsDocumentModuleMenuItems : IMenuItemsProvider
{
	public const string DOCUMENT_MODULE_SETTINGS = "document_module_settings";

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public void Items(MenuItemFactory factory)
	{
		factory.Action((SettingsController c) => c.Index()).Code("document_module_settings").Name(SR.M("Документы"))
			.Container("left")
			.Order(80)
			.Parent("admin")
			.Copy(delegate(MenuItemBuilder b)
			{
				b.Container("top");
			});
	}
}
