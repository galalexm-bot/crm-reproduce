using System;

namespace EleWise.ELMA.Api.Models;

public sealed class ClientExtensionPointModelDto
{
	private string _003CPointId_003Ek__BackingField;

	private Guid _003CTypeUid_003Ek__BackingField;

	private ClientImplementationModelDto[] _003CImplementations_003Ek__BackingField;

	public string PointId
	{
		get
		{
			return _003CPointId_003Ek__BackingField;
		}
		set
		{
			_003CPointId_003Ek__BackingField = value;
		}
	}

	public Guid TypeUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CTypeUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CTypeUid_003Ek__BackingField = value;
		}
	}

	public ClientImplementationModelDto[] Implementations
	{
		get
		{
			return _003CImplementations_003Ek__BackingField;
		}
		set
		{
			_003CImplementations_003Ek__BackingField = value;
		}
	}
}
