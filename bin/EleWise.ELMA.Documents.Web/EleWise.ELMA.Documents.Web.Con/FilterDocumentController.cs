using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.FullTextSearch;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Documents.Web.FullTextSearch.Extensions;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Documents.Web.Portlets;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Iesi.Collections.Generic;
using Newtonsoft.Json;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Documents.Web.Controllers;

[Permission("410ABDDC-FC2D-46E6-BB5E-ADF1B41E49A1")]
public class FilterDocumentController : FilterTreeBaseController<IDocument, long>
{
	[NotNull]
	public ISystemFoldersService SystemFoldersService { get; set; }

	protected override bool EnableEqlQuery => true;

	public static FilterModel EmptyFilterModel(long? folderId, bool setMyDocumentFolderIfNull)
	{
		IFolder folder2;
		if (!folderId.HasValue)
		{
			IFolder folder = (setMyDocumentFolderIfNull ? Locator.GetServiceNotNull<ISystemFoldersService>().GetMyDocumentFolderForCurrentUser() : null);
			folder2 = folder;
		}
		else
		{
			folder2 = FolderManager.Instance.Load(folderId.Value);
		}
		IFolder folder3 = folder2;
		InstanceOf<IFilterDocumentFolder> instanceOf = new InstanceOf<IFilterDocumentFolder>();
		instanceOf.New.SearchOnOpen = true;
		instanceOf.New.Virtual = true;
		IFilterDocumentFolder @new = instanceOf.New;
		IDocumentFilter documentFilter = (IDocumentFilter)InterfaceActivator.Create(InterfaceActivator.TypeOf<IDocumentFilter>());
		documentFilter.Folder = folder3;
		@new.FilterFields = UniversalFilterSaver.Pack(documentFilter);
		return new FilterModel(@new, InterfaceActivator.UID<IDocument>(), null, null, "Filter", null, null, enableEqlQuery: true, null, null, null, InterfaceActivator.TypeOf<IFilterDocumentFolder>())
		{
			DisableColumnSettings = false,
			ZoneMode = ZoneMode.FilterSerach
		};
	}

	public static FilterModel EmptyFilterModel(long? folderId)
	{
		return EmptyFilterModel(folderId, setMyDocumentFolderIfNull: true);
	}

	protected override void CheckFilterEditPermission(IFilterBase filter)
	{
		if (filter != null && !filter.IsNew() && !base.SecurityService.HasPermission(PermissionProvider.DocumentEditPermission, filter))
		{
			throw new SecurityException(SR.T("Текущий пользователь не имеет прав на редактирование папки-фильтра \"{0}\" с идентификатором {1}", filter.Name, filter.Id));
		}
	}

	[HttpGet]
	public override ActionResult EditFilter(long? FilterId = null)
	{
		string value = ((Controller)this).get_HttpContext().Request["folderId"];
		long? num = null;
		if (!string.IsNullOrEmpty(value))
		{
			num = Convert.ToInt64(value);
		}
		IFilterDocumentFolder filterDocumentFolder;
		if (!FilterId.HasValue)
		{
			IFolder folder;
			if (!num.HasValue)
			{
				IFolder myDocumentFolderForCurrentUser = SystemFoldersService.GetMyDocumentFolderForCurrentUser();
				folder = myDocumentFolderForCurrentUser;
			}
			else
			{
				folder = FolderManager.Instance.Load(num.Value);
			}
			IFolder folder2 = folder;
			if (!base.SecurityService.HasPermission(PermissionProvider.DocumentEditPermission, folder2) && !base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, folder2))
			{
				folder2 = SystemFoldersService.GetMyDocumentFolderForCurrentUser();
			}
			InstanceOf<IFilterDocumentFolder> instanceOf = new InstanceOf<IFilterDocumentFolder>();
			instanceOf.New.Folder = folder2;
			instanceOf.New.ObjectsType = new ReferenceOnEntityType
			{
				TypeUid = InterfaceActivator.UID<IDocument>()
			};
			instanceOf.New.SearchOnOpen = true;
			instanceOf.New.Virtual = true;
			filterDocumentFolder = instanceOf.New;
		}
		else
		{
			filterDocumentFolder = FilterDocumentFolderManager.Instance.Load(FilterId.Value);
		}
		CheckFilterEditPermission(filterDocumentFolder);
		FilterModel filterModel = new FilterModel(filterDocumentFolder, filterDocumentFolder.ObjectsType.TypeUid, null, null, "Filter", null, null, EnableEqlQuery, null, null, null, InterfaceActivator.TypeOf<IFilterDocumentFolder>())
		{
			ShowAllFields = true,
			DisablePermissionSettings = true,
			ZoneMode = ZoneMode.EditFilter
		};
		InitEqlQuery(filterModel);
		((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix("DataFilter");
		return (ActionResult)(object)((Controller)this).View("Filter/Edit", (object)filterModel);
	}

	[HttpPost]
	public override ActionResult EditFilter([Bind(Prefix = "DataFilter")] FilterModel model, EditableListModel access)
	{
		if (model.Entity is IFilterDocumentFolder filterDocumentFolder && filterDocumentFolder.Folder != null && !base.SecurityService.HasPermission(PermissionProvider.DocumentEditPermission, filterDocumentFolder.Folder) && !base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, filterDocumentFolder.Folder))
		{
			throw FolderManager.Instance.CreateSecurityException(SR.T("Нет прав доступа на папку \"{0}\"({1})", filterDocumentFolder.Folder.Name, filterDocumentFolder.Folder.Id), filterDocumentFolder.Folder.Id);
		}
		return base.EditFilter(model, access);
	}

	protected override void CheckModel(FilterModel model)
	{
		if (model.Entity is IFilterDocumentFolder filterDocumentFolder && filterDocumentFolder.Folder != null && !base.SecurityService.HasPermission(PermissionProvider.DocumentEditPermission, filterDocumentFolder.Folder) && !base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, filterDocumentFolder.Folder))
		{
			filterDocumentFolder.Folder = SystemFoldersService.GetMyDocumentFolderForCurrentUser();
		}
	}

	protected override ActionResult RedirectAfterSave(FilterModel model)
	{
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "FilterDocument", (object)new
		{
			area = "EleWise.ELMA.Documents.Web",
			FilterId = model.Entity.Id
		});
	}

	[ContentItem(Name = "SR.M('Поиск документов')", Id = "documents-search", Image24 = "#search.svg")]
	public ActionResult Search(long? FilterId = null, bool? searchOnOpen = true)
	{
		if (!((ControllerBase)this).get_ControllerContext().get_IsChildAction() && !((Controller)this).get_Request().QueryString.AllKeys.Any())
		{
			ActionResult val = BaseIndex(FilterId, "FilterId", "Search");
			if (val != null)
			{
				return val;
			}
		}
		FilterModel filterModel = CreateFilter(FilterId);
		filterModel.ZoneMode = ZoneMode.FilterSerach;
		GridDataFilter<IDocument> gridDataFilter = ((((Controller)this).get_Request().QueryString.Count != 1 || !(((Controller)this).get_Request()["FilterId"] == "0")) ? CreateGridData(null, filterModel) : HtmlExtensions.CreateGridDataNoData<IDocument>(null, filterModel));
		CheckFullTextSearchModel checkFullTextSearchModel = IsFullTextSearch(filterModel.Filter);
		DocumentFilterModel documentFilterModel = new DocumentFilterModel
		{
			Entity = (IFilterDocumentFolder)filterModel.Entity,
			SerachOnOpen = (searchOnOpen.HasValue && searchOnOpen.Value),
			GridData = gridDataFilter,
			UseFullTextSearch = (IsTextSearchServiceEnabled() && checkFullTextSearchModel.IsFullTextSearch),
			EQLSearch = !string.IsNullOrEmpty(filterModel.Filter.Query)
		};
		if (!searchOnOpen.HasValue || !searchOnOpen.Value || (IsTextSearchServiceEnabled() && documentFilterModel.UseFullTextSearch))
		{
			gridDataFilter.SetCount((GridData<IDocument> d, FetchOptions f) => 0L);
		}
		if (IsTextSearchServiceEnabled() && !documentFilterModel.UseFullTextSearch)
		{
			documentFilterModel.UseFullTextSearchErrors = checkFullTextSearchModel.ErrorsString;
		}
		return (ActionResult)(object)((Controller)this).View("View", (object)documentFilterModel);
	}

	public ActionResult View(long? FilterId = null)
	{
		ActionResult val = BaseIndex(FilterId, "FilterId", "View");
		if (val != null)
		{
			return val;
		}
		FilterModel filterModel = CreateFilter(FilterId);
		filterModel.ZoneMode = ZoneMode.FilterSerach;
		GridDataFilter<IDocument> gridDataFilter = CreateGridData(null, filterModel);
		CheckFullTextSearchModel checkFullTextSearchModel = IsFullTextSearch(filterModel.Filter);
		DocumentFilterModel documentFilterModel = new DocumentFilterModel
		{
			Entity = (IFilterDocumentFolder)filterModel.Entity,
			GridData = gridDataFilter,
			UseFullTextSearch = (!FilterId.HasValue && checkFullTextSearchModel.IsFullTextSearch)
		};
		documentFilterModel.SerachOnOpen = documentFilterModel.Entity.SearchOnOpen;
		if (!documentFilterModel.Entity.SearchOnOpen || !FilterId.HasValue || FilterId.Value == 0L || (IsTextSearchServiceEnabled() && documentFilterModel.UseFullTextSearch))
		{
			gridDataFilter.SetCount((GridData<IDocument> d, FetchOptions f) => 0L);
		}
		if (IsTextSearchServiceEnabled() && !documentFilterModel.UseFullTextSearch)
		{
			documentFilterModel.UseFullTextSearchErrors = checkFullTextSearchModel.ErrorsString;
		}
		return (ActionResult)(object)((Controller)this).View((object)documentFilterModel);
	}

	protected override FilterModel CreateFilter(long? FilterId = null, Guid? FilterCode = null, IEntityFilter filterToMerge = null, GridState getSourceForRefresh = null, string updatePrefix = "Filter")
	{
		return CreateFilterModel(FilterId, FilterCode, filterToMerge, getSourceForRefresh, updatePrefix);
	}

	private FilterModel CreateFilterModel(long? FilterId = null, Guid? FilterCode = null, IEntityFilter filterToMerge = null, GridState getSourceForRefresh = null, string updatePrefix = "Filter", Guid? filterModelTypeUid = null)
	{
		Guid.TryParse(((Controller)this).get_Request()["FilterTypeSelector"], out var result);
		IFilterDocumentFolder filterDocumentFolder;
		if (!(FilterId > 0))
		{
			InstanceOf<IFilterDocumentFolder> instanceOf = new InstanceOf<IFilterDocumentFolder>();
			instanceOf.New.SearchOnOpen = true;
			instanceOf.New.Virtual = true;
			filterDocumentFolder = instanceOf.New;
		}
		else
		{
			filterDocumentFolder = FilterDocumentFolderManager.Instance.Load(FilterId.Value);
		}
		IFilterDocumentFolder filterDocumentFolder2 = filterDocumentFolder;
		if (filterDocumentFolder2.FilterFields == null && result != Guid.Empty)
		{
			object obj = InterfaceActivator.Create(MetadataLoader.GetFilterType(result));
			filterDocumentFolder2.FilterFields = UniversalFilterSaver.Pack((IEntityFilter)obj);
		}
		Guid result2 = Guid.Empty;
		if (filterModelTypeUid.HasValue)
		{
			result2 = filterModelTypeUid.Value;
		}
		else if (((Controller)this).get_Request()["Filter.Types[0].TypeUid"] != null && ((Controller)this).get_Request()["Filter.Types[1].TypeUid"] == null)
		{
			Guid.TryParse(((Controller)this).get_Request()["Filter.Types[0].TypeUid"], out result2);
		}
		Guid filterObjectTypeUid = FilterObjectTypeUid(filterDocumentFolder2, FilterCode);
		Guid? typeUid = ((result2 != Guid.Empty) ? new Guid?(result2) : null);
		Guid? filterCode = FilterCode ?? Code;
		FilterModel filterModel = new FilterModel(filterDocumentFolder2, filterObjectTypeUid, typeUid, null, "Filter", filterToMerge, filterCode, EnableEqlQuery, getSourceForRefresh, null, TypesRootName, InterfaceActivator.TypeOf<IFilterDocumentFolder>())
		{
			DisableColumnSettings = DisableColumnSettings
		};
		bool disableSecurity = filterModel.Filter.DisableSecurity;
		((Controller)this).TryUpdateModel<IEntityFilter>(filterModel.Filter, updatePrefix);
		filterModel.Filter.DisableSecurity = disableSecurity;
		if (!string.IsNullOrEmpty(GridIdPrefix))
		{
			filterModel.GridIdPrefix = GridIdPrefix;
		}
		return filterModel;
	}

	[HttpGet]
	public ActionResult SearchDocumentPortlet(SearchDocumentPersonalization settings)
	{
		SearchDocumentPortletInfo searchDocumentPortletInfo = new SearchDocumentPortletInfo
		{
			Personalization = settings,
			FilterModel = EmptyFilterModel(null, setMyDocumentFolderIfNull: false)
		};
		return (ActionResult)(object)((Controller)this).PartialView("SearchDocumentPortlet", (object)searchDocumentPortletInfo);
	}

	[HttpGet]
	public ActionResult SearchDocument()
	{
		return (ActionResult)(object)((Controller)this).PartialView("Filter", (object)new SearchDocumentInfo
		{
			FilterModel = EmptyFilterModel(null, setMyDocumentFolderIfNull: false)
		});
	}

	[TransactionAction]
	public override ActionResult FilterSave(string FilterName, [Bind(Prefix = "DataFilter")] FilterModel model)
	{
		IFilterDocumentFolder filterDocumentFolder = (IFilterDocumentFolder)model.Entity;
		IFilterBase filterBase = model.CreateCopyFilter(FilterName, InterfaceActivator.TypeOf<IFilterDocumentFolder>());
		IFilterDocumentFolder filterDocumentFolder2 = (IFilterDocumentFolder)filterBase;
		filterDocumentFolder2.Folder = filterDocumentFolder.Folder;
		if (filterDocumentFolder2.Folder != null && !base.SecurityService.HasPermission(PermissionProvider.DocumentEditPermission, filterDocumentFolder2.Folder) && !base.SecurityService.HasPermission(PermissionProvider.DocumentFullAccessPermission, filterDocumentFolder2.Folder))
		{
			throw FolderManager.Instance.CreateSecurityException(SR.T("Нет прав доступа на папку \"{0}\"({1})", filterDocumentFolder2.Folder.Name, filterDocumentFolder2.Folder.Id), filterDocumentFolder2.Folder.Id);
		}
		filterDocumentFolder2.Virtual = true;
		filterDocumentFolder2.SearchOnOpen = filterDocumentFolder.IsNew() || filterDocumentFolder.SearchOnOpen;
		model.Entity = filterBase;
		model.Entity.Save();
		filterDocumentFolder.Refresh();
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			filterId = model.Entity.Id,
			filterName = model.Entity.Name
		}, (JsonRequestBehavior)0);
	}

	public ActionResult CheckFullTextSearch([Bind(Prefix = "DataFilter")] FilterModel model)
	{
		IFullTextSearchService serviceNotNull = Locator.GetServiceNotNull<IFullTextSearchService>();
		DocumentsFullTextSearchSettingsModule serviceNotNull2 = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
		if (!serviceNotNull.IndexingIsWorking() && serviceNotNull2.Settings != null && serviceNotNull2.Settings.Indexing)
		{
			((Controller)this).Json((object)new
			{
				fulltext = false
			});
		}
		CheckFullTextSearchModel checkFullTextSearchModel = IsFullTextSearch(model.Filter);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			fulltext = !checkFullTextSearchModel.Errors.Any(),
			errors = checkFullTextSearchModel.ErrorsString
		});
	}

	protected bool IsTextSearchServiceEnabled()
	{
		IFullTextSearchService serviceNotNull = Locator.GetServiceNotNull<IFullTextSearchService>();
		DocumentsFullTextSearchSettingsModule serviceNotNull2 = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
		if (serviceNotNull.IndexingIsWorking() && serviceNotNull2.Settings != null)
		{
			return serviceNotNull2.Settings.Indexing;
		}
		return false;
	}

	protected bool IsFullTextSearch(FilterModel filter)
	{
		if (filter == null)
		{
			return false;
		}
		return IsFullTextSearch(filter.Filter).IsFullTextSearch;
	}

	private CheckFullTextSearchModel IsFullTextSearch(IEntityFilter filter)
	{
		CheckFullTextSearchModel checkFullTextSearchModel = new CheckFullTextSearchModel();
		if (filter == null || string.IsNullOrWhiteSpace(filter.SearchString) || filter.SearchString.Length < 3)
		{
			checkFullTextSearchModel.Errors.Add(SR.T("Поисковая строка состоит менее чем из 3 символов"));
		}
		IEnumerable<INeedFullTextSearchCheck> extensionPoints = ComponentManager.Current.GetExtensionPoints<INeedFullTextSearchCheck>();
		IDocumentFilter filter2 = (IDocumentFilter)filter;
		foreach (INeedFullTextSearchCheck item in extensionPoints)
		{
			item.HasUserFields(filter2, checkFullTextSearchModel);
		}
		return checkFullTextSearchModel;
	}

	public ActionResult DocumentTypeTable(Guid[] typeUid, string prefix, string onchange, Guid? parentTypeUid = null)
	{
		if (typeUid == null)
		{
			typeUid = new Guid[0];
		}
		List<Guid> list = typeUid.Distinct().ToList();
		list.RemoveAll((Guid t) => t == Guid.Empty);
		((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(prefix);
		((ControllerBase)this).get_ViewData().set_Item("OnChangeHandler", (object)onchange);
		((ControllerBase)this).get_ViewData().set_Item("ParentTypeUid", (object)parentTypeUid);
		return (ActionResult)(object)((Controller)this).PartialView("EditorTemplates/DocumentTypeTable", (object)list.Select((Guid u) => new ReferenceOnEntityType
		{
			TypeUid = u
		}).ToList());
	}

	public ActionResult GetBaseDocumentTypeFromTypes(Guid[] docTypeUids)
	{
		if (docTypeUids == null || docTypeUids.Length == 0)
		{
			return null;
		}
		if (docTypeUids.Length == 1)
		{
			return (ActionResult)(object)((Controller)this).Content(JsonConvert.SerializeObject((object)new
			{
				typeUid = docTypeUids[0],
				typeName = (MetadataLoader.GetFilterType(docTypeUids[0]) ?? typeof(Filter))
			}));
		}
		Type type = InterfaceActivator.TypeOf<IDocument>();
		IMetadataRuntimeService metadataRuntimeService = MetadataServiceContext.MetadataRuntimeService;
		Type[] array = docTypeUids.Select((Guid uid) => metadataRuntimeService.GetTypeByUid(uid)).ToArray();
		bool flag = true;
		int num = 1;
		Guid guid;
		while (flag)
		{
			flag = false;
			for (int i = num; i < array.Length; i++)
			{
				if (array[0].Equals(array[i]) || array[0].IsAssignableFrom(array[i]))
				{
					continue;
				}
				if (array[i].IsAssignableFrom(array[0]))
				{
					array[0] = array[i];
					continue;
				}
				if (array[0] == type || array[i] == type)
				{
					guid = InterfaceActivator.UID<IDocument>();
					return (ActionResult)(object)((Controller)this).Content(JsonConvert.SerializeObject((object)new
					{
						typeUid = guid,
						typeName = (MetadataLoader.GetFilterType(guid) ?? typeof(Filter))
					}));
				}
				array[i] = array[i].BaseType;
				array[0] = array[0].BaseType;
				num = i;
				flag = true;
			}
		}
		guid = InterfaceActivator.UID(array[0]);
		return (ActionResult)(object)((Controller)this).Content(JsonConvert.SerializeObject((object)new
		{
			typeUid = guid,
			typeName = (MetadataLoader.GetFilterType(guid) ?? typeof(Filter))
		}));
	}

	public ActionResult LifeCycleStatusTable(long[] statusId, Guid[] docType, string prefix)
	{
		if (statusId == null)
		{
			statusId = new long[0];
		}
		List<long> list = statusId.Distinct().ToList();
		list.RemoveAll((long t) => t == 0);
		((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(prefix);
		if (docType != null)
		{
			List<ReferenceOnEntityType> documentsTypes = null;
			List<Guid> list2 = docType.Where((Guid t) => t != Guid.Empty).ToList();
			if (list2.Count > 0)
			{
				documentsTypes = list2.Select(delegate(Guid t)
				{
					EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(t);
					return new ReferenceOnEntityType
					{
						TypeUid = entityMetadata.ImplementationUid
					};
				}).ToList();
			}
			List<ILifeCycleStatus> cycles = LifeCycleStatusManager.Instance.GetStatusesByTypes("", documentsTypes);
			list.RemoveAll((long s) => !cycles.Any((ILifeCycleStatus c) => c.Id == s));
			((ControllerBase)this).get_ViewData().set_Item("DocTypeFilter", (object)docType.ToList());
		}
		return (ActionResult)(object)((Controller)this).PartialView("EditorTemplates/LifeCycleStatusTable", (object)new HashedSet<ILifeCycleStatus>((ICollection<ILifeCycleStatus>)list.Select((long u) => LifeCycleStatusManager.Instance.Load(u)).ToList()));
	}

	[CustomGridAction]
	public override ActionResult Grid(GridCommand command, [Bind(Prefix = "DataFilter")] FilterModel model, long? FilterId = null, string SearchTasksType = null)
	{
		((ControllerBase)this).get_ViewData().set_Item("InPortlet", (object)(((Controller)this).get_RouteData().Values["portlet"] != null));
		return base.Grid(command, model, FilterId, SearchTasksType);
	}

	public ActionResult SearchDocumentPopup(Guid popupUid, string inputName, Guid typeUid, bool showOnlyGroups, string entityFilterProvider, string entityFilterData, int popupWidth, bool multiSelect)
	{
		SearchEntityPopupModel searchEntityPopupModel = new SearchEntityPopupModel
		{
			TypeUid = typeUid,
			PopupUid = popupUid,
			InputName = inputName,
			ShowOnlyGroups = showOnlyGroups,
			EntityFilterData = entityFilterData,
			EntityFilterProvider = entityFilterData,
			PopupWidth = popupWidth,
			MultiSelect = multiSelect
		};
		return (ActionResult)(object)((Controller)this).PartialView("Document/SearchDocumentPopup", (object)searchEntityPopupModel);
	}

	[CustomGridAction]
	public ActionResult DocumentExplorerGrid(GridCommand command, [Bind(Prefix = "DataFilter")] FilterModel model, string inputPrefix, string inputId = null, bool? multiSelect = false, Guid? typeUid = null, string filterProviderData = null, string prefixUid = null)
	{
		((ControllerBase)this).get_ViewData().set_Item("InputId", (object)inputId);
		if (string.IsNullOrWhiteSpace(prefixUid))
		{
			prefixUid = Guid.NewGuid().ToString("n");
		}
		((ControllerBase)this).get_ViewData().set_Item("prefixUid", (object)$"{prefixUid}");
		((ControllerBase)this).get_ViewData().set_Item("filterGridId", (object)$"Explorer_{prefixUid}");
		((ControllerBase)this).get_ViewData().set_Item("PopupId", (object)$"ExplorerPopup_{prefixUid}");
		((ControllerBase)this).get_ViewData().set_Item("MultiSelect", (object)(multiSelect == true));
		if (model == null)
		{
			model = CreateFilterModel();
		}
		if (typeUid.HasValue)
		{
			Guid filterTypeUid = model.FilterTypeUid;
			Guid? guid = typeUid;
			if (filterTypeUid != guid)
			{
				model.FilterTypeUid = typeUid.Value;
			}
		}
		IDocumentFilter documentFilter = model.Filter as IDocumentFilter;
		if (documentFilter != null && documentFilter.Types != null && documentFilter.Types.Count == 1 && documentFilter.Types[0] == null && model.ParentTypeUid.HasValue)
		{
			documentFilter.Types[0] = new ReferenceOnEntityType
			{
				TypeUid = model.ParentTypeUid.Value
			};
		}
		GridDataFilter<IDocument> gridData = CreateGridData(command, model);
		if (documentFilter != null && !string.IsNullOrEmpty(documentFilter.Query))
		{
			((ControllerBase)this).get_ViewData().set_Item("EQLSearch", (object)true);
		}
		return GridView("Folder/DocumentExplorerGrid", gridData);
	}

	[CreatorForm]
	[CustomGridAction]
	public ActionResult DocumentExplorer(GridCommand command, string inputId, string inputPrefix, string inputPostFix, bool? multiSelect = false, string filterProviderUid = null, string filterProviderData = null, Guid? typeUid = null, string filterQuery = null, string prefixUid = null)
	{
		((ControllerBase)this).get_ViewData().set_Item("InputId", (object)inputId);
		((ControllerBase)this).get_ViewData().set_Item("MultiSelect", (object)(multiSelect == true));
		if (string.IsNullOrWhiteSpace(prefixUid))
		{
			prefixUid = Guid.NewGuid().ToString("n");
		}
		((ControllerBase)this).get_ViewData().set_Item("prefixUid", (object)$"{prefixUid}");
		((ControllerBase)this).get_ViewData().set_Item("filterGridId", (object)$"Explorer_{prefixUid}");
		((ControllerBase)this).get_ViewData().set_Item("PopupId", (object)$"ExplorerPopup_{prefixUid}");
		FilterModel filterModel = CreateFilterModel(null, null, null, null, "Filter", typeUid);
		filterModel.EnableSave = false;
		filterModel.ZoneMode = ZoneMode.FilterSerach;
		GridDataFilter<IDocument> gridDataFilter = CreateGridData(null, filterModel);
		DocumentFilterModel documentFilterModel = new DocumentFilterModel
		{
			Entity = (IFilterDocumentFolder)filterModel.Entity,
			GridData = gridDataFilter,
			UseFullTextSearch = false,
			EQLSearch = !string.IsNullOrEmpty(filterProviderData)
		};
		IDmsObjectFilter dmsObjectFilter = filterModel.Filter as IDmsObjectFilter;
		if (dmsObjectFilter != null && !string.IsNullOrEmpty(filterProviderData))
		{
			dmsObjectFilter.Query = filterProviderData;
			documentFilterModel.EQLSearch = false;
			((ControllerBase)this).get_ViewData().set_Item("EQLSearch", (object)false);
			filterModel.EnableEqlQuery = false;
		}
		if (typeUid.HasValue)
		{
			if (dmsObjectFilter != null)
			{
				dmsObjectFilter.DocumentType = typeUid;
			}
			filterModel.ParentTypeUid = typeUid;
		}
		string text = $"Explorer_{inputId}_{prefixUid}";
		((ControllerBase)this).get_ViewData().set_Item("filterGridId", (object)text);
		((Controller)this).get_RouteData().Values.Add("prefix", text);
		documentFilterModel.SerachOnOpen = documentFilterModel.Entity.SearchOnOpen;
		gridDataFilter.SetCount((GridData<IDocument> d, FetchOptions f) => 0L);
		return (ActionResult)(object)((Controller)this).PartialView("Folder/DocumentExplorer", (object)documentFilterModel);
	}
}
