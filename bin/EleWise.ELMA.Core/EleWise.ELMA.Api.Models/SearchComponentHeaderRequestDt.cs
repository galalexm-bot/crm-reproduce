using System;

namespace EleWise.ELMA.Api.Models;

public sealed class SearchComponentHeaderRequestDto
{
	private Guid _003CDataClassUid_003Ek__BackingField;

	private int _003CViewType_003Ek__BackingField;

	private UIRuntimeModelDto _003CRuntimeModel_003Ek__BackingField;

	public Guid DataClassUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CDataClassUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CDataClassUid_003Ek__BackingField = value;
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

	public UIRuntimeModelDto RuntimeModel
	{
		get
		{
			return _003CRuntimeModel_003Ek__BackingField;
		}
		set
		{
			_003CRuntimeModel_003Ek__BackingField = value;
		}
	}
}
