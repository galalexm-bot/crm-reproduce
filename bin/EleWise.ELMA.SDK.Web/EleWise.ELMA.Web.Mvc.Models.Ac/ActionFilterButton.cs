using System;

namespace EleWise.ELMA.Web.Mvc.Models.ActionItems;

[Serializable]
public class ActionFilterButton
{
	private string text;

	private object attributes;

	public object Attributes
	{
		get
		{
			return attributes;
		}
		set
		{
			attributes = value;
		}
	}

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

	public string CloseIconClick { get; set; }

	public string Click { get; set; }

	public string CloseIconUrl { get; set; }

	public bool CloseIconHide { get; set; }

	public bool ShowTooltip { get; set; }
}
