using System.Collections.Generic;

namespace EleWise.ELMA.Api.Models;

internal sealed class ServiceReferenceInfoDto
{
	private string _003CName_003Ek__BackingField;

	private System.Collections.Generic.ICollection<string> _003CMethodNames_003Ek__BackingField;

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

	public System.Collections.Generic.ICollection<string> MethodNames
	{
		get
		{
			return _003CMethodNames_003Ek__BackingField;
		}
		set
		{
			_003CMethodNames_003Ek__BackingField = value;
		}
	}
}
