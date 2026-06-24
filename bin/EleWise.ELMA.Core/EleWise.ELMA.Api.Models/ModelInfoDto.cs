using System;

namespace EleWise.ELMA.Api.Models;

public sealed class ModelInfoDto
{
	private Guid _003CTypeUid_003Ek__BackingField;

	private Guid _003CSubTypeUid_003Ek__BackingField;

	private Guid _003CFormUid_003Ek__BackingField;

	private int _003CViewType_003Ek__BackingField;

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

	public Guid SubTypeUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CSubTypeUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CSubTypeUid_003Ek__BackingField = value;
		}
	}

	public Guid FormUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CFormUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CFormUid_003Ek__BackingField = value;
		}
	}

	public int ViewType
	{
		get
		{
			return _003CViewType_003Ek__BackingField;
		}
		set
		{
			_003CViewType_003Ek__BackingField = value;
		}
	}
}
