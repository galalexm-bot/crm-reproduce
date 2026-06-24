using System;

namespace EleWise.ELMA.Api.Models;

internal sealed class FormViewItemHeaderDto
{
	private Guid _003CUid_003Ek__BackingField;

	private string _003CDisplayName_003Ek__BackingField;

	private int _003CRuntimeVersion_003Ek__BackingField;

	private Guid _003CGroupUid_003Ek__BackingField;

	private Guid _003CTargetUid_003Ek__BackingField;

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

	public string DisplayName
	{
		get
		{
			return _003CDisplayName_003Ek__BackingField;
		}
		set
		{
			_003CDisplayName_003Ek__BackingField = value;
		}
	}

	public int RuntimeVersion
	{
		get
		{
			return _003CRuntimeVersion_003Ek__BackingField;
		}
		set
		{
			_003CRuntimeVersion_003Ek__BackingField = value;
		}
	}

	public Guid GroupUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CGroupUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CGroupUid_003Ek__BackingField = value;
		}
	}

	public Guid TargetUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CTargetUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CTargetUid_003Ek__BackingField = value;
		}
	}
}
