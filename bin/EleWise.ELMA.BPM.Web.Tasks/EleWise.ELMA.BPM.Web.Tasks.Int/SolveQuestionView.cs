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
public class SolveQuestionView : ISolveTaskViewer
{
	public bool CheckType(ITaskBase task)
	{
		return task.TypeUid == InterfaceActivator.UID<IQuestion>();
	}

	public MvcHtmlString Render(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings, bool forControl)
	{
		StringBuilder resultBuilder = new StringBuilder();
		MvcHtmlString value = helper.StatusLink(task, showInfo: false, false, false, settings.OpenLinksInNewWindow);
		resultBuilder.Append(value);
		string value2 = string.Format("<br/><span style=\"color: Grey;padding-bottom:3px;\">{0} ({1})</span>", SR.T("Вопрос"), PartialExtensions.Partial(helper, "DisplayTemplates/Entities/User", (object)task.CreationAuthor));
		resultBuilder.Append(value2);
		if (!settings.HideAttachmets)
		{
			SolveTaskHelper.RunWithDebug("SolvePortlet/TaskBaseAttachmentsInfo", settings.DebugMode, delegate
			{
				MvcHtmlString value3 = PartialExtensions.Partial(helper, "SolvePortlet/TaskBaseAttachmentsInfo", (object)task);
				resultBuilder.Append(value3);
			});
		}
		return MvcHtmlString.Create(resultBuilder.ToString());
	}
}
