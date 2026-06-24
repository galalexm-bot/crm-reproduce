using System;
using Bridge;
using EleWise.ELMA.Api.Attributes;

namespace EleWise.ELMA.Api.Models;

[SimpleSerialize]
public class StructuredFileResponse
{
	private bool _003CSuccess_003Ek__BackingField;

	private Guid _003CUid_003Ek__BackingField;

	private string _003CError_003Ek__BackingField;

	[Name("success")]
	public bool Success
	{
		get
		{
			return _003CSuccess_003Ek__BackingField;
		}
		set
		{
			_003CSuccess_003Ek__BackingField = value;
		}
	}

	[Name("uid")]
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

	[Name("error")]
	public string Error
	{
		get
		{
			return _003CError_003Ek__BackingField;
		}
		set
		{
			_003CError_003Ek__BackingField = value;
		}
	}
}
