using System;
using EleWise.ELMA.Core.Diagnostics;

namespace EleWise.ELMA.Model.Types;

public sealed class SubTypeDescriptor : ITypeDescriptor
{
	private Guid _003CUid_003Ek__BackingField;

	private readonly Guid _003CSubTypeUid_003Ek__BackingField;

	private readonly string _003CName_003Ek__BackingField;

	private bool _003CCanBeNullable_003Ek__BackingField;

	private bool? _003CDefaultNullableValue_003Ek__BackingField;

	private System.Type _003CSettingsType_003Ek__BackingField;

	private bool _003CUseForEntity_003Ek__BackingField;

	private readonly ITypeDescriptor baseTypeDescriptor;

	public Guid Uid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CUid_003Ek__BackingField = value;
		}
	}

	public Guid SubTypeUid => _003CSubTypeUid_003Ek__BackingField;

	public Guid ParentUid => Uid;

	public bool IsGroup => false;

	public string Name => _003CName_003Ek__BackingField;

	public bool Visible => true;

	public bool CanBeNullable
	{
		get
		{
			return _003CCanBeNullable_003Ek__BackingField;
		}
		set
		{
			_003CCanBeNullable_003Ek__BackingField = value;
		}
	}

	public bool? DefaultNullableValue
	{
		get
		{
			return _003CDefaultNullableValue_003Ek__BackingField;
		}
		set
		{
			_003CDefaultNullableValue_003Ek__BackingField = value;
		}
	}

	public System.Type SettingsType
	{
		get
		{
			return _003CSettingsType_003Ek__BackingField;
		}
		set
		{
			_003CSettingsType_003Ek__BackingField = value;
		}
	}

	public bool UseForEntity
	{
		get
		{
			return _003CUseForEntity_003Ek__BackingField;
		}
		set
		{
			_003CUseForEntity_003Ek__BackingField = value;
		}
	}

	public SubTypeDescriptor(ITypeDescriptor baseTypeDescriptor, Guid subTypeUid, string name)
		: this(baseTypeDescriptor, baseTypeDescriptor.Uid, subTypeUid, name)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Contract.ArgumentNotNull(baseTypeDescriptor, "baseTypeDescriptor");
	}

	public SubTypeDescriptor(ITypeDescriptor baseTypeDescriptor, Guid typeUid, Guid subTypeUid, string name)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		Contract.ArgumentNotNull(baseTypeDescriptor, "baseTypeDescriptor");
		this.baseTypeDescriptor = baseTypeDescriptor;
		_003CSubTypeUid_003Ek__BackingField = subTypeUid;
		_003CName_003Ek__BackingField = name;
		Uid = typeUid;
		SettingsType = baseTypeDescriptor.SettingsType;
		UseForEntity = baseTypeDescriptor.UseForEntity;
		CanBeNullable = baseTypeDescriptor.CanBeNullable;
		DefaultNullableValue = baseTypeDescriptor.DefaultNullableValue;
	}
}
