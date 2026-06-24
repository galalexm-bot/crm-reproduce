using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface ITypeDescriptor : IXsiType
{
	Guid Uid { get; }

	Guid ParentUid { get; }

	bool IsGroup { get; }

	string Name { get; }

	bool Visible { get; }

	Guid SubTypeUid { get; }

	bool UseForId { get; }

	bool UseForEntity { get; }

	bool CanBeNullable { get; }

	bool? DefaultNullableValue { get; }

	Type SettingsType { get; }

	IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata);

	bool IsVisibleForMetadata(ClassMetadata classMetadata);

	Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata);

	TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata);

	bool IsEmpty(PropertyMetadata propertyMetadata, object val);

	bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val);

	bool HasRealColumn(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata);
}
