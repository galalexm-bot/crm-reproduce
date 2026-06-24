using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class FilterModel : EntityModel<IFilterBase>
{
	public const string EqlPropertyUID_S = "{EBB4D57E-E7EB-43E4-B9D4-185883002DCD}";

	public static readonly Guid ObjectsTypePropertyUid = ReferenceOnEntityTypeDecription.TypeUid_UID;

	public static readonly Guid EqlPropertyUid = new Guid("{EBB4D57E-E7EB-43E4-B9D4-185883002DCD}");

	public bool ExistPropertiesForFastSearch = true;

	private bool expandable = true;

	private List<SelectListItem> filterColumnsAvailable;

	private List<SelectListItem> filterColumnsSelected;

	private Dictionary<Guid, string> properiesStyles;

	internal UrlHelper Url => new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext);

	public string TypesRootName { get; set; }

	public string Header { get; set; }

	public Guid? ParentTypeUid { get; set; }

	public Guid FilterTypeUid { get; set; }

	public Guid? MainTypeUid { get; set; }

	public IEntityFilter Filter { get; set; }

	public bool EnableEqlQuery { get; set; }

	public bool DisableColumnSettings { get; set; }

	public bool DisablePermissionSettings { get; set; }

	public string UniquePostfixForIds { get; set; }

	public bool DisableColumnsRefresh { get; set; }

	public string SaveFilterCallback { get; set; }

	public GridState GetSourceForRefresh { get; set; }

	public List<SelectListItem> FilterColumnsAvailable
	{
		get
		{
			if (filterColumnsAvailable == null)
			{
				FillAvailableColumns();
			}
			return filterColumnsAvailable;
		}
		set
		{
			filterColumnsAvailable = value;
		}
	}

	public bool Expandable
	{
		get
		{
			return expandable;
		}
		set
		{
			expandable = value;
		}
	}

	public List<SelectListItem> FilterColumnsSelected
	{
		get
		{
			if (filterColumnsSelected == null)
			{
				FillAvailableColumns();
			}
			return filterColumnsSelected;
		}
		set
		{
			filterColumnsSelected = value;
		}
	}

	public FilterFolderManager FilterFolderManager => ComponentManager.Current.GetExtensionPointByType<FilterFolderManager>();

	public GridState GridState { get; set; }

	public bool ShowAllFields { get; set; }

	public string GridIdPrefix { get; set; }

	public string GridStatePrefix { get; set; }

	public string GridStateId { get; set; }

	public ZoneMode? ZoneMode { get; set; }

	public string FastSaveFilterAction { get; set; }

	public string FastSaveFilterActionSave { get; set; }

	public string FastSaveFilterController { get; set; }

	public string FastSaveFilterArea { get; set; }

	public string FilterLinkUrl { get; set; }

	public string FilterLinkSaveSelector { get; set; }

	public string FilterMenuItemCode { get; set; }

	protected Dictionary<Guid, string> PropertyStyles
	{
		get
		{
			if (properiesStyles == null)
			{
				List<KeyValuePair<Guid, string>> list = (from s in ComponentManager.Current.GetExtensionPoints<IFilterPropertyStyler>()
					where s.CheckType(this)
					select s).SelectMany((IFilterPropertyStyler s) => s.Styles).ToList();
				Dictionary<Guid, string> dictionary = new Dictionary<Guid, string>();
				foreach (KeyValuePair<Guid, string> item in list)
				{
					if (!dictionary.ContainsKey(item.Key))
					{
						dictionary.Add(item.Key, item.Value);
					}
				}
				properiesStyles = dictionary;
			}
			return properiesStyles;
		}
	}

	public List<PropertiesViewModel.PropertyItem> VisibleProperties { get; set; }

	public List<PropertiesViewModel.PropertyItem> InvisibleProperties { get; set; }

	public List<string> DisableSaveColumns { get; set; }

	public string ShowOnlyMyProperty { get; set; }

	public bool ShowFullTextInAttachments { get; set; }

	public string ShowOnlyMyPropertyDisplayName { get; set; }

	public string ShowFullTextInAttachmentsDisplayName { get; set; }

	public string ApplayFilterScript { get; set; }

	public string GridAction { get; set; }

	public Dictionary<string, object> HiddenInputs { get; set; }

	public Func<HtmlHelper<FilterModel>, MvcHtmlString> SimpleSearchTr { get; set; }

	public Func<HtmlHelper<FilterModel>, MvcHtmlString> HeaderContent { get; set; }

	public string SubmitText { get; set; }

	public bool? EnableSave { get; set; }

	public string ExtededSearchText { get; set; }

	public string SimpleSearchText { get; set; }

	public string FilterUrl { get; set; }

	public List<string> HiddenColumns { get; set; }

	public List<string> IgnoreColumns { get; set; }

	public List<Guid> DefaultFields { get; set; }

	public List<Guid> ForceMoveFields { get; set; }

	public IList<ActionButton> Buttons { get; private set; }

	protected void InitEmptyModel(Type filterEntityType = null)
	{
		object entity;
		if (!(filterEntityType != null))
		{
			IFilterBase filterBase = InterfaceActivator.Create<IFilter>();
			entity = filterBase;
		}
		else
		{
			entity = (IFilterBase)InterfaceActivator.Create(filterEntityType);
		}
		base.Entity = (IFilterBase)entity;
		base.Entity.ObjectsType = new ReferenceOnEntityType();
		base.Entity.UseDefaultSettings = true;
		GridIdPrefix = "Filter";
	}

	public FilterModel()
	{
		InitEmptyModel();
		FastSaveFilterAction = "FastFilterSave";
		FastSaveFilterActionSave = "FilterSave";
		Buttons = new List<ActionButton>();
	}

	[Obsolete("Ипользовать конструктор без параметра subTypes", true)]
	public FilterModel(IFilter filter, Guid filterObjectTypeUid, bool subTypes, Guid? typeUid = null, Guid? mainTypeUid = null, Dictionary<Guid, Type> filterTypes = null, string gridStatePrefix = "Filter", IEntityFilter filterToMerge = null, Guid? filterCode = null, bool enableEqlQuery = false, GridState getSourceForRefresh = null, string gridIdPrefix = null, string typesRootName = null)
		: this(filter, filterObjectTypeUid, typeUid, mainTypeUid, gridStatePrefix, filterToMerge, filterCode, enableEqlQuery, getSourceForRefresh, gridIdPrefix, typesRootName)
	{
	}

	public FilterModel(IFilterBase filter, Guid filterObjectTypeUid, Guid? typeUid = null, Guid? mainTypeUid = null, string gridStatePrefix = "Filter", IEntityFilter filterToMerge = null, Guid? filterCode = null, bool enableEqlQuery = false, GridState getSourceForRefresh = null, string gridIdPrefix = null, string typesRootName = null, Type filterEntityType = null)
		: this(new FilterModelSettings
		{
			Filter = filter,
			FilterObjectTypeUid = filterObjectTypeUid,
			TypeUid = typeUid,
			MainTypeUid = mainTypeUid,
			GridStatePrefix = gridStatePrefix,
			FilterToMerge = filterToMerge,
			FilterCode = filterCode,
			EnableEqlQuery = enableEqlQuery,
			GetSourceForRefresh = getSourceForRefresh,
			GridIdPrefix = gridIdPrefix,
			TypesRootName = typesRootName,
			FilterEntityType = filterEntityType
		})
	{
	}

	public FilterModel(FilterModelSettings filterModelSettings)
	{
		Contract.ArgumentNotNull(filterModelSettings, "filterModelSettings");
		if (filterModelSettings.FilterEntityType != null)
		{
			InitEmptyModel(filterModelSettings.FilterEntityType);
		}
		FastSaveFilterAction = "FastFilterSave";
		FastSaveFilterActionSave = "FilterSave";
		GetSourceForRefresh = filterModelSettings.GetSourceForRefresh;
		base.Entity = filterModelSettings.Filter ?? InterfaceActivator.Create<IFilter>();
		GridStatePrefix = filterModelSettings.GridStatePrefix;
		GridStateId = filterModelSettings.GridStateId;
		MainTypeUid = filterModelSettings.MainTypeUid;
		EnableEqlQuery = filterModelSettings.EnableEqlQuery;
		base.Entity.ObjectsType = new ReferenceOnEntityType
		{
			TypeUid = filterModelSettings.FilterObjectTypeUid
		};
		if (base.Entity.IsNew())
		{
			base.Entity.Code = filterModelSettings.FilterCode;
			base.Entity.UseDefaultSettings = true;
		}
		object obj = null;
		if (filterModelSettings.FilterToMerge != null)
		{
			obj = UniversalFilterSaver.Pack(filterModelSettings.FilterToMerge);
		}
		IEntityFilter entityFilter = UniversalFilterSaver.UnPack(base.Entity.FilterFields);
		if (obj != null && entityFilter != null)
		{
			entityFilter = UniversalFilterSaver.UnPack(obj, null, entityFilter);
		}
		if (entityFilter == null)
		{
			IEntityFilter entityFilter2 = (IEntityFilter)InterfaceActivator.Create(MetadataLoader.GetFilterType(filterModelSettings.TypeUid ?? MainTypeUid ?? base.Entity.ObjectsType.TypeUid) ?? typeof(Filter));
			entityFilter = ((obj == null) ? entityFilter2 : UniversalFilterSaver.UnPack(obj, null, entityFilter2));
		}
		Filter = entityFilter;
		FilterTypeUid = MetadataLoader.GetEntityMetadataByFilter(Filter.GetType())?.Uid ?? (EnableEqlQuery ? filterModelSettings.FilterObjectTypeUid : Guid.Empty);
		if (string.IsNullOrEmpty(filterModelSettings.GridIdPrefix))
		{
			try
			{
				GridIdPrefix = base.Entity.ObjectsType.EntityType.Name;
			}
			catch
			{
				GridIdPrefix = "Filter";
			}
		}
		else
		{
			GridIdPrefix = filterModelSettings.GridIdPrefix;
		}
		TypesRootName = filterModelSettings.TypesRootName;
		Buttons = new List<ActionButton>();
		ReInit();
	}

	public void ReInit()
	{
		FillGridState();
		FillAvailableColumns();
	}

	private IUniqueFilterExtension UniqueFilterExtension(Guid? typeUid)
	{
		if (!typeUid.HasValue)
		{
			return null;
		}
		return UniqueFilterHelper.GetExtension(typeUid.Value);
	}

	private void FillAvailableColumns()
	{
		Dictionary<Guid, Guid> universalFilterUnPackFromDictionary = new Dictionary<Guid, Guid>();
		List<FilterMetadataProperty> metadataProperties = ((FilterTypeUid != Guid.Empty) ? FilterTypeUid : base.Entity.ObjectsType.TypeUid).LoadFilterMetadataProperties(withSubTypes: false, Filter, "", universalFilterUnPackFromDictionary, null, MainTypeUid ?? base.Entity.ObjectsType.TypeUid, base.Entity.Code).ToList();
		if (EnableEqlQuery)
		{
			metadataProperties.Insert(0, new FilterMetadataProperty
			{
				ClassDisplayName = "",
				PropertyName = "EQLQuery",
				PropertyDisplayName = SR.T("EQL-запрос"),
				PropertyUid = EqlPropertyUid
			});
		}
		List<SearchFieldsData> searchFields;
		if (base.Entity.SearchFields != null)
		{
			if (base.Entity.SearchFields is List<string>)
			{
				base.Entity.SearchFields = (from sf in (List<string>)base.Entity.SearchFields
					select (from prop in metadataProperties
						where (!sf.Contains(".")) ? (sf == prop.PropertyName) : (sf == prop.ClassFullName + "." + prop.PropertyName)
						select new SearchFieldsData
						{
							PropertyUid = prop.PropertyUid,
							PropertyName = prop.PropertyName
						}).FirstOrDefault() into sf
					where sf != null
					select sf).ToList();
			}
			else if (base.Entity.SearchFields is List<Guid>)
			{
				base.Entity.SearchFields = (from sf in (List<Guid>)base.Entity.SearchFields
					select (!universalFilterUnPackFromDictionary.ContainsKey(sf)) ? sf : universalFilterUnPackFromDictionary[sf] into sf
					select (from prop in metadataProperties
						where prop.PropertyUid == sf
						select new SearchFieldsData
						{
							PropertyUid = prop.PropertyUid,
							PropertyName = prop.PropertyName
						}).FirstOrDefault() into sf
					where sf != null
					select sf).ToList();
			}
			searchFields = (List<SearchFieldsData>)base.Entity.SearchFields;
			int i;
			for (i = 0; i < searchFields.Count; i++)
			{
				if (universalFilterUnPackFromDictionary.ContainsKey(searchFields[i].PropertyUid))
				{
					searchFields[i].PropertyUid = universalFilterUnPackFromDictionary[searchFields[i].PropertyUid];
					FilterMetadataProperty filterMetadataProperty = metadataProperties.FirstOrDefault((FilterMetadataProperty p) => p.PropertyUid == searchFields[i].PropertyUid);
					if (filterMetadataProperty != null)
					{
						int num = searchFields[i].PropertyName.LastIndexOf('.');
						searchFields[i].PropertyName = ((num >= 0) ? searchFields[i].PropertyName.Remove(num + 1) : "") + filterMetadataProperty.PropertyName;
					}
				}
			}
		}
		else
		{
			base.Entity.SearchFields = (searchFields = metadataProperties.Select((FilterMetadataProperty prop) => new SearchFieldsData
			{
				PropertyUid = prop.PropertyUid,
				PropertyName = prop.PropertyName
			}).ToList());
		}
		metadataProperties.RemoveAll((FilterMetadataProperty prop) => !prop.Visible || prop.Hidden);
		var source = metadataProperties.Select(delegate(FilterMetadataProperty prop)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Expected O, but got Unknown
			SelectListItem val = new SelectListItem();
			val.set_Text(prop.PropertyDisplayName + ((!string.IsNullOrEmpty(prop.PropertyPath) && metadataProperties.Any((FilterMetadataProperty p) => p.PropertyName != prop.PropertyName && p.PropertyDisplayName == prop.PropertyDisplayName)) ? (" (" + prop.PropertyPath + ")") : ""));
			val.set_Value(new SearchFieldsData
			{
				PropertyUid = prop.PropertyUid,
				PropertyName = prop.PropertyName
			}.ToString());
			return new
			{
				SelectListItem = val,
				PropertyUid = prop.PropertyUid,
				PropertyName = prop.PropertyName
			};
		}).ToArray();
		if (base.Entity.Id == 0L)
		{
			filterColumnsAvailable = (from prop in source
				where searchFields.All((SearchFieldsData sf) => sf.PropertyName != prop.PropertyName || prop.PropertyUid == EqlPropertyUid)
				select prop.SelectListItem).ToList();
			filterColumnsSelected = (from prop in source
				where searchFields.Any((SearchFieldsData sf) => sf.PropertyName == prop.PropertyName && prop.PropertyUid != EqlPropertyUid)
				select prop.SelectListItem).ToList();
			return;
		}
		IEntityFilter entityFilter = UniversalFilterSaver.UnPack(base.Entity.FilterFields);
		if (entityFilter != null)
		{
			ClassMetadata entityMetadataByFilter = MetadataLoader.GetEntityMetadataByFilter(entityFilter.GetType());
			if (entityMetadataByFilter != null && entityMetadataByFilter.Uid != FilterTypeUid)
			{
				List<Guid> entityMetadataProperties = (from p in entityMetadataByFilter.Uid.LoadFilterMetadataProperties(withSubTypes: false, entityFilter, "", universalFilterUnPackFromDictionary, null, MainTypeUid ?? base.Entity.ObjectsType.TypeUid, base.Entity.Code)
					select p.PropertyUid).ToList();
				searchFields.AddRange((from p in metadataProperties
					select new SearchFieldsData
					{
						PropertyUid = p.PropertyUid,
						PropertyName = p.PropertyName
					} into p
					where !entityMetadataProperties.Contains(p.PropertyUid) && !searchFields.Any((SearchFieldsData f) => f.PropertyUid == p.PropertyUid)
					select p).ToArray());
			}
		}
		filterColumnsAvailable = (from prop in source
			where searchFields.All((SearchFieldsData sf) => sf.PropertyName != prop.PropertyName)
			select prop.SelectListItem).ToList();
		filterColumnsSelected = new List<SelectListItem>();
		foreach (SearchFieldsData sf2 in searchFields)
		{
			var anon = source.FirstOrDefault(p => p.PropertyName == sf2.PropertyName);
			if (anon != null)
			{
				if (sf2.PropertyUid == EqlPropertyUid)
				{
					filterColumnsSelected.Insert(0, anon.SelectListItem);
				}
				else
				{
					filterColumnsSelected.Add(anon.SelectListItem);
				}
			}
		}
	}

	public void FillGridState()
	{
		IUniqueFilterExtension uniqueFilterExtension = UniqueFilterExtension(base.Entity.ObjectsType.TypeUid);
		Type type = ((uniqueFilterExtension != null) ? uniqueFilterExtension.EntityType : Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(MainTypeUid ?? base.Entity.ObjectsType.TypeUid));
		IFilterGridStateCreator filterGridStateCreator = ComponentManager.Current.GetExtensionPoints<IFilterGridStateCreator>().FirstOrDefault((IFilterGridStateCreator c) => c.CheckType(this));
		if (filterGridStateCreator != null)
		{
			if (GetSourceForRefresh != null)
			{
				GridState = ((GetSourceForRefresh != null) ? filterGridStateCreator.Refresh(this, GetSourceForRefresh) : filterGridStateCreator.Create(this));
			}
			else
			{
				GridState = ((base.Entity.GridState != null) ? filterGridStateCreator.Refresh(this) : filterGridStateCreator.Create(this));
			}
			if (GridState != null)
			{
				GridState.TypeGridState = filterGridStateCreator.GetGridStateEntityType(this);
			}
			return;
		}
		string gridId = (string.IsNullOrEmpty(GridStateId) ? $"{GridStatePrefix}_{base.Entity.Uid}" : GridStateId);
		GridState = ((base.Entity.GridState != null) ? GridState.Deserialize(base.Entity.GridState) : GridState.CreateNew(gridId, type));
		if (GridState != null)
		{
			GridState.GridId = gridId;
			GridState.TypeGridState = type;
			GridState.Refresh(type);
		}
	}

	public IFilterBase CreateCopyFilter(string filterName, Type filterType)
	{
		IFilterBase filterBase = (IFilterBase)InterfaceActivator.Create(filterType);
		filterBase.FilterFields = UniversalFilterSaver.Pack(Filter);
		filterBase.SearchFields = FilterColumnsSelected.Select((SelectListItem field) => new SearchFieldsData(field.get_Value())).ToList();
		filterBase.Name = filterName;
		filterBase.ObjectsType = base.Entity.ObjectsType;
		if (filterBase is IFilter)
		{
			((IFilter)filterBase).ParentFolder = FilterFolderManager.GetDefaultFilterFolder(base.Entity.ObjectsType, base.Entity.Code);
		}
		filterBase.GridState = ((GridState != null) ? ClassSerializationHelper.SerializeObject(GridState) : null);
		filterBase.ExpandSearch = base.Entity.ExpandSearch;
		filterBase.UseDefaultSettings = base.Entity.UseDefaultSettings;
		filterBase.Code = base.Entity.Code;
		return filterBase;
	}

	public void Save(string filterName, Type filterType)
	{
		IFilterBase filterBase2 = (base.Entity = CreateCopyFilter(filterName, filterType));
		base.Entity.Save();
	}

	public void Save(string filterName)
	{
		Save(filterName, InterfaceActivator.TypeOf<IFilter>());
	}

	public MvcHtmlString PropertyEditor(HtmlHelper<object> helper, FilterMetadataProperty prop, bool isVisibleColumn, List<Guid> defaultFields, List<Guid> forceMoveFields)
	{
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		IFilterPropertyEditorExtension filterPropertyEditorExtension = ComponentManager.Current.GetExtensionPoints<IFilterPropertyEditorExtension>().FirstOrDefault((IFilterPropertyEditorExtension e) => e.Resolve(prop, this));
		if (filterPropertyEditorExtension == null)
		{
			return null;
		}
		MvcHtmlString val = filterPropertyEditorExtension.PropertyEditor(helper, prop, this);
		if (val != null)
		{
			string text = "";
			if (isVisibleColumn)
			{
				text = "editorContainer";
				if (defaultFields != null && defaultFields.Contains(prop.PropertyUid))
				{
					text += " default";
				}
				if (forceMoveFields != null && forceMoveFields.Contains(prop.PropertyUid))
				{
					text += " forcemove";
				}
			}
			string text2 = (PropertyStyles.ContainsKey(prop.PropertyUid) ? PropertyStyles[prop.PropertyUid] : null);
			val = new MvcHtmlString(string.Format("<tr id='{2}_Container' class='{3}'>\r\n<td id='{2}_CaptionContainer' class='captionCell' style='{4}'>{0}</td>\r\n<td id='{2}_ValueContainer'>{1}</td>\r\n</tr>", prop.PropertyDisplayName, ((HtmlString)(object)val).ToHtmlString(), ((ViewDataDictionary)helper.get_ViewData()).get_TemplateInfo().GetFullHtmlFieldId(prop.PropertyName), text, text2));
		}
		return val;
	}

	public void PropertyAction(HtmlHelper<object> helper, FilterMetadataProperty prop, bool isVisibleColumn, List<Guid> defaultFields, List<Guid> forceMoveFields, WebViewAttributes a)
	{
		if (isVisibleColumn)
		{
			a.TrClass = "editorContainer";
			if (defaultFields != null && defaultFields.Contains(prop.PropertyUid))
			{
				a.TrClass += " default";
			}
			if (forceMoveFields != null && forceMoveFields.Contains(prop.PropertyUid))
			{
				a.TrClass += " forcemove";
			}
		}
		a.ReadOnly = false;
		a.Name = prop.PropertyDisplayName;
		a.PropertyPath = prop.PropertyPath;
		if (PropertyStyles.ContainsKey(prop.PropertyUid))
		{
			a.LabelStyle = PropertyStyles[prop.PropertyUid];
		}
		ComponentManager.Current.GetExtensionPoints<IFilterPropertyEditorExtension>().FirstOrDefault((IFilterPropertyEditorExtension e) => e.Resolve(prop, this))?.PropertyAction(helper, prop, this, a);
	}

	public FilterPropertiesTree GetZoneFilterPropertiesTree()
	{
		if (!ZoneMode.HasValue)
		{
			return null;
		}
		return FilterPropertiesZoneExtensions.BuildZoneTree(this);
	}

	public FilterModelBuilder Builder()
	{
		return new FilterModelBuilder(this);
	}

	public bool HasSimpleSearchTr(HtmlHelper<FilterModel> helper)
	{
		if (SimpleSearchTr == null)
		{
			return ((ViewDataDictionary)helper.get_ViewData()).ContainsKey("SimpleSearchTr");
		}
		return true;
	}

	public MvcHtmlString GetSimpleSearchTr(HtmlHelper<FilterModel> helper)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		if (SimpleSearchTr == null)
		{
			if (!((ViewDataDictionary)helper.get_ViewData()).ContainsKey("SimpleSearchTr"))
			{
				return null;
			}
			return (MvcHtmlString)((ViewDataDictionary)helper.get_ViewData()).get_Item("SimpleSearchTr");
		}
		return SimpleSearchTr(helper);
	}
}
