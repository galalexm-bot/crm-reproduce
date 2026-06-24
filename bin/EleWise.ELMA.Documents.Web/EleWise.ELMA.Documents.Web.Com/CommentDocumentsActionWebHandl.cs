using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
public class CommentDocumentsActionWebHandler : ICommentActionWebHandler
{
	[Obsolete]
	[NotNull]
	public IAuthenticationService AuthenticationService { get; set; }

	public void BeforeCreateProcess(IValueProvider valueProvider, object target)
	{
		Contract.ArgumentNotNull(target, "target");
		if (!(target is TaskModel taskModel))
		{
			return;
		}
		ICommentWithDocumentsActionModel commentActionModel = taskModel.CommentActionModel as ICommentWithDocumentsActionModel;
		if (commentActionModel != null && taskModel.Entity is IAttachmentsTaskBase attachmentsTaskBase && ((IEnumerable<IDocumentAttachment>)attachmentsTaskBase.DocumentAttachments).Any())
		{
			if (commentActionModel.DocumentAttachments == null)
			{
				commentActionModel.DocumentAttachments = new List<IDocumentAttachment>();
			}
			((IEnumerable<IDocumentAttachment>)attachmentsTaskBase.DocumentAttachments).ForEach(delegate(IDocumentAttachment a)
			{
				commentActionModel.DocumentAttachments.Add(a);
			});
		}
	}
}
