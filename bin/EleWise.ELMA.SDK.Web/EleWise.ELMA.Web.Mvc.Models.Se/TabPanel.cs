using System.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Models.Selectors;

public class TabPanel
{
	public string Name { get; set; }

	public string CssClass { get; set; }

	public IList<TabPanelItem> Items { get; set; }

	public string OnSelectTab { get; set; }

	public TabPanel(string name)
	{
		Name = name;
		Items = new List<TabPanelItem>();
	}
}
