using System;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Model.Types.Groups;

[Component]
public abstract class TypesGroupDescriptor : ITypeDescriptor
{
	public abstract Guid Uid { get; }

	public Guid SubTypeUid => Guid.Empty;

	public virtual Guid ParentUid => Guid.Empty;

	public abstract string Name { get; }

	public virtual bool Visible => true;

	public bool CanBeNullable => false;

	public bool? DefaultNullableValue => null;

	public System.Type SettingsType => null;

	public bool UseForEntity => false;

	public bool IsGroup => true;

	internal virtual bool OrderTypesByName => true;
}
