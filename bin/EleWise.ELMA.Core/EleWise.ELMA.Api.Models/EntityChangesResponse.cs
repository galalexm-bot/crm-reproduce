using System;
using EleWise.ELMA.Api.Attributes;

namespace EleWise.ELMA.Api.Models;

[SimpleSerialize]
internal class EntityChangesResponse
{
	private Guid _003CTypeUid_003Ek__BackingField;

	private string _003CEQL_003Ek__BackingField;

	private System.DateTime _003CFromDate_003Ek__BackingField;

	private System.DateTime _003CNow_003Ek__BackingField;

	private long[] _003CDeleted_003Ek__BackingField;

	private long[] _003CUpdated_003Ek__BackingField;

	private Guid _003CId_003Ek__BackingField;

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

	public string EQL
	{
		get
		{
			return _003CEQL_003Ek__BackingField;
		}
		set
		{
			_003CEQL_003Ek__BackingField = value;
		}
	}

	public System.DateTime FromDate
	{
		get
		{
			return _003CFromDate_003Ek__BackingField;
		}
		set
		{
			_003CFromDate_003Ek__BackingField = value;
		}
	}

	public System.DateTime Now
	{
		get
		{
			return _003CNow_003Ek__BackingField;
		}
		set
		{
			_003CNow_003Ek__BackingField = value;
		}
	}

	public long[] Deleted
	{
		get
		{
			return _003CDeleted_003Ek__BackingField;
		}
		set
		{
			_003CDeleted_003Ek__BackingField = value;
		}
	}

	public long[] Updated
	{
		get
		{
			return _003CUpdated_003Ek__BackingField;
		}
		set
		{
			_003CUpdated_003Ek__BackingField = value;
		}
	}

	public Guid Id
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CId_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CId_003Ek__BackingField = value;
		}
	}
}
