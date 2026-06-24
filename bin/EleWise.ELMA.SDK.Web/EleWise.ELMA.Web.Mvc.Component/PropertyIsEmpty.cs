using System;
using System.Collections;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component(Order = int.MaxValue)]
public class PropertyIsEmpty : IPropertyIsEmptyOrDefault, IPropertyIsEmpty
{
	private bool? IsEmptyPrivate(PropertyViewItem propertyViewItem, object entity, EntityMetadata metadata, Func<ITypeDescriptor, PropertyMetadata, object, bool?> checkPropertyProc)
	{
		if (metadata == null)
		{
			return null;
		}
		IPropertyMetadata propertyMetadata = metadata.GetPropertiesAndTableParts().FirstOrDefault((IPropertyMetadata p) => p.PropertyUid == propertyViewItem.PropertyUid);
		if (propertyMetadata == null)
		{
			return null;
		}
		if (propertyMetadata is PropertyMetadata propertyMetadata2)
		{
			return checkPropertyProc(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeDescriptor(propertyMetadata2.TypeUid, propertyMetadata2.SubTypeUid), propertyMetadata2, entity.GetPropertyValue(propertyMetadata2.Name, null));
		}
		IEntity entity2 = entity as IEntity;
		ITablePartMetadata tablePartMetadata = propertyMetadata as ITablePartMetadata;
		if (entity2 != null && tablePartMetadata != null)
		{
			return entity2.GetPropertyValue(tablePartMetadata.TablePartPropertyUid) is ICollection collection && collection.Count == 0;
		}
		return null;
	}

	public bool? IsEmpty(PropertyViewItem propertyViewItem, object entity, EntityMetadata metadata)
	{
		return IsEmptyPrivate(propertyViewItem, entity, metadata, (ITypeDescriptor typeDescriptor, PropertyMetadata propertyMetadata, object value) => typeDescriptor.IsEmpty(propertyMetadata, value));
	}

	public bool? IsEmptyOrDefault(PropertyViewItem propertyViewItem, object entity, EntityMetadata metadata)
	{
		return IsEmptyPrivate(propertyViewItem, entity, metadata, (ITypeDescriptor typeDescriptor, PropertyMetadata propertyMetadata, object value) => typeDescriptor.IsEmptyOrDefault(propertyMetadata, value));
	}
}
