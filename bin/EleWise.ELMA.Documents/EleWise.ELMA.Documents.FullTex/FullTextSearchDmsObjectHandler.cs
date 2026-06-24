using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.FullTextSearch.Model;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.FullTextSearch.Components;

[Component]
public class FullTextSearchDmsObjectHandlerExtension : FullTextSearchObjectHandlerExtension
{
	private readonly Guid uid = new Guid("1EFDF203-E1E7-410D-B552-072F0B11EBEB");

	private DmsObjectManager dmsObjectManager;

	private readonly List<Guid> supportedUids = new List<Guid> { InterfaceActivator.UID<IDmsObject>() };

	private readonly List<string> importantProperties = new List<string>
	{
		LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.Id)),
		LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.Name)),
		LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.CreationAuthor)),
		LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.CreationDate)),
		LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.ChangeDate)),
		LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.TypeUid)),
		LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.Permissions)),
		LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.Folder)),
		LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.IsDeleted)),
		LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.IsArchived))
	};

	private readonly List<string> visualDataProperties = new List<string>
	{
		LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.Name)),
		LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.Folder)),
		LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.IsDeleted)),
		LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.IsArchived))
	};

	public DmsObjectManager DmsObjectManager => dmsObjectManager ?? (dmsObjectManager = Locator.GetServiceNotNull<DmsObjectManager>());

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

	public override List<string> GetVisualDataProperties
	{
		get
		{
			DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
			if (serviceNotNull.Settings == null || !serviceNotNull.Settings.Indexing)
			{
				return new List<string>();
			}
			return visualDataProperties;
		}
	}

	public override List<QueueToIndex> ProcessingMergedIndexQueue(List<KeyValuePair<string, object>> mergedIndexQueueItem, long id, Guid typeUid)
	{
		List<QueueToIndex> list = new List<QueueToIndex>();
		if (mergedIndexQueueItem != null)
		{
			QueueToIndex queueToIndex = new QueueToIndex
			{
				Id = id,
				CardType = typeof(IDocumentsFullTextSearchObject),
				Properties = new List<KeyValuePair<string, object>>()
			};
			KeyValuePair<string, object> keyValuePair = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.Id))));
			if (keyValuePair.Key != null)
			{
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Id)), keyValuePair.Value));
			}
			KeyValuePair<string, object> keyValuePair2 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.Name))));
			if (keyValuePair2.Key != null)
			{
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Name)), keyValuePair2.Value));
			}
			KeyValuePair<string, object> keyValuePair3 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.TypeUid))));
			if (keyValuePair3.Key != null)
			{
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.TypeUid)), keyValuePair3.Value));
			}
			KeyValuePair<string, object> keyValuePair4 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.IsDeleted))));
			if (keyValuePair4.Key != null)
			{
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.IsDeleted)), keyValuePair4.Value));
			}
			KeyValuePair<string, object> keyValuePair5 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.IsArchived))));
			if (keyValuePair5.Key != null)
			{
				bool result;
				if (keyValuePair5.Value == null)
				{
					result = false;
				}
				else
				{
					bool.TryParse(keyValuePair5.Value.ToString(), out result);
				}
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.IsArchived)), result));
			}
			KeyValuePair<string, object> keyValuePair6 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.CreationAuthor))));
			if (keyValuePair6.Key != null)
			{
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CreationAuthorId)), keyValuePair6.Value));
				if (keyValuePair6.Value != null && long.TryParse(keyValuePair6.Value.ToString(), out var result2))
				{
					IUser user = UserManager.Instance.LoadOrNull(result2);
					if (user != null)
					{
						queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CreationAuthor)), user.FullName));
					}
				}
				else
				{
					queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CreationAuthor)), ""));
				}
			}
			if (mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.Permissions)))).Key != null)
			{
				SerializableList<object> value = new SerializableList<object>(DmsObjectManager.GetUserSecuritySetCacheHasViewAccess(id).Cast<object>().ToArray());
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.UserSecuritySetCacheId)), value));
			}
			queueToIndex.DynamicProperties.AddRange(mergedIndexQueueItem.Select((KeyValuePair<string, object> i) => i.Value).OfType<FieldIndexListItem>());
			if (queueToIndex.Properties.Any() || queueToIndex.DynamicProperties.Any())
			{
				list.Add(queueToIndex);
			}
		}
		return list;
	}
}
