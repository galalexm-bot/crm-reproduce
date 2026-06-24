using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IPropertyHandler
{
	Guid Uid { get; }

	string Name { get; }

	bool IsAvailableFor(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, Guid typeUid, Guid subTypeUid, IEnumerable<PropertyHandlerInfo> currentHandlers);
}
