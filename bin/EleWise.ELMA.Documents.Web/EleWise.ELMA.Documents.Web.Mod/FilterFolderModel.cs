using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Documents.Web.Models;

[Obsolete("Больше не используется")]
public class FilterFolderModel : FolderBaseModel<IFilterDocumentFolder>
{
	private Lazy<List<SelectListItem>> _filterColumns;

	private Lazy<ClassMetadata> _metadata;

	public IDocumentFilter DocumentFilter { get; set; }

	public GridState GridState { get; set; }

	public List<SelectListItem> FilterColumns
	{
		get
		{
			if (DocumentFilter == null)
			{
				return new List<SelectListItem>();
			}
			if (_filterColumns == null)
			{
				_filterColumns = new Lazy<List<SelectListItem>>(() => InitFilterColumns());
			}
			return _filterColumns.Value;
		}
	}

	public List<SelectListItem> FilterColumnsAvailable { get; set; }

	public List<SelectListItem> FilterColumnsSelected { get; set; }

	public bool SearchResults { get; set; }

	public bool UseFullTextSearch { get; set; }

	public bool ExpandSearch { get; set; }

	public bool SearchAllFolder { get; set; }

	public bool EnableSecurity
	{
		get
		{
			if (DocumentFilter == null)
			{
				return true;
			}
			return !DocumentFilter.DisableSecurity;
		}
		set
		{
			DocumentFilter.DisableSecurity = !value;
		}
	}

	public new ClassMetadata Metadata
	{
		get
		{
			if (DocumentFilter == null)
			{
				return null;
			}
			if (_metadata == null)
			{
				_metadata = new Lazy<ClassMetadata>(() => MetadataLoader.GetEntityMetadataByFilter(DocumentFilter.GetType()));
			}
			return _metadata.Value;
		}
	}

	public List<PropertyMetadata> GetPropertyMetadatasForSearch()
	{
		if (DocumentFilter == null)
		{
			return new List<PropertyMetadata>();
		}
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(DocumentFilter.GetType());
		List<PropertyMetadata> properties = (from p in classMetadata.Properties.Where(IsBasePropertyForSerach)
			orderby p.Order
			select p).ToList();
		List<PropertyMetadata> source = (from p in classMetadata.Properties
			where p.ViewSettings == null || p.ViewSettings.GetForView(ViewType.Filter) == null || p.ViewSettings.GetForView(ViewType.Filter).Visible
			orderby p.Order
			select p).ToList();
		properties.AddRange(source.Where((PropertyMetadata fp) => properties.All((PropertyMetadata p) => p.Uid != fp.Uid)));
		return properties;
	}

	public bool HasCustomProperties()
	{
		return GetPropertyMetadatasForSearch().Any((PropertyMetadata p) => !IsBasePropertyForSerach(p));
	}

	public static bool IsBasePropertyForSerachByName(string propertyName)
	{
		if (!(propertyName == LinqUtils.NameOf((Expression<Func<IDmsObjectFilter, object>>)((IDmsObjectFilter f) => f.Name))) && !(propertyName == LinqUtils.NameOf((Expression<Func<IDmsObjectFilter, object>>)((IDmsObjectFilter f) => f.CreationAuthor))) && !(propertyName == LinqUtils.NameOf((Expression<Func<IDmsObjectFilter, object>>)((IDmsObjectFilter f) => f.CreationDate))) && !(propertyName == LinqUtils.NameOf((Expression<Func<IDmsObjectFilter, object>>)((IDmsObjectFilter f) => f.ChangeAuthor))) && !(propertyName == LinqUtils.NameOf((Expression<Func<IDmsObjectFilter, object>>)((IDmsObjectFilter f) => f.ChangeDate))) && !(propertyName == LinqUtils.NameOf((Expression<Func<IDmsObjectFilter, object>>)((IDmsObjectFilter f) => f.IsArchived))) && !(propertyName == LinqUtils.NameOf((Expression<Func<IDocumentFilter, object>>)((IDocumentFilter f) => f.NeedAnswer))))
		{
			return propertyName == LinqUtils.NameOf((Expression<Func<IDocumentFilter, object>>)((IDocumentFilter f) => f.ListCycleStatus));
		}
		return true;
	}

	public static bool IsBasePropertyForSerach(PropertyMetadata property)
	{
		if (!(property.Uid == InterfaceActivator.PropertyUid((IDmsObjectFilter f) => f.Name)) && !(property.Uid == InterfaceActivator.PropertyUid((IDmsObjectFilter f) => f.CreationAuthor)) && !(property.Uid == InterfaceActivator.PropertyUid((IDmsObjectFilter f) => f.CreationDate)) && !(property.Uid == InterfaceActivator.PropertyUid((IDmsObjectFilter f) => f.ChangeAuthor)) && !(property.Uid == InterfaceActivator.PropertyUid((IDmsObjectFilter f) => f.ChangeDate)) && !(property.Uid == InterfaceActivator.PropertyUid((IDmsObjectFilter f) => f.IsArchived)) && !(property.Uid == InterfaceActivator.PropertyUid((IDocumentFilter f) => f.NeedAnswer)))
		{
			return property.Uid == InterfaceActivator.PropertyUid((IDocumentFilter f) => f.ListCycleStatus);
		}
		return true;
	}

	public FilterFolderModel()
	{
		DocumentFilter = InterfaceActivator.Create<IDocumentFilter>();
		DocumentFilter.Types = new List<ReferenceOnEntityType>();
		DocumentFilter.HierarchicalByFolder = true;
		FilterColumnsAvailable = new List<SelectListItem>();
		FilterColumnsSelected = new List<SelectListItem>();
		SearchAllFolder = true;
	}

	private List<SelectListItem> InitFilterColumns()
	{
		return ((ClassMetadata)MetadataLoader.LoadMetadata((DocumentFilter == null) ? InterfaceActivator.TypeOf<IDocumentFilter>() : DocumentFilter.GetType())).Properties.Where((PropertyMetadata p) => p.ViewSettings == null || p.ViewSettings.GetForView(ViewType.Filter) == null || p.ViewSettings.GetForView(ViewType.Filter).Visible).Select((Func<PropertyMetadata, SelectListItem>)delegate(PropertyMetadata p)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			SelectListItem val = new SelectListItem();
			val.set_Text(p.DisplayName);
			val.set_Value(p.Name);
			return val;
		}).ToList();
	}
}
