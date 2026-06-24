using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component]
internal class DocumentListener : PostFlushEventListener
{
	private readonly string nameOfVersions = LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Versions));

	private readonly string nameOfPermissions = LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Permissions));

	public static void DoReferencesUpdate(IDocument document)
	{
		IEnumerable<IDocumentReference> references = null;
		Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegiesAndWithDeleted(delegate
		{
			references = DocumentReferenceManager.Instance.GetReferences(document);
		});
		foreach (IDocumentReference item in references)
		{
			bool flag = false;
			if (!document.CreationDate.HasValue || !item.CreationDate.HasValue || item.CreationDate.Value != document.CreationDate.Value)
			{
				item.CreationDate = document.CreationDate;
				flag = true;
			}
			if (!document.ChangeDate.HasValue || !item.ChangeDate.HasValue || item.ChangeDate.Value != document.ChangeDate.Value)
			{
				item.ChangeDate = document.ChangeDate;
				flag = true;
			}
			if (item.CreationAuthor != document.CreationAuthor)
			{
				item.CreationAuthor = document.CreationAuthor;
				flag = true;
			}
			if (item.ChangeAuthor != document.ChangeAuthor)
			{
				item.ChangeAuthor = document.ChangeAuthor;
				flag = true;
			}
			if (item.UseSourceName && item.Name != document.Name)
			{
				item.Name = document.Name;
				flag = true;
			}
			if (flag)
			{
				item.Save();
			}
		}
	}

	public static void DoUpdate(IDocument document)
	{
		DoReferencesUpdate(document);
		if (document is ISendableDocument)
		{
			DocumentSendStatusCacheManager.Instance.CreateOrUpdateByDocument(document);
		}
		DocumentMetadata documentMetadata = (DocumentMetadata)MetadataLoader.LoadMetadata(document.GetType());
		if (documentMetadata != null && !string.IsNullOrEmpty(documentMetadata.TemplateName) && !documentMetadata.IsAllowRename)
		{
			IDocumentVersion currentVersion = document.CurrentVersion;
			string text2 = (document.Name = DocumentManager.Instance.GenerateName(document, (currentVersion != null && currentVersion.File != null) ? currentVersion.File.Name : "", forceGenerate: true));
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		if (!(((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IDocument document))
		{
			return;
		}
		if (document.Folder == null)
		{
			document.Folder = MyDocumentFolderManager.Instance.LoadByUser(document.CreationAuthor);
		}
		DoUpdate(document);
		if (!ElmaAgentHelper.IsRefreshCommandProcessed(document))
		{
			ElmaAgentHelper.SendRefreshCommand(document);
			int num = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.CurrentVersion)));
			if (@event.get_OldState()[num] != @event.get_State()[num])
			{
				ElmaAgentHelper.SendRefreshCommand(document.CurrentVersion);
			}
		}
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IDocument document)
		{
			ElmaAgentHelper.ProcessRefreshCommand(document);
			if (document.Folder == null)
			{
				document.Folder = MyDocumentFolderManager.Instance.LoadByUser(document.CreationAuthor);
			}
			if (document is ISendableDocument)
			{
				DocumentSendStatusCacheManager.Instance.CreateOrUpdateByDocument(document);
			}
		}
	}

	public override void OnPostUpdateCollection(PostCollectionUpdateEvent @event)
	{
		if (@event != null)
		{
			IDocument document = ((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() as IDocument;
			if (document != null && ((AbstractCollectionEvent)@event).get_Collection().get_Role() != null && ((AbstractCollectionEvent)@event).get_Collection().get_Role().EndsWith("." + nameOfVersions) && ((ICollection<IDocumentVersion>)document.Versions).Count == 0)
			{
				document.CurrentVersion = null;
			}
			if (document != null && ((AbstractCollectionEvent)@event).get_Collection().get_Role() != null && ((AbstractCollectionEvent)@event).get_Collection().get_Role().EndsWith("." + nameOfPermissions))
			{
				ElmaAgentHelper.SendDocumentPermissionsChangedCommand(document);
			}
		}
	}
}
