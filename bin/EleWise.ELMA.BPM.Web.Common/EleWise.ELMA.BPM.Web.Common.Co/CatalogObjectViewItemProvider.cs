using System;
using EleWise.ELMA.Common.Components;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.BPM.Web.Common.Components;

public class CatalogObjectViewItemProvider : EntityObjectViewItemProvider
{
	public new static readonly Guid UID = new Guid("{02F3E4CF-9A6B-4044-B38E-1242E900A059}");

	public override Guid ProviderUid => UID;

	public static string CreateViewItemId(IEntity entity, ViewType viewType, Guid? formGuid, ItemType itemType)
	{
		if (entity != null)
		{
			return string.Join(";", (int)viewType, formGuid, (int)itemType, InterfaceActivator.UID(EntityHelper.GetType(entity)), entity.GetId());
		}
		return null;
	}

	protected new static FormViewItem TransformateStatic(ClassMetadata metadata, FormViewItem formViewItem, ViewType viewType, ItemType itemType)
	{
		formViewItem = formViewItem ?? new FormViewItemBuilder(metadata.Uid, viewType).DefaultContainer().FormView;
		formViewItem = formViewItem.Transformate(CatalogsFormViewTransformate.GetTransformation(metadata, formViewItem, viewType));
		return EntityObjectViewItemProvider.TransformateStatic(metadata, formViewItem, viewType, itemType);
	}

	protected override FormViewItem Transformate(ClassMetadata metadata, FormViewItem formViewItem, ViewType viewType, ItemType itemType)
	{
		return TransformateStatic(metadata, formViewItem, viewType, itemType);
	}

	public static FormViewItem GetViewItem(Type entityType, ViewType viewType)
	{
		return EntityObjectViewItemProvider.GetFormViewItem(entityType, viewType, ItemType.Default, (ClassMetadata metadata, FormViewItem form) => TransformateStatic(metadata, form, viewType, ItemType.Default));
	}

	public new static FormViewItem GetViewItem(Type entityType, ViewType viewType, ItemType itemType)
	{
		return EntityObjectViewItemProvider.GetFormViewItem(entityType, viewType, ItemType.Default, (ClassMetadata metadata, FormViewItem form) => TransformateStatic(metadata, form, viewType, itemType));
	}

	public static FormViewItem GetViewItem(Type entityType, ViewType viewType, Guid? formGuid)
	{
		return EntityObjectViewItemProvider.GetViewItem(entityType, formGuid, ItemType.Default, (ClassMetadata metadata, FormViewItem form) => TransformateStatic(metadata, form ?? new FormViewItemBuilder(metadata.Uid, viewType).DefaultContainer().FormView, viewType, ItemType.Default)) as FormViewItem;
	}
}
