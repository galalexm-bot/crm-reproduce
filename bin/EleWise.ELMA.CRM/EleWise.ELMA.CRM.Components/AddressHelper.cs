using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Components;

public static class AddressHelper
{
	public static readonly string FormatTemplate = SR.T("{if {$Zip} = null}{else}{$Zip}, {end}{if {$Country} = null}{else}{$Country}, {end}{if {$Region} = null}{else}{$Region}, {end}{if {$District} = null}{else}{$District}, {end}{if {$City} = null}{else}г. {$City}, {end}{if {$Locality} = null}{else}{$Locality}, {end}{if {$Street} = null}{else}ул. {$Street}, {end}{if {$Building} = null}{else}д. {$Building}, {end}{if {$Korpus} = null}{else}кор. {$Korpus}, {end}{if {$Stroenie} = null}{else}стр. {$Stroenie}, {end}{if {$Appartment} = null}{else}{if {$AptType} = 'Appartment'}кв.{end}{if {$AptType} = 'Office'}оф.{end}{if {$AptType} = 'Hall'}пом.{end}{if {$AptType} = 'Room'}к.{end}{if {$AptType} = 'Cabinet'}каб.{end}{if {$AptType} = 'POBox'}а/я.{end} {$Appartment}, {end}");

	public static bool IsEmpty(this IAddress address)
	{
		List<PropertyMetadata> list = new List<PropertyMetadata>();
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(address.GetType());
		list.AddRange(classMetadata.Properties);
		bool result = true;
		foreach (PropertyMetadata item in list)
		{
			ITypeDescriptor typeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(item.TypeUid, item.SubTypeUid);
			if (typeDescriptor == null)
			{
				continue;
			}
			PropertyInfo reflectionProperty = address.GetType().GetReflectionProperty(item.Name);
			if (!(reflectionProperty == null))
			{
				object value = reflectionProperty.GetValue(address, null);
				if (!typeDescriptor.IsEmptyOrDefault(item, value))
				{
					return false;
				}
			}
		}
		return result;
	}

	public static bool IsEqual(this IAddress address, IAddress otherAddress)
	{
		if (address == null && otherAddress == null)
		{
			return true;
		}
		if (address == null || otherAddress == null)
		{
			return false;
		}
		List<PropertyMetadata> list = new List<PropertyMetadata>();
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(address.GetType());
		list.AddRange(classMetadata.Properties.Where((PropertyMetadata p) => !p.IsSystem));
		foreach (PropertyMetadata item in list)
		{
			if (MetadataServiceContext.Service.GetTypeDescriptor(item.TypeUid, item.SubTypeUid) == null)
			{
				continue;
			}
			PropertyInfo reflectionProperty = address.GetType().GetReflectionProperty(item.Name);
			if (!(reflectionProperty == null))
			{
				object obj = reflectionProperty.GetValue(address, null).CastAsRealType();
				object obj2 = reflectionProperty.GetValue(otherAddress, null).CastAsRealType();
				if (obj != obj2 && ((obj != null && !obj.Equals(obj2)) || obj == null))
				{
					return false;
				}
			}
		}
		return true;
	}

	public static IAddress CloneTo(this IAddress address, IAddress destinationAddress)
	{
		if (destinationAddress == null)
		{
			return destinationAddress;
		}
		Type type = address.GetType().CastAsRealType();
		if (destinationAddress.GetType().CastAsRealType() != type)
		{
			destinationAddress = InterfaceActivator.Create(type) as IAddress;
			if (destinationAddress == null)
			{
				return destinationAddress;
			}
		}
		List<PropertyMetadata> list = new List<PropertyMetadata>();
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(type);
		list.AddRange(classMetadata.Properties);
		foreach (PropertyMetadata item in list)
		{
			if ((!(item.Name == "Uid") || !item.IsSystem) && MetadataServiceContext.Service.GetTypeDescriptor(item.TypeUid, item.SubTypeUid) != null)
			{
				PropertyInfo reflectionProperty = address.GetType().GetReflectionProperty(item.Name);
				if (!(reflectionProperty == null))
				{
					object value = reflectionProperty.GetValue(address, null);
					destinationAddress.SetPropertyValue(item.Uid, value);
				}
			}
		}
		return destinationAddress;
	}

	public static IAddress ConvertTo(this IAddress address, Guid addressTypeUid)
	{
		return address.ConvertTo(MetadataServiceContext.MetadataRuntimeService.GetTypeByUid(addressTypeUid));
	}

	public static IAddress ConvertTo(this IAddress address, Type addressType)
	{
		if (address == null || address.GetType().IsInheritOrSame(addressType))
		{
			return address;
		}
		return CloneHelperBuilder.Create(address).Clone((IAddress)InterfaceActivator.Create(addressType));
	}
}
