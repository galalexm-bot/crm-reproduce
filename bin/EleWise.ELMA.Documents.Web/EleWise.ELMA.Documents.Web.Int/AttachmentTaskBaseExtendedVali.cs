using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Documents.Web.Integration.Tasks;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class AttachmentTaskBaseExtendedValidateProvider : IExtendedValidateProvider
{
	public bool CheckType(Type type)
	{
		if (typeof(ITask).IsAssignableFrom(type))
		{
			return false;
		}
		return typeof(IAttachmentsTaskBase).IsAssignableFrom(type);
	}

	public void RenderExtendedControl(HtmlHelper html, Guid actionUid, object model)
	{
		IAttachmentsTaskBase entity = (IAttachmentsTaskBase)model;
		DocumentsSettingsModule service = Locator.GetService<DocumentsSettingsModule>();
		if (service == null || service.Settings == null || !(actionUid == TaskBaseActions.RedirectGuid))
		{
			TaskViewModel validatorModel = new TaskViewModel
			{
				Entity = entity
			};
			Func<object, object> action = (dynamic m) => PartialExtensions.Partial(html, "TaskExtendedViewValidator", (object)validatorModel);
			html.RegisterContent("TaskExtendedViewValidator", action);
		}
	}

	public string SubmitClick(Guid actionUid, object model, string form, string submitFunction)
	{
		DocumentsSettingsModule service = Locator.GetService<DocumentsSettingsModule>();
		if (service != null && service.Settings != null && actionUid == TaskBaseActions.RedirectGuid)
		{
			return null;
		}
		if (model is IAttachmentsTaskBase attachmentsTaskBase && (((ICollection<IDocumentAttachment>)attachmentsTaskBase.DocumentAttachments).Count > 0 || ((ICollection<IDocumentAttachment>)attachmentsTaskBase.DocumentAttachmentsSpecified).Count > 0))
		{
			return "SendTaskReassigne(this);";
		}
		return string.Empty;
	}
}
