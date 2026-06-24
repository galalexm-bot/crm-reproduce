using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Documents.Web.Integration.Tasks;

[Component]
public class TaskDoCompleteValidator : ITaskCompleteValidator
{
	public bool CheckType(TaskCommentModel model)
	{
		if (model == null || model.ObjectTypeUid != InterfaceActivator.UID<ITask>())
		{
			return false;
		}
		_ = (IAttachmentsTaskBase)TaskManager.Instance.Load(model.ObjectId);
		if (!(model.HtmlPrefix == "DoCompleted"))
		{
			return model.HtmlPrefix == "DoInCompleted";
		}
		return true;
	}

	public void RenderExtendedControl(HtmlHelper html, TaskCommentModel model)
	{
		RenderPartialExtensions.RenderPartial(html, "AddPermissionToDocumentDoCompleteValidator");
	}

	public string SubmitClick(HtmlHelper html, TaskCommentModel model)
	{
		IAttachmentsTaskBase attachmentsTaskBase = (IAttachmentsTaskBase)TaskManager.Instance.Load(model.ObjectId);
		List<long> list = new List<long>();
		if (attachmentsTaskBase.ParentTask != null)
		{
			ITaskBase taskBase = attachmentsTaskBase.ParentTask.CastAsRealType();
			list.AddRange(new List<long>
			{
				taskBase.Executor.Id,
				taskBase.CreationAuthor.Id
			});
			if (taskBase is ITask task && task.ControlUser != null)
			{
				list.Add(task.ControlUser.Id);
			}
		}
		if (((ITask)attachmentsTaskBase).ControlUser != null)
		{
			list.Add(((ITask)attachmentsTaskBase).ControlUser.Id);
		}
		list.Add(((ITask)attachmentsTaskBase).CreationAuthor.Id);
		list = list.Distinct().ToList();
		string text = ((attachmentsTaskBase.ParentTask != null) ? SR.T("У автора или контролера выполняемой задачи или у автора, исполнителя, контролера родительской задачи нет прав доступа на некоторые документы по Вашей задаче. Если не нужно раздавать им права, снимите все галочки.") : SR.T("У автора или контролера выполняемой задачи нет прав доступа на некоторые документы по Вашей задаче. Если не нужно раздавать им права, снимите все галочки."));
		string text2 = string.Format("[{0}]", string.Join(",", list));
		string text3 = model.Id ?? html.GenerateName("model_form");
		return string.Format("elma.AddPermissionsToDocument($('#{0}'), {1}, ResolveDocuments_{4}(), '{2}', '{3}')", text3, text2, HttpUtility.UrlEncode($"elma.openPleaseWait(true);$('#{text3}').submit();"), text, model.HtmlPrefix);
	}
}
