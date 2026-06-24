using System;

namespace EleWise.ELMA.Web.Mvc.Models.Wizard;

public class WizardItem
{
	private string url;

	private bool selected;

	private bool enabled;

	private string text;

	public Func<object, object> Content { get; set; }

	public Action Toolbar { get; set; }

	public string Header { get; set; }

	public string ShortName { get; set; }

	public string Description { get; set; }

	public string Text
	{
		get
		{
			return text;
		}
		set
		{
			text = value;
		}
	}

	public bool Selected
	{
		get
		{
			return selected;
		}
		set
		{
			selected = value;
			if (selected)
			{
				enabled = true;
			}
		}
	}

	public bool Enabled
	{
		get
		{
			return enabled;
		}
		set
		{
			enabled = value;
			if (!enabled)
			{
				selected = false;
			}
		}
	}

	public string Url
	{
		get
		{
			return url;
		}
		set
		{
			url = value;
		}
	}

	public bool PostNext { get; set; }

	public bool ReloadOnSelect { get; set; }
}
