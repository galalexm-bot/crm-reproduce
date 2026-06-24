using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Helpers;

internal static class PropertyDependencyHelper
{
	internal static ICollection<ILinkedObject> PropertiesProcessing(ClassMetadata md, ICollection<ILinkedObject> allMetadata)
	{
		List<ILinkedObject> list = new List<ILinkedObject>();
		foreach (PropertyMetadata property in md.Properties)
		{
			ProcessProperty(property, allMetadata, list);
		}
		if (md is EntityMetadata entityMetadata)
		{
			if (entityMetadata.TableParts != null)
			{
				foreach (TablePartMetadata tablePart in entityMetadata.TableParts)
				{
					list.AddRange(PropertiesProcessing(tablePart, allMetadata));
				}
			}
			if (entityMetadata.EntityTableParts != null)
			{
				foreach (TablePartMetadata item in (IEnumerable<TablePartMetadata>)entityMetadata.EntityTableParts)
				{
					list.AddRange(PropertiesProcessing(item, allMetadata));
				}
			}
			if (entityMetadata.EntityProperties != null)
			{
				foreach (EntityPropertyMetadata item2 in (IEnumerable<EntityPropertyMetadata>)entityMetadata.EntityProperties)
				{
					ProcessProperty(item2, allMetadata, list);
				}
			}
			if (entityMetadata.ViewModelMetadata != null)
			{
				list.AddRange(PropertiesProcessing(entityMetadata.ViewModelMetadata, allMetadata));
			}
		}
		return list;
	}

	private static void ProcessProperty(object property, ICollection<ILinkedObject> allMetadata, ICollection<ILinkedObject> resultList)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.property = (PropertyMetadata)property;
		if (CS_0024_003C_003E8__locals0.property.SubTypeUid != Guid.Empty)
		{
			ILinkedObject linkedObject = allMetadata.FirstOrDefault((ILinkedObject item) => _003C_003Ec__DisplayClass1_0.T9VXrKv0zTmC5mbLoErw(item) == CS_0024_003C_003E8__locals0.property.SubTypeUid);
			if (linkedObject != null)
			{
				resultList.Add(linkedObject);
			}
		}
		if (!(CS_0024_003C_003E8__locals0.property.Settings is PropertySettings propertySettings))
		{
			return;
		}
		_003C_003Ec__DisplayClass1_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass1_1();
		CS_0024_003C_003E8__locals1.entityTypeUid = propertySettings.EntityTypeUid;
		if (allMetadata.Any((ILinkedObject item) => _003C_003Ec__DisplayClass1_0.UrvN0kvmBdZfK2jlWFPW(_003C_003Ec__DisplayClass1_0.T9VXrKv0zTmC5mbLoErw(item), _003C_003Ec__DisplayClass1_0.MSDvkhvmFvy0oK62f6or(CS_0024_003C_003E8__locals0.property))))
		{
			ILinkedObject item2 = allMetadata.First((ILinkedObject item) => _003C_003Ec__DisplayClass1_1.CpQ0LUvmGt4GxhaiQyrn(item.Uid, CS_0024_003C_003E8__locals1.entityTypeUid));
			resultList.Add(item2);
		}
	}
}
