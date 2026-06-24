using Bridge;

namespace EleWise.ELMA.Model.ViewModel;

[ObjectLiteral]
public sealed class DroppedObjectInfo
{
	private int _003CWidth_003Ek__BackingField;

	private int _003CHeight_003Ek__BackingField;

	private int _003CX_003Ek__BackingField;

	private int _003CY_003Ek__BackingField;

	[Name("width")]
	public int Width
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
	public int Height
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

	[Name("x")]
	public int X
	{
		get
		{
			return _003CX_003Ek__BackingField;
		}
		set
		{
			_003CX_003Ek__BackingField = value;
		}
	}

	[Name("y")]
	public int Y
	{
		get
		{
			return _003CY_003Ek__BackingField;
		}
		set
		{
			_003CY_003Ek__BackingField = value;
		}
	}
}
