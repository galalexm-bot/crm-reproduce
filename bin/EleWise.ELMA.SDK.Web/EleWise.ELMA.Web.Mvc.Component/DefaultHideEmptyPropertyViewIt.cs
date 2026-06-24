using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component(Order = int.MaxValue)]
public class DefaultHideEmptyPropertyViewItemAdjustment : IHideEmptyPropertyViewItemAdjustment
{
	public bool IsApplicable(PropertyViewItem propertyViewItem, object entity)
	{
		return true;
	}

	public void Adjust(PropertyViewItem propertyViewItem, object entity)
	{
		if (propertyViewItem is PropertyCaptionViewItem || propertyViewItem is PropertyDescriptionViewItem)
		{
			propertyViewItem.Hide = true;
		}
		else
		{
			if (entity == null || !propertyViewItem.IsHideEmpty() || propertyViewItem.Attributes.ShowEmpty || !(MetadataLoader.LoadMetadata(entity.GetType()) is EntityMetadata entityMetadata))
			{
				return;
			}
			List<IPropertyIsEmpty> extensionPoints = ComponentManager.Current.GetExtensionPoints<IPropertyIsEmpty>().ToList();
			foreach (IPropertyIsEmpty item in extensionPoints)
			{
				bool? flag = item.IsEmpty(propertyViewItem, entity, entityMetadata);
				if (flag.HasValue)
				{
					propertyViewItem.Hide = flag.Value;
					break;
				}
			}
			if (!propertyViewItem.Items.Any())
			{
				return;
			}
			IPropertyMetadata propertyMetadata = entityMetadata.GetPropertiesAndTableParts().FirstOrDefault((IPropertyMetadata p) => p.PropertyUid == propertyViewItem.PropertyUid);
			if (propertyMetadata == null)
			{
				return;
			}
			IEntity propertyEntity = entity.GetPropertyValue(propertyMetadata.Name, null) as IEntity;
			if (propertyEntity == null)
			{
				return;
			}
			EntityMetadata propertyEntityMetadata = MetadataLoader.LoadMetadata(propertyEntity.GetType()) as EntityMetadata;
			if (propertyEntityMetadata == null)
			{
				return;
			}
			propertyViewItem.Items.ForEach(delegate(ViewItem i)
			{
				if (!(i is PropertyViewItem propertyViewItem2))
				{
					return;
				}
				foreach (IPropertyIsEmpty item2 in extensionPoints)
				{
					bool? flag2 = item2.IsEmpty(propertyViewItem2, propertyEntity, propertyEntityMetadata);
					if (flag2.HasValue)
					{
						propertyViewItem2.Hide |= flag2.Value;
						break;
					}
				}
			});
		}
	}
}
