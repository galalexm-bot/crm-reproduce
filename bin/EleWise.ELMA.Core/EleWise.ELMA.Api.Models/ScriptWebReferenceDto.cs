using System.Collections.Generic;

namespace EleWise.ELMA.Api.Models;

internal sealed class ScriptWebReferenceDto
{
	private string _003CName_003Ek__BackingField;

	private string _003CNamespace_003Ek__BackingField;

	private System.Collections.Generic.ICollection<ScriptProjectItemDto> _003CItems_003Ek__BackingField;

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

	public string Namespace
	{
		get
		{
			return _003CNamespace_003Ek__BackingField;
		}
		set
		{
			_003CNamespace_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.ICollection<ScriptProjectItemDto> Items
	{
		get
		{
			return _003CItems_003Ek__BackingField;
		}
		set
		{
			_003CItems_003Ek__BackingField = value;
		}
	}
}
