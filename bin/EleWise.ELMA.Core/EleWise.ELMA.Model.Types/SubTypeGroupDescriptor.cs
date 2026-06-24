using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Types;

public class SubTypeGroupDescriptor : ITypeDescriptor
{
	private readonly List<ITypeDescriptor> _003CSubTypes_003Ek__BackingField;

	private readonly string _003CName_003Ek__BackingField;

	private readonly ITypeDescriptor parent;

	public Guid Uid => Guid.Empty;

	public Guid SubTypeUid => Guid.Empty;

	public Guid ParentUid => Guid.Empty;

	public List<ITypeDescriptor> SubTypes => _003CSubTypes_003Ek__BackingField;

	public bool IsGroup => true;

	public string Name => _003CName_003Ek__BackingField;

	public virtual bool Visible => true;

	public bool CanBeNullable => false;

	public bool? DefaultNullableValue => null;

	public System.Type SettingsType => null;

	public bool UseForEntity => false;

	public SubTypeGroupDescriptor(string name, ITypeDescriptor parent)
	{
		this.parent = parent;
		_003CName_003Ek__BackingField = name;
		_003CSubTypes_003Ek__BackingField = new List<ITypeDescriptor>();
	}
}
