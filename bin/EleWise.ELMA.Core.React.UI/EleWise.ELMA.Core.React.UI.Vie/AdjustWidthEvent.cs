using Bridge;

namespace EleWise.ELMA.Core.React.UI.Views;

[ObjectLiteral]
public sealed class AdjustWidthEvent
{
	private string _003CMode_003Ek__BackingField;

	[Name("mode")]
	public string Mode
	{
		get
		{
			return _003CMode_003Ek__BackingField;
		}
		set
		{
			_003CMode_003Ek__BackingField = value;
		}
	}
}
