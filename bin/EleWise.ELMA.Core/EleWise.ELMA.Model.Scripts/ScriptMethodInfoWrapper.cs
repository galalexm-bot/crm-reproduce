using System;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Scripts.Models;

namespace EleWise.ELMA.Model.Scripts;

public sealed class ScriptMethodInfoWrapper
{
	private readonly string _003CName_003Ek__BackingField;

	private readonly string _003CDisplayName_003Ek__BackingField;

	private readonly CodeType _003CCodeType_003Ek__BackingField;

	private readonly Guid _003CMetadataUid_003Ek__BackingField;

	public string Name => _003CName_003Ek__BackingField;

	public string DisplayName => _003CDisplayName_003Ek__BackingField;

	public CodeType CodeType => _003CCodeType_003Ek__BackingField;

	public Guid MetadataUid => _003CMetadataUid_003Ek__BackingField;

	public ScriptMethodInfoWrapper(ScriptMethodInfo methodInfo)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		_003CName_003Ek__BackingField = methodInfo.Name;
		_003CDisplayName_003Ek__BackingField = methodInfo.Name;
		_003CCodeType_003Ek__BackingField = methodInfo.CodeType;
		_003CMetadataUid_003Ek__BackingField = methodInfo.MetadataUid;
	}

	public ScriptMethodInfoWrapper(string name, CodeType codeType, Guid metadataUid)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CName_003Ek__BackingField = ScriptMethodInfoHelper.NormalizeMethodName(name);
		_003CDisplayName_003Ek__BackingField = name;
		_003CCodeType_003Ek__BackingField = codeType;
		_003CMetadataUid_003Ek__BackingField = metadataUid;
	}

	public ScriptMethodInfoWrapper(string name, string displayName, CodeType codeType, Guid metadataUid)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		_003CName_003Ek__BackingField = ScriptMethodInfoHelper.NormalizeMethodName(name);
		_003CDisplayName_003Ek__BackingField = displayName;
		_003CCodeType_003Ek__BackingField = codeType;
		_003CMetadataUid_003Ek__BackingField = metadataUid;
	}
}
