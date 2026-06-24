using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Diagrammer;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views.Diagrammer;

internal sealed class SwimlaneDiagrammerShapeViewItem : BaseDiagrammerVertexShapeViewItem
{
	public static readonly Guid ContainerUid = Guid.Parse("B9C86531-214A-417B-991F-EB993F8F1B07");

	public static readonly Guid BottomControlSlotUid = Guid.Parse("99970BFB-3A05-44E3-AD7D-AB7EBC86AFAD");

	public static readonly Guid RightControlSlotUid = Guid.Parse("19FDA142-FF8E-4EE8-843A-8413DC0C7881");

	public static readonly Guid ContextMenuUid = Guid.Parse("5901C686-7510-4EB7-BB22-123A9936B58B");

	private string _003CText_003Ek__BackingField;

	private int _003CWidth_003Ek__BackingField;

	private int _003CHeight_003Ek__BackingField;

	private DiagrammerLaneDirection _003CDirection_003Ek__BackingField;

	private ActionWithParam<string> _003COnTextChanged_003Ek__BackingField;

	private double _003CScaleFactor_003Ek__BackingField;

	private bool _003CEditState_003Ek__BackingField;

	[JsonIgnore]
	[DynamicProperty(false)]
	public string Text
	{
		get
		{
			return _003CText_003Ek__BackingField;
		}
		set
		{
			_003CText_003Ek__BackingField = value;
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
	public DiagrammerLaneDirection Direction
	{
		get
		{
			return _003CDirection_003Ek__BackingField;
		}
		set
		{
			_003CDirection_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public ActionWithParam<string> OnTextChanged
	{
		get
		{
			return _003COnTextChanged_003Ek__BackingField;
		}
		set
		{
			_003COnTextChanged_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public double ScaleFactor
	{
		get
		{
			return _003CScaleFactor_003Ek__BackingField;
		}
		set
		{
			_003CScaleFactor_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public bool EditState
	{
		get
		{
			return _003CEditState_003Ek__BackingField;
		}
		set
		{
			_003CEditState_003Ek__BackingField = value;
		}
	}
}
