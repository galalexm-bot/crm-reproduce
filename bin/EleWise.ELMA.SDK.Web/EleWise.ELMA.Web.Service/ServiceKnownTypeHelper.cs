using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Models.API;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Web.Service;

public static class ServiceKnownTypeHelper
{
	public static IEnumerable<Type> GetGlobalKnownTypes(ICustomAttributeProvider provider)
	{
		return new Type[7]
		{
			typeof(DateTimeOffset),
			typeof(SerializableList<object>),
			typeof(SerializableDictionary<string, object>),
			typeof(EleWise.ELMA.Common.Models.WebData),
			typeof(EleWise.ELMA.Common.Models.WebData[]),
			typeof(EleWise.ELMA.Common.Models.API.WebData),
			typeof(EleWise.ELMA.Common.Models.API.WebData[])
		};
	}

	public static IEnumerable<Type> GetMetadataKnownTypes(ICustomAttributeProvider provider)
	{
		return new Type[3]
		{
			typeof(DateTimeOffset),
			typeof(PropertyViewSettings),
			typeof(ViewAttribute)
		}.Union(GetXmlKnownTypes(provider));
	}

	public static IEnumerable<Type> GetXmlKnownTypes(ICustomAttributeProvider provider)
	{
		return ComponentManager.Current.GetExtensionPointTypes<IXsiType>();
	}

	public static IEnumerable<Type> GetEntityKnownTypes(ICustomAttributeProvider provider)
	{
		return ComponentManager.Current.GetExtensionPointTypes<IEntity>();
	}
}
