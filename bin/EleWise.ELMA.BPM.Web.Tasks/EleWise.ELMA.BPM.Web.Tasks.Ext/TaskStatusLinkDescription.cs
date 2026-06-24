using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component(Order = 10)]
public class TaskStatusLinkDescription : ITaskStatusLinkDescription
{
	public bool CheckType(ITaskBase task)
	{
		return task.TypeUid == InterfaceActivator.UID<ITask>();
	}

	public MvcHtmlString Description(HtmlHelper htmlHelper, ITaskBase task)
	{
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		bool? flag = (bool?)htmlHelper.get_ViewData().get_Item("Portlet");
		ITask task2 = task as ITask;
		string innerHtml = ((flag == true) ? SR.T("Задача ({0})", PartialExtensions.Partial(htmlHelper, "DisplayTemplates/Entities/User", (object)task.CreationAuthor)) : SR.T("Задача"));
		if (task2 != null && task2.ControlUser != null && task2.UnderControl && (task2.Status == TaskBaseStatus.CompleteNeedControl || task2.Status == TaskBaseStatus.IncompleteNeedControl))
		{
			if (!task2.EndWorkDate.HasValue)
			{
				innerHtml = ((!(task2.Status == TaskBaseStatus.CompleteNeedControl)) ? ((flag == true) ? SR.T("Контроль (Невозможно выполнить, автор: {0})", PartialExtensions.Partial(htmlHelper, "DisplayTemplates/Entities/User", (object)task.CreationAuthor)) : SR.T("Контроль (Невозможно выполнить)")) : ((flag == true) ? SR.T("Контроль (Выполнено, автор: {0})", PartialExtensions.Partial(htmlHelper, "DisplayTemplates/Entities/User", (object)task.CreationAuthor)) : SR.T("Контроль (Выполнено)")));
			}
			else
			{
				string text = task2.EndWorkDate.Value.ToClientDateTime().ToCurrentFullFormat();
				innerHtml = ((!(task2.Status == TaskBaseStatus.CompleteNeedControl)) ? ((flag == true) ? SR.T("Контроль (Невозможно выполнить {0}, автор: {1})", text, PartialExtensions.Partial(htmlHelper, "DisplayTemplates/Entities/User", (object)task.CreationAuthor)) : SR.T("Контроль (Невозможно выполнить {0})", text)) : ((flag == true) ? SR.T("Контроль (Выполнено {0}, автор: {1})", text, PartialExtensions.Partial(htmlHelper, "DisplayTemplates/Entities/User", (object)task.CreationAuthor)) : SR.T("Контроль (Выполнено {0})", text)));
			}
		}
		if (task2.ControlType == TaskControlType.Current && (task2.Status == TaskBaseStatus.NewOrder || task2.Status == TaskBaseStatus.InProgress || task2.Status == TaskBaseStatus.Read || task2.Status == TaskBaseStatus.OnApprovalExecutor))
		{
			innerHtml = ((flag == true) ? SR.T("Задача (Срок: {0}, автор: {1})", task2.EndDate.DamperEndDateTime(), PartialExtensions.Partial(htmlHelper, "DisplayTemplates/Entities/User", (object)task.CreationAuthor)) : SR.T("Задача (Срок: {0})", task2.EndDate.DamperEndDateTime()));
		}
		TagBuilder val = new TagBuilder("span");
		val.set_InnerHtml(innerHtml);
		val.AddCssClass("gray_text");
		return MvcHtmlString.Create(val.ToString((TagRenderMode)0));
	}
}
