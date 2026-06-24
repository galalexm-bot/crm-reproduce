using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Tasks.ViewItems;
using EleWise.ELMA.Web.Mvc.Components;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
[Obsolete("Don't use")]
public class WorkLogTabViewItemRenderer : TabViewItemRenderer
{
	public override bool CanRender(ViewItem viewItem)
	{
		return viewItem.GetType() == typeof(WorkLogTabViewItem);
	}

	public override MvcHtmlString Render(HtmlHelper html, ViewItem viewItem, object model)
	{
		ITaskBase taskBase = (model ?? html.get_ViewData().get_Model()) as ITaskBase;
		long num = 0L;
		if (WorkLogSettingsHelper.WorkLogEnabled() && taskBase != null)
		{
			num = WorkLogManager.Instance.GetWorkLogsCount(taskBase);
		}
		if (num <= 0 || taskBase == null)
		{
			return MvcHtmlString.Empty;
		}
		return base.Render(html, viewItem, model);
	}
}
