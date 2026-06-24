using System;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.Web.Mvc.Models.Panels;

public sealed class Popover : Popup
{
	public Func<object, object> Header { get; set; }

	public override bool Draggable => false;

	public Popover()
	{
		base.Modal = false;
		base.ShowHeader = false;
	}

	public Popover(Popup popup)
		: this()
	{
		this.CopyFrom(popup);
	}
}
