using Bridge;
using EleWise.ELMA.Api.Attributes;

namespace EleWise.ELMA.Api.Models;

[ObjectLiteral]
[SimpleSerialize]
public class CustomViewItemContentRequest : ViewItemRequest
{
	private string _003CViewItem_003Ek__BackingField;

	public string ViewItem
	{
		get
		{
			return _003CViewItem_003Ek__BackingField;
		}
		set
		{
			_003CViewItem_003Ek__BackingField = value;
		}
	}
}
