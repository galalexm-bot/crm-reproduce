using System;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Web.Models;

public class CatalogInfo : CatalogItemModel
{
	public bool CopyPermissionFromParent { get; set; }

	public override DynamicFormSettings DynamicFormSettings
	{
		get
		{
			if (dynamicFormSettings != null)
			{
				return dynamicFormSettings;
			}
			base.ViewItemId = ((base.FormUid == Guid.Empty) ? EntityObjectViewItemProvider.CreateViewItemId(base.Entity, base.ViewType, ItemType.Default) : CatalogObjectViewItemProvider.CreateViewItemId(base.Entity, base.ViewType, base.FormUid, ItemType.Default));
			DynamicFormSettings = new DynamicFormSettings
			{
				DynamicFormsProviderUid = EntityDynamicFormProvider.UID,
				DynamicFormsProviderData = EntityDynamicFormProvider.CreateData(base.Entity, base.ViewType, base.ItemType),
				ViewProviderUid = CatalogObjectViewItemProvider.UID,
				ViewItemId = base.ViewItemId
			};
			if (!string.IsNullOrEmpty(base.FormId))
			{
				dynamicFormSettings.FormId = base.FormId;
			}
			GetViewItem();
			return dynamicFormSettings;
		}
		set
		{
			dynamicFormSettings = value;
		}
	}

	public CatalogInfo()
		: this(null, ViewType.Create)
	{
	}

	public CatalogInfo(IEntity entity, ViewType viewType)
		: this(entity, viewType, null)
	{
	}

	public CatalogInfo(IEntity entity, ViewType viewType, string formId)
		: this(entity, Guid.Empty, formId, viewType)
	{
	}

	public CatalogInfo(IEntity entity, Guid fomGuid, string formId, ViewType viewType = ViewType.Custom)
	{
		if (entity != null && !entity.IsNew())
		{
			base.Id = entity.GetId();
		}
		base.Entity = entity;
		base.ViewType = viewType;
		base.FormUid = fomGuid;
		base.FormId = formId;
		CopyPermissionFromParent = true;
		ApplyFormTransformations();
	}

	protected override FormViewItem GetViewItem()
	{
		if (view != null)
		{
			return view;
		}
		Type type = base.Entity.CastAsRealType().GetType();
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(type);
		if (base.FormUid.HasValue && base.FormUid.Value != Guid.Empty)
		{
			view = entityMetadata.GetForms().FirstOrDefault((FormViewItem q) => q.Uid == base.FormUid.Value);
		}
		else
		{
			view = CatalogObjectViewItemProvider.GetViewItem(type, base.ViewType);
		}
		view = DynamicFormHelper.FormWithExecutedLoadScripts(view, base.Entity, entityMetadata, DynamicFormSettings);
		if (view == null)
		{
			return null;
		}
		if (base.ViewType == ViewType.Display)
		{
			base.FormReadOnly = true;
		}
		if (base.FormReadOnly)
		{
			view = (FormViewItem)view.CloneAsReadOnly();
			base.ViewType = ViewType.Display;
		}
		return view;
	}

	private void ApplyFormTransformations()
	{
		if (base.Entity == null)
		{
			return;
		}
		Type type = base.Entity.CastAsRealType().GetType();
		EntityMetadata metadata = MetadataLoader.LoadMetadata(type) as EntityMetadata;
		if (metadata != null)
		{
			ComponentManager.Current.GetExtensionPoints<IMetadataFormsTransformations>().ForEach(delegate(IMetadataFormsTransformations p)
			{
				p.Transformate(metadata);
			});
		}
	}
}
