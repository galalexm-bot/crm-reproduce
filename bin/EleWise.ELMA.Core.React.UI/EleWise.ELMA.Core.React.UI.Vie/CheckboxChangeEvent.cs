using Bridge;
using Bridge.Html5;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

public class CheckboxChangeEvent : SyntheticEvent<HTMLInputElement>
{
	private CheckboxChangeEventTarget _003CTarget_003Ek__BackingField;

	[Name("target")]
	public CheckboxChangeEventTarget Target
	{
		get
		{
			return _003CTarget_003Ek__BackingField;
		}
		set
		{
			_003CTarget_003Ek__BackingField = value;
		}
	}
}
