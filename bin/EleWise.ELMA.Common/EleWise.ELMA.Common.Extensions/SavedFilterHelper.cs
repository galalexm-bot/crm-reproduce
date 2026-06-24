using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Extensions;

public static class SavedFilterHelper
{
	public const int MaxLevels = 3;

	private static void LoadMetadataProperties(Type type, IEntityFilter obj, List<FilterMetadataProperty> res, bool inherit, int levels, string prefix, string propertyPath, Dictionary<Guid, Guid> universalFilterUnPackFromDictionary, Dictionary<string, Type> propertyFilterTypes, Guid? filterObjectTypeUid, Guid? filterCode)
	{
		if (levels < 0)
		{
			return;
		}
		IEnumerable<IFilterPropertiesExtension> extensionPoints = ComponentManager.Current.GetExtensionPoints<IFilterPropertiesExtension>();
		List<Type> list = new List<Type>();
		while (type != null)
		{
			list.Insert(0, type);
			type = (inherit ? type.BaseType : null);
		}
		foreach (Type item in list)
		{
			ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(item, inherit: false, loadImplementation: false);
			FilterForAttribute filterForAttribute = (FilterForAttribute)item.GetCustomAttributes(typeof(FilterForAttribute), inherit: true).FirstOrDefault();
			ClassMetadata entityMetadata = ((filterForAttribute != null) ? ((ClassMetadata)MetadataLoader.LoadMetadata(filterForAttribute.EntityType, inherit: false, loadImplementation: false)) : null);
			if (universalFilterUnPackFromDictionary != null)
			{
				foreach (KeyValuePair<Guid, string> pair in UniversalFilterSaver.UniversalFilterUnPackFromDictionary(item))
				{
					Guid guid = (from m in classMetadata.Properties
						where m.Name == pair.Value
						select m.Uid).FirstOrDefault();
					if (guid != Guid.Empty)
					{
						universalFilterUnPackFromDictionary[pair.Key] = guid;
					}
				}
			}
			foreach (PropertyMetadata prop in classMetadata.Properties.OrderBy((PropertyMetadata m) => m.Order).ToList())
			{
				IFilterPropertiesExtension filterPropertiesExtension = extensionPoints.FirstOrDefault((IFilterPropertiesExtension p) => p.Resolve(prop, entityMetadata));
				if (filterPropertiesExtension != null)
				{
					bool addProperty;
					List<FilterMetadataProperty> list2 = (filterPropertiesExtension.GetFilterMetadataProperties(obj, prop, entityMetadata, prefix, filterObjectTypeUid, filterCode, out addProperty) ?? Enumerable.Empty<FilterMetadataProperty>()).ToList();
					if (!string.IsNullOrEmpty(propertyPath))
					{
						list2.ForEach(delegate(FilterMetadataProperty p)
						{
							p.PropertyPath = ((!string.IsNullOrEmpty(p.PropertyPath)) ? (propertyPath + " / " + p.PropertyPath) : propertyPath);
						});
					}
					res.AddRange(list2);
					if (!addProperty)
					{
						continue;
					}
				}
				PropertyInfo propertyInfo = item.GetReflectionProperty(prop.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public) ?? item.GetReflectionProperty(prop.Name);
				IEntityFilter entityFilter = ((obj != null && item.IsInstanceOfType(obj)) ? (propertyInfo.GetValue(obj, null) as IEntityFilter) : null);
				Type type2 = InterfaceActivator.TypeOf(propertyInfo.PropertyType);
				if (entityFilter == null && obj != null && typeof(IEntityFilter).IsAssignableFrom(type2))
				{
					try
					{
						entityFilter = (IEntityFilter)InterfaceActivator.Create(type2);
						propertyInfo.SetValue(obj, entityFilter, null);
					}
					catch
					{
					}
				}
				Type type3 = ((entityFilter != null) ? entityFilter.GetType() : type2);
				if (propertyFilterTypes != null && type3 != type2)
				{
					propertyFilterTypes[$"{prefix}{prop.Name}"] = type3;
				}
				if (typeof(IEntityFilter).IsAssignableFrom(type3))
				{
					LoadMetadataProperties(InterfaceActivator.TypeOf(type3), entityFilter, res, inherit: true, levels - 1, prefix + prop.Name + ".", string.IsNullOrWhiteSpace(propertyPath) ? prop.DisplayName : (propertyPath + " / " + prop.DisplayName), universalFilterUnPackFromDictionary, propertyFilterTypes, filterObjectTypeUid, filterCode);
					continue;
				}
				res.Add(new FilterMetadataProperty
				{
					ClassFullName = item.FullName,
					ClassUid = ((entityMetadata != null) ? entityMetadata.Uid : Guid.Empty),
					ClassDisplayName = ((entityMetadata != null) ? entityMetadata.DisplayName : string.Empty),
					PropertyName = $"{prefix}{prop.Name}",
					PropertyDisplayName = prop.DisplayName,
					PropertyPath = propertyPath,
					PropertyUid = prop.Uid
				}.SetVisible(prop.ViewSettings));
			}
		}
	}

	public static List<FilterMetadataProperty> LoadMetadataProperties(this IEntityFilter entity, string prefix = "", Dictionary<Guid, Guid> universalFilterUnPackFromDictionary = null, Dictionary<string, Type> propertyFilterTypes = null, Guid? filterObjectTypeUid = null, Guid? filterCode = null)
	{
		return entity.LoadMetadataProperties(3, prefix, universalFilterUnPackFromDictionary, propertyFilterTypes, filterObjectTypeUid, filterCode);
	}

	public static List<FilterMetadataProperty> LoadMetadataProperties(this IEntityFilter entity, int levels, string prefix = "", Dictionary<Guid, Guid> universalFilterUnPackFromDictionary = null, Dictionary<string, Type> propertyFilterTypes = null, Guid? filterObjectTypeUid = null, Guid? filterCode = null)
	{
		return LoadMetadataProperties(entity.GetType(), entity, levels, prefix, universalFilterUnPackFromDictionary, propertyFilterTypes, filterObjectTypeUid, filterCode);
	}

	public static List<FilterMetadataProperty> LoadMetadataProperties(this Type type, string prefix = "", Dictionary<Guid, Guid> universalFilterUnPackFromDictionary = null, Dictionary<string, Type> propertyFilterTypes = null, Guid? filterObjectTypeUid = null, Guid? filterCode = null)
	{
		return type.LoadMetadataProperties(3, prefix, universalFilterUnPackFromDictionary, propertyFilterTypes, filterObjectTypeUid, filterCode);
	}

	public static List<FilterMetadataProperty> LoadMetadataProperties(this Type type, int levels, string prefix = "", Dictionary<Guid, Guid> universalFilterUnPackFromDictionary = null, Dictionary<string, Type> propertyFilterTypes = null, Guid? filterObjectTypeUid = null, Guid? filterCode = null)
	{
		return LoadMetadataProperties(type, null, levels, prefix, universalFilterUnPackFromDictionary, propertyFilterTypes, filterObjectTypeUid, filterCode);
	}

	private static List<FilterMetadataProperty> LoadMetadataProperties(Type type, IEntityFilter entity, int levels, string prefix, Dictionary<Guid, Guid> universalFilterUnPackFromDictionary, Dictionary<string, Type> propertyFilterTypes, Guid? filterObjectTypeUid, Guid? filterCode)
	{
		List<FilterMetadataProperty> res = new List<FilterMetadataProperty>();
		LoadMetadataProperties(type, entity, res, inherit: true, levels, prefix, null, universalFilterUnPackFromDictionary, propertyFilterTypes, filterObjectTypeUid, filterCode);
		ComponentManager.Current.GetExtensionPoints<IFilterPropertiesExtension>().Each(delegate(IFilterPropertiesExtension p)
		{
			p.UpdateProperties(type, filterObjectTypeUid, filterCode, res);
		});
		return res;
	}

	private static void LoadFilterMetadataSubProperties(Guid typeUid, Type type, Type baseType, IEntityFilter entity, List<FilterMetadataProperty> res, int levels, string prefix, Dictionary<Guid, Guid> universalFilterUnPackFromDictionary, Dictionary<string, Type> propertyFilterTypes, Guid? filterObjectTypeUid, Guid? filterCode)
	{
		type = type ?? MetadataLoader.GetFilterType(typeUid);
		if (type != null && type != baseType)
		{
			LoadMetadataProperties(type, entity, res, baseType == null, levels, prefix, null, universalFilterUnPackFromDictionary, propertyFilterTypes, filterObjectTypeUid, filterCode);
		}
		IEnumerable<ClassMetadata> enumerable = (from m in Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList()
			where m is ClassMetadata && ((ClassMetadata)m).BaseClassUid == typeUid
			select m).Cast<ClassMetadata>();
		IFilterTypeFilter filterTypeFilter = ComponentManager.Current.GetExtensionPoints<IFilterTypeFilter>().FirstOrDefault((IFilterTypeFilter f) => f.EntityTypeUid == typeUid);
		if (filterTypeFilter != null)
		{
			enumerable = enumerable.Where(filterTypeFilter.GetFilter());
		}
		foreach (ClassMetadata item in enumerable)
		{
			LoadFilterMetadataSubProperties(item.Uid, null, type, entity, res, levels, prefix, universalFilterUnPackFromDictionary, propertyFilterTypes, filterObjectTypeUid, filterCode);
		}
	}

	public static List<FilterMetadataProperty> LoadFilterMetadataProperties(this Guid typeUid, bool withSubTypes, IEntityFilter entity = null, string prefix = "", Dictionary<Guid, Guid> universalFilterUnPackFromDictionary = null, Dictionary<string, Type> propertyFilterTypes = null, Guid? filterObjectTypeUid = null, Guid? filterCode = null)
	{
		return typeUid.LoadFilterMetadataProperties(withSubTypes, entity, 3, prefix, universalFilterUnPackFromDictionary, propertyFilterTypes, filterObjectTypeUid, filterCode);
	}

	public static List<FilterMetadataProperty> LoadFilterMetadataProperties(this Guid typeUid, bool withSubTypes, int levels, string prefix = "", Dictionary<Guid, Guid> universalFilterUnPackFromDictionary = null, Dictionary<string, Type> propertyFilterTypes = null, Guid? filterObjectTypeUid = null, Guid? filterCode = null)
	{
		return typeUid.LoadFilterMetadataProperties(withSubTypes, null, levels, prefix, universalFilterUnPackFromDictionary, propertyFilterTypes, filterObjectTypeUid, filterCode);
	}

	public static List<FilterMetadataProperty> LoadFilterMetadataProperties(this Guid typeUid, bool withSubTypes, IEntityFilter entity, int levels, string prefix = "", Dictionary<Guid, Guid> universalFilterUnPackFromDictionary = null, Dictionary<string, Type> propertyFilterTypes = null, Guid? filterObjectTypeUid = null, Guid? filterCode = null)
	{
		List<FilterMetadataProperty> res = new List<FilterMetadataProperty>();
		Type type = MetadataLoader.GetFilterType(typeUid);
		if (type != null)
		{
			if (withSubTypes)
			{
				LoadFilterMetadataSubProperties(typeUid, type, null, entity, res, levels, prefix, universalFilterUnPackFromDictionary, propertyFilterTypes, filterObjectTypeUid, filterCode);
			}
			else
			{
				LoadMetadataProperties(type, entity, res, inherit: true, levels, prefix, null, universalFilterUnPackFromDictionary, propertyFilterTypes, filterObjectTypeUid, filterCode);
			}
			ComponentManager.Current.GetExtensionPoints<IFilterPropertiesExtension>().Each(delegate(IFilterPropertiesExtension p)
			{
				p.UpdateProperties(type, filterObjectTypeUid, filterCode, res);
			});
		}
		return res;
	}

	private static void LoadMetadataWithChilds(Type type, List<FilterMetadataProperty> res)
	{
		(from p in type.LoadMetadataProperties()
			where res.All((FilterMetadataProperty mp) => mp.PropertyName != p.PropertyName)
			select p).ForEach(res.Add);
		FilterForAttribute filterForAttribute = (FilterForAttribute)type.GetCustomAttributes(typeof(FilterForAttribute), inherit: true).FirstOrDefault();
		ClassMetadata entityMetadata = ((filterForAttribute != null) ? ((ClassMetadata)MetadataLoader.LoadMetadata(filterForAttribute.EntityType, inherit: false, loadImplementation: false)) : null);
		if (entityMetadata != null)
		{
			(from m in Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList()
				where m is ClassMetadata && ((ClassMetadata)m).BaseClassUid == entityMetadata.Uid
				select m).ToList().ForEach(delegate(IMetadata ch)
			{
				LoadMetadataWithChilds(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(ch.Uid), res);
			});
		}
	}

	public static List<FilterMetadataProperty> LoadMetadataWithChilds(this Type type, Dictionary<Guid, Type> filterTypes = null)
	{
		List<FilterMetadataProperty> list = new List<FilterMetadataProperty>();
		LoadMetadataWithChilds(type, list);
		return list;
	}
}
