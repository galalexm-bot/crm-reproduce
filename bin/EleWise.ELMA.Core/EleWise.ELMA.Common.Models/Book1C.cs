using System;
using Bridge;
using EleWise.ELMA.Api.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Common.Models;

[SimpleSerialize]
public sealed class Book1C
{
	private string _003CId_003Ek__BackingField;

	private string _003CName_003Ek__BackingField;

	private Guid _003CTypeUid_003Ek__BackingField;

	public string Id
	{
		get
		{
			return _003CId_003Ek__BackingField;
		}
		set
		{
			_003CId_003Ek__BackingField = value;
		}
	}

	[Name("$toString")]
	[JsonProperty("$toString")]
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

	public override string ToString()
	{
		return Name;
	}
}
