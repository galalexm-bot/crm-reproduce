using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Portlets;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Integration.Portlets;

[Component]
public class SolveApprovalTaskView : ISolveTaskViewer
{
	public bool CheckType(ITaskBase task)
	{
		return task.TypeUid == InterfaceActivator.UID<IApprovalTask>();
	}

	public MvcHtmlString Render(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings, bool forControl)
	{
		StringBuilder resultBuilder = new StringBuilder();
		string infoText;
		MvcHtmlString value = helper.StatusLink(task, showInfo: false, out infoText, false, false, settings.OpenLinksInNewWindow);
		resultBuilder.Append(value);
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
