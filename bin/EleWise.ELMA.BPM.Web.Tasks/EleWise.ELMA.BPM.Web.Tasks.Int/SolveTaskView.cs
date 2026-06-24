using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Portlets;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Integration.Portlets;

[Component]
public class SolveTaskView : ISolveTaskViewer
{
	public bool CheckType(ITaskBase task)
	{
		return task.TypeUid == InterfaceActivator.UID<ITask>();
	}

	public MvcHtmlString Render(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings, bool forControl)
	{
		StringBuilder resultBuilder = new StringBuilder();
		string infoText;
		MvcHtmlString value = helper.StatusLink(task, showInfo: false, out infoText, false, false, settings.OpenLinksInNewWindow);
		resultBuilder.Append(value);
		if (((IEnumerable<ITaskBase>)task.ChildTasks).Any())
		{
			resultBuilder.Append(string.Format("<span class=\"comment\"><a href=\"{0}\" {2}>({1})</a></span>", helper.Url().Action("Execute", "Task", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks",
				id = task.Id,
				selectedTab = "SubTasks"
			}), SR.T("Есть подзадачи"), settings.OpenLinksInNewWindow ? "target=\"_blank\"" : ""));
		}
		if (forControl && !string.IsNullOrEmpty(infoText))
		{
			resultBuilder.Append($"<br/>{infoText}");
		}
		if (!settings.HideAttachmets)
		{
			SolveTaskHelper.RunWithDebug("SolvePortlet/TaskBaseAttachmentsInfo", settings.DebugMode, delegate
			{
				MvcHtmlString value2 = PartialExtensions.Partial(helper, "SolvePortlet/TaskBaseAttachmentsInfo", (object)task);
				resultBuilder.Append(value2);
			});
		}
		return MvcHtmlString.Create(resultBuilder.ToString());
	}
}
