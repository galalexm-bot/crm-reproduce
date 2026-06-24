using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

public static class TaskChangeDateExtensions
{
	public static MvcHtmlString ChangePopup(this HtmlHelper html, TaskChangeModel taskChangeModel)
	{
		using (IEnumerator<ITaskActionRenderer> enumerator = (from e in ComponentManager.Current.GetExtensionPoints<ITaskActionRenderer>()
			where e.CanRender(taskChangeModel)
			select e).GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				return enumerator.Current.Render(html, taskChangeModel);
			}
		}
		return html.PopupWindow("TaskDateChangePopup", SR.T("Перенести срок выполнения задачи"), html.Url().Action("TaskDateChange", "Task", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks",
			taskId = taskChangeModel.TaskId,
			redirectUrl = taskChangeModel.RedirectUrl,
			requiredStartDate = taskChangeModel.RequiredStartDate,
			requiredEndDate = taskChangeModel.RequiredEndDate,
			hideStartDate = taskChangeModel.HideStartDate,
			hideEndDate = taskChangeModel.HideEndDate
		}), 620);
	}
}
