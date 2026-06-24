using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IUniqueFilterExtension
{
	Guid Uid { get; }

	Type FilterType { get; }

	Type EntityType { get; }
}
