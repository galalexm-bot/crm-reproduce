using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.ComponentModel;

[DeveloperApi(DeveloperApiType.Service)]
public interface IComponentManager
{
	IEnumerable<T> GetExtensionPoints<T>();

	IEnumerable<Type> GetExtensionPointTypes(Type type);

	IEnumerable<Type> GetExtensionPointTypes<T>();

	Type[] GetExtensionPointTypesArray(Type type);
}
