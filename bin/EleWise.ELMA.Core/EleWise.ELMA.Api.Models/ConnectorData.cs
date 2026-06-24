using Bridge;
using EleWise.ELMA.Api.Attributes;

namespace EleWise.ELMA.Api.Models;

[SimpleSerialize]
[ObjectLiteral]
internal sealed class ConnectorData
{
	private string _003CText_003Ek__BackingField;

	private string _003CClickCode_003Ek__BackingField;

	public string Text
	{
		get
		{
			return _003CText_003Ek__BackingField;
		}
		set
		{
			_003CText_003Ek__BackingField = value;
		}
	}

	public string ClickCode
	{
		get
		{
			return _003CClickCode_003Ek__BackingField;
		}
		set
		{
			_003CClickCode_003Ek__BackingField = value;
		}
	}
}
