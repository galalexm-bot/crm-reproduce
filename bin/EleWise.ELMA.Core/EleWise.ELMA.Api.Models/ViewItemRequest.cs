using System;
using Bridge;
using EleWise.ELMA.Api.Attributes;

namespace EleWise.ELMA.Api.Models;

[SimpleSerialize]
[ObjectLiteral]
public class ViewItemRequest
{
	private string _003CHtmlPrefix_003Ek__BackingField;

	private Guid _003CEntityTypeUid_003Ek__BackingField;

	private long _003CEntityId_003Ek__BackingField;

	private string[] _003CRegisteredZones_003Ek__BackingField = new string[0];

	public string HtmlPrefix
	{
		get
		{
			return _003CHtmlPrefix_003Ek__BackingField;
		}
		set
		{
			_003CHtmlPrefix_003Ek__BackingField = value;
		}
	}

	public Guid EntityTypeUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CEntityTypeUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CEntityTypeUid_003Ek__BackingField = value;
		}
	}

	public long EntityId
	{
		get
		{
			return _003CEntityId_003Ek__BackingField;
		}
		set
		{
			_003CEntityId_003Ek__BackingField = value;
		}
	}

	public string[] RegisteredZones
	{
		get
		{
			return _003CRegisteredZones_003Ek__BackingField;
		}
		set
		{
			_003CRegisteredZones_003Ek__BackingField = value;
		}
	}
}
