using System;
using System.Web.Mvc;
using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Web.Models;

public class DragAndDropInfo
{
	private Lazy<DragAndDropSettings> _dragAndDropSettings;

	public string Text { get; set; }

	public DragAndDropSettings DragAndDropSettings
	{
		get
		{
			if (_dragAndDropSettings == null)
			{
				_dragAndDropSettings = new Lazy<DragAndDropSettings>(() => Locator.GetServiceNotNull<DragAndDropSettingsBlock>().Settings);
			}
			return _dragAndDropSettings.Value;
		}
	}

	public bool IsCloseDragAndDropNotification(HtmlHelper html)
	{
		return ((ControllerContext)html.get_ViewContext()).get_HttpContext().Request.Cookies["IsCloseDragAndDropNotification"] != null;
	}
}
