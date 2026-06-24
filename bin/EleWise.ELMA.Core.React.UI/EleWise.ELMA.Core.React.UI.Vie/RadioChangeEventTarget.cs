using Bridge;

namespace EleWise.ELMA.Core.React.UI.Views;

[ObjectLiteral]
public class RadioChangeEventTarget
{
	private bool _003CChecked_003Ek__BackingField;

	private string _003CValue_003Ek__BackingField;

	[Name("checked")]
	public bool Checked
	{
		get
		{
			return _003CChecked_003Ek__BackingField;
		}
		set
		{
			_003CChecked_003Ek__BackingField = value;
		}
	}

	[Name("value")]
	public string Value
	{
		get
		{
			return _003CValue_003Ek__BackingField;
		}
		set
		{
			_003CValue_003Ek__BackingField = value;
		}
	}
}
