using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component]
public class DocumentVersionListener : PostFlushEventListener
{
	public DocumentVersionManager DocumentVersionManager { get; set; }

	public ITransformationProvider TransformationProvider { get; set; }

	public override void OnPostInsert(PostInsertEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IDocumentVersion documentVersion)
		{
			if (documentVersion.File == null && documentVersion.Content == null)
			{
				throw new Exception(SR.T("Версия должна содержать либо файл, либо содержимое HTML (name:{0},document:{1})", documentVersion.Name, (documentVersion.Document != null) ? documentVersion.Document.Id.ToString() : string.Empty));
			}
			documentVersion.Version = DocumentVersionManager.GetLastVersionDocument(documentVersion.Document) + 1;
			if (documentVersion.Status == DocumentVersionStatus.Current)
			{
				documentVersion.Document.CurrentVersion = documentVersion;
				UpdateStatuses(documentVersion);
				((ISession)(object)((AbstractEvent)@event).get_Session()).CleanUpCache(typeof(IDocumentVersion));
			}
			else
			{
				ResetCurrentVersionForDocument(documentVersion);
			}
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IDocumentVersion documentVersion)
		{
			if (documentVersion.Status == DocumentVersionStatus.Current)
			{
				documentVersion.Document.CurrentVersion = documentVersion;
				UpdateStatuses(documentVersion);
				((ISession)(object)((AbstractEvent)@event).get_Session()).CleanUpCache(typeof(IDocumentVersion));
			}
			else
			{
				ResetCurrentVersionForDocument(documentVersion);
			}
			ElmaAgentHelper.SendRefreshCommand(documentVersion);
		}
	}

	public override void OnPostUpdateCollection(PostCollectionUpdateEvent @event)
	{
		if (@event != null && ((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() is IDocumentVersion version)
		{
			ElmaAgentHelper.SendRefreshCommand(version);
		}
	}

	private static void UpdateStatuses(IDocumentVersion version)
	{
		foreach (IDocumentVersion item in ((IEnumerable<IDocumentVersion>)version.Document.Versions).Where((IDocumentVersion v) => v.Status == DocumentVersionStatus.Current && v.Id != version.Id))
		{
			item.Status = DocumentVersionStatus.Obsolete;
		}
	}

	private void ResetCurrentVersionForDocument(IDocumentVersion version)
	{
		if (version.Document != null && ((IEnumerable<IDocumentVersion>)version.Document.Versions).LastOrDefault((IDocumentVersion v) => v.Status == DocumentVersionStatus.Current) == null)
		{
			version.Document.CurrentVersion = null;
		}
	}
}
