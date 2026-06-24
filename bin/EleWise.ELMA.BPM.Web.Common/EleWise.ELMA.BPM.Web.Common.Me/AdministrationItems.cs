using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content.Menu;

namespace EleWise.ELMA.BPM.Web.Common.Menu;

[Component(Order = 100)]
public class AdministrationItems : IMenuItemsProvider
{
	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public void Items(MenuItemFactory factory)
	{
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Parent("system-home");
			b.Container("left");
		});
		factory.Action((SettingsController c) => c.Index(null, null, null)).Order(10).Copy(delegate(MenuItemBuilder b)
		{
			b.Container("top");
		});
		factory.Action((LicenseController c) => c.Index()).Code("components").Order(20)
			.Copy(delegate(MenuItemBuilder b)
			{
				b.Container("top");
			});
		factory.Action((SchedulerController c) => c.Index()).Code("scheduler").Order(40)
			.Copy(delegate(MenuItemBuilder b)
			{
				b.Container("top");
			});
		factory.Action((DiagnosticsController c) => c.Index()).Code("diagnostics").Order(80)
			.Copy(delegate(MenuItemBuilder b)
			{
				b.Container("top");
			});
		factory.Action((TestEqlFilterController c) => c.Index()).Code("eqlfilters").Order(100)
			.Copy(delegate(MenuItemBuilder b)
			{
				b.Container("top");
			});
		factory.Action((DeployImportController c) => c.Index()).Code("import").Order(120)
			.Copy(delegate(MenuItemBuilder b)
			{
				b.Container("top");
			});
	}
}
