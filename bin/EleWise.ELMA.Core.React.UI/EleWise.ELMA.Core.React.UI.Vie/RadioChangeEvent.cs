using Bridge;
using Bridge.Html5;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

public class RadioChangeEvent : SyntheticEvent<HTMLInputElement>
{
	private RadioChangeEventTarget _003CTarget_003Ek__BackingField;

	[Name("target")]
	public RadioChangeEventTarget Target
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
