using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.ViewItems;

namespace EleWise.ELMA.Workflow.Web.Components;

[Component]
public class HideEmptyContextPropertyViewItemAdjustment : IHideEmptyPropertyViewItemAdjustment
{
	public bool IsApplicable(PropertyViewItem propertyViewItem, object entity)
	{
		return propertyViewItem is ContextPropertyViewItem;
	}

	public void Adjust(PropertyViewItem propertyViewItem, object entity)
	{
		if (!propertyViewItem.IsHideEmpty() || propertyViewItem.Attributes.ShowEmpty)
		{
			return;
		}
		object contextEntity = ContextVars.GetOrDefault<object>("ContextPropertyViewItemModel") ?? ContextVars.GetOrDefault<object>("FormViewItemEntity");
		if (contextEntity == null)
		{
			return;
		}
		ProcessContext orAdd = ContextVars.GetOrAdd("ContextPropertyIsEmpty_metadata", () => MetadataLoader.LoadMetadata(contextEntity.GetType()) as ProcessContext);
		if (orAdd == null)
		{
			return;
		}
		List<IPropertyIsEmpty> extensionPoints = ComponentManager.Current.GetExtensionPoints<IPropertyIsEmpty>().ToList();
		foreach (IPropertyIsEmpty item in extensionPoints)
		{
			bool? flag = item.IsEmpty(propertyViewItem, contextEntity, orAdd);
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
		IPropertyMetadata propertyMetadata = orAdd.GetPropertiesAndTableParts().FirstOrDefault((IPropertyMetadata p) => p.PropertyUid == propertyViewItem.PropertyUid);
		if (propertyMetadata == null)
		{
			return;
		}
		IEntity propertyEntity = contextEntity.GetPropertyValue(propertyMetadata.Name, null) as IEntity;
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
