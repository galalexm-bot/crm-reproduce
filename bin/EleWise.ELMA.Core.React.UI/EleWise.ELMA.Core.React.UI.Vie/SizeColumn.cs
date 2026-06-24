using Bridge;

namespace EleWise.ELMA.Core.React.UI.Views;

[ObjectLiteral]
public sealed class SizeColumn
{
	private Union<int, string> _003CWidth_003Ek__BackingField;

	private Union<int, string> _003CHeight_003Ek__BackingField;

	[Name("width")]
	public Union<int, string> Width
	{
		get
		{
			return _003CWidth_003Ek__BackingField;
		}
		set
		{
			_003CWidth_003Ek__BackingField = value;
		}
	}

	[Name("height")]
	public Union<int, string> Height
	{
		get
		{
			return _003CHeight_003Ek__BackingField;
		}
		set
		{
			_003CHeight_003Ek__BackingField = value;
		}
	}
}
