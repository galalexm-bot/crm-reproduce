using Bridge;
using EleWise.ELMA.Api.Attributes;

namespace EleWise.ELMA.Api.Models;

[ObjectLiteral]
[SimpleSerialize]
public sealed class HtmlWrapper
{
	private string _003CHtml_003Ek__BackingField;

	public string Html
	{
		get
		{
			return _003CHtml_003Ek__BackingField;
		}
		set
		{
			_003CHtml_003Ek__BackingField = value;
		}
	}
}
