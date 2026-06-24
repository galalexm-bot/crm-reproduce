using System;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;

namespace EleWise.ELMA.Workflow.Web.Models;

public class StartRouteButtonInfo
{
	private string text = SR.T("Отправить по маршруту");

	private string toolTipHeader = SR.T("Отправить по маршруту");

	private string toolTip = SR.T("Отправить по одному из доступных процессов. Процессы настраиваются в дизайнере ELMA.");

	private Lazy<bool> _hasRoutes;

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

	public string ToolTipHeader
	{
		get
		{
			return toolTipHeader;
		}
		set
		{
			toolTipHeader = value;
		}
	}

	public string ToolTip
	{
		get
		{
			return toolTip;
		}
		set
		{
			toolTip = value;
		}
	}

	public Guid ObjectType { get; set; }

	public long ObjectId { get; set; }

	public RelationType? RelationType { get; set; }

	public string ImageUrl { get; set; }

	public string PopupId { get; set; }

	public string Name { get; set; }

	public string Caption { get; set; }

	public bool Hide { get; set; }

	public IActionItem ActionItem { get; set; }

	public int? ActionItemIndex { get; set; }

	public bool HasRoutes => false;
}
