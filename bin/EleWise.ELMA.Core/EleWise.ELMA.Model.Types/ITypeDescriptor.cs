using System;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Model.Types;

[ExtensionPoint]
public interface ITypeDescriptor
{
	Guid Uid { get; }

	Guid ParentUid { get; }

	bool IsGroup { get; }

	string Name { get; }

	bool Visible { get; }

	Guid SubTypeUid { get; }

	bool UseForEntity { get; }

	bool CanBeNullable { get; }

	bool? DefaultNullableValue { get; }

	System.Type SettingsType { get; }
}
