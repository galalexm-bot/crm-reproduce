using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.FullTextSearch;
using EleWise.ELMA.Documents.FullTextSearch.Model;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Services;

[Service]
public class FullTextTreeService : IFullTextTreeService
{
	private readonly ITransformationProvider transformationProvider;

	private readonly IAuthenticationService authenticationService;

	private readonly IFullTextSearchDescriptorService fullTextSearchDescriptorService;

	private readonly IFullTextSearchService fullTextSearchService;

	private readonly IEnumerable<IFullTextTreeDocument> fullTextTreeDocument;

	private Type cardType;

	private string folderIdIndex;

	private string idIndex;

	private string nameIndex;

	private string userSecuritySetCacheId;

	private string typeUidIndex;

	private string creationAuthorIndex;

	private string creationDateIndex;

	private string imageUrlIndex;

	private string folderTypeIndex;

	private string virtualIndex;

	private IPropertyMetadata ownerPropertyMetadata;

	private string sortTypeId;

	private FilterListItem isDeletedFilter;

	private ITypeDescriptor ownerDescriptor;

	private SortList listSortFields = new SortList();

	private List<string> listReturnFields = new List<string>();

	[NotNull]
	public ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

	private Type CardType => cardType ?? (cardType = typeof(IDocumentsFullTextSearchObject));

	private string FolderIdIndex => folderIdIndex ?? (folderIdIndex = LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject p) => p.FolderId)));

	private string IdIndex => idIndex ?? (idIndex = LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject p) => p.Id)));

	private string NameIndex => nameIndex ?? (nameIndex = LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject p) => p.Name)));

	private string UserSecuritySetCacheId => userSecuritySetCacheId ?? (userSecuritySetCacheId = LinqUtils.NameOf((Expression<Func<IDocumentsFullTextSearchObject, object>>)((IDocumentsFullTextSearchObject p) => p.UserSecuritySetCacheId)));

	private string TypeUidIndex => typeUidIndex ?? (typeUidIndex = LinqUtils.NameOf((Expression<Func<IFullTextSearchObject, object>>)((IFullTextSearchObject p) => p.TypeUid)));

	private string CreationAuthorIndex
	{
		get
		{
			if (creationAuthorIndex == null)
			{
				PropertyMetadata propMd = InterfaceActivator.LoadPropertyMetadata(typeof(IDmsObject), InterfaceActivator.PropertyName((IDmsObject d) => d.CreationAuthor), inherit: false);
				creationAuthorIndex = fullTextSearchDescriptorService.GetReturnField(propMd).FirstOrDefault();
			}
			return creationAuthorIndex;
		}
	}

	private string CreationDateIndex
	{
		get
		{
			if (creationDateIndex == null)
			{
				PropertyMetadata propMd = InterfaceActivator.LoadPropertyMetadata(typeof(IDmsObject), InterfaceActivator.PropertyName((IDmsObject p) => p.CreationDate), inherit: false);
				creationDateIndex = fullTextSearchDescriptorService.GetReturnField(propMd).FirstOrDefault();
			}
			return creationDateIndex;
		}
	}

	private string ImageUrlIndex
	{
		get
		{
			if (imageUrlIndex == null)
			{
				PropertyMetadata propMd = InterfaceActivator.LoadPropertyMetadata(typeof(IFolder), InterfaceActivator.PropertyName((IFolder p) => p.ImageUrl), inherit: false);
				imageUrlIndex = fullTextSearchDescriptorService.GetReturnField(propMd).FirstOrDefault();
			}
			return imageUrlIndex;
		}
	}

	private string FolderTypeIndex
	{
		get
		{
			if (folderTypeIndex == null)
			{
				PropertyMetadata propMd = InterfaceActivator.LoadPropertyMetadata(typeof(IFolder), InterfaceActivator.PropertyName((IFolder p) => p.FolderType), inherit: false);
				folderTypeIndex = fullTextSearchDescriptorService.GetReturnField(propMd).FirstOrDefault();
			}
			return folderTypeIndex;
		}
	}

	private string VirtualIndex
	{
		get
		{
			if (virtualIndex == null)
			{
				PropertyMetadata propMd = InterfaceActivator.LoadPropertyMetadata(typeof(IDmsObject), InterfaceActivator.PropertyName((IDmsObject p) => p.Virtual), inherit: false);
				virtualIndex = fullTextSearchDescriptorService.GetReturnField(propMd).FirstOrDefault();
			}
			return virtualIndex;
		}
	}

	private IPropertyMetadata OwnerPropertyMetadata
	{
		get
		{
			PropertyMetadata propertyMetadata = (PropertyMetadata)(ownerPropertyMetadata = InterfaceActivator.LoadPropertyMetadata(typeof(IMyDocumentFolder), InterfaceActivator.PropertyName((IMyDocumentFolder p) => p.Owner), inherit: false));
			return ownerPropertyMetadata;
		}
	}

	private string SortTypeId
	{
		get
		{
			if (sortTypeId == null)
			{
				PropertyMetadata propMd = InterfaceActivator.LoadPropertyMetadata(typeof(IDmsObject), InterfaceActivator.PropertyName((IDmsObject p) => p.SortTypeId), inherit: false);
				sortTypeId = fullTextSearchDescriptorService.GetReturnField(propMd).FirstOrDefault();
			}
			return sortTypeId;
		}
	}

	private FilterListItem IsDeletedFilter
	{
		get
		{
			if (isDeletedFilter == null)
			{
				PropertyMetadata propertyMetadata = InterfaceActivator.LoadPropertyMetadata(typeof(IDmsObject), InterfaceActivator.PropertyName((IDmsObject p) => p.IsDeleted), inherit: false);
				ITypeDescriptor typeDescriptor = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeDescriptor(propertyMetadata.TypeUid, propertyMetadata.SubTypeUid);
				isDeletedFilter = ((IFullTextTypeDescriptor)typeDescriptor).FullTextPropertyDescriptor.GetFilterField(false, propertyMetadata, null);
			}
			return isDeletedFilter;
		}
	}

	private ITypeDescriptor OwnerDescriptor
	{
		get
		{
			if (ownerDescriptor == null)
			{
				PropertyMetadata propertyMetadata = InterfaceActivator.LoadPropertyMetadata(typeof(IMyDocumentFolder), InterfaceActivator.PropertyName((IMyDocumentFolder p) => p.Owner), inherit: false);
				ITypeDescriptor typeDescriptor = (ownerDescriptor = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeDescriptor(propertyMetadata.TypeUid, propertyMetadata.SubTypeUid));
			}
			return ownerDescriptor;
		}
	}

	private SortList ListSortFields
	{
		get
		{
			if (listSortFields != null && !listSortFields.Any())
			{
				listSortFields.Add(new SortListItem(FolderIdIndex, FullTextFieldType.String));
				listSortFields.Add(new SortListItem(SortTypeId, FullTextFieldType.Long));
				listSortFields.Add(new SortListItem(NameIndex, FullTextFieldType.String));
			}
			return listSortFields;
		}
	}

	private List<string> ListReturnFields
	{
		get
		{
			if (listReturnFields != null && !listReturnFields.Any())
			{
				listReturnFields.Add(FolderIdIndex);
				listReturnFields.Add(IdIndex);
				listReturnFields.Add(NameIndex);
				listReturnFields.Add(TypeUidIndex);
				listReturnFields.Add(CreationAuthorIndex);
				listReturnFields.Add(CreationDateIndex);
				listReturnFields.Add(ImageUrlIndex);
				listReturnFields.Add(FolderTypeIndex);
				listReturnFields.Add(VirtualIndex);
			}
			return listReturnFields;
		}
	}

	public FullTextTreeService(ITransformationProvider transformationProvider, IAuthenticationService authenticationService, IFullTextSearchDescriptorService fullTextSearchDescriptorService, IFullTextSearchService fullTextSearchService, IEnumerable<IFullTextTreeDocument> fullTextTreeDocument)
	{
		this.transformationProvider = transformationProvider;
		this.authenticationService = authenticationService;
		this.fullTextSearchDescriptorService = fullTextSearchDescriptorService;
		this.fullTextSearchService = fullTextSearchService;
		this.fullTextTreeDocument = fullTextTreeDocument;
	}

	internal bool IndexingIsSupport()
	{
		if (!SR.GetSetting("Documents.Tree.Elastic", defaultValue: false))
		{
			return false;
		}
		if (fullTextSearchService != null)
		{
			IFullTextSearchProvider currentProvider = fullTextSearchService.Provider;
			if (fullTextTreeDocument != null && currentProvider != null)
			{
				return fullTextTreeDocument.Any((IFullTextTreeDocument f) => f.GetDocumentTreeProviderUid == currentProvider.ProviderUid);
			}
		}
		return false;
	}

	public IList<FolderTreeNode> LoadTreeFromIndex()
	{
		if (!IndexingIsSupport())
		{
			return null;
		}
		DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
		if (serviceNotNull.Settings == null || !serviceNotNull.Settings.Indexing)
		{
			return null;
		}
		FilterList filterList = new FilterList();
		if (!(authenticationService.GetCurrentUser() is EleWise.ELMA.Security.Models.IUser user))
		{
			return null;
		}
		if (!SecurityService.HasPermission(PermissionProvider.DocumentsFullAccessToAllObjectsPermission))
		{
			string sql = string.Format("SELECT DISTINCT ussc.{1} as {1} FROM {0} WHERE (ussc.{2} = {3})", transformationProvider.NoLockTableExpression("UserSecuritySetCache", "ussc"), transformationProvider.Dialect.QuoteIfNeeded("SetId"), transformationProvider.Dialect.QuoteIfNeeded("UserId"), user.GetId());
			List<string> list = new List<string>();
			using (IDataReader dataReader = transformationProvider.ExecuteQuery(sql))
			{
				while (dataReader.Read())
				{
					if (!(dataReader["SetId"] is DBNull))
					{
						string item = Convert.ToString(dataReader["SetId"]);
						if (!list.Contains(item))
						{
							list.Add(item);
						}
					}
				}
			}
			List<object> list2 = new List<object>();
			list2.AddRange(list.ToList());
			filterList.Add(new FilterListItem(UserSecuritySetCacheId, list2, FilterListItemType.Must, FullTextFieldType.String));
		}
		filterList.Add(IsDeletedFilter);
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeof(IFolder));
		List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(classMetadata);
		List<object> list3 = new List<object>();
		list3.Add(classMetadata.Uid.ToString("n"));
		list3.AddRange(childClasses.Select((ClassMetadata c) => c.Uid.ToString("n")));
		filterList.Add(new FilterListItem(TypeUidIndex, list3, FilterListItemType.Must, FullTextFieldType.String));
		FilterListItem filterField = ((IFullTextTypeDescriptor)OwnerDescriptor).FullTextPropertyDescriptor.GetFilterField(new EntityWrapper(user), OwnerPropertyMetadata, null);
		filterField.ItemType = FilterListItemType.MustOrMiss;
		filterList.Add(filterField);
		object value;
		return fullTextSearchService.Find(CardType, ListReturnFields, filterList, ListSortFields, 0, int.MaxValue)?.Items.Select((FullTextSearchResultItem treeitem) => new FolderTreeNode
		{
			CreationAuthor = Convert.ToInt64(treeitem.ResultDictionary.TryGetValue(CreationAuthorIndex, out value) ? value : null),
			CreationDate = new DateTime(Convert.ToInt64(treeitem.ResultDictionary.TryGetValue(CreationDateIndex, out value) ? value : null)),
			FolderId = ((!treeitem.ResultDictionary.TryGetValue(FolderIdIndex, out value)) ? null : ((Convert.ToInt64(value) > 0) ? new long?(Convert.ToInt64(value)) : null)),
			FolderType = Convert.ToInt32(treeitem.ResultDictionary.TryGetValue(FolderTypeIndex, out value) ? value : ((object)0)),
			Id = Convert.ToInt64(treeitem.ResultDictionary["Id"]),
			ImageUrl = ((!treeitem.ResultDictionary.TryGetValue(ImageUrlIndex, out value)) ? null : (string.IsNullOrEmpty(Convert.ToString(value)) ? null : Convert.ToString(value))),
			Name = Convert.ToString(treeitem.ResultDictionary.TryGetValue(NameIndex, out value) ? value : null),
			NodeTypeUid = Guid.Parse(treeitem.ResultDictionary["TypeUid"].ToString()),
			Virtual = Convert.ToBoolean(treeitem.ResultDictionary.TryGetValue(VirtualIndex, out value) ? value : ((object)0))
		}).ToList();
	}
}
