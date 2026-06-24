using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[ObjectLiteral]
public sealed class OptionData
{
	private string _003CValue_003Ek__BackingField;

	private Union<ReactElement, string> _003CLabel_003Ek__BackingField;

	private bool _003CDisabled_003Ek__BackingField;

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

	[Name("label")]
	public Union<ReactElement, string> Label
	{
		get
		{
			return _003CLabel_003Ek__BackingField;
		}
		set
		{
			_003CLabel_003Ek__BackingField = value;
		}
	}

	[Name("disabled")]
	public bool Disabled
	{
		get
		{
			return _003CDisabled_003Ek__BackingField;
		}
		set
		{
			_003CDisabled_003Ek__BackingField = value;
		}
	}
}
