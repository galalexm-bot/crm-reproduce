using System;
using System.Linq;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.Common.Components;

[Component(Order = 2147483646)]
internal sealed class CatalogObjectFormProvider : AbstractObjectFormProvider
{
	private readonly CatalogManager catalogManager;

	public CatalogObjectFormProvider(IMetadataRuntimeService metadataRuntimeService, ViewModelDescriptor viewModelDescriptor, CatalogManager catalogManager)
		: base(metadataRuntimeService, viewModelDescriptor)
	{
		this.catalogManager = catalogManager;
	}

	public override bool Check(Guid typeUid, Guid subTypeUid)
	{
		if (typeUid != EntityMetadata.UID)
		{
			return false;
		}
		if (!(MetadataRuntimeService.GetMetadata(subTypeUid) is EntityMetadata entityMetadata))
		{
			return false;
		}
		return catalogManager.LoadByCatalog(entityMetadata.ImplementationUid) != null;
	}

	public override FormViewItem GetFormByType(object obj, ViewType viewType)
	{
		IEntity obj2 = (IEntity)obj;
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(obj2.CastAsRealType().GetType());
		FormViewItem formViewItem = ((classMetadata.FormsScheme == ClassFormsScheme.FormConstructor) ? classMetadata.DefaultForms.GetForm(viewType) : null);
		ItemType itemType = ((!IsGroup(obj2, classMetadata)) ? ItemType.Element : ItemType.Group);
		formViewItem = Transform(classMetadata, formViewItem, viewType, itemType);
		if (formViewItem != null && viewType == ViewType.Display)
		{
			formViewItem = (FormViewItem)formViewItem.CloneAsReadOnly();
		}
		return formViewItem;
	}

	public override FormViewItem GetFormByUid(object obj, Guid formUid)
	{
		if (formUid == Guid.Empty)
		{
			return null;
		}
		IEntity obj2 = (IEntity)obj;
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(obj2.CastAsRealType().GetType());
		FormViewItem formViewItem = classMetadata.GetForms().FirstOrDefault((FormViewItem q) => q.Uid == formUid);
		ItemType itemType = ((!IsGroup(obj2, classMetadata)) ? ItemType.Element : ItemType.Group);
		return Transform(classMetadata, formViewItem, ViewType.Custom, itemType);
	}

	protected override FormViewItem Transform(ClassMetadata metadata, FormViewItem formViewItem, ViewType viewType = ViewType.Custom, ItemType itemType = ItemType.Default)
	{
		formViewItem = formViewItem ?? new FormViewItemBuilder(metadata.Uid, viewType).DefaultContainer().FormView;
		formViewItem = formViewItem.Transformate(CatalogsFormViewTransformate.GetTransformation(metadata, formViewItem, viewType));
		return base.Transform(metadata, formViewItem, viewType, itemType);
	}

	private static bool IsGroup(IEntity entity, ClassMetadata metadata)
	{
		EntityMetadata entityMetadata;
		if ((entityMetadata = metadata as EntityMetadata) != null)
		{
			PropertyMetadata propertyMetadata = ((entityMetadata.Hierarchical && entityMetadata.HierarchyType == HierarchyType.GroupAndElements && entityMetadata.IsGroupPropertyUid != Guid.Empty) ? metadata.Properties.Find((PropertyMetadata p) => p.Uid == entityMetadata.IsGroupPropertyUid) : null);
			if (propertyMetadata != null)
			{
				return (bool)entity.GetPropertyValue(propertyMetadata.Uid);
			}
		}
		return false;
	}
}
