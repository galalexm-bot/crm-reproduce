using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 100)]
public class ReplacementTaskActiveTasksTab : IReplacementTaskObjectsTab
{
	public string Name => SR.T("Задачи");

	public string TabId => "activeTasksTab";

	public IEnumerable<long> Count(long replacementTaskId)
	{
		yield return ReplacementTaskManager.Instance.ActiveTasksCount(replacementTaskId);
	}

	public string ContentUrl(HtmlHelper html, long replacementTaskId)
	{
		return html.Url().Action("ReplacementActiveTasksGrid", "ReplacementTask", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks",
			replacementTaskId = replacementTaskId
		});
	}
}
