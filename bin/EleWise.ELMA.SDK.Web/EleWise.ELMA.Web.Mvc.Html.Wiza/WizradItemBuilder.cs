using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Models.Wizard;

namespace EleWise.ELMA.Web.Mvc.Html.Wizard;

public class WizradItemBuilder
{
	private HtmlHelper html;

	private WizardModel wizard;

	private WizardItem item;

	public WizradItemBuilder(HtmlHelper html, WizardModel wizardModel)
	{
		this.html = html;
		wizard = wizardModel;
	}

	public WizradItemBuilder Add(WizardItem item)
	{
		if (wizard.Items == null)
		{
			wizard.Items = new List<WizardItem>();
		}
		wizard.Items.Add(item);
		this.item = item;
		return this;
	}

	public WizradItemBuilder Content(Func<object, object> content)
	{
		item.Content = content;
		return this;
	}

	public WizradItemBuilder Toolbar(Action content)
	{
		foreach (WizardItem item in wizard.Items.Where((WizardItem p) => p == item))
		{
			item.Toolbar = delegate
			{
				content();
			};
		}
		this.item.Toolbar = delegate
		{
			content();
		};
		return this;
	}

	public WizradItemBuilder Url(string url)
	{
		item.Url = url;
		return this;
	}

	public WizradItemBuilder Text(string text)
	{
		item.Text = text;
		return this;
	}

	[Obsolete("Используйте метод Text")]
	public WizradItemBuilder ShortName(string name)
	{
		item.Text = name;
		return this;
	}

	public WizradItemBuilder Description(string description)
	{
		item.Description = description;
		return this;
	}

	public WizradItemBuilder Selected(bool selected)
	{
		item.Selected = selected;
		return this;
	}

	public WizradItemBuilder Enabled(bool enabled)
	{
		item.Enabled = enabled;
		return this;
	}

	public WizradItemBuilder PostNext(bool postNext)
	{
		item.PostNext = postNext;
		return this;
	}

	public WizradItemBuilder ReloadOnSelect(bool reload)
	{
		item.ReloadOnSelect = reload;
		return this;
	}
}
