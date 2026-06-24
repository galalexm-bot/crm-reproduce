using System;
using EleWise.ELMA.Web.Mvc.Models.Boxes;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class AutoCompleteSeparatorItem : AutocompleteItem
{
	public static AutoCompleteSeparatorItem GetItem(string text, string value = null)
	{
		text = $"<div class=\"object-separator-text\">{text}</div>";
		return new AutoCompleteSeparatorItem
		{
			DropDownText = text,
			Value = (value ?? Guid.NewGuid().ToString()),
			ViewText = text,
			Text = text,
			VirtualItem = true,
			ListItemClass = "object-separator separator-gray"
		};
	}
}
