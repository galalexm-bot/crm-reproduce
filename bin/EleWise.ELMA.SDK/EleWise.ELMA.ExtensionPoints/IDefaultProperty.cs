using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IDefaultProperty
{
	string Name { get; }

	Guid Uid { get; }

	bool DefaultChecked { get; }

	bool IsAvailableFor(ClassMetadata classMetadata, List<IMetadata> allProperties = null);

	void InitProperty(ClassMetadata classMetadata, PropertyMetadata propertyMetadata);
}
