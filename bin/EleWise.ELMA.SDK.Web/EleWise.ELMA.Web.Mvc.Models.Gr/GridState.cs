using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;
using Iesi.Collections.Generic;
using Telerik.Web.Mvc.UI.DropDown;

namespace EleWise.ELMA.Web.Mvc.Models.Grids;

[Serializable]
public class GridState : ICloneable
{
	[NonSerialized]
	public bool refreshed;

	[OptionalField]
	private List<CustomColumnDescriptor> customColumns;

	[NonSerialized]
	private bool saveDefault;

	[OptionalField]
	private Guid providerUid = Guid.Empty;

	[OptionalField]
	private DateTime dateState = DateTime.Now;

	[OptionalField]
	private string providerData;

	[OptionalField]
	private bool saveOnlyInSession;

	private GridStateSet columnStates;

	[OptionalField]
	private string sortExpression = "";

	[NonSerialized]
	private Type typeGridState;

	public string GridId { get; set; }

	public int PageSize { get; set; }

	public int CurrentPage { get; set; }

	public string SortColumnUniqueName { get; set; }

	public ColumnResizeMode ColumnResizeMode { get; set; }

	public ListSortDirection SortDirection { get; set; }

	public bool UseForAllUsers { get; set; }

	public string UniqueName { get; set; }

	public List<CustomColumnDescriptor> CustomColumns
	{
		get
		{
			return customColumns;
		}
		set
		{
			customColumns = value;
		}
	}

	[XmlIgnore]
	public bool SaveDefault
	{
		get
		{
			return saveDefault;
		}
		set
		{
			saveDefault = value;
		}
	}

	public List<GridGroupDescriptor> GroupDescriptors { get; set; }

	[Obsolete("Не использовать! Оставлена для обратной совместимости с настройками")]
	public List<ColumnState> ColumnUids { get; set; }

	public Guid ProviderUid
	{
		get
		{
			return providerUid;
		}
		set
		{
			providerUid = value;
		}
	}

	[XmlIgnore]
	public DateTime DateState
	{
		get
		{
			return dateState;
		}
		set
		{
			dateState = value;
		}
	}

	public string ProviderData
	{
		get
		{
			return providerData;
		}
		set
		{
			providerData = value;
		}
	}

	internal bool SaveOnlyInSession
	{
		get
		{
			return saveOnlyInSession;
		}
		set
		{
			saveOnlyInSession = value;
		}
	}

	public int ExpandedWidth { get; set; }

	public GridStateSet ColumnStates
	{
		get
		{
			if (columnStates == null)
			{
				if (ColumnUids != null)
				{
					ColumnState[] array = new ColumnState[ColumnUids.Count];
					ColumnUids.CopyTo(array);
					columnStates = new GridStateSet(array);
					ColumnUids = null;
				}
				else
				{
					columnStates = new GridStateSet();
				}
			}
			return columnStates;
		}
		internal set
		{
			columnStates = value;
		}
	}

	[XmlIgnore]
	public List<Tuple<string, string>> ColumnsWidth
	{
		get
		{
			return (from c in ColumnStates
				where !c.Hidden
				orderby c.Order
				select new Tuple<string, string>(c.UniqueName, c.WidthAttribute)).ToList();
		}
		set
		{
			if (value == null)
			{
				return;
			}
			foreach (Tuple<string, string> item in value)
			{
				Tuple<string, string> tuple = item;
				ColumnState columnState = ((tuple.Item1 != null) ? ColumnStates[tuple.Item1] : null);
				if (columnState != null)
				{
					columnState.WidthAttribute = item.Item2;
				}
			}
		}
	}

	[XmlIgnore]
	public List<Tuple<string, int>> ColumnsOrder
	{
		get
		{
			return (from c in ColumnStates
				where !c.Hidden
				orderby c.Order
				select new Tuple<string, int>(c.UniqueName, c.Order)).ToList();
		}
		set
		{
			if (value == null)
			{
				return;
			}
			foreach (Tuple<string, int> item in value)
			{
				Tuple<string, int> tuple = item;
				ColumnState columnState = ((tuple.Item1 != null) ? ColumnStates[tuple.Item1] : null);
				if (columnState != null)
				{
					columnState.Order = item.Item2;
				}
			}
		}
	}

	[XmlIgnore]
	public List<SelectListItem> AvailableAndCustomColumns
	{
		get
		{
			List<SelectListItem> list = new List<SelectListItem>(AvailableColumns);
			list.AddRange(((IEnumerable<CustomColumnDescriptor>)CustomColumns).Select((Func<CustomColumnDescriptor, SelectListItem>)delegate(CustomColumnDescriptor cc)
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				//IL_0011: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Expected O, but got Unknown
				SelectListItem val = new SelectListItem();
				val.set_Text(cc.DisplayName);
				val.set_Value(UniqueName);
				return val;
			}));
			return list;
		}
	}

	[XmlIgnore]
	public List<SelectListItem> AvailableColumns
	{
		get
		{
			return ColumnStates.Where((ColumnState c) => c.Hidden && !c.ForceHidden).Select((Func<ColumnState, SelectListItem>)delegate(ColumnState c)
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Unknown result type (might be due to invalid IL or missing references)
				//IL_0023: Expected O, but got Unknown
				SelectListItem val = new SelectListItem();
				val.set_Text(SR.T(c.DisplayName));
				val.set_Value(c.UniqueName);
				return val;
			}).ToList();
		}
		set
		{
			if (value == null)
			{
				return;
			}
			foreach (SelectListItem item in value)
			{
				SelectListItem val = item;
				ColumnState columnState = ColumnStates[val.get_Value()];
				if (columnState != null)
				{
					if (string.IsNullOrEmpty(columnState.DisplayName))
					{
						columnState.DisplayName = item.get_Text();
					}
					columnState.Hidden = true;
				}
				else
				{
					Logger.Log.Debug(SR.T("Неподдерживаемая операция добавления колонок в коллекцию. Колонка {0}, значение {1}", item.get_Text(), item.get_Value()));
				}
			}
			UpdateColumnUidsSortOder();
		}
	}

	[XmlIgnore]
	public List<SelectListItem> SelectedColumns
	{
		get
		{
			return ((IEnumerable<ColumnState>)(from c in ColumnStates
				where !c.Hidden && !c.ForceHidden
				orderby c.Order
				select c)).Select((Func<ColumnState, SelectListItem>)delegate(ColumnState c)
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Unknown result type (might be due to invalid IL or missing references)
				//IL_0023: Expected O, but got Unknown
				SelectListItem val = new SelectListItem();
				val.set_Text(SR.T(c.DisplayName));
				val.set_Value(c.UniqueName);
				return val;
			}).ToList();
		}
		set
		{
			if (value == null)
			{
				return;
			}
			int num = 1;
			foreach (SelectListItem item in value)
			{
				ColumnState columnState = ColumnStates[item.get_Value()];
				if (columnState != null)
				{
					if (string.IsNullOrEmpty(columnState.DisplayName))
					{
						columnState.DisplayName = item.get_Text();
					}
					columnState.Hidden = false;
					columnState.Order = num;
				}
				else
				{
					Logger.Log.Debug(SR.T("Неподдерживаемая операция добавления колонок в коллекцию. Колонка {0}, значение {1}", item.get_Text(), item.get_Value()));
				}
				num++;
			}
			UpdateColumnUidsSortOder();
		}
	}

	[XmlIgnore]
	public string SortExpression
	{
		get
		{
			if (ColumnStates == null)
			{
				return null;
			}
			ColumnState col = ((!string.IsNullOrEmpty(SortColumnUniqueName)) ? ColumnStates[SortColumnUniqueName] : null);
			CustomColumnDescriptor customColumnDescriptor = null;
			if (CustomColumns != null)
			{
				customColumnDescriptor = CustomColumns.FirstOrDefault((CustomColumnDescriptor cc) => cc.UniqueName == SortColumnUniqueName);
			}
			if (customColumnDescriptor != null)
			{
				return customColumnDescriptor.SortExpression;
			}
			if (col != null)
			{
				string text = ((col.TypeUid != Guid.Empty) ? ColumnState.GetDbColumnDescription(col.GetDbName(withParent: true)) : col.GetDbName());
				if (!ColumnStates.Any((ColumnState c) => !c.Equals(col) && c.GetDbName() == col.GetDbName()) && !(sortExpression == text))
				{
					return col.GetDbName();
				}
				return text;
			}
			return sortExpression;
		}
		set
		{
			sortExpression = value;
			ColumnState columnState = ((ColumnStates != null && !string.IsNullOrEmpty(value)) ? (ColumnStates.FirstOrDefault((ColumnState c) => c.GetDbName() == value) ?? ColumnStates.FirstOrDefault((ColumnState c) => ColumnState.GetDbColumnDescription(c.GetDbName(withParent: true)) == value)) : null);
			CustomColumnDescriptor customColumnDescriptor = null;
			if (columnState == null && CustomColumns != null && !string.IsNullOrEmpty(value))
			{
				customColumnDescriptor = CustomColumns.FirstOrDefault((CustomColumnDescriptor cc) => cc.SortExpression == value);
			}
			SortColumnUniqueName = ((columnState != null) ? columnState.UniqueName : customColumnDescriptor?.UniqueName);
		}
	}

	public Type TypeGridState
	{
		get
		{
			return typeGridState;
		}
		set
		{
			typeGridState = value;
		}
	}

	public bool IsTableState => typeGridState.IsDataRow();

	private void UpdateColumnUidsSortOder()
	{
		foreach (ColumnState item in ColumnStates.Where((ColumnState c) => c.Hidden || c.ForceHidden))
		{
			item.Order = ColumnStates.Count;
		}
	}

	public GridState()
	{
		PageSize = 15;
		CurrentPage = 1;
		refreshed = false;
		ColumnResizeMode = ColumnResizeMode.Web;
		CustomColumns = new List<CustomColumnDescriptor>();
	}

	public string GetDbSortExpression(bool withParent = false)
	{
		if (withParent)
		{
			string sortExpr = SortExpression;
			string entityName;
			string expressionFromString = CustomPropertyProjection.GetExpressionFromString(sortExpr, out entityName);
			if (ColumnStates != null && !string.IsNullOrEmpty(sortExpr))
			{
				ColumnState columnState = (expressionFromString.Contains(".") ? ColumnStates.FirstOrDefault((ColumnState c) => ColumnState.GetDbColumnDescription(c.GetDbName(withParent: true, forSortExpression: true)) == SortExpression) : ColumnStates.FirstOrDefault((ColumnState c) => c.GetDbName() == sortExpr));
				if (columnState != null)
				{
					return ColumnState.GetDbColumnDescription(columnState.GetDbName(withParent: true, forSortExpression: true));
				}
			}
		}
		return SortExpression;
	}

	public static GridState CreateNew(string gridId, Type typeItem)
	{
		GridState gridState = new GridState();
		gridState.GridId = gridId;
		gridState.Refresh(typeItem, isNew: true);
		return gridState;
	}

	public static GridState Deserialize(byte[] bytes)
	{
		return (GridState)ClassSerializationHelper.DeserializeObject(bytes);
	}

	public void ReloadFromMetadata(Type typeItem)
	{
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeItem);
		if (classMetadata == null || ColumnStates == null)
		{
			return;
		}
		foreach (KeyValuePair<PropertyMetadata, ClassMetadata> childProperty in MetadataLoader.GetChildProperties(classMetadata))
		{
			PropertyMetadata key = childProperty.Key;
			string uidStr = key.UidStr;
			ColumnState columnState = ColumnStates[uidStr];
			if (columnState != null)
			{
				ViewAttribute viewAttribute = ((key.ViewSettings != null) ? key.ViewSettings.GetForView(ViewType.List) : null);
				if (viewAttribute != null && viewAttribute.Visibility == Visibility.ForceHidden)
				{
					columnState.Hidden = true;
				}
				else
				{
					columnState.Hidden = viewAttribute == null || !viewAttribute.Visible;
				}
			}
		}
	}

	public bool Refresh(Type typeItem, bool isNew = false, bool forceRefresh = false, bool addEntityName = true)
	{
		if (!forceRefresh && refreshed)
		{
			return false;
		}
		typeGridState = typeItem;
		refreshed = true;
		if (IsTableState)
		{
			return false;
		}
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeItem, inherit: false);
		if (classMetadata == null)
		{
			return false;
		}
		bool result = false;
		IPropertyPermissionService propertyPermissionService = Locator.GetService<IPropertyPermissionService>();
		bool checkPermissions = propertyPermissionService != null && propertyPermissionService.HasPermissions(typeItem);
		Func<Guid, bool> hasPropertyPermission = delegate(Guid pUid)
		{
			if (!checkPermissions)
			{
				return true;
			}
			bool flag4 = propertyPermissionService.HasPermissionsByRole(typeItem, pUid);
			return propertyPermissionService.CheckPropertyPermissionByGlobalOnly(typeItem, pUid) != PropertyPermissionType.Hide || flag4;
		};
		List<KeyValuePair<PropertyMetadata, ClassMetadata>> basePropertiesAndMetadata = MetadataLoader.GetBasePropertiesAndMetadata(classMetadata);
		HashedSet<string> uidStrs = new HashedSet<string>((ICollection<string>)basePropertiesAndMetadata.Select((KeyValuePair<PropertyMetadata, ClassMetadata> p) => p.Key.UidStr).ToList());
		List<KeyValuePair<PropertyMetadata, ClassMetadata>> list = (from p in MetadataLoader.GetChildProperties(classMetadata)
			where !((Set<string>)(object)uidStrs).Contains(p.Key.UidStr)
			select p).ToList();
		basePropertiesAndMetadata.AddRange(list);
		((ICollection<string>)uidStrs).AddRange(list.Select((KeyValuePair<PropertyMetadata, ClassMetadata> cp) => cp.Key.UidStr));
		Dictionary<string, ColumnState> columnUniqueNames = new Dictionary<string, ColumnState>(ColumnStates.GetColumnStatesWithUnique());
		ColumnState value4;
		bool flag = (CustomColumns != null && CustomColumns.Any((CustomColumnDescriptor c) => columnUniqueNames.TryGetValue(c.UniqueName, out value4) && value4 != null && !value4.ForceHidden && !value4.Hidden)) || basePropertiesAndMetadata.Any((KeyValuePair<PropertyMetadata, ClassMetadata> p) => p.Key.ViewSettings != null && p.Key.ViewSettings.GetForView(ViewType.List).Visibility == Visibility.Visible && hasPropertyPermission(p.Key.Uid));
		foreach (IGrouping<string, KeyValuePair<PropertyMetadata, ClassMetadata>> item in from pair in basePropertiesAndMetadata
			group pair by pair.Key.DisplayName)
		{
			int num = item.Count();
			foreach (KeyValuePair<PropertyMetadata, ClassMetadata> item2 in item)
			{
				PropertyMetadata key = item2.Key;
				EntitySettings entitySettings = key.Settings as EntitySettings;
				bool flag2 = key.Sortable && (entitySettings == null || entitySettings.RelationType == RelationType.OneToOne);
				ClassMetadata value = item2.Value;
				string uidStr = key.UidStr;
				ViewAttribute viewAttribute = ((key.ViewSettings != null) ? key.ViewSettings.GetForView(ViewType.List) : null);
				bool flag3 = (viewAttribute != null && viewAttribute.Visibility == Visibility.ForceHidden) || !hasPropertyPermission(key.Uid);
				if (!columnUniqueNames.TryGetValue(uidStr, out var value2))
				{
					if (flag3)
					{
						continue;
					}
					bool hidden = viewAttribute == null || viewAttribute.Visibility == Visibility.Hidden || (!viewAttribute.Visible && (flag || key.IsSystem));
					value2 = new ColumnState
					{
						UniqueName = uidStr,
						TypeUid = value.Uid,
						Hidden = hidden,
						Order = key.Order,
						Sortable = flag2
					};
					columnUniqueNames.Add(uidStr, value2);
					result = true;
				}
				else if (flag3)
				{
					columnUniqueNames.Remove(uidStr);
					result = true;
				}
				if (value2.Name != key.DisplayName)
				{
					value2.Name = key.DisplayName;
					result = true;
				}
				if (value2.ContainerName != value.DisplayName)
				{
					value2.ContainerName = value.DisplayName;
					result = true;
				}
				string text = ((value2.ContainerName.IsNullOrWhiteSpace() && (addEntityName || num > 1)) ? $"{key.ToString(key.DisplayName)} ({value.DisplayName})" : key.ToString(key.DisplayName));
				if (value2.DisplayName != text)
				{
					value2.DisplayName = text;
					result = true;
				}
				if (value2.TypeUid != value.Uid)
				{
					value2.TypeUid = value.Uid;
					result = true;
				}
				if (value2.Sortable != flag2 && value2.Sortable)
				{
					value2.Sortable = false;
					result = true;
				}
				if (string.IsNullOrEmpty(value2.WidthAttribute) && key.TableColumnWidth > 0)
				{
					value2.WidthAttribute = key.TableColumnWidth.ToString();
				}
			}
		}
		if (CustomColumns != null && CustomColumns.Count > 0)
		{
			foreach (CustomColumnDescriptor customColumn in CustomColumns)
			{
				if (!columnUniqueNames.TryGetValue(customColumn.UniqueName, out var value3))
				{
					value3 = new ColumnState
					{
						UniqueName = customColumn.UniqueName,
						DisplayName = customColumn.DisplayName,
						Hidden = !customColumn.Visible,
						Order = columnUniqueNames.Values.Select((ColumnState s) => s.Order).LastOrDefault(),
						Sortable = customColumn.Sortable
					};
					columnUniqueNames.Add(customColumn.UniqueName, value3);
					result = true;
				}
				else
				{
					if (value3.DisplayName != customColumn.DisplayName)
					{
						value3.DisplayName = customColumn.DisplayName;
						result = true;
					}
					if (value3.Sortable != customColumn.Sortable)
					{
						value3.Sortable = customColumn.Sortable;
						result = true;
					}
				}
			}
		}
		string[] array = (from c in columnUniqueNames.Values
			where (CustomColumns == null || CustomColumns.All((CustomColumnDescriptor cc) => cc.UniqueName != c.UniqueName)) && !((Set<string>)(object)uidStrs).Contains(c.UniqueName)
			select c into a
			select a.UniqueName).ToArray();
		if (array.Any())
		{
			string[] array2 = array;
			foreach (string key2 in array2)
			{
				columnUniqueNames.Remove(key2);
			}
			result = true;
		}
		TableView tableView = ((classMetadata.TableViews != null) ? classMetadata.TableViews.FirstOrDefault((TableView v) => v.ViewType == ViewType.List) : null);
		if (isNew && tableView != null && tableView.PageSize > 0 && PageSize != tableView.PageSize)
		{
			PageSize = tableView.PageSize;
			result = true;
		}
		if (string.IsNullOrEmpty(SortExpression) && tableView != null && tableView.SortDescriptors != null && tableView.SortDescriptors.Count > 0)
		{
			PropertyMetadata propertyMetadata = null;
			TableViewSortDescriptor sortDescr = null;
			if (tableView.SortDescriptors != null && tableView.SortDescriptors.Any())
			{
				sortDescr = tableView.SortDescriptors.First();
				propertyMetadata = basePropertiesAndMetadata.FirstOrDefault((KeyValuePair<PropertyMetadata, ClassMetadata> p) => p.Key.Uid == sortDescr.PropertyUid).Key;
			}
			string text2 = propertyMetadata?.Name;
			ListSortDirection listSortDirection = ((sortDescr != null) ? sortDescr.Direction : ListSortDirection.Ascending);
			if (SortExpression != text2)
			{
				SortExpression = text2;
				result = true;
			}
			if (SortDirection != listSortDirection)
			{
				SortDirection = listSortDirection;
				result = true;
			}
		}
		if (ProviderUid != Guid.Empty)
		{
			ComponentManager.Current.GetExtensionPoints<IGridStateProvider>().FirstOrDefault((IGridStateProvider item) => item.Uid == ProviderUid)?.OnRefresh(this, ProviderData);
		}
		ColumnStates.Clear();
		ColumnStates.AddAll(columnUniqueNames.Values);
		return result;
	}

	public Dictionary<Guid, string> GetMetadataGuids()
	{
		List<ClassMetadata> metadata = GetMetadata();
		Dictionary<Guid, string> dictionary = new Dictionary<Guid, string> { 
		{
			Guid.Empty,
			SR.T("Базовые атрибуты объекта")
		} };
		foreach (ClassMetadata item in metadata)
		{
			dictionary[item.Uid] = item.DisplayName;
		}
		return dictionary;
	}

	public List<ClassMetadata> GetMetadata()
	{
		if (IsTableState)
		{
			return new List<ClassMetadata>();
		}
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeGridState);
		if (classMetadata == null)
		{
			return null;
		}
		List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(classMetadata);
		List<ClassMetadata> list = new List<ClassMetadata>();
		list.Add(classMetadata);
		list.AddRange(childClasses);
		return list;
	}

	public Dictionary<Guid, List<Guid>> GetGuidsChildClasses()
	{
		List<ClassMetadata> metadata = GetMetadata();
		Dictionary<Guid, List<Guid>> dictionary = new Dictionary<Guid, List<Guid>>();
		dictionary.Add(Guid.Empty, metadata.Select((ClassMetadata l) => l.Uid).ToList());
		foreach (ClassMetadata item in metadata)
		{
			List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(item);
			dictionary[item.Uid] = childClasses.Select((ClassMetadata k) => k.Uid).ToList();
		}
		return dictionary;
	}

	public static List<SelectListItem> TypesTree(UrlHelper url, ClassMetadata rootMetadata, Guid? selectTypeUid = null, Func<IEnumerable<ClassMetadata>, IEnumerable<ClassMetadata>> metadataFilter = null, Func<Guid, Type, string> valueFunc = null, string typesRootName = null)
	{
		string selectedValue = null;
		return TypesTree(url, rootMetadata, null, ref selectedValue, metadataFilter, valueFunc, typesRootName);
	}

	public static List<SelectListItem> TypesTree(UrlHelper url, ClassMetadata rootMetadata, Guid? selectTypeUid, ref string selectedValue, Func<IEnumerable<ClassMetadata>, IEnumerable<ClassMetadata>> metadataFilter = null, Func<Guid, Type, string> valueFunc = null, string typesRootName = null)
	{
		return TypesTree(url, rootMetadata, selectTypeUid, ref selectedValue, metadataFilter, valueFunc, typesRootName, null);
	}

	public static List<SelectListItem> TypesTree(UrlHelper url, ClassMetadata rootMetadata, Guid? selectTypeUid, ref string selectedValue, Func<IEnumerable<ClassMetadata>, IEnumerable<ClassMetadata>> metadataFilter = null, Func<Guid, Type, string> valueFunc = null, string typesRootName = null, Func<ClassMetadata, string> classFunc = null)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		Guid typeUid = rootMetadata.Uid;
		ReferenceOnEntityType referenceOnEntityType = new ReferenceOnEntityType
		{
			TypeUid = typeUid
		};
		string text = ((valueFunc != null) ? valueFunc(typeUid, MetadataLoader.GetFilterType(typeUid) ?? typeof(Filter)) : typeUid.ToString());
		List<SelectListItem> list = new List<SelectListItem>();
		DropDownSelectListItem val = new DropDownSelectListItem();
		((SelectListItem)val).set_Text(typesRootName ?? HttpUtility.HtmlEncode(referenceOnEntityType.DisplayName ?? ""));
		val.set_DropDownText(string.Format("<span class=\"iconTypeText\">{0}{1}</span>", GetEntityIcon(url, rootMetadata), typesRootName ?? HttpUtility.HtmlEncode(referenceOnEntityType.DisplayName ?? "")));
		((SelectListItem)val).set_Value(text);
		list.Add((SelectListItem)val);
		List<SelectListItem> list2 = list;
		if (selectTypeUid == typeUid)
		{
			selectedValue = text;
		}
		Guid complexTaskUid = new Guid("3f33e28e-908d-4e93-8f40-b05ae88038ed");
		IEnumerable<ClassMetadata> enumerable = (from m in Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList()
			where m is ClassMetadata && m.Uid != complexTaskUid && ((ClassMetadata)m).BaseClassUid == typeUid
			select m).Cast<ClassMetadata>();
		if (metadataFilter != null)
		{
			enumerable = metadataFilter(enumerable);
		}
		AddSubTypes(url, selectTypeUid, list2, enumerable, metadataFilter, ref selectedValue, valueFunc, "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;", classFunc);
		return list2;
	}

	protected static void AddSubTypes(UrlHelper url, Guid? selectTypeUid, List<SelectListItem> types, IEnumerable<ClassMetadata> metadata, Func<IEnumerable<ClassMetadata>, IEnumerable<ClassMetadata>> metadataFilter, ref string selectedValue, Func<Guid, Type, string> valueFunc = null, string level = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;", Func<ClassMetadata, string> classFunc = null)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		foreach (ClassMetadata item in metadata.OrderBy((ClassMetadata m) => m.DisplayName))
		{
			ReferenceOnEntityType referenceOnEntityType = new ReferenceOnEntityType
			{
				TypeUid = item.Uid
			};
			EntityMetadata entitymetadata = item as EntityMetadata;
			string text = ((valueFunc != null) ? valueFunc(item.Uid, MetadataLoader.GetFilterType(item.Uid)) : item.Uid.ToString());
			DropDownSelectListItem val = new DropDownSelectListItem();
			val.set_ListItemClass((classFunc != null) ? classFunc(item) : "");
			((SelectListItem)val).set_Text(HttpUtility.HtmlEncode(referenceOnEntityType.DisplayName ?? ""));
			val.set_DropDownText(string.Format("<span class=\"iconTypeText\">{0}{1}{2}</span>", level, GetEntityIcon(url, entitymetadata), HttpUtility.HtmlEncode(referenceOnEntityType.DisplayName ?? "").Replace(" ", "&nbsp;")));
			((SelectListItem)val).set_Value(text);
			types.Add((SelectListItem)val);
			if (selectTypeUid == item.Uid)
			{
				selectedValue = text;
			}
			ClassMetadata md1 = item;
			IEnumerable<ClassMetadata> enumerable = (from m in Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList()
				where m is ClassMetadata && ((ClassMetadata)m).BaseClassUid == md1.Uid
				select m).Cast<ClassMetadata>();
			if (enumerable != null && enumerable.Any())
			{
				if (metadataFilter != null)
				{
					enumerable = metadataFilter(enumerable);
				}
				AddSubTypes(url, selectTypeUid, types, enumerable, metadataFilter, ref selectedValue, valueFunc, $"{level}&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;", classFunc);
			}
		}
	}

	protected static string GetEntityIcon(UrlHelper url, ClassMetadata entitymetadata)
	{
		if (url == null || entitymetadata == null)
		{
			return null;
		}
		if (entitymetadata.Images != null && entitymetadata.Images.Count > 0)
		{
			return HtmlExtensions.Image(url, url.Action("Object", "Images", (object)new
			{
				area = "EleWise.ELMA.SDK.Web",
				id = entitymetadata.Uid
			}), "", "", new
			{
				@class = "entityTypeIcon"
			});
		}
		return GetEntityIcon(url, (EntityMetadata)MetadataLoader.LoadMetadata(entitymetadata.BaseClassUid));
	}

	public object Clone()
	{
		return new GridState
		{
			GridId = GridId,
			PageSize = PageSize,
			CurrentPage = CurrentPage,
			SortColumnUniqueName = SortColumnUniqueName,
			ColumnResizeMode = ColumnResizeMode,
			SortDirection = SortDirection,
			UniqueName = UniqueName,
			CustomColumns = ((CustomColumns != null) ? CustomColumns.Select((CustomColumnDescriptor cc) => (CustomColumnDescriptor)cc.Clone()).ToList() : null),
			GroupDescriptors = ((GroupDescriptors != null) ? GroupDescriptors.Select((GridGroupDescriptor gd) => (GridGroupDescriptor)gd.Clone()).ToList() : null),
			ColumnUids = ((ColumnUids != null) ? ColumnUids.Select((ColumnState cu) => (ColumnState)cu.Clone()).ToList() : null),
			ProviderUid = ProviderUid,
			DateState = DateState,
			ProviderData = ProviderData,
			columnStates = ((columnStates != null) ? ((GridStateSet)columnStates.Clone()) : null),
			sortExpression = sortExpression,
			ExpandedWidth = ExpandedWidth,
			SaveOnlyInSession = SaveOnlyInSession,
			UseForAllUsers = UseForAllUsers
		};
	}
}
