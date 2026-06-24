using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.Selectors;
using EleWise.ELMA.Web.Mvc.Models.Selectors;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

public static class WorkLogExtensions
{
	public static MvcHtmlString AddWorkLogPopup(this HtmlHelper html, WorkLogModel workLogItem)
	{
		using (IEnumerator<ITaskActionRenderer> enumerator = (from e in ComponentManager.Current.GetExtensionPoints<ITaskActionRenderer>()
			where e.CanRender(workLogItem)
			select e).GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				return enumerator.Current.Render(html, workLogItem);
			}
		}
		return PartialExtensions.Partial(html, "WorkLog/PopupWorkLogEditor", (object)workLogItem);
	}

	public static void AddWorkLogTab(this HtmlHelper html, TabPanelItemsBuilder tabs, object task)
	{
		html.AddWorkLogTab(tabs, task, null);
	}

	public static void AddWorkLogTab(this HtmlHelper html, TabPanelItemsBuilder tabs, object task, int? tabIndex = null)
	{
		if (task is ITaskBase taskBase && WorkLogSettingsHelper.WorkLogEnabled())
		{
			long workLogsCount = WorkLogManager.Instance.GetWorkLogsCount(taskBase);
			long num = ((WorkLogExtensionHelper.FindExtensionByObjectUid(taskBase.TypeUid, enabled: true) != null) ? WorkLogItemManager.Instance.ForObjectCount(taskBase) : 0);
			if (workLogsCount > 0 || num > 0)
			{
				TabPanelItem tabPanelItem = new TabPanelItem();
				((NavigationItem<TabStripItem>)(object)tabPanelItem).set_Text(SR.T("Трудозатраты"));
				((TabStripItem)tabPanelItem).set_ContentUrl(html.Url().Action("WorkLogTab", "WorkLogReport", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Tasks",
					taskId = taskBase.Id,
					showWorkLog = (workLogsCount > 0),
					showSummaryTable = (num > 0)
				}));
				tabPanelItem.TabIndex = tabIndex;
				tabs.Add(tabPanelItem);
			}
		}
	}
}
