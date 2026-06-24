using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Models.Selectors;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.Web.Mvc.Html.Selectors;

public class TabPanelItemsBuilder
{
	private readonly HtmlHelper html;

	private readonly TabPanel tabPanel;

	public TabPanelItemsBuilder(HtmlHelper html, TabPanel tabPanel)
	{
		this.html = html;
		this.tabPanel = tabPanel;
	}

	public TabPanelItemBuilder Add(TabPanelItem item)
	{
		if (tabPanel.Items == null)
		{
			tabPanel.Items = new List<TabPanelItem>();
		}
		if (item.TabIndex.HasValue && item.TabIndex >= 0 && item.TabIndex < tabPanel.Items.Count)
		{
			tabPanel.Items.Insert(item.TabIndex.Value, item);
		}
		else
		{
			tabPanel.Items.Add(item);
		}
		return new TabPanelItemBuilder(html, tabPanel, item);
	}

	public TabPanelItemBuilder Add(string text)
	{
		TabPanelItem tabPanelItem = new TabPanelItem();
		((NavigationItem<TabStripItem>)(object)tabPanelItem).set_Text(text);
		return Add(tabPanelItem);
	}

	public HtmlHelper GetHtml()
	{
		return html;
	}
}
