using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 10)]
public class TasksReplacementEditView : ReplacementEditViewBase
{
	public static string PanelId = "replacementEditTasks";

	public override string Id => PanelId;

	public override string Name => SR.T("Задачи");

	public override MvcHtmlString Render(HtmlHelper html, ReplacementModel model)
	{
		if (model == null)
		{
			return MvcHtmlString.Empty;
		}
		if (model.Replacement is IReplacementExtension replacementExtension)
		{
			if (model.Replacement.IsNew())
			{
				replacementExtension.TasksDistributer = model.Replacement.SourceUser;
			}
			return PartialExtensions.Partial(html, "Replacement/TasksReplacementProperties", (object)new ReplacementExtensionModel
			{
				Replacement = replacementExtension
			});
		}
		return MvcHtmlString.Empty;
	}
}
