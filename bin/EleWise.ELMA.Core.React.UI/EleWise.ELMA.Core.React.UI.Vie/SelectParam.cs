using Bridge;

namespace EleWise.ELMA.Core.React.UI.Views;

[ObjectLiteral]
public sealed class SelectParam : ClickParam
{
	private string[] _003CSelectedKeys_003Ek__BackingField;

	[Name("selectedKeys")]
	public string[] SelectedKeys
	{
		get
		{
			return _003CSelectedKeys_003Ek__BackingField;
		}
		set
		{
			_003CSelectedKeys_003Ek__BackingField = value;
		}
	}
}
