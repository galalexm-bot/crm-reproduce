using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Selectors;

namespace EleWise.ELMA.Web.Mvc.Html.Selectors;

public class TabPanelBuilder
{
	private const int TabPanelItemCountAtExtensionPoint = 20;

	protected HtmlHelper html;

	protected TabPanel tabPanel;

	protected bool useTabProvider;

	protected bool useSequentialSort;

	protected string tabPanelName;

	private bool tabsFromProvidersAdded;

	public TabPanelBuilder(HtmlHelper html, string tabPanelName, string tabProviderPanelName)
	{
		this.html = html;
		tabPanel = new TabPanel(tabPanelName);
		this.tabPanelName = tabProviderPanelName;
	}

	public TabPanelBuilder(HtmlHelper html, string tabPanelName)
		: this(html, tabPanelName, tabPanelName)
	{
	}

	public TabPanelBuilder(HtmlHelper html, TabPanel tabPanel, string tabProviderPanelName)
	{
		this.html = html;
		this.tabPanel = tabPanel;
		tabPanelName = tabProviderPanelName;
	}

	public TabPanelBuilder(HtmlHelper html, TabPanel tabPanel)
		: this(html, tabPanel, tabPanel.Name)
	{
	}

	public TabPanelBuilder Items(Action<TabPanelItemsBuilder> itemsBuilder)
	{
		TabPanelItemsBuilder obj = new TabPanelItemsBuilder(html, tabPanel);
		itemsBuilder(obj);
		return this;
	}

	public TabPanelBuilder CssClass(string cssClass)
	{
		tabPanel.CssClass = cssClass;
		return this;
	}

	public TabPanelBuilder OnSelectTab(string script)
	{
		tabPanel.OnSelectTab = script;
		return this;
	}

	public void AddTabsFromProviders()
	{
		if (!useTabProvider || tabsFromProvidersAdded)
		{
			return;
		}
		List<Pair<int, TabPanelItem>> list = new List<Pair<int, TabPanelItem>>();
		int num = 0;
		foreach (TabPanelItem item in tabPanel.Items)
		{
			list.Add(new Pair<int, TabPanelItem>(item.TabIndex ?? (++num), item));
		}
		IEnumerable<ITabProviderExtension> extensionPoints = ComponentManager.Current.GetExtensionPoints<ITabProviderExtension>();
		int num2 = 0;
		foreach (ITabProviderExtension item2 in extensionPoints)
		{
			if (!(item2.IdTabPanal(html) == tabPanelName))
			{
				continue;
			}
			List<TabPanelItem> list2 = item2.Items(html).ToList();
			num = 0;
			if (useSequentialSort)
			{
				num2++;
			}
			foreach (TabPanelItem item3 in list2)
			{
				int num3 = ((!useSequentialSort) ? (item3.TabIndex ?? (-1)) : (num2 * 20 + (item3.TabIndex ?? (++num))));
				if (num3 >= 0 && num3 < list.Count)
				{
					list.Insert(num3, new Pair<int, TabPanelItem>(num3, item3));
				}
				else
				{
					list.Add(new Pair<int, TabPanelItem>(num3, item3));
				}
			}
		}
		IEnumerable<Pair<int, TabPanelItem>> source = list;
		if (num2 > 0)
		{
			source = source.OrderBy((Pair<int, TabPanelItem> x) => x.First);
		}
		tabPanel.Items = source.Select((Pair<int, TabPanelItem> x) => x.Second).ToList();
		tabsFromProvidersAdded = true;
	}

	public virtual MvcHtmlString Render()
	{
		AddTabsFromProviders();
		return PartialExtensions.Partial(html, "Templates/TabPanel", (object)tabPanel);
	}

	public override string ToString()
	{
		return string.Empty;
	}

	public TabPanelBuilder UseTabProvider(bool value)
	{
		useTabProvider = value;
		return this;
	}

	public TabPanelBuilder UseSequentialSort(bool value)
	{
		useSequentialSort = value;
		return this;
	}
}
