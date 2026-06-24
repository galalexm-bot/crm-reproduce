using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
internal sealed class DocumentAttachmentsSpecifiedActionWebHandler : ICommentActionWebHandler
{
	private readonly IAuthenticationService authenticationService;

	public DocumentAttachmentsSpecifiedActionWebHandler(IAuthenticationService authenticationService)
	{
		this.authenticationService = authenticationService;
	}

	public void BeforeCreateProcess(IValueProvider valueProvider, object target)
	{
		if (!(target is TaskModel taskModel))
		{
			return;
		}
		ValueProviderResult value = valueProvider.GetValue("DocumentId");
		if (value == null || !(taskModel.Entity is IAttachmentsTaskBase attachmentsTaskBase))
		{
			return;
		}
		string[] array = value.get_AttemptedValue().Replace(" ", string.Empty).Split(',');
		for (int i = 0; i < array.Length; i++)
		{
			if (long.TryParse(array[i], out var result))
			{
				IDocument document = DocumentManager.Instance.Load(result);
				InstanceOf<IDocumentAttachment> instanceOf = new InstanceOf<IDocumentAttachment>();
				instanceOf.New.Document = document;
				instanceOf.New.CreationDate = DateTime.Now;
				instanceOf.New.CreationAuthor = authenticationService.GetCurrentUser<IUser>();
				IDocumentAttachment @new = instanceOf.New;
				attachmentsTaskBase.DocumentAttachmentsSpecified.Add(@new);
			}
		}
		if (((ICollection<IDocumentAttachment>)attachmentsTaskBase.DocumentAttachmentsSpecified).Count == 1)
		{
			taskModel.Entity.Subject = ((IEnumerable<IDocumentAttachment>)attachmentsTaskBase.DocumentAttachmentsSpecified).First().Document.Name;
		}
	}
}
