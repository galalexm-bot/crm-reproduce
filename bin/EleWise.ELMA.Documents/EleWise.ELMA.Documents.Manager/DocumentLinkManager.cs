using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Documents.Managers.Filters;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Documents.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class DocumentLinkManager : EntityManager<IDocumentLink, long>
{
	public new static DocumentLinkManager Instance => Locator.GetServiceNotNull<DocumentLinkManager>();

	public IEntityActionHandler EntityActionHandler { get; set; }

	[PublicApiMember]
	public override void Save(IDocumentLink obj)
	{
		bool num = obj.IsNew();
		base.Save(obj);
		if (num)
		{
			EntityActionEventArgs e = new EntityActionEventArgs(null, obj, DocumentLinkActions.UserCreateGuid);
			EntityActionHandler.ActionExecuted(e);
		}
	}

	[PublicApiMember]
	public override void Delete(IDocumentLink obj)
	{
		EntityActionEventArgs e = new EntityActionEventArgs(null, obj, DocumentLinkActions.UserDeleteGuid);
		EntityActionHandler.ActionExecuted(e);
		base.Delete(obj);
	}

	[Transaction]
	public virtual void EditSave(IDocumentLink obj)
	{
		Save(obj);
		EntityActionEventArgs e = new EntityActionEventArgs(null, obj, DocumentLinkActions.UserEditGuid);
		EntityActionHandler.ActionExecuted(e);
	}

	[Obsolete("Use GetAllLinks")]
	public virtual IEnumerable<IDocumentLink> GetAlLinks(long documentId)
	{
		return GetAllLinks(documentId);
	}

	[ContextCache]
	public virtual IEnumerable<IDocumentLink> GetAllLinks(long documentId)
	{
		return GetAllLinksCriteria(documentId).List<IDocumentLink>();
	}

	internal ICriteria GetAllLinksCriteria(long documentId)
	{
		DocumentLinkFilter filter = new DocumentLinkFilter
		{
			DisableSoftDeletable = true
		};
		return CreateCriteria(filter).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq("Document.Id", (object)documentId), (ICriterion)(object)Restrictions.Eq("LinkedDocument.Id", (object)documentId))).SetCacheRegion(base.ImplementationType.FullName + ":QueryCache").SetCacheable(true);
	}

	protected override void SetupFetchOptions(ICriteria criteria, FetchOptions fetchOptions, Type entityType)
	{
		base.SetupFetchOptions(criteria, fetchOptions, entityType);
		criteria.SetFetchMode("Document", (FetchMode)1);
		criteria.SetFetchMode("LinkedDocument", (FetchMode)1);
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (filter == null || !(filter is DocumentLinkFilter))
		{
			return;
		}
		DocumentLinkFilter documentLinkFilter = (DocumentLinkFilter)filter;
		if (documentLinkFilter.Document != null)
		{
			switch (documentLinkFilter.LinkType)
			{
			case DocumentLinkTypes.All:
				criteria.Add((ICriterion)(object)((Junction)Restrictions.Disjunction()).Add((ICriterion)(object)Restrictions.Eq("Document.Id", (object)documentLinkFilter.Document.Id)).Add((ICriterion)(object)Restrictions.Eq("LinkedDocument.Id", (object)documentLinkFilter.Document.Id)));
				break;
			case DocumentLinkTypes.InternalLinks:
				criteria.Add((ICriterion)(object)Restrictions.Eq("Document.Id", (object)documentLinkFilter.Document.Id));
				break;
			case DocumentLinkTypes.ExternalLinks:
				criteria.Add((ICriterion)(object)Restrictions.Eq("LinkedDocument.Id", (object)documentLinkFilter.Document.Id));
				break;
			}
		}
	}

	[PublicApiMember]
	[PublicApiNodeId("DocumentDocflowApi")]
	public virtual void DeleteLinks(IDocument document, IDocument linkedDocument)
	{
		if (document == null)
		{
			throw new NullReferenceException(SR.T("Документне может быть null"));
		}
		if (linkedDocument == null)
		{
			throw new NullReferenceException(SR.T("Связный документ не может быть null"));
		}
		if (document.Id != linkedDocument.Id)
		{
			((AbstractNHEntityManager<IDocumentLink, long>)Instance).Find((Expression<Func<IDocumentLink, bool>>)((IDocumentLink l) => l.Document == document && l.LinkedDocument == linkedDocument)).ToList().ForEach(delegate(IDocumentLink l)
			{
				l.Delete();
			});
			((AbstractNHEntityManager<IDocumentLink, long>)Instance).Find((Expression<Func<IDocumentLink, bool>>)((IDocumentLink l) => l.Document == linkedDocument && l.LinkedDocument == document)).ToList().ForEach(delegate(IDocumentLink l)
			{
				l.Delete();
			});
		}
	}

	[PublicApiMember]
	[PublicApiNodeId("DocumentDocflowApi")]
	public virtual IDocumentLink CreateLink(IDocument document, IDocument linkedDocument, string linkName)
	{
		if (document == null)
		{
			throw new NullReferenceException(SR.T("Документне может быть null"));
		}
		if (linkedDocument == null)
		{
			throw new NullReferenceException(SR.T("Связный документ не может быть null"));
		}
		if (document.Id == linkedDocument.Id)
		{
			throw new InvalidOperationException(SR.T("Нельзя создать связь документа на самого себя"));
		}
		IDocumentLink documentLink = InterfaceActivator.Create<IDocumentLink>();
		documentLink.CreationAuthor = base.AuthenticationService.GetCurrentUser<IUser>();
		documentLink.CreationDate = DateTime.Now;
		documentLink.Document = document;
		documentLink.LinkedDocument = linkedDocument;
		documentLink.Name = linkName;
		documentLink.Save();
		return documentLink;
	}
}
