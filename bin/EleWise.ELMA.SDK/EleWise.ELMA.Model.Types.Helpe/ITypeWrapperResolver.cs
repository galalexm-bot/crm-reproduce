using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.Types.Helpers;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface ITypeWrapperResolver
{
	Guid Uid { get; }

	string Caption { get; }

	object GetObjectInstance(string typeDescriptor);

	string GetObjectInstanceDescriptor(object property);
}
