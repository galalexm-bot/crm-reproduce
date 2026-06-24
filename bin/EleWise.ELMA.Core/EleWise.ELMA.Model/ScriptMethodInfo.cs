using System;
using EleWise.ELMA.Scripts.Models;

namespace EleWise.ELMA.Model;

public sealed class ScriptMethodInfo
{
	private string _003CName_003Ek__BackingField;

	private CodeType _003CCodeType_003Ek__BackingField;

	private Guid _003CMetadataUid_003Ek__BackingField;

	public string Name
	{
		get
		{
			return _003CName_003Ek__BackingField;
		}
		set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	public CodeType CodeType
	{
		get
		{
			return _003CCodeType_003Ek__BackingField;
		}
		set
		{
			_003CCodeType_003Ek__BackingField = value;
		}
	}

	public Guid MetadataUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CMetadataUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CMetadataUid_003Ek__BackingField = value;
		}
	}
}
