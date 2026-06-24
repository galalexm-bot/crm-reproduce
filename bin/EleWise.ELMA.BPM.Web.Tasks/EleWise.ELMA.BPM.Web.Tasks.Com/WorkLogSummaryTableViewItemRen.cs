using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Tasks.ViewItems;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
public class WorkLogSummaryTableViewItemRenderer : ViewItemRendererBase<WorkLogSummaryTableViewItem>, ICountViewItemRenderer
{
	public override bool IsHideEmpty(ViewItem viewItem)
	{
		if (!(ViewItemRenderer.Entity is ITaskBase taskBase) || !WorkLogSettingsHelper.WorkLogEnabled())
		{
			return base.IsHideEmpty(viewItem);
		}
		long num = (IsTypeEnabled(taskBase) ? WorkLogItemManager.Instance.ForObjectCount(taskBase) : 0);
		if (base.IsHideEmpty(viewItem))
		{
			return num == 0;
		}
		return false;
	}

	private bool IsTypeEnabled(ITaskBase taskBase)
	{
		return WorkLogExtensionHelper.FindExtensionByObjectUid(taskBase.TypeUid, enabled: true) != null;
	}

	public long? Count(object model, ICountViewItem viewItem)
	{
		ITaskBase taskBase = model as ITaskBase;
		if (!(viewItem is WorkLogSummaryTableViewItem) || taskBase == null || !WorkLogSettingsHelper.WorkLogEnabled())
		{
			return null;
		}
		return IsTypeEnabled(taskBase) ? WorkLogItemManager.Instance.ForObjectCount(taskBase) : 0;
	}
}
