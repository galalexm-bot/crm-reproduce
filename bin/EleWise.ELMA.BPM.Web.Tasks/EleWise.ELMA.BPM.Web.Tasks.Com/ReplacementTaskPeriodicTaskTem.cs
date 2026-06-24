using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 200)]
internal class ReplacementTaskPeriodicTaskTemplates : IReplacementTaskObjectsTab
{
	public string Name => SR.T("Периодические задачи");

	public string TabId => "periodicTaskTemplatesTab";

	public IEnumerable<long> Count(long replacementTaskId)
	{
		yield return ReplacementTaskManager.Instance.PeriodicTaskTemplatesCount(replacementTaskId);
	}

	public string ContentUrl(HtmlHelper html, long replacementTaskId)
	{
		return html.Url().Action("ReplacementPeriodicTaskTemplatesGrid", "ReplacementTask", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks",
			replacementTaskId = replacementTaskId
		});
	}
}
