using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[Component(Order = 10000)]
public class FilterPortletExtensions : IFilterPortlet
{
	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	private UrlHelper Url => new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext);

	protected virtual bool AddColumnTypeIcon => false;

	public virtual bool AvailableFilterType(Guid filterTypeUid)
	{
		return true;
	}

	public object GetModel(GridCommand command, FilterModel filterModel, string gridId, HtmlHelper html)
	{
		Type typeByUid = MetadataRuntimeService.GetTypeByUid(filterModel.FilterTypeUid);
		IMetadata metadata = MetadataLoader.LoadMetadata(filterModel.FilterTypeUid);
		ClassMetadata classmetadata = (ClassMetadata)metadata;
		IEntityMetadata entityMetadata = classmetadata as IEntityMetadata;
		foreach (IFilterPortletFilterModifier item in from p in ComponentManager.Current.GetExtensionPoints<IFilterPortletFilterModifier>()
			where p.AvailableFilterType(filterModel.FilterTypeUid, filterModel.Entity.Code)
			select p)
		{
			filterModel.Filter = item.ModifyFilter(filterModel.Filter);
		}
		IGridData gridData = GetGridData(command, filterModel.FilterTypeUid, filterModel.Filter);
		if (gridData == null)
		{
			return null;
		}
		FilterPortletDynamicGridModel filterPortletDynamicGridModel = new FilterPortletDynamicGridModel(gridId, gridId, gridData, typeByUid);
		filterPortletDynamicGridModel.StateProviderUid = PortletGridStateProvider.UID;
		filterPortletDynamicGridModel.Resizeable = false;
		filterPortletDynamicGridModel.Reorderable = false;
		filterPortletDynamicGridModel.Sortable = true;
		filterPortletDynamicGridModel.Customizable = true;
		filterPortletDynamicGridModel.EnableCustomize = false;
		filterPortletDynamicGridModel.Action = "PortletGrid";
		filterPortletDynamicGridModel.Controller = "FilterPortlet";
		List<Guid> availablePropertyUids = ComponentManager.Current.GetExtensionPoints<IFilterPortletAvailablePropertyUids>().FirstOrDefault((IFilterPortletAvailablePropertyUids p) => p.AvailableFilterType(filterModel.FilterTypeUid, filterModel.Entity.Code))?.AvailablePropertyUids();
		((List<GridColumn>)filterPortletDynamicGridModel.Columns).AddRange(GridBuilderExtensions.GetDefaultColumns(typeByUid, classmetadata, filterPortletDynamicGridModel.State, childs: true, availablePropertyUids));
		ColumnEntityIcon(filterModel, filterPortletDynamicGridModel);
		PropertyMetadata titleProperty = GetTitleProperty(classmetadata);
		GridColumn gridColumn = ((titleProperty != null) ? filterPortletDynamicGridModel.Columns.FirstOrDefault((GridColumn c) => c.UniqueName == titleProperty.Uid.ToString()) : null);
		if (gridColumn != null)
		{
			if (metadata is EntityMetadata && ((EntityMetadata)metadata).ShowInCatalogList)
			{
				if (entityMetadata != null && entityMetadata.Hierarchical && filterModel.Filter.IsEmpty())
				{
					filterModel.Filter.FilterByHierarchyParent = true;
					filterModel.Filter.HierarchyParent = null;
				}
				int filterId = 0;
				if (entityMetadata != null && entityMetadata.Hierarchical)
				{
					GridColumn gridColumn2 = new GridColumn
					{
						ValueType = typeof(string),
						Name = null,
						Header = "",
						Sortable = false,
						UniqueName = "folderColumn" + filterModel.FilterTypeUid,
						Width = "1%"
					};
					Func<object, string> func2 = (Func<object, string>)(gridColumn2.Template = (Func<object, string>)((dynamic entity) => FolderCellCatalogTemplate(entity, filterModel.FilterTypeUid, null, filterId)));
					filterPortletDynamicGridModel.Columns.Add(gridColumn2);
				}
				gridColumn.Template = (dynamic entity) => ((!string.IsNullOrEmpty(GenerateViewItemUrl(entity)))) ? TitleCellTemplate(entity, titleProperty.Uid) : TitleCellCatalogTemplate(entity, filterModel.FilterTypeUid, titleProperty.Uid, null, classmetadata, filterId);
			}
			else
			{
				IFilterPortletColor colorpoint = ComponentManager.Current.GetExtensionPoints<IFilterPortletColor>().FirstOrDefault((IFilterPortletColor p) => p.AvailableFilterType(filterModel.Entity.ObjectsType.TypeUid));
				if (colorpoint != null)
				{
					gridColumn.Template = (dynamic entity) => colorpoint.Template(((IEntity)entity).CastAsRealType(), html);
				}
				else
				{
					gridColumn.Template = (dynamic entity) => TitleCellTemplate(entity, titleProperty.Uid);
				}
			}
		}
		foreach (IFilterPortletColumnModifier item2 in from p in ComponentManager.Current.GetExtensionPoints<IFilterPortletColumnModifier>()
			where p.AvailableFilterType(filterModel.Entity.ObjectsType.TypeUid)
			select p)
		{
			IFilterPortletColumnModifier colpoint = item2;
			GridColumn gridColumn3 = filterPortletDynamicGridModel.Columns.FirstOrDefault((GridColumn c) => c.UniqueName == colpoint.UniqueName);
			if (gridColumn3 == null)
			{
				continue;
			}
			if (colpoint.NeedHeader)
			{
				gridColumn3.Header = colpoint.Header;
			}
			if (colpoint.NeedTemplate)
			{
				gridColumn3.Template = (dynamic entity) => colpoint.Template(((IEntity)entity).CastAsRealType(), html);
			}
		}
		return filterPortletDynamicGridModel;
	}

	protected PropertyMetadata GetTitleProperty(ClassMetadata classmetadata)
	{
		return classmetadata.GetTitleProperty();
	}

	private void ColumnEntityIcon(FilterModel filterModel, DynamicGrid grid)
	{
		if (AddColumnTypeIcon)
		{
			GridColumn gridColumn = new GridColumn
			{
				ValueType = typeof(string),
				Name = null,
				Header = "",
				Sortable = false,
				UniqueName = "iconColumn" + filterModel.FilterTypeUid,
				Width = "1%"
			};
			Func<object, string> func2 = (Func<object, string>)(gridColumn.Template = (Func<object, string>)((dynamic entity) => EntityIconCellTemplate(entity)));
			grid.Columns.Add(gridColumn);
		}
	}

	private string FolderCellCatalogTemplate(IEntity entity, Guid uid, object parentId, long? FilterId = null)
	{
		object parentId2;
		if (entity == null)
		{
			parentId2 = parentId;
		}
		else
		{
			IEntityMetadata entityMetadata = ((ClassMetadata)MetadataRuntimeService.GetMetadata(uid)) as IEntityMetadata;
			if (entity == null || entityMetadata == null || !entityMetadata.Hierarchical)
			{
				return string.Empty;
			}
			bool flag = entityMetadata != null && entityMetadata.HierarchyType == HierarchyType.GroupAndElements && entityMetadata.IsGroupPropertyUid != Guid.Empty && (bool)entity.GetPropertyValue(entityMetadata.IsGroupPropertyUid);
			if ((entityMetadata == null || entityMetadata.HierarchyType != HierarchyType.Elements) && !flag)
			{
				return string.Empty;
			}
			parentId2 = entity.GetId();
		}
		return string.Format("<a href=\"{1}\">{0}</a>", EleWise.ELMA.Web.Mvc.Html.HtmlExtensions.Image(Url, "#folder.svg", SR.T("Перейти в группу")), GenerateCatalogViewUrl(uid, parentId2, FilterId));
	}

	protected virtual string EntityIconCellTemplate(IEntity entity)
	{
		if (entity == null)
		{
			return "";
		}
		if (MetadataLoader.LoadMetadata(entity.GetType()) is EntityMetadata)
		{
			return EleWise.ELMA.Web.Mvc.Html.HtmlExtensions.Image(Url.ObjectIcon(ObjectIconFormat.x16, entity), (object)null);
		}
		return "";
	}

	private string TitleCellCatalogTemplate(IEntity entity, Guid uid, Guid titlePropertyUid, object parentId, ClassMetadata metadata, long? FilterId = null)
	{
		if (entity == null)
		{
			return string.Format("<a href=\"{0}\">{1}</a>", GenerateCatalogViewUrl(uid, parentId, FilterId), HttpUtility.HtmlEncode(SR.T("...\\(на уровень выше)")));
		}
		bool num = metadata is IEntityMetadata entityMetadata && entityMetadata.Hierarchical && entityMetadata.HierarchyType == HierarchyType.GroupAndElements && entityMetadata.IsGroupPropertyUid != Guid.Empty && (bool)entity.GetPropertyValue(entityMetadata.IsGroupPropertyUid);
		object propertyValue = entity.GetPropertyValue(titlePropertyUid);
		propertyValue = HttpUtility.HtmlEncode(propertyValue ?? string.Empty);
		if (!num)
		{
			return $"<a href=\"{GenerateCatalogViewItemUrl(uid, entity.GetId())}\">{propertyValue}</a>";
		}
		return $"<a href=\"{GenerateCatalogViewUrl(uid, entity.GetId(), FilterId)}\">{propertyValue}</a>";
	}

	private string TitleCellTemplate(IEntity entity, Guid titlePropertyUid)
	{
		object propertyValue = entity.GetPropertyValue(titlePropertyUid);
		propertyValue = HttpUtility.HtmlEncode(propertyValue ?? string.Empty);
		return $"<a href=\"{GenerateViewItemUrl(entity)}\">{propertyValue}</a>";
	}

	private string GenerateCatalogViewItemUrl(Guid uid, object objectId)
	{
		return Url.Action("ViewItem", "Catalogs", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			uid = uid,
			id = objectId?.ToString().Trim()
		});
	}

	private string GenerateCatalogViewUrl(Guid uid, object parentId, long? FilterId = null)
	{
		return Url.Action("View", "Catalogs", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			uid = uid,
			parentId = parentId,
			FilterId = FilterId
		});
	}

	private string GenerateViewItemUrl(IEntity entity)
	{
		return Url.Entity(entity);
	}

	private IGridData GetGridData(GridCommand command, Guid uid, IEntityFilter filter)
	{
		Type typeByUid = MetadataRuntimeService.GetTypeByUid(uid);
		if (typeByUid == null)
		{
			return null;
		}
		return (IGridData)typeof(FilterPortletExtensions).GetMethod("GetGridDataGeneric", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy).MakeGenericMethod(typeByUid).Invoke(this, new object[2] { command, filter });
	}

	[UsedImplicitly]
	private IGridData GetGridDataGeneric<T>(GridCommand command, IEntityFilter filter) where T : class, IEntity
	{
		if (filter != null)
		{
			return (GridData<T>)GridBuilderExtensions.GetFilteredGridData<T, IEntityFilter>(command, filter);
		}
		return (GridData<T>)GridBuilderExtensions.GetGridData<T>(command);
	}

	public virtual string ViewName()
	{
		return "Templates/DynamicGrid";
	}
}
