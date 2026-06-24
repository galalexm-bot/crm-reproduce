using System;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class CatalogItemModel
{
	protected string viewItemId;

	protected DynamicFormSettings dynamicFormSettings;

	protected FormViewItem view;

	public string CatalogName { get; set; }

	public object Id { get; set; }

	public Guid TypeUid { get; set; }

	public IEntity Entity { get; set; }

	public bool InPopUp { get; set; }

	public bool Continue { get; set; }

	public bool IsGroup { get; set; }

	public string FormId { get; set; }

	public ViewType ViewType { get; set; }

	public ItemType ItemType
	{
		get
		{
			if (!IsGroup)
			{
				return ItemType.Element;
			}
			return ItemType.Group;
		}
	}

	public string ViewItemId
	{
		get
		{
			if (!string.IsNullOrEmpty(viewItemId))
			{
				return viewItemId;
			}
			viewItemId = EntityObjectViewItemProvider.CreateViewItemId(Entity, ViewType, ItemType);
			return viewItemId;
		}
		set
		{
			viewItemId = value;
		}
	}

	public bool CanEdit { get; set; }

	public bool CanDelete { get; set; }

	public bool CanFullAccess { get; set; }

	public string BackUrl { get; set; }

	public Guid? FormUid { get; set; }

	public bool FormReadOnly { get; set; }

	public virtual DynamicFormSettings DynamicFormSettings
	{
		get
		{
			if (dynamicFormSettings != null)
			{
				return dynamicFormSettings;
			}
			dynamicFormSettings = new DynamicFormSettings
			{
				DynamicFormsProviderUid = EntityDynamicFormProvider.UID,
				DynamicFormsProviderData = EntityDynamicFormProvider.CreateData(Entity, ViewType, ItemType),
				ViewProviderUid = CatalogObjectViewItemProvider.UID,
				ViewItemId = ViewItemId
			};
			if (!string.IsNullOrEmpty(FormId))
			{
				dynamicFormSettings.FormId = FormId;
			}
			GetViewItem();
			return dynamicFormSettings;
		}
		set
		{
			dynamicFormSettings = value;
		}
	}

	public FormViewItem View
	{
		get
		{
			return GetViewItem();
		}
		set
		{
			view = value;
		}
	}

	public CatalogItemModel()
	{
		ViewType = ViewType.Create;
	}

	protected virtual FormViewItem GetViewItem()
	{
		if (view != null)
		{
			return view;
		}
		Type type = EntityHelper.GetType(Entity);
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(type);
		if (FormUid.HasValue && FormUid.Value != Guid.Empty)
		{
			view = classMetadata.GetForms().FirstOrDefault((FormViewItem q) => q.Uid == FormUid.Value);
		}
		else
		{
			view = CatalogObjectViewItemProvider.GetViewItem(type, ViewType, ItemType);
		}
		if (view != null && view.RuntimeVersion == RuntimeVersion.Version1)
		{
			view = DynamicFormHelper.FormWithExecutedLoadScripts(view, Entity, classMetadata, DynamicFormSettings);
		}
		if (view == null)
		{
			return null;
		}
		if (ViewType == ViewType.Display)
		{
			FormReadOnly = true;
		}
		if (FormReadOnly)
		{
			view = (FormViewItem)view.CloneAsReadOnly();
			ViewType = ViewType.Display;
		}
		return view;
	}
}
