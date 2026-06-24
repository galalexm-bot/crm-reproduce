using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Documents.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class DocumentAttachmentManager : EntityManager<IDocumentAttachment, long>
{
	public new static DocumentAttachmentManager Instance => Locator.GetServiceNotNull<DocumentAttachmentManager>();

	public IEnumerable<IDocumentAttachment> FindByUidArray(List<Guid> uids)
	{
		ICriteria obj = CreateCriteria();
		obj.Add((ICriterion)(object)Restrictions.In("Uid", (ICollection)uids));
		return obj.List<IDocumentAttachment>();
	}

	[PublicApiMember]
	public virtual IDocumentAttachment Create(IDocument document, IUser creationAuthor)
	{
		IDocumentAttachment documentAttachment = InterfaceActivator.Create<IDocumentAttachment>();
		documentAttachment.Document = document;
		documentAttachment.CreationAuthor = creationAuthor ?? base.AuthenticationService.GetCurrentUser<IUser>();
		documentAttachment.CreationDate = DateTime.Now;
		documentAttachment.Save();
		return documentAttachment;
	}

	[PublicApiMember]
	public virtual IDocumentAttachment Create(IDocument document)
	{
		return Create(document, null);
	}
}
