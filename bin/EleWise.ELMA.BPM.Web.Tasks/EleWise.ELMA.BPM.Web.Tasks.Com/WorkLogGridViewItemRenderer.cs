using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Tasks.ViewItems;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
public class WorkLogGridViewItemRenderer : ViewItemRendererBase<WorkLogGridViewItem>, ICountViewItemRenderer
{
	public override bool IsHideEmpty(ViewItem viewItem)
	{
		ITaskBase taskBase = ViewItemRenderer.Entity as ITaskBase;
		if (!(viewItem is WorkLogGridViewItem) || taskBase == null || !WorkLogSettingsHelper.WorkLogEnabled())
		{
			return base.IsHideEmpty(viewItem);
		}
		long workLogsCount = WorkLogManager.Instance.GetWorkLogsCount(taskBase);
		if (base.IsHideEmpty(viewItem))
		{
			return workLogsCount == 0;
		}
		return false;
	}

	public long? Count(object model, ICountViewItem viewItem)
	{
		if (!(model is ITaskBase task) || !WorkLogSettingsHelper.WorkLogEnabled())
		{
			return null;
		}
		return WorkLogManager.Instance.GetWorkLogsCount(task);
	}
}
