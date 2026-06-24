using Bridge;

namespace EleWise.ELMA.Model.ViewModel;

[ObjectLiteral]
public sealed class DraggedObjectInfo
{
	private int _003CWidth_003Ek__BackingField;

	private int _003CHeight_003Ek__BackingField;

	private int _003COffsetX_003Ek__BackingField;

	private int _003COffsetY_003Ek__BackingField;

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

	[Name("offsetX")]
	public int OffsetX
	{
		get
		{
			return _003COffsetX_003Ek__BackingField;
		}
		set
		{
			_003COffsetX_003Ek__BackingField = value;
		}
	}

	[Name("offsetY")]
	public int OffsetY
	{
		get
		{
			return _003COffsetY_003Ek__BackingField;
		}
		set
		{
			_003COffsetY_003Ek__BackingField = value;
		}
	}
}
