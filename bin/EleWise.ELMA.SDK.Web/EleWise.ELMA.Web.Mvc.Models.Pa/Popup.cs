using System;

namespace EleWise.ELMA.Web.Mvc.Models.Panels;

public class Popup
{
	public string PopupId { get; set; }

	public string PopupHeader { get; set; }

	public int Width { get; set; }

	public string WidthMode { get; set; }

	public bool Modal { get; set; }

	public bool RegisterOnce { get; set; }

	public virtual bool Draggable { get; set; }

	public string ActionUrl { get; set; }

	public Func<object, object> Content { get; set; }

	public bool ShowHeader { get; set; }

	public int ZIndex { get; set; }

	public Popup()
	{
		Modal = true;
		RegisterOnce = false;
		ShowHeader = true;
		Draggable = true;
	}
}
