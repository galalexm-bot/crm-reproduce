using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.FullTextSearch.Model;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Extensions;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.FullTextSearch.Components;

[Component]
public class FullTextSearchDocumentHandlerExtension : FullTextSearchObjectHandlerExtension
{
	private readonly Guid uid = new Guid("59D01D9E-78C8-46D3-B593-A50A8D3EDE42");

	private DmsObjectManager dmsObjectManager;

	private readonly List<Guid> supportedUids = new List<Guid> { InterfaceActivator.UID<IDocument>() };

	private readonly List<string> importantProperties = new List<string>
	{
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Id)),
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Name)),
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.CreationAuthor)),
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.CreationDate)),
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.ChangeDate)),
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.TypeUid)),
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Permissions)),
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Folder)),
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.IsDeleted)),
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Versions)),
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.CurrentVersion)),
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.IsArchived)),
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Encrypt))
	};

	private readonly List<string> visualDataProperties = new List<string>
	{
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Name)),
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Folder)),
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.IsDeleted)),
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.IsArchived)),
		LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.CurrentVersion))
	};

	private DmsObjectManager DmsObjectManager => dmsObjectManager ?? (dmsObjectManager = Locator.GetServiceNotNull<DmsObjectManager>());

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
			KeyValuePair<string, object> keyValuePair = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Id))));
			if (keyValuePair.Key != null)
			{
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Id)), keyValuePair.Value));
			}
			bool? flag = null;
			KeyValuePair<string, object> keyValuePair2 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Encrypt))));
			if (keyValuePair2.Key != null)
			{
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.IsEncrypt)), keyValuePair2.Value));
				if (keyValuePair2.Value != null && bool.TryParse(keyValuePair2.Value.ToString(), out var result))
				{
					flag = result;
				}
			}
			KeyValuePair<string, object> keyValuePair3 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Name))));
			if (keyValuePair3.Key != null)
			{
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Name)), keyValuePair3.Value));
			}
			KeyValuePair<string, object> keyValuePair4 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.CreationDate))));
			if (keyValuePair4.Key != null)
			{
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CreationDate)), keyValuePair4.Value));
			}
			KeyValuePair<string, object> keyValuePair5 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.ChangeDate))));
			if (keyValuePair5.Key != null)
			{
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.ChangeDate)), keyValuePair5.Value));
			}
			KeyValuePair<string, object> keyValuePair6 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.TypeUid))));
			if (keyValuePair6.Key != null)
			{
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.TypeUid)), keyValuePair6.Value));
			}
			KeyValuePair<string, object> keyValuePair7 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.IsDeleted))));
			if (keyValuePair7.Key != null)
			{
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.IsDeleted)), keyValuePair7.Value));
			}
			KeyValuePair<string, object> keyValuePair8 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.IsArchived))));
			if (keyValuePair8.Key != null)
			{
				bool result2;
				if (keyValuePair8.Value == null)
				{
					result2 = false;
				}
				else
				{
					bool.TryParse(keyValuePair8.Value.ToString(), out result2);
				}
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.IsArchived)), result2));
			}
			DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
			if (flag == true || serviceNotNull.Settings == null || !serviceNotNull.Settings.IndexingVersion)
			{
				SerializableList<object> value = new SerializableList<object>(new List<string>());
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Versions)), value));
			}
			KeyValuePair<string, object> keyValuePair9 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.CurrentVersion))));
			if (keyValuePair9.Key != null)
			{
				if (keyValuePair9.Value != null && long.TryParse(keyValuePair9.Value.ToString(), out var result3))
				{
					IDocumentVersion documentVersion = DocumentVersionManager.Instance.LoadOrNull(result3);
					if (documentVersion != null)
					{
						queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CurrentVersionId)), result3));
						if (documentVersion.File != null)
						{
							queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CurrentVersionFile)), documentVersion.File.Id));
						}
					}
				}
				else
				{
					queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CurrentVersionId)), "0"));
					queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CurrentVersionFile)), "0"));
				}
			}
			KeyValuePair<string, object> keyValuePair10 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Folder))));
			if (keyValuePair10.Key != null)
			{
				if (keyValuePair10.Value != null && long.TryParse(keyValuePair10.Value.ToString(), out var result4))
				{
					IFolder folder = FolderManager.Instance.LoadOrNull(result4);
					if (folder != null)
					{
						queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.FolderName)), FolderManager.Instance.GetFolderPathWithMyDocuments(folder)));
					}
				}
				else
				{
					queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.FolderName)), ""));
				}
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.FolderId)), keyValuePair10.Value));
			}
			KeyValuePair<string, object> keyValuePair11 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.CreationAuthor))));
			if (keyValuePair11.Key != null)
			{
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CreationAuthorId)), keyValuePair11.Value));
				if (keyValuePair11.Value != null && long.TryParse(keyValuePair11.Value.ToString(), out var result5))
				{
					IUser user = UserManager.Instance.LoadOrNull(result5);
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
			if (mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Permissions)))).Key != null)
			{
				SerializableList<object> value2 = new SerializableList<object>(DmsObjectManager.GetUserSecuritySetCacheHasViewAccess(id).Cast<object>().ToArray());
				queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.UserSecuritySetCacheId)), value2));
			}
			KeyValuePair<string, object> keyValuePair12 = mergedIndexQueueItem.Find((KeyValuePair<string, object> p) => object.Equals(p.Key, LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.CurrentVersion))));
			if (keyValuePair12.Key != null)
			{
				DocumentsFullTextSearchSettingsModule serviceNotNull2 = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
				if (keyValuePair12.Value != null && serviceNotNull2.Settings != null && serviceNotNull2.Settings.IndexingVersion)
				{
					List<string> list2 = new List<string>();
					long.TryParse(keyValuePair12.Value.ToString(), out var result6);
					IDocumentVersion documentVersion2 = DocumentVersionManager.Instance.LoadOrNull(result6);
					if (documentVersion2 != null && documentVersion2.File != null && documentVersion2.Status == DocumentVersionStatus.Current && Locator.GetServiceNotNull<IFilePreviewService>().IsSupportPreview(documentVersion2.File))
					{
						try
						{
							string text = HighlightsHelper.CutHtmlTags(documentVersion2.File);
							if (!string.IsNullOrWhiteSpace(text))
							{
								list2.Add(text);
							}
						}
						catch (PreviewTextFileDoNotExistException)
						{
						}
						catch (Exception)
						{
						}
					}
					if (documentVersion2 != null && documentVersion2.Content != null)
					{
						string text2 = documentVersion2.Content.ToString();
						if (!string.IsNullOrWhiteSpace(text2))
						{
							list2.Add(HighlightsHelper.CutHtmlTags(text2, isHtml: true));
						}
					}
					SerializableList<object> value3 = new SerializableList<object>(list2);
					list2.Add("");
					queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Versions)), value3));
				}
				else
				{
					SerializableList<object> value4 = new SerializableList<object>(new List<string>());
					queueToIndex.Properties.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Versions)), value4));
				}
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
