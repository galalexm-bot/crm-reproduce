using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Convertors;
using EleWise.ELMA.RPA.Services;

namespace EleWise.ELMA.RPA.Models.Mappings;

[Service]
internal sealed class RPAPropertyMapService : IRPAPropertyMapService
{
	private readonly ITypeConverterService elmaTypeConverterService;

	private readonly IPropertyMapService propertyMapService;

	private readonly IRPASerializationService serializationService;

	public RPAPropertyMapService(ITypeConverterService elmaTypeConverterService, IPropertyMapService propertyMapService, IRPASerializationService serializationService)
	{
		this.elmaTypeConverterService = elmaTypeConverterService;
		this.propertyMapService = propertyMapService;
		this.serializationService = serializationService;
	}

	public string MapToRPA(object objLeft, object objRight, PropertyMap map)
	{
		Contract.ArgumentNotNull(objLeft, "objLeft");
		Contract.ArgumentNotNull(objRight, "objRight");
		Contract.ArgumentNotNull(map, "map");
		ClassMetadata objectClassMetadata = GetObjectClassMetadata(objLeft);
		ClassMetadata objectClassMetadata2 = GetObjectClassMetadata(objRight);
		IEnumerable<IPropertyMetadata> propertiesFromMetadata = GetPropertiesFromMetadata(objectClassMetadata);
		IEnumerable<IPropertyMetadata> propertiesFromMetadata2 = GetPropertiesFromMetadata(objectClassMetadata2);
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		foreach (PropertyMapItem item in map.Items)
		{
			if (item.RightPropertyUid == Guid.Empty)
			{
				continue;
			}
			IPropertyMetadata propertyMetadata = null;
			if (item.LeftPropertyUid != Guid.Empty)
			{
				propertyMetadata = ((item.ParentProperties.Count != 0) ? ((ClassMetadata)MetadataLoader.LoadMetadata(item.ParentProperties.Last().SubTypeUid)).Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == item.LeftPropertyUid) : propertiesFromMetadata.FirstOrDefault((IPropertyMetadata p) => p.PropertyUid == item.LeftPropertyUid));
			}
			IPropertyMetadata propertyMetadata2 = propertiesFromMetadata2.FirstOrDefault((IPropertyMetadata p) => p.PropertyUid == item.RightPropertyUid);
			if (propertyMetadata2 == null)
			{
				continue;
			}
			PropertyMetadata leftPropMd = propertyMetadata as PropertyMetadata;
			object leftValue = GetLeftValue(objLeft, leftPropMd, item);
			if (leftValue != null)
			{
				object obj = ConvertValueToTargetType(leftValue, propertyMetadata2);
				KeyValuePair<string, object> keyValuePair = ((obj == null) ? MapProperty(leftValue, propertyMetadata2) : MapProperty(obj, propertyMetadata2));
				if (keyValuePair.Key != null)
				{
					dictionary[keyValuePair.Key] = keyValuePair.Value;
				}
			}
		}
		return serializationService.Serialize(dictionary);
	}

	public void MapFromRPA(object objLeft, object objRight, PropertyMap map, string rpaOutContext)
	{
		Contract.ArgumentNotNull(objLeft, "objLeft");
		Contract.ArgumentNotNull(objRight, "objRight");
		Contract.ArgumentNotNull(map, "map");
		ClassMetadata objectClassMetadata = GetObjectClassMetadata(objLeft);
		ClassMetadata objectClassMetadata2 = GetObjectClassMetadata(objRight);
		IEnumerable<IPropertyMetadata> propertiesFromMetadata = GetPropertiesFromMetadata(objectClassMetadata);
		IEnumerable<IPropertyMetadata> propertiesFromMetadata2 = GetPropertiesFromMetadata(objectClassMetadata2);
		foreach (PropertyMapItem item in map.Items)
		{
			if (item.RightPropertyUid == Guid.Empty)
			{
				continue;
			}
			IPropertyMetadata propertyMetadata = ((item.LeftPropertyUid != Guid.Empty) ? propertiesFromMetadata.FirstOrDefault((IPropertyMetadata p) => p.PropertyUid == item.LeftPropertyUid) : null);
			IPropertyMetadata propertyMetadata2 = null;
			if (item.LeftPropertyUid != Guid.Empty)
			{
				propertyMetadata2 = ((item.ParentProperties.Count != 0) ? ((ClassMetadata)MetadataLoader.LoadMetadata(item.ParentProperties.Last().SubTypeUid)).Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == item.RightPropertyUid) : propertiesFromMetadata2.FirstOrDefault((IPropertyMetadata p) => p.PropertyUid == item.RightPropertyUid));
			}
			if (propertyMetadata2 == null)
			{
				continue;
			}
			PropertyMetadata propertyMetadata3 = propertyMetadata as PropertyMetadata;
			object leftValue = GetLeftValue(rpaOutContext, propertyMetadata3, item);
			object parentObjectForProperty = GetParentObjectForProperty(objRight, item);
			if (parentObjectForProperty != null)
			{
				object obj = ConvertValueToTargetType(leftValue, propertyMetadata2);
				if (obj != null)
				{
					propertyMapService.MapProperty(parentObjectForProperty, (PropertyMetadata)propertyMetadata2, obj, (PropertyMetadata)propertyMetadata2);
				}
				else
				{
					propertyMapService.MapProperty(parentObjectForProperty, (PropertyMetadata)propertyMetadata2, leftValue, propertyMetadata3);
				}
			}
		}
	}

	private KeyValuePair<string, object> MapProperty(object leftValue, IPropertyMetadata rightPropMd)
	{
		return new KeyValuePair<string, object>(rightPropMd.Name, leftValue);
	}

	private object GetLeftValue(object obj, IPropertyMetadata leftPropMd, PropertyMapItem item)
	{
		if (obj is string)
		{
			if (leftPropMd == null)
			{
				return null;
			}
			return serializationService.Deserialize<Dictionary<string, object>>((string)obj)[leftPropMd.Name.ToLower()];
		}
		if (item.ParentProperties.Count != 0)
		{
			object parentObjectForProperty = GetParentObjectForProperty(obj, item);
			if (parentObjectForProperty == null || leftPropMd == null)
			{
				return null;
			}
			return parentObjectForProperty.GetType().GetReflectionProperty(leftPropMd.Name).GetValue(parentObjectForProperty);
		}
		IEntity entity = obj as IEntity;
		if (leftPropMd == null)
		{
			if (!item.ThisMarker)
			{
				return item.LeftValue;
			}
			return entity;
		}
		if (entity != null)
		{
			return entity.GetPropertyValue(leftPropMd.Uid);
		}
		return obj.GetType().GetReflectionProperty(leftPropMd.Name).GetValue(obj, null);
	}

	private object GetParentObjectForProperty(object startingObj, PropertyMapItem item)
	{
		if (item.ParentProperties.Count != 0)
		{
			object obj = startingObj;
			{
				foreach (PropertyMetadata parentProperty in item.ParentProperties)
				{
					obj = obj.GetType().GetReflectionProperty(parentProperty.Name).GetValue(obj);
					if (obj == null)
					{
						return null;
					}
				}
				return obj;
			}
		}
		return startingObj;
	}

	private object ConvertValueToTargetType(object value, IPropertyMetadata targetMetadata)
	{
		if (targetMetadata == null)
		{
			return null;
		}
		return elmaTypeConverterService.GetConverterToTargetType(targetMetadata.TypeUid)?.DoConvert(value);
	}

	private ClassMetadata GetObjectClassMetadata(object obj)
	{
		ClassMetadata classMetadata = obj as ClassMetadata;
		if (classMetadata == null)
		{
			classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(obj.GetType());
		}
		return classMetadata;
	}

	private IEnumerable<IPropertyMetadata> GetPropertiesFromMetadata(ClassMetadata metadata)
	{
		if (!(metadata is EntityMetadata))
		{
			return metadata.Properties.Cast<IPropertyMetadata>();
		}
		return ((EntityMetadata)metadata).GetPropertiesAndTableParts();
	}
}
