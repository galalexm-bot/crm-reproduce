using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Selectors;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.Web.Mvc.Html.Selectors;

public class TabPanelItemBuilder
{
	private HtmlHelper html;

	private readonly TabPanel tabPanel;

	private readonly TabPanelItem item;

	public TabPanelItemBuilder(HtmlHelper html, TabPanel tabPanel, TabPanelItem item)
	{
		this.html = html;
		this.tabPanel = tabPanel;
		this.item = item;
	}

	public TabPanelItemBuilder Content(Action content)
	{
		((NavigationItem<TabStripItem>)(object)item).get_Template().set_Content(content);
		foreach (TabPanelItem item in tabPanel.Items.Where((TabPanelItem p) => p == item))
		{
			((NavigationItem<TabStripItem>)(object)item).get_Template().set_Content(content);
		}
		return this;
	}

	public TabPanelItemBuilder Counter(long? counter)
	{
		((TabStripItem)item).set_Counter(counter);
		return this;
	}

	public TabPanelItemBuilder CounterText(string counterText)
	{
		((TabStripItem)item).set_CounterText(counterText);
		return this;
	}

	public TabPanelItemBuilder Builder([NotNull] Action<TabPanelItem> itemBuilder)
	{
		if (itemBuilder == null)
		{
			throw new ArgumentNullException("itemBuilder");
		}
		itemBuilder(item);
		foreach (TabPanelItem item in tabPanel.Items.Where((TabPanelItem p) => p == item))
		{
			itemBuilder(item);
		}
		return this;
	}

	public TabPanelItemBuilder Selected(bool selected = true)
	{
		((NavigationItem<TabStripItem>)(object)item).set_Selected(selected);
		foreach (TabPanelItem item in tabPanel.Items.Where((TabPanelItem p) => p == item))
		{
			((NavigationItem<TabStripItem>)(object)item).set_Selected(selected);
		}
		return this;
	}

	public TabPanelItemBuilder Content(Func<object, object> value)
	{
		((HtmlTemplate<object>)(object)((NavigationItem<TabStripItem>)(object)item).get_Template()).set_InlineTemplate(value);
		foreach (TabPanelItem item in tabPanel.Items.Where((TabPanelItem p) => p == item))
		{
			((HtmlTemplate<object>)(object)((NavigationItem<TabStripItem>)(object)item).get_Template()).set_InlineTemplate(value);
		}
		return this;
	}

	public TabPanelItemBuilder ContentUrl(string contentUrl)
	{
		((TabStripItem)item).set_ContentUrl(contentUrl);
		return this;
	}

	public TabPanelItemBuilder HtmlAttributes(Dictionary<string, object> attr)
	{
		foreach (KeyValuePair<string, object> item in attr)
		{
			((NavigationItem<TabStripItem>)(object)this.item).get_HtmlAttributes().Add(item);
		}
		return this;
	}
}
