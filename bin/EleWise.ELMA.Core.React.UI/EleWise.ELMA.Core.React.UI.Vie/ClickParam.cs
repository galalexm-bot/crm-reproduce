using Bridge;

namespace EleWise.ELMA.Core.React.UI.Views;

[ObjectLiteral]
public class ClickParam
{
	private string _003CMenuKey_003Ek__BackingField;

	private string[] _003CKeyPath_003Ek__BackingField;

	[Name("key")]
	public string MenuKey
	{
		get
		{
			return _003CMenuKey_003Ek__BackingField;
		}
		set
		{
			_003CMenuKey_003Ek__BackingField = value;
		}
	}

	[Name("keyPath")]
	public string[] KeyPath
	{
		get
		{
			return _003CKeyPath_003Ek__BackingField;
		}
		set
		{
			_003CKeyPath_003Ek__BackingField = value;
		}
	}
}
