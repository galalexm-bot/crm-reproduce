using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.FullTextSearch.Model;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Documents.FullTextSearch.Model;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.FullTextSearch.Components;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Extensions;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.FullTextSearch.Components;

[Component]
internal class ContractorFullTextSearchExtension : ModuleFullTextSearchExtension
{
	private readonly Guid searchStringPropertyUid = InterfaceActivator.PropertyUid((IEntityFilter a) => a.SearchString);

	private readonly Guid phonePropertyUid = InterfaceActivator.PropertyUid((IContractorFilter a) => a.Phone);

	private readonly Guid emailPropertyUid = InterfaceActivator.PropertyUid((IContractorFilter a) => a.Email);

	private readonly Guid showOnlyMyPropertyUid = InterfaceActivator.PropertyUid((IContractorFilter a) => a.ShowOnlyMy);

	private readonly Guid phoneSubTypeUid = InterfaceActivator.UID<IPhone>(loadImplementation: false);

	public static Guid ContractorCardUid = Guid.Parse("EF933C9B-1DDF-4965-AEC7-38BAFE7258F4");

	public IFullTextSearchDescriptorService FullTextSearchDescriptorService { get; set; }

	public override IGlobalSettingsModule SettingModule => Locator.GetService<CRMFullTextSearchSettingsModule>();

	public override Dictionary<string, string> GetReverseMapping(Type cardType)
	{
		return new Dictionary<string, string>();
	}

	public override Dictionary<string, long> GetHighlightsOrder(Type cardType)
	{
		return new Dictionary<string, long>();
	}

	public override List<KeyValuePair<Type, Guid>> GetSupportedCardTypes(bool checkSettings = true)
	{
		if (checkSettings && (!(SettingModule is CRMFullTextSearchSettingsModule cRMFullTextSearchSettingsModule) || cRMFullTextSearchSettingsModule.Settings == null || !cRMFullTextSearchSettingsModule.Settings.IndexingContractor))
		{
			return new List<KeyValuePair<Type, Guid>>();
		}
		return new List<KeyValuePair<Type, Guid>>
		{
			new KeyValuePair<Type, Guid>(typeof(IContractorFullTextSearchObject), ContractorCardUid)
		};
	}

	public override Type GetSupportedCardType(Guid cardUid)
	{
		if (cardUid.Equals(ContractorCardUid))
		{
			return typeof(IContractorFullTextSearchObject);
		}
		return null;
	}

	public override Guid? GetSupportedCardType(Type cardType)
	{
		if (cardType == typeof(IContractorFullTextSearchObject))
		{
			return ContractorCardUid;
		}
		return null;
	}

	public override Type GetSupportedCardTypeByTypeUid(Guid objectTypeUid)
	{
		if (!(SettingModule is CRMFullTextSearchSettingsModule cRMFullTextSearchSettingsModule) || cRMFullTextSearchSettingsModule.Settings == null || !cRMFullTextSearchSettingsModule.Settings.IndexingContractor)
		{
			return null;
		}
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadataOrNull(objectTypeUid);
		Guid uid = InterfaceActivator.UID<IContractor>();
		if (classMetadata != null && (classMetadata.Uid == uid || MetadataLoader.GetBaseClasses(classMetadata).Any((ClassMetadata m) => m != null && m.Uid == uid)))
		{
			return typeof(IContractorFullTextSearchObject);
		}
		return null;
	}

	public override Type GetSupportedCardTypeByObject(object obj)
	{
		if (!(SettingModule is CRMFullTextSearchSettingsModule cRMFullTextSearchSettingsModule) || cRMFullTextSearchSettingsModule.Settings == null || !cRMFullTextSearchSettingsModule.Settings.IndexingContractor)
		{
			return null;
		}
		if (obj is IContractor)
		{
			return typeof(IContractorFullTextSearchObject);
		}
		return null;
	}

	public override Dictionary<Type, Dictionary<Guid, List<string>>> GetDynamicFieldsMapping()
	{
		ClassMetadata classMd = (ClassMetadata)MetadataLoader.LoadMetadata(typeof(IContractor));
		Dictionary<Guid, List<string>> value = ProcessingDynamicFieldsMapping(classMd);
		return new Dictionary<Type, Dictionary<Guid, List<string>>> { 
		{
			typeof(IContractorFullTextSearchObject),
			value
		} };
	}

	public override List<string> GetHighlightFields(Type cardType)
	{
		return new List<string>();
	}

	public override List<string> GetFields(Type cardType)
	{
		if (cardType != null && typeof(IContractorFullTextSearchObject) == cardType)
		{
			List<string> fields = base.GetFields(cardType);
			fields.AddRange(new List<string> { LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Name)) });
			fields.AddRange(new List<string> { LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Site)) });
			return fields;
		}
		return new List<string>();
	}

	public override FieldIndexList MappingFields(Type cardType)
	{
		if (cardType != null && typeof(IContractorFullTextSearchObject) == cardType)
		{
			ClassMetadata metadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeof(IContractor));
			FieldIndexList fieldIndexList = ContractorConstMappingFields();
			fieldIndexList.AddRange(MappingFields(metadata));
			return fieldIndexList;
		}
		return new FieldIndexList();
	}

	private FieldIndexList ContractorConstMappingFields()
	{
		return new FieldIndexList
		{
			new FieldIndexListItem("Id", null, FullTextFieldType.String, FullTextFieldTag.Keyword),
			new FieldIndexListItem("IsDeleted", null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem("Name", null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem("CreationAuthor", null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem("ResponsibleId", null, FullTextFieldType.Long, FullTextFieldTag.Value),
			new FieldIndexListItem("Site", null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem("TypeUid", null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem("UserSecuritySetCacheId", null, FullTextFieldType.String, FullTextFieldTag.Value)
		};
	}

	public override List<string> GetSearchFields(Type cardType)
	{
		return GetSearchFields(cardType, null);
	}

	public override List<string> GetSearchFields(Type cardType, IEntityFilter filter)
	{
		if (cardType != null && typeof(IContractorFullTextSearchObject) == cardType)
		{
			List<string> searchFields = base.GetSearchFields(cardType);
			CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
			if ((serviceNotNull.Settings == null || serviceNotNull.Settings.IndexingContractorAttachments) && (filter == null || filter.FullTextInAttachments))
			{
				searchFields.AddRange(new List<string>
				{
					LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Name)),
					LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Phone)),
					LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Email)),
					LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Site)),
					LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.AttachmentsName)),
					LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.AttachmentsText)),
					LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.DocumentsName))
				});
			}
			else
			{
				searchFields.AddRange(new List<string>
				{
					LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Name)),
					LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Phone)),
					LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Email)),
					LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Site))
				});
			}
			return searchFields;
		}
		return new List<string>();
	}

	public override FilterList GetFilterFields(Type cardType, FullTextSearchResultModel searchModel)
	{
		if (cardType != null && typeof(IContractorFullTextSearchObject) == cardType)
		{
			FilterList filterList = new FilterList();
			if (searchModel is ContractorFullTextSearchResultModel contractorFullTextSearchResultModel && MetadataLoader.LoadMetadata(contractorFullTextSearchResultModel.TypeUid) is ClassMetadata classMetadata)
			{
				List<ClassMetadata> list = (from c in MetadataLoader.GetChildClasses(classMetadata)
					where c != null
					select c).ToList();
				list.Add(classMetadata);
				List<object> list2 = new List<object>();
				list2.AddRange(list.Select((ClassMetadata c) => c.Uid.ToString("n")));
				filterList.Add(new FilterListItem(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.TypeUid)), list2, FilterListItemType.Must, FullTextFieldType.String));
			}
			EleWise.ELMA.Security.Models.IUser user = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser() as EleWise.ELMA.Security.Models.IUser;
			if (!(user.Uid == SecurityConstants.AdminUserUid) && !Locator.GetServiceNotNull<ISecurityService>().HasPermission(CRMPermissionProvider.CRMFullAccessPermission))
			{
				ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				string sql = string.Format("SELECT DISTINCT usc.{1} as {1} FROM {0} WHERE (usc.{2} = {3})", serviceNotNull.NoLockTableExpression("UserSecuritySetCache", "usc"), serviceNotNull.Dialect.QuoteIfNeeded("SetId"), serviceNotNull.Dialect.QuoteIfNeeded("UserId"), user.GetId());
				List<string> list3 = new List<string>();
				using (IDataReader dataReader = serviceNotNull.ExecuteQuery(sql))
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
				filterList.Add(new FilterListItem(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.UserSecuritySetCacheId)), list4, FilterListItemType.Must, FullTextFieldType.String));
			}
			filterList.Add(new FilterListItem(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.IsDeleted)), new List<object> { "false" }, FilterListItemType.Must, FullTextFieldType.String));
			return filterList;
		}
		return new FilterList();
	}

	public override Dictionary<string, Weight> GetWeightSearchFields(Type cardType)
	{
		Dictionary<string, Weight> dictionary = new Dictionary<string, Weight>();
		if (cardType != null && typeof(IContractorFullTextSearchObject) == cardType)
		{
			dictionary.Add(LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject d) => d.Name)), Weight.High);
		}
		return dictionary;
	}

	public override FieldList GetCustomSearchFields(Type cardType, FilterProperty filterProperty)
	{
		FieldList customSearchFields = base.GetCustomSearchFields(cardType, filterProperty);
		if (customSearchFields != null)
		{
			return customSearchFields;
		}
		if (filterProperty != null && filterProperty.Uid == searchStringPropertyUid)
		{
			FieldList fieldList = new FieldList();
			Dictionary<Guid, List<IPropertyMetadata>> dictionary = SupportedDynamicFields((ClassMetadata)MetadataLoader.LoadMetadata(typeof(IContractor)));
			List<Guid> list = new List<Guid>();
			{
				foreach (KeyValuePair<Guid, List<IPropertyMetadata>> item in dictionary)
				{
					foreach (IPropertyMetadata item2 in item.Value)
					{
						if (item2.TypeUid == EntityDescriptor.UID && item2.SubTypeUid == phoneSubTypeUid && !list.Contains(item2.Uid))
						{
							FieldListItem searchField = FullTextSearchDescriptorService.GetSearchField(filterProperty.Value, item2);
							searchField.ItemType = FilterListItemType.Should;
							fieldList.Add(searchField);
							list.Add(item2.Uid);
						}
					}
				}
				return fieldList;
			}
		}
		if (cardType != null && typeof(IContractorFullTextSearchObject) == cardType && filterProperty != null)
		{
			if (phonePropertyUid == filterProperty.Uid)
			{
				if (filterProperty.Value == null)
				{
					return new FieldList();
				}
				string value = ConvertPhoneNumber(filterProperty.Value.ToString());
				if (string.IsNullOrWhiteSpace(value))
				{
					return new FieldList();
				}
				FieldList fieldList2 = new FieldList();
				fieldList2.Add(new FieldListItem(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Phone)), value));
				return fieldList2;
			}
			if (emailPropertyUid == filterProperty.Uid)
			{
				if (filterProperty.Value == null)
				{
					return new FieldList();
				}
				string value2 = filterProperty.Value.ToString();
				if (string.IsNullOrWhiteSpace(value2))
				{
					return new FieldList();
				}
				FieldList fieldList3 = new FieldList();
				fieldList3.Add(new FieldListItem(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Email)), value2));
				return fieldList3;
			}
		}
		return null;
	}

	public override FilterList GetCustomFilterFields(Type cardType, FilterProperty filterProperty, FullTextSearchResultModel searchModel)
	{
		FilterList customFilterFields = base.GetCustomFilterFields(cardType, filterProperty, searchModel);
		if (customFilterFields != null)
		{
			return customFilterFields;
		}
		if (cardType != null && typeof(IContractorFullTextSearchObject) == cardType && filterProperty != null && filterProperty.Uid == showOnlyMyPropertyUid)
		{
			if (filterProperty.Value == null || (bool.TryParse(filterProperty.Value.ToString(), out var result) && !result))
			{
				return new FilterList();
			}
			EleWise.ELMA.Security.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
			if (currentUser != null)
			{
				object id = currentUser.GetId();
				if (id != null && long.TryParse(id.ToString(), out var result2))
				{
					FilterList filterList = new FilterList();
					filterList.Add(new FilterListItem(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.ResponsibleId)), new List<object> { result2 }, FilterListItemType.Must, FullTextFieldType.Long));
					return filterList;
				}
			}
			return null;
		}
		return null;
	}

	public static string ConvertPhoneNumber(string text)
	{
		if (string.IsNullOrWhiteSpace(text))
		{
			return text;
		}
		return new string(text.Where((char c) => char.IsNumber(c)).ToArray());
	}

	public override void FillObject(Type cardType, IFullTextSearchObjectContainer obj, IEntity entity)
	{
		if (!(cardType != null) || !(typeof(IContractorFullTextSearchObject) == cardType))
		{
			return;
		}
		Locator.GetServiceNotNull<ISecurityService>().RunBySystemUser(delegate
		{
			Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
			{
				if (entity is IContractor contractor && obj.SearchObject is IContractorFullTextSearchObject contractorFullTextSearchObject)
				{
					obj.IndexedObject = contractor;
					contractorFullTextSearchObject.Id = contractor.Id.ToString(CultureInfo.InvariantCulture);
					contractorFullTextSearchObject.Name = contractor.Name;
					contractorFullTextSearchObject.CreationAuthor = ((contractor.CreationAuthor != null) ? contractor.CreationAuthor.FullName : string.Empty);
					contractorFullTextSearchObject.TypeUid = contractor.TypeUid.ToString("n");
					contractorFullTextSearchObject.IsDeleted = contractor.IsDeleted;
					contractorFullTextSearchObject.Site = contractor.Site;
					contractorFullTextSearchObject.Email = ((contractor.Email != null) ? (from e in (IEnumerable<IEmail>)contractor.Email
						where e != null && !string.IsNullOrEmpty(e.EmailString)
						select e.EmailString).ToArray() : new string[0]);
					contractorFullTextSearchObject.Phone = ((contractor.Phone != null) ? (from e in (IEnumerable<IPhone>)contractor.Phone
						where e != null && !string.IsNullOrEmpty(e.PhoneString)
						select ConvertPhoneNumber(e.PhoneString)).ToArray() : new string[0]);
					if (contractor.Responsible != null)
					{
						contractorFullTextSearchObject.ResponsibleId = contractor.Responsible.Id;
					}
					if (((IEnumerable<IContractorPersonPermission>)contractor.Permission).Any())
					{
						contractorFullTextSearchObject.UserSecuritySetCacheId = ((IEnumerable<IContractorPersonPermission>)contractor.Permission).Select((IContractorPersonPermission p) => p.UserSecuritySetCacheId.ToString()).Distinct().ToArray();
					}
					CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
					if (serviceNotNull.Settings == null || serviceNotNull.Settings.IndexingContractorAttachments)
					{
						GetAttachmentsForContractor(contractor, out var attachmentsName, out var attachmentsText, out var documentsName, out var documentsId);
						contractorFullTextSearchObject.AttachmentsText = attachmentsText.ToArray();
						contractorFullTextSearchObject.AttachmentsName = attachmentsName.ToArray();
						contractorFullTextSearchObject.DocumentsId = documentsId.ToArray();
						contractorFullTextSearchObject.DocumentsName = documentsName.ToArray();
					}
					ProcessingDynamicProperties(entity, obj);
				}
			});
		});
	}

	public static void GetAttachmentsForContractor(IContractor contractor, out List<string> attachmentsName, out List<string> attachmentsText, out List<string> documentsName, out List<long> documentsId)
	{
		attachmentsName = new List<string>();
		attachmentsText = new List<string>();
		documentsName = new List<string>();
		documentsId = new List<long>();
		if (contractor == null)
		{
			return;
		}
		ICRMAttachmentFilter iCRMAttachmentFilter = InterfaceActivator.Create<ICRMAttachmentFilter>();
		iCRMAttachmentFilter.Contractor = contractor;
		foreach (ICRMAttachment item in from a in CrmAttachmentManager.Instance.Find(iCRMAttachmentFilter, new FetchOptions
			{
				MaxResults = 100
			})
			where a != null
			select a)
		{
			if (item.Files != null)
			{
				IFilePreviewService serviceNotNull = Locator.GetServiceNotNull<IFilePreviewService>();
				foreach (IAttachment item2 in ((IEnumerable<IAttachment>)item.Files).Where((IAttachment f) => f != null && f.File != null))
				{
					if (item2.File != null && !string.IsNullOrWhiteSpace(item2.File.Name))
					{
						attachmentsName.Add(item2.File.Name);
					}
					if (item2.File == null || !serviceNotNull.IsSupportPreview(item2.File))
					{
						continue;
					}
					try
					{
						string text = HighlightsHelper.CutHtmlTags(item2.File);
						if (!string.IsNullOrWhiteSpace(text))
						{
							attachmentsText.Add(text);
						}
					}
					catch (PreviewTextFileDoNotExistException)
					{
					}
					catch (Exception)
					{
					}
				}
			}
			if (item.Documents == null)
			{
				continue;
			}
			foreach (IDocument item3 in (IEnumerable<IDocument>)item.Documents)
			{
				if (item3 != null && !item3.IsDeleted && !string.IsNullOrWhiteSpace(item3.Name))
				{
					documentsId.Add(item3.Id);
					documentsName.Add(item3.Name);
				}
			}
		}
	}

	public override List<IEntity> GetEntities(Type cardType, List<Guid> listUid)
	{
		CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
		if (serviceNotNull.Settings == null || !serviceNotNull.Settings.IndexingContractor)
		{
			return new List<IEntity>();
		}
		if (cardType != null && typeof(IContractorFullTextSearchObject) == cardType)
		{
			List<IEntity> list = new List<IEntity>();
			Locator.GetServiceNotNull<ISecurityService>().RunBySystemUser(delegate
			{
				Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
				{
					foreach (Guid item in listUid)
					{
						IContractor contractor = ContractorManager.Instance.LoadOrNull(item);
						if (contractor != null)
						{
							list.Add(contractor);
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
		CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
		if (serviceNotNull.Settings == null || !serviceNotNull.Settings.IndexingContractor)
		{
			return new List<IEntity>();
		}
		if (cardType != null && typeof(IContractorFullTextSearchObject) == cardType)
		{
			List<IEntity> list = new List<IEntity>();
			Locator.GetServiceNotNull<ISecurityService>().RunBySystemUser(delegate
			{
				Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
				{
					foreach (long item in listId)
					{
						IContractor contractor = ContractorManager.Instance.LoadOrNull(item);
						if (contractor != null)
						{
							list.Add(contractor);
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
		return LoadEntities(cardType, delegate
		{
			int pageSize = GetPageSize();
			FetchOptions fetchOptions = new FetchOptions
			{
				MaxResults = pageSize,
				FirstResult = page * pageSize,
				SortExpression = "Id"
			};
			return ContractorManager.Instance.Find(fetchOptions).Cast<IEntity>().ToList();
		}, typeUidFilter);
	}

	public override List<IEntity> LoadEntities(Type cardType, long? lastId, List<Guid> typeUidFilter = null)
	{
		return LoadEntities(cardType, delegate
		{
			FetchOptions fetchOptions = new FetchOptions
			{
				MaxResults = GetPageSize(),
				SortExpression = "Id"
			};
			return ContractorManager.Instance.Find(lastId.HasValue ? new Filter
			{
				Query = "Id > " + lastId
			} : null, fetchOptions).Cast<IEntity>().ToList();
		}, typeUidFilter);
	}

	protected virtual List<IEntity> LoadEntities(Type cardType, Func<List<IEntity>> find, List<Guid> typeUidFilter)
	{
		CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
		if (serviceNotNull.Settings == null || !serviceNotNull.Settings.IndexingContractor)
		{
			return new List<IEntity>();
		}
		if (cardType != null && typeof(IContractorFullTextSearchObject) == cardType)
		{
			ISecurityService securityService = Locator.GetServiceNotNull<ISecurityService>();
			List<IEntity> list = null;
			securityService.RunBySystemUser(delegate
			{
				securityService.RunWithElevatedPrivilegies(delegate
				{
					list = find();
				});
			});
			return list;
		}
		return new List<IEntity>();
	}

	public override FullTextSearchResultModel CreateResultModelByFilter(IEntityFilter filter)
	{
		ContractorFullTextSearchResultModel contractorFullTextSearchResultModel = new ContractorFullTextSearchResultModel();
		SetFilterTypeUid(contractorFullTextSearchResultModel, filter);
		return contractorFullTextSearchResultModel;
	}

	public override List<KeyValuePair<string, object>> CreateFromObject(Type cardType, IFullTextSearchObjectContainer obj)
	{
		if (cardType != null && typeof(IContractorFullTextSearchObject) == cardType && obj.SearchObject is IContractorFullTextSearchObject contractorFullTextSearchObject)
		{
			List<KeyValuePair<string, object>> list = WebData.CreateFromObject(obj.SearchObject).ToKeyValueList().ToList();
			list.RemoveAll((KeyValuePair<string, object> i) => i.Key == LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.ResponsibleId)));
			list.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.ResponsibleId)), contractorFullTextSearchObject.ResponsibleId));
			if (contractorFullTextSearchObject.DocumentsId != null)
			{
				list.RemoveAll((KeyValuePair<string, object> i) => i.Key == LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.DocumentsId)));
				list.Add(new KeyValuePair<string, object>(LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.DocumentsId)), contractorFullTextSearchObject.DocumentsId.ToList()));
			}
			return list;
		}
		return new List<KeyValuePair<string, object>>();
	}

	public override void DisableIndexing(string disableInfo)
	{
		if (SettingModule is CRMFullTextSearchSettingsModule cRMFullTextSearchSettingsModule && cRMFullTextSearchSettingsModule.Settings != null)
		{
			cRMFullTextSearchSettingsModule.Settings.IndexingContractor = false;
			cRMFullTextSearchSettingsModule.Settings.IndexingContractorAttachments = false;
			cRMFullTextSearchSettingsModule.Settings.IndexingStopInfo = disableInfo;
			cRMFullTextSearchSettingsModule.SaveSettings();
		}
	}

	public override void ReconstructEntity(Type cardType, IFullTextSearchResultItem resultItem, IEntity<long> fakeEntity)
	{
		if (!(cardType != null) || !(typeof(IContractorFullTextSearchObject) == cardType) || resultItem == null || resultItem.ResultData == null || fakeEntity == null || !(fakeEntity is IContractor contractor))
		{
			return;
		}
		WebDataItem webDataItem = resultItem.ResultData.Items.FirstOrDefault((WebDataItem i) => i.Name == LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Name)));
		if (webDataItem != null)
		{
			contractor.Name = webDataItem.Value;
		}
		WebDataItem webDataItem2 = resultItem.ResultData.Items.FirstOrDefault((WebDataItem i) => i.Name == LinqUtils.NameOf((Expression<Func<IContractorFullTextSearchObject, object>>)((IContractorFullTextSearchObject d) => d.Site)));
		if (webDataItem2 != null)
		{
			contractor.Site = webDataItem2.Value;
		}
	}
}
