using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.FullTextSearch.Model;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Manager;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.FullTextSearch.Components;

[Component]
public class FullTextSearchPermissionHandlerExtension : FullTextSearchObjectHandlerExtension
{
	private readonly Guid uid = new Guid("BFE0DE7B-3AA0-4C77-9971-E5B66749D2BE");

	private readonly List<Guid> supportedUids = new List<Guid> { InterfaceActivator.UID<IDmsObjectPermission>() };

	private readonly List<string> importantProperties = new List<string>();

	public IContextBoundVariableService ContextCacheService { get; set; }

	public IndexQueueManager IndexQueueManager { get; set; }

	public override Guid Uid => uid;

	public override Type SupportedCard => typeof(IDocumentsFullTextSearchObject);

	public override List<Guid> SupportedUids => supportedUids;

	public override List<string> GetImportantProperties
	{
		get
		{
			DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
			if (serviceNotNull.Settings == null || !serviceNotNull.Settings.Indexing)
			{
				return new List<string>();
			}
			return importantProperties;
		}
	}

	public override List<QueueToIndex> ProcessingMergedIndexQueue(List<KeyValuePair<string, object>> mergedIndexQueueItem, long id, Guid typeUid)
	{
		List<QueueToIndex> list = new List<QueueToIndex>();
		if (mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, "Insert021AF042C3F4450EBE4D49B1A53FF502")).Key != null)
		{
			IDmsObjectPermission dmsObjectPermission = EntityManager<IDmsObjectPermission>.Instance.LoadOrNull(id);
			if (dmsObjectPermission != null && dmsObjectPermission.DmsObject != null)
			{
				IDmsObject dmsObject = dmsObjectPermission.DmsObject;
				if (((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).Any())
				{
					QueueToIndex queueToIndex = new QueueToIndex
					{
						Id = dmsObject.Id,
						CardType = typeof(IDocumentsFullTextSearchObject),
						Properties = new List<KeyValuePair<string, object>>()
					};
					queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Id)), id));
					queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.UserSecuritySetCacheId)), ((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).Select((IDmsObjectPermission p) => p.UserSecuritySetCacheId.ToString()).ToArray()));
					if (queueToIndex.Properties.Any())
					{
						list.Add(queueToIndex);
					}
				}
			}
		}
		return list;
	}

	private void ProcessPermission(IDmsObjectPermission perm)
	{
		if (perm != null && perm.DmsObject != null)
		{
			IDmsObject dmsObject = perm.DmsObject;
			Guid objectTypeUid = ((ClassMetadata)MetadataLoader.LoadMetadata(dmsObject.GetType())).Uid;
			List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
			KeyValuePair<string, object> item = new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.Permissions)), null);
			list.Add(item);
			IIndexQueue item2 = IndexQueueManager.CreateReindexObjectPartItem(typeof(IDocumentsFullTextSearchObject), dmsObject.Id, objectTypeUid, list);
			ContextCacheService.GetOrAdd(IndexQueueManager.IndexQueueListContextKeyConst, () => new List<IIndexQueue>()).Add(item2);
		}
	}

	public override void OnInsertProcessing(Guid typeUid, object obj)
	{
		DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
		if (serviceNotNull.Settings != null && serviceNotNull.Settings.Indexing)
		{
			IDmsObjectPermission perm = obj as IDmsObjectPermission;
			ProcessPermission(perm);
		}
	}

	public override void OnDeleteProcessing(Guid typeUid, object obj)
	{
		DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
		if (serviceNotNull.Settings != null && serviceNotNull.Settings.Indexing)
		{
			IDmsObjectPermission perm = obj as IDmsObjectPermission;
			ProcessPermission(perm);
		}
	}
}
