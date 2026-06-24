using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ITaskCompleteValidator
{
	bool CheckType(TaskCommentModel model);

	void RenderExtendedControl(HtmlHelper html, TaskCommentModel model);

	string SubmitClick(HtmlHelper html, TaskCommentModel model);
}
