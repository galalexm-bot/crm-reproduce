using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class DndPreviewViewItem : RootViewItem
{
	private int _003CType_003Ek__BackingField;

	private int _003CWidth_003Ek__BackingField;

	private int _003CHeight_003Ek__BackingField;

	private string _003CBackgroundColor_003Ek__BackingField;

	private string _003CStrokeColor_003Ek__BackingField;

	[JsonIgnore]
	[DynamicProperty(false)]
	public int Type
	{
		get
		{
			return _003CType_003Ek__BackingField;
		}
		set
		{
			_003CType_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
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

	[DynamicProperty(false)]
	[JsonIgnore]
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

	[JsonIgnore]
	[DynamicProperty(false)]
	public string BackgroundColor
	{
		get
		{
			return _003CBackgroundColor_003Ek__BackingField;
		}
		set
		{
			_003CBackgroundColor_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public string StrokeColor
	{
		get
		{
			return _003CStrokeColor_003Ek__BackingField;
		}
		set
		{
			_003CStrokeColor_003Ek__BackingField = value;
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		if (parentViewItem is SlotViewItem && parentViewItem.Parent != null)
		{
			return parentViewItem.Parent is DndViewItem;
		}
		return false;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}
}
