using System.Collections.Generic;
using Bridge;
using EleWise.ELMA.Api.Attributes;

namespace EleWise.ELMA.Api.Models;

[ObjectLiteral]
[SimpleSerialize]
public sealed class GetHtmlStringContentRequest
{
	private string _003CHtmlValue_003Ek__BackingField;

	private List<string> _003CRegisteredZones_003Ek__BackingField = new List<string>();

	public string HtmlValue
	{
		get
		{
			return _003CHtmlValue_003Ek__BackingField;
		}
		set
		{
			_003CHtmlValue_003Ek__BackingField = value;
		}
	}

	public List<string> RegisteredZones
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
