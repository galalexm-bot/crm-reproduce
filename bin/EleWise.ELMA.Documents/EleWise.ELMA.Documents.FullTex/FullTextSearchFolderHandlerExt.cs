using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.DTO.Models;
using EleWise.ELMA.Documents.FullTextSearch.Model;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.FullTextSearch.Components;

[Component]
public class FullTextSearchFolderHandlerExtension : FullTextSearchObjectHandlerExtension
{
	private readonly Guid uid = new Guid("43B1B89A-F7ED-4D6F-823B-07AC5EEB02D2");

	private readonly List<Guid> supportedUids = new List<Guid> { InterfaceActivator.UID<IFolder>() };

	private readonly List<string> importantProperties = new List<string>
	{
		LinqUtils.NameOf((Expression<Func<IFolder, object>>)((IFolder d) => d.Folder)),
		LinqUtils.NameOf((Expression<Func<IFolder, object>>)((IFolder d) => d.Permissions)),
		LinqUtils.NameOf((Expression<Func<IFolder, object>>)((IFolder d) => d.Name))
	};

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
		KeyValuePair<string, object> keyValuePair = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, "Folder"));
		KeyValuePair<string, object> keyValuePair2 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, "Name"));
		if (mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, "Permissions")).Key != null || keyValuePair.Key != null || keyValuePair2.Key != null)
		{
			foreach (DmsObjectDTO allChild in DmsObjectManager.Instance.GetAllChilds(id))
			{
				bool flag = allChild.UserSecuritySetCacheIds.Any();
				if (flag || ((keyValuePair.Key != null || keyValuePair2.Key != null) && allChild.FolderId.HasValue))
				{
					QueueToIndex queueToIndex = new QueueToIndex
					{
						Id = allChild.Id,
						CardType = typeof(IDocumentsFullTextSearchObject),
						Properties = new List<KeyValuePair<string, object>>()
					};
					if ((keyValuePair.Key != null || keyValuePair2.Key != null) && allChild.FolderId.HasValue)
					{
						queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.FolderName)), FolderManager.Instance.GetFolderPath(allChild.FolderId.Value, convertMyDocuments: false, convertForAll: true)));
					}
					if (flag)
					{
						queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Id)), allChild.Id));
						SerializableList<object> value = new SerializableList<object>(allChild.UserSecuritySetCacheIds.Select((long p) => p.ToString()));
						queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.UserSecuritySetCacheId)), value));
					}
					if (allChild.Id == id)
					{
						queueToIndex.DynamicProperties.AddRange(mergedIndexQueueItem.Select((KeyValuePair<string, object> i) => i.Value).OfType<FieldIndexListItem>());
					}
					if (queueToIndex.Properties.Any() || queueToIndex.DynamicProperties.Any())
					{
						list.Add(queueToIndex);
					}
				}
			}
			return list;
		}
		return list;
	}
}
