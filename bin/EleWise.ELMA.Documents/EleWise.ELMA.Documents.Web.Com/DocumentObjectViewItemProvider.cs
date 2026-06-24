using System;
using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.Documents.Web.Components;

public class DocumentObjectViewItemProvider : EntityObjectViewItemProvider
{
	public new static readonly Guid UID = new Guid("{76C8EE6E-F80C-4FD8-B085-312FFC97DEF4}");

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
		formViewItem = formViewItem.Transformate(DocumentFormViewTransformate.GetTransformation(metadata as DocumentMetadata, viewType));
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

	public static FormViewItem GetViewItem(Type entityType, ViewType viewType, Guid? formGuid)
	{
		return EntityObjectViewItemProvider.GetViewItem(entityType, formGuid, ItemType.Default, (ClassMetadata metadata, FormViewItem form) => TransformateStatic(metadata, form ?? new FormViewItemBuilder(metadata.Uid, viewType).DefaultContainer().FormView, viewType, ItemType.Default)) as FormViewItem;
	}
}
