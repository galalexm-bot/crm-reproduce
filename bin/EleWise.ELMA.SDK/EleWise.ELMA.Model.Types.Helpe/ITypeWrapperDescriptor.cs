using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.Types.Helpers;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface ITypeWrapperDescriptor
{
	Type OriginalType { get; }

	Type WrapperType { get; }

	bool TestType(Type type);

	object CreateWrapper(object obj);

	object GetObject(object wrapper);
}
