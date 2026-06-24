using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.FullTextSearch.Model;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Types;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.FullTextSearch.Components;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Exceptions;
using EleWise.ELMA.FullTextSearch.Extensions;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Documents.FullTextSearch.Components;

[Component]
internal class DocumentsFullTextSearchExtension : ModuleFullTextSearchExtension
{
	private FolderManager folderManager;

	private IAuthenticationService authenticationService;

	private IFilePreviewService filePreviewService;

	private DmsObjectManager dmsObjectManager;

	private ISecurityService securityService;

	private ITransformationProvider transformationProvider;

	private ISessionProvider sessionProvider;

	private IFullTextSearchDescriptorService fullTextSearchDescriptorService;

	public static Guid DocumentCardUid = Guid.Parse("7B5849F3-F947-4B05-A171-8453B8DA95FC");

	private FolderManager FolderManager => folderManager ?? (folderManager = Locator.GetServiceNotNull<FolderManager>());

	private IAuthenticationService AuthenticationService => authenticationService ?? (authenticationService = Locator.GetServiceNotNull<IAuthenticationService>());

	private IFilePreviewService FilePreviewService => filePreviewService ?? (filePreviewService = Locator.GetServiceNotNull<IFilePreviewService>());

	private DmsObjectManager DmsObjectManager => dmsObjectManager ?? (dmsObjectManager = Locator.GetServiceNotNull<DmsObjectManager>());

	private ISecurityService SecurityService => securityService ?? (securityService = Locator.GetServiceNotNull<ISecurityService>());

	private ITransformationProvider TransformationProvider => transformationProvider ?? (transformationProvider = Locator.GetServiceNotNull<ITransformationProvider>());

	private ISessionProvider SessionProvider => sessionProvider ?? (sessionProvider = Locator.GetServiceNotNull<ISessionProvider>());

	private IFullTextSearchDescriptorService FullTextSearchDescriptorService => fullTextSearchDescriptorService ?? (fullTextSearchDescriptorService = Locator.GetServiceNotNull<IFullTextSearchDescriptorService>());

	public override IGlobalSettingsModule SettingModule => Locator.GetService<DocumentsFullTextSearchSettingsModule>();

	public override FieldIndexList MappingFields(Type cardType)
	{
		if (cardType != null && typeof(IDocumentsFullTextSearchObject) == cardType)
		{
			ClassMetadata metadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeof(IDmsObject));
			FieldIndexList fieldIndexList = DmsObjectConstMappingFields();
			fieldIndexList.AddRange(MappingFields(metadata));
			return fieldIndexList;
		}
		return new FieldIndexList();
	}

	private FieldIndexList DmsObjectConstMappingFields()
	{
		return new FieldIndexList
		{
			new FieldIndexListItem("ChangeDate", null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem("CreationAuthor", null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem("CreationAuthorId", null, FullTextFieldType.Long, FullTextFieldTag.Keyword),
			new FieldIndexListItem("CreationDate", null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem("CurrentVersionFile", null, FullTextFieldType.String, FullTextFieldTag.Keyword),
			new FieldIndexListItem("CurrentVersionId", null, FullTextFieldType.Long, FullTextFieldTag.Keyword),
			new FieldIndexListItem("FolderId", null, FullTextFieldType.Long, FullTextFieldTag.Keyword),
			new FieldIndexListItem("FolderName", null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem("Id", null, FullTextFieldType.String, FullTextFieldTag.Keyword),
			new FieldIndexListItem("IsArchived", null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem("IsDeleted", null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem("IsEncrypt", null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem("Name", null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem("TypeUid", null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem("UserSecuritySetCacheId", null, FullTextFieldType.String, FullTextFieldTag.Value)
		};
	}

	public override Dictionary<string, string> GetReverseMapping(Type cardType)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		if (cardType != null && typeof(IDocumentsFullTextSearchObject) == cardType)
		{
			dictionary.Add("Name", SR.T("Название"));
			dictionary.Add("CreationAuthor", SR.T("Автор"));
			dictionary.Add("Versions", SR.T("Текущая версия"));
			dictionary.Add("FolderName", SR.T("Путь"));
		}
		return dictionary;
	}

	public override Dictionary<string, long> GetHighlightsOrder(Type cardType)
	{
		Dictionary<string, long> dictionary = new Dictionary<string, long>();
		if (cardType != null && typeof(IDocumentsFullTextSearchObject) == cardType)
		{
			dictionary.Add("Name", 100L);
			dictionary.Add("FolderName", 200L);
			dictionary.Add("CreationAuthor", 300L);
			dictionary.Add("Versions", 1000000L);
		}
		return dictionary;
	}

	public override List<KeyValuePair<Type, Guid>> GetSupportedCardTypes(bool checkSettings = true)
	{
		if (checkSettings && (!(SettingModule is DocumentsFullTextSearchSettingsModule documentsFullTextSearchSettingsModule) || documentsFullTextSearchSettingsModule.Settings == null || !documentsFullTextSearchSettingsModule.Settings.Indexing))
		{
			return new List<KeyValuePair<Type, Guid>>();
		}
		return new List<KeyValuePair<Type, Guid>>
		{
			new KeyValuePair<Type, Guid>(typeof(IDocumentsFullTextSearchObject), DocumentCardUid)
		};
	}

	public override Type GetSupportedCardType(Guid cardUid)
	{
		if (cardUid.Equals(DocumentCardUid))
		{
			return typeof(IDocumentsFullTextSearchObject);
		}
		return null;
	}

	public override Guid? GetSupportedCardType(Type cardType)
	{
		if (cardType == typeof(IDocumentsFullTextSearchObject))
		{
			return DocumentCardUid;
		}
		return null;
	}

	public override Type GetSupportedCardTypeByTypeUid(Guid objectTypeUid)
	{
		if (!(SettingModule is DocumentsFullTextSearchSettingsModule documentsFullTextSearchSettingsModule) || documentsFullTextSearchSettingsModule.Settings == null || !documentsFullTextSearchSettingsModule.Settings.Indexing)
		{
			return null;
		}
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadataOrNull(objectTypeUid);
		Guid docUid = InterfaceActivator.UID<IDmsObject>();
		if (classMetadata != null && (classMetadata.Uid == docUid || MetadataLoader.GetBaseClasses(classMetadata).Any((ClassMetadata m) => m != null && m.Uid == docUid)))
		{
			return typeof(IDocumentsFullTextSearchObject);
		}
		return null;
	}

	public override Type GetSupportedCardTypeByObject(object obj)
	{
		if (!(SettingModule is DocumentsFullTextSearchSettingsModule documentsFullTextSearchSettingsModule) || documentsFullTextSearchSettingsModule.Settings == null || !documentsFullTextSearchSettingsModule.Settings.Indexing)
		{
			return null;
		}
		if (obj is IDmsObject)
		{
			return typeof(IDocumentsFullTextSearchObject);
		}
		return null;
	}

	public override Dictionary<Type, Dictionary<Guid, List<string>>> GetDynamicFieldsMapping()
	{
		ClassMetadata classMd = (ClassMetadata)MetadataLoader.LoadMetadata(typeof(IDmsObject));
		Dictionary<Guid, List<string>> value = ProcessingDynamicFieldsMapping(classMd);
		return new Dictionary<Type, Dictionary<Guid, List<string>>> { 
		{
			typeof(IDocumentsFullTextSearchObject),
			value
		} };
	}

	public override List<string> GetHighlightFields(Type cardType)
	{
		if (cardType != null && typeof(IDocumentsFullTextSearchObject) == cardType)
		{
			DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
			List<string> list;
			if (serviceNotNull.Settings != null && !serviceNotNull.Settings.IndexingVersion)
			{
				list = new List<string>();
				list.Add(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Name)));
				list.Add(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CreationAuthor)));
				list.Add(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.FolderName)));
				return list;
			}
			list = new List<string>();
			list.Add(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Name)));
			list.Add(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CreationAuthor)));
			list.Add(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Versions)));
			list.Add(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.FolderName)));
			return list;
		}
		return new List<string>();
	}

	public override List<string> GetFields(Type cardType)
	{
		if (cardType != null && typeof(IDocumentsFullTextSearchObject) == cardType)
		{
			List<string> fields = base.GetFields(cardType);
			fields.AddRange(new List<string>
			{
				LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Name)),
				LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CreationAuthor)),
				LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CreationAuthorId)),
				LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CreationDate)),
				LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.ChangeDate)),
				LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CurrentVersionId)),
				LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CurrentVersionFile)),
				LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.IsArchived)),
				LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.FolderName)),
				LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.FolderId))
			});
			return fields;
		}
		return new List<string>();
	}

	public override List<string> GetSearchFields(Type cardType)
	{
		if (cardType != null && typeof(IDocumentsFullTextSearchObject) == cardType)
		{
			List<string> searchFields = base.GetSearchFields(cardType);
			DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
			if (serviceNotNull.Settings == null || serviceNotNull.Settings.IndexingVersion)
			{
				searchFields.AddRange(new List<string>
				{
					LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Name)),
					LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CreationAuthor)),
					LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Versions)),
					LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.FolderName))
				});
			}
			else
			{
				searchFields.AddRange(new List<string>
				{
					LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Name)),
					LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CreationAuthor)),
					LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.FolderName))
				});
			}
			return searchFields;
		}
		return new List<string>();
	}

	public override List<string> GetSearchFields(Type cardType, IEntityFilter filter)
	{
		if (cardType != null && typeof(IDocumentsFullTextSearchObject) == cardType)
		{
			List<string> searchFields = base.GetSearchFields(cardType);
			DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
			if ((serviceNotNull.Settings == null || serviceNotNull.Settings.IndexingVersion) && (filter == null || filter.FullTextInAttachments))
			{
				searchFields.AddRange(new List<string>
				{
					LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Name)),
					LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CreationAuthor)),
					LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Versions)),
					LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.FolderName))
				});
			}
			else
			{
				searchFields.AddRange(new List<string>
				{
					LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Name)),
					LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CreationAuthor)),
					LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.FolderName))
				});
			}
			return searchFields;
		}
		return new List<string>();
	}

	public override Dictionary<string, Weight> GetWeightSearchFields(Type cardType)
	{
		Dictionary<string, Weight> dictionary = new Dictionary<string, Weight>();
		if (cardType != null && typeof(IDocumentsFullTextSearchObject) == cardType)
		{
			dictionary.Add(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Name)), Weight.High);
		}
		return dictionary;
	}

	public override FilterList GetFilterFields(Type cardType, FullTextSearchResultModel searchModel)
	{
		if (cardType != null && typeof(IDocumentsFullTextSearchObject) == cardType)
		{
			FilterList filterList = new FilterList();
			if (searchModel is DocumentFullTextSearchResultModel documentFullTextSearchResultModel && documentFullTextSearchResultModel.TypeUid != Guid.Empty && MetadataLoader.LoadMetadata(documentFullTextSearchResultModel.TypeUid) is ClassMetadata classMetadata)
			{
				List<ClassMetadata> list = (from c in MetadataLoader.GetChildClasses(classMetadata)
					where c != null
					select c).ToList();
				list.Add(classMetadata);
				List<object> list2 = new List<object>();
				list2.AddRange(list.Select((ClassMetadata c) => c.Uid.ToString("n")));
				filterList.Add(new FilterListItem(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.TypeUid)), list2, FilterListItemType.Must, FullTextFieldType.String));
			}
			EleWise.ELMA.Security.Models.IUser user = AuthenticationService.GetCurrentUser() as EleWise.ELMA.Security.Models.IUser;
			if (!(user.Uid == SecurityConstants.AdminUserUid) && !SecurityService.HasPermission(user, PermissionProvider.DocumentsFullAccessToAllObjectsPermission))
			{
				string sql = string.Format("SELECT DISTINCT usc.{1} as {1} FROM {0} WHERE (usc.{2} = {3})", TransformationProvider.NoLockTableExpression("UserSecuritySetCache", "usc"), TransformationProvider.Dialect.QuoteIfNeeded("SetId"), TransformationProvider.Dialect.QuoteIfNeeded("UserId"), user.GetId());
				List<string> list3 = new List<string>();
				using (IDataReader dataReader = TransformationProvider.ExecuteQuery(sql))
				{
					while (dataReader.Read())
					{
						if (!(dataReader["SetId"] is DBNull))
						{
							string item = Convert.ToString(dataReader["SetId"]);
							if (!list3.Contains(item))
							{
								list3.Add(item);
							}
						}
					}
				}
				List<object> list4 = new List<object>();
				list4.AddRange(list3.ToList());
				filterList.Add(new FilterListItem(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.UserSecuritySetCacheId)), list4, FilterListItemType.Must, FullTextFieldType.String));
			}
			DocumentFullTextSearchResultModel documentFullTextSearchResultModel2 = searchModel as DocumentFullTextSearchResultModel;
			if (documentFullTextSearchResultModel2 != null && documentFullTextSearchResultModel2.SearchFolder != null)
			{
				List<long> list5 = new List<long>();
				if (documentFullTextSearchResultModel2.HierarchicalByFolder.HasValue && documentFullTextSearchResultModel2.HierarchicalByFolder.Value)
				{
					list5 = FolderManager.GetAllSubFoldersId(documentFullTextSearchResultModel2.SearchFolder.Id).ToList();
				}
				else
				{
					list5.Add(documentFullTextSearchResultModel2.SearchFolder.Id);
				}
				List<object> list6 = new List<object>();
				list6.AddRange(((IEnumerable<long>)list5).Select((Func<long, object>)((long f) => f)).ToList());
				filterList.Add(new FilterListItem(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.FolderId)), list6, FilterListItemType.Must, FullTextFieldType.Long));
			}
			filterList.Add(new FilterListItem(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.IsDeleted)), new List<object> { "false" }, FilterListItemType.Must, FullTextFieldType.String));
			filterList.Add(new FilterListItem(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.IsEncrypt)), new List<object> { "false" }, FilterListItemType.Must, FullTextFieldType.String));
			if (documentFullTextSearchResultModel2 != null)
			{
				if (documentFullTextSearchResultModel2.IsArchived == true)
				{
					filterList.Add(new FilterListItem(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.IsArchived)), new List<object> { "true" }, FilterListItemType.Must, FullTextFieldType.String));
				}
				if (documentFullTextSearchResultModel2.IsArchived == false)
				{
					filterList.Add(new FilterListItem(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.IsArchived)), new List<object> { "false", "" }, FilterListItemType.Must, FullTextFieldType.String));
				}
				if (!documentFullTextSearchResultModel2.IsArchived.HasValue && (documentFullTextSearchResultModel2.DisableArchive == false || !documentFullTextSearchResultModel2.DisableArchive.HasValue))
				{
					filterList.Add(new FilterListItem(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.IsArchived)), new List<object> { "false", "" }, FilterListItemType.Must, FullTextFieldType.String));
				}
			}
			return filterList;
		}
		return new FilterList();
	}

	public override FilterList GetCustomFilterFields(Type cardType, FilterProperty filterProperty, FullTextSearchResultModel searchModel)
	{
		FilterList customFilterFields = base.GetCustomFilterFields(cardType, filterProperty, searchModel);
		if (customFilterFields != null)
		{
			return customFilterFields;
		}
		if (cardType != null && typeof(IDocumentsFullTextSearchObject) == cardType && filterProperty != null)
		{
			if (InterfaceActivator.LoadPropertyMetadata((IDmsObjectFilter m) => m.HierarchicalByFolder).Uid == filterProperty.Uid)
			{
				if (filterProperty.Value == null || (bool.TryParse(filterProperty.Value.ToString(), out var result) && !result))
				{
					return new FilterList();
				}
				return null;
			}
			if (InterfaceActivator.LoadPropertyMetadata((IDmsObjectFilter m) => m.DisableArchive).Uid == filterProperty.Uid)
			{
				if (searchModel is DocumentFullTextSearchResultModel documentFullTextSearchResultModel)
				{
					if (filterProperty.Value != null && bool.TryParse(filterProperty.Value.ToString(), out var result2))
					{
						documentFullTextSearchResultModel.DisableArchive = result2;
					}
					else
					{
						documentFullTextSearchResultModel.DisableArchive = null;
					}
					return new FilterList();
				}
				return null;
			}
			if (InterfaceActivator.LoadPropertyMetadata((IDocumentFilter m) => m.SendInfo).Uid == filterProperty.Uid)
			{
				SendInfoWrapper sendInfoWrapper = filterProperty.Value as SendInfoWrapper;
				if (filterProperty.Value == null || sendInfoWrapper == null || sendInfoWrapper.Info == null)
				{
					return new FilterList();
				}
				SendInfo info = sendInfoWrapper.Info;
				if (info.SendStatus.HasValue || info.SendUser != null || info.SendDocumentType != null || !string.IsNullOrEmpty(info.SendNumber))
				{
					return null;
				}
				if (info.SendDate != null)
				{
					DateTimeRange dateTimeRange = new DateTimeRange(info.SendDate.FromValue, info.SendDate.ToValue);
					if (dateTimeRange.From.HasValue || dateTimeRange.To.HasValue)
					{
						return null;
					}
				}
				return new FilterList();
			}
			if (InterfaceActivator.LoadPropertyMetadata((IDmsObjectFilter m) => m.ReturnOnlyDocuments).Uid == filterProperty.Uid)
			{
				if (filterProperty.Value == null || (bool.TryParse(filterProperty.Value.ToString(), out var result3) && !result3))
				{
					return new FilterList();
				}
				return null;
			}
			if (InterfaceActivator.LoadPropertyMetadata((IEntityFilter m) => m.PermissionId).Uid == filterProperty.Uid)
			{
				if (filterProperty.Value == null || (Guid.TryParse(filterProperty.Value.ToString(), out var result4) && result4 == PermissionProvider.DocumentViewPermission.Id))
				{
					return new FilterList();
				}
				return null;
			}
			if (InterfaceActivator.LoadPropertyMetadata((IDmsObjectFilter m) => m.SearchAlsoEncrypted).Uid == filterProperty.Uid)
			{
				if (filterProperty.Value == null || (bool.TryParse(filterProperty.Value.ToString(), out var result5) && !result5))
				{
					return new FilterList();
				}
				return null;
			}
		}
		return null;
	}

	public override FilterList GetAutoFilterFields(Type cardType, FilterProperty filterProperty, FullTextSearchResultModel searchModel)
	{
		if (searchModel is DocumentFullTextSearchResultModel documentFullTextSearchResultModel && cardType != null && typeof(IDocumentsFullTextSearchObject) == cardType && filterProperty != null && InterfaceActivator.LoadPropertyMetadata((IDmsObjectFilter m) => m.IsArchived).Uid == filterProperty.Uid)
		{
			if (filterProperty.Value != null && bool.TryParse(filterProperty.Value.ToString(), out var result))
			{
				documentFullTextSearchResultModel.IsArchived = result;
			}
			else
			{
				documentFullTextSearchResultModel.IsArchived = null;
			}
			return new FilterList();
		}
		return null;
	}

	public override void FillObject(Type cardType, IFullTextSearchObjectContainer obj, IEntity entity)
	{
		if (!(cardType != null) || !(typeof(IDocumentsFullTextSearchObject) == cardType))
		{
			return;
		}
		SecurityService.RunBySystemUser(delegate
		{
			SecurityService.RunWithElevatedPrivilegies(delegate
			{
				if (entity is IDocument document)
				{
					if (obj.SearchObject is IDocumentsFullTextSearchObject documentsFullTextSearchObject)
					{
						obj.IndexedObject = document;
						documentsFullTextSearchObject.Id = document.Id.ToString(CultureInfo.InvariantCulture);
						documentsFullTextSearchObject.Name = document.Name;
						if (document.CreationAuthor != null)
						{
							documentsFullTextSearchObject.CreationAuthor = document.CreationAuthor.FullName;
							documentsFullTextSearchObject.CreationAuthorId = document.CreationAuthor.Id;
						}
						else
						{
							documentsFullTextSearchObject.CreationAuthor = string.Empty;
						}
						documentsFullTextSearchObject.CreationDate = document.CreationDate;
						documentsFullTextSearchObject.ChangeDate = document.ChangeDate;
						documentsFullTextSearchObject.TypeUid = document.TypeUid.ToString("n");
						documentsFullTextSearchObject.IsDeleted = document.IsDeleted;
						documentsFullTextSearchObject.IsArchived = document.IsArchived == true;
						documentsFullTextSearchObject.IsEncrypt = document.Encrypt;
						DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
						if ((serviceNotNull.Settings == null || serviceNotNull.Settings.IndexingVersion) && document.CurrentVersion != null)
						{
							documentsFullTextSearchObject.CurrentVersionId = document.CurrentVersion.Id;
							IDocumentVersion currentVersion = document.CurrentVersion;
							List<string> list = new List<string>();
							if (currentVersion.File != null)
							{
								documentsFullTextSearchObject.CurrentVersionFile = document.CurrentVersion.File.Id;
							}
							if (currentVersion.File != null && FilePreviewService.IsSupportPreview(currentVersion.File))
							{
								try
								{
									string text = HighlightsHelper.CutHtmlTags(currentVersion.File);
									if (!string.IsNullOrWhiteSpace(text))
									{
										list.Add(text);
									}
								}
								catch (PreviewTextFileDoNotExistException)
								{
								}
								catch (Exception)
								{
								}
							}
							if (currentVersion != null && currentVersion.Content != null)
							{
								string text2 = currentVersion.Content.ToString();
								if (!string.IsNullOrWhiteSpace(text2))
								{
									list.Add(HighlightsHelper.CutHtmlTags(text2, isHtml: true));
								}
							}
							documentsFullTextSearchObject.Versions = list.ToArray();
						}
						if (((IEnumerable<IDmsObjectPermission>)document.Permissions).Any())
						{
							documentsFullTextSearchObject.UserSecuritySetCacheId = (from p in ((IEnumerable<IDmsObjectPermission>)document.Permissions).Where((IDmsObjectPermission a) => a.PermissionId == PermissionProvider.DocumentViewPermission.Id).Distinct()
								select p.UserSecuritySetCacheId.ToString()).ToArray();
						}
						if (document.Folder != null)
						{
							documentsFullTextSearchObject.FolderName = FolderManager.GetFolderPathWithMyDocuments(document.Folder);
							documentsFullTextSearchObject.FolderId = document.Folder.Id;
						}
						ProcessingDynamicProperties(entity, obj);
					}
				}
				else if (entity is IDmsObject dmsObject && obj.SearchObject is IDocumentsFullTextSearchObject documentsFullTextSearchObject2)
				{
					obj.IndexedObject = dmsObject;
					documentsFullTextSearchObject2.Id = dmsObject.Id.ToString(CultureInfo.InvariantCulture);
					documentsFullTextSearchObject2.Name = dmsObject.Name;
					documentsFullTextSearchObject2.CreationAuthor = ((dmsObject.CreationAuthor != null) ? dmsObject.CreationAuthor.FullName : string.Empty);
					documentsFullTextSearchObject2.TypeUid = dmsObject.TypeUid.ToString("n");
					documentsFullTextSearchObject2.IsDeleted = dmsObject.IsDeleted;
					documentsFullTextSearchObject2.IsArchived = dmsObject.IsArchived == true;
					if (((IEnumerable<IDmsObjectPermission>)dmsObject.Permissions).Any())
					{
						documentsFullTextSearchObject2.UserSecuritySetCacheId = (from a in (IEnumerable<IDmsObjectPermission>)dmsObject.Permissions
							where a.PermissionId == PermissionProvider.DocumentViewPermission.Id
							select a into p
							select p.UserSecuritySetCacheId.ToString()).Distinct().ToArray();
					}
					if (dmsObject.Folder != null)
					{
						documentsFullTextSearchObject2.FolderId = dmsObject.Folder.Id;
					}
					ProcessingDynamicProperties(entity, obj);
				}
			});
		});
	}

	public override List<IEntity> GetEntities(Type cardType, List<Guid> listUid)
	{
		DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
		if (serviceNotNull.Settings == null || !serviceNotNull.Settings.Indexing)
		{
			return new List<IEntity>();
		}
		if (cardType != null && typeof(IDocumentsFullTextSearchObject) == cardType)
		{
			List<IEntity> list = new List<IEntity>();
			SecurityService.RunBySystemUser(delegate
			{
				SecurityService.RunWithElevatedPrivilegies(delegate
				{
					foreach (Guid item in listUid)
					{
						IDmsObject dmsObject = DmsObjectManager.LoadOrNull(item);
						if (dmsObject != null)
						{
							list.Add(dmsObject);
						}
					}
				});
			});
			return list;
		}
		return new List<IEntity>();
	}

	public override List<IEntity> GetEntities(Type cardType, List<long> listId)
	{
		DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
		if (serviceNotNull.Settings == null || !serviceNotNull.Settings.Indexing)
		{
			return new List<IEntity>();
		}
		if (cardType != null && typeof(IDocumentsFullTextSearchObject) == cardType)
		{
			List<IEntity> list = new List<IEntity>();
			SecurityService.RunBySystemUser(delegate
			{
				SecurityService.RunWithElevatedPrivilegies(delegate
				{
					foreach (long item in listId)
					{
						IDmsObject dmsObject = DmsObjectManager.LoadOrNull(item);
						if (dmsObject != null)
						{
							list.Add(dmsObject);
						}
					}
				});
			});
			return list;
		}
		return new List<IEntity>();
	}

	public override List<IEntity> LoadEntitiesByPage(Type cardType, int page, List<Guid> typeUidFilter = null)
	{
		List<IEntity> result = null;
		TransformationProvider.ExecuteWithTimeout(0, delegate
		{
			result = LoadEntities(cardType, (ICriteria c) => c.SetFirstResult(page * GetPageSize()), typeUidFilter);
		});
		return result;
	}

	public override List<IEntity> LoadEntities(Type cardType, long? lastId, List<Guid> typeUidFilter = null)
	{
		return LoadEntities(cardType, (ICriteria c) => (!lastId.HasValue) ? c : c.Add((ICriterion)(object)Restrictions.Gt("Id", (object)lastId)), typeUidFilter);
	}

	protected virtual List<IEntity> LoadEntities(Type cardType, Func<ICriteria, ICriteria> criteriaAction, List<Guid> typeUidFilter)
	{
		DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
		if (serviceNotNull.Settings == null || !serviceNotNull.Settings.Indexing)
		{
			return new List<IEntity>();
		}
		if (cardType != null && typeof(IDocumentsFullTextSearchObject) == cardType)
		{
			List<IEntity> list = new List<IEntity>();
			SecurityService.RunBySystemUser(delegate
			{
				SecurityService.RunWithElevatedPrivilegies(delegate
				{
					ISession session = SessionProvider.GetSession("");
					(from IEntity d in criteriaAction(session.CreateCriteria(InterfaceActivator.TypeOf<IDmsObject>()).AddOrder(Order.Asc("Id")).SetMaxResults(GetPageSize())).List()
						where d != null
						select d).ForEach(list.Add);
				});
			});
			return list;
		}
		return new List<IEntity>();
	}

	public override FullTextSearchResultModel CreateResultModelByFilter(IEntityFilter filter)
	{
		DocumentFullTextSearchResultModel documentFullTextSearchResultModel = new DocumentFullTextSearchResultModel();
		SetFilterTypeUid(documentFullTextSearchResultModel, filter);
		return documentFullTextSearchResultModel;
	}

	public override SortList GetDefaultSortExpression()
	{
		EntityPropertyMetadata propMd = InterfaceActivator.LoadPropertyMetadata((IDmsObject m) => m.SortTypeId) as EntityPropertyMetadata;
		SortListItem sortField = FullTextSearchDescriptorService.GetSortField(propMd);
		if (sortField == null)
		{
			throw new FullTextFilterException(SR.T("{1}: Поле \"{0}\" не поддерживает сортировку", "SortTypeId", "Dynamic Indexing Error"));
		}
		sortField.Direction = ListSortDirection.Ascending;
		return new SortList { sortField };
	}

	public override List<KeyValuePair<string, object>> CreateFromObject(Type cardType, IFullTextSearchObjectContainer obj)
	{
		if (cardType != null && typeof(IDocumentsFullTextSearchObject) == cardType && obj.SearchObject is IDocumentsFullTextSearchObject documentsFullTextSearchObject)
		{
			List<KeyValuePair<string, object>> list = WebData.CreateFromObject(obj.SearchObject).ToKeyValueList().ToList();
			list.RemoveAll((KeyValuePair<string, object> i) => i.Key == LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CreationAuthorId)));
			list.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CreationAuthorId)), documentsFullTextSearchObject.CreationAuthorId));
			list.RemoveAll((KeyValuePair<string, object> i) => i.Key == LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CurrentVersionId)));
			list.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.CurrentVersionId)), documentsFullTextSearchObject.CurrentVersionId));
			list.RemoveAll((KeyValuePair<string, object> i) => i.Key == LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.FolderId)));
			list.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.FolderId)), documentsFullTextSearchObject.FolderId));
			return list;
		}
		return new List<KeyValuePair<string, object>>();
	}

	public override void DisableIndexing(string disableInfo)
	{
		if (SettingModule is DocumentsFullTextSearchSettingsModule documentsFullTextSearchSettingsModule && documentsFullTextSearchSettingsModule.Settings != null)
		{
			documentsFullTextSearchSettingsModule.Settings.Indexing = false;
			documentsFullTextSearchSettingsModule.Settings.IndexingVersion = false;
			documentsFullTextSearchSettingsModule.Settings.IndexingStopInfo = disableInfo;
			documentsFullTextSearchSettingsModule.SaveSettings();
		}
	}

	public override void ReconstructEntity(Type cardType, IFullTextSearchResultItem resultItem, IEntity<long> fakeEntity)
	{
		if (!(cardType != null) || !(typeof(IDocumentsFullTextSearchObject) == cardType) || resultItem == null || resultItem.ResultData == null || fakeEntity == null || !(fakeEntity is IDmsObject dmsObject))
		{
			return;
		}
		WebDataItem webDataItem = resultItem.ResultData.Items.FirstOrDefault((WebDataItem i) => i.Name == LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Name)));
		if (webDataItem != null)
		{
			dmsObject.Name = webDataItem.Value;
		}
	}
}
