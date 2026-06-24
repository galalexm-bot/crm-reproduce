using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views.Diagrammer;

internal sealed class RectangleDiagrammerShapeViewItem : BaseDiagrammerVertexShapeViewItem
{
	public static readonly Guid ContainerUid = Guid.Parse("d7b1dc68-4177-4670-aac0-09e0df7ddd1a");

	public static readonly Guid ContextMenuUid = Guid.Parse("49016798-B37E-4E4C-ABF9-2CC4D3510413");

	private int _003CWidth_003Ek__BackingField;

	private int _003CHeight_003Ek__BackingField;

	private string _003CTopLeftImage_003Ek__BackingField;

	private string[] _003CBottomMiddleImage_003Ek__BackingField;

	private string _003CBottomIconColor_003Ek__BackingField;

	private string _003CTopIconColor_003Ek__BackingField;

	private string _003CText_003Ek__BackingField;

	private string _003CTag_003Ek__BackingField;

	private Guid _003CParentElement_003Ek__BackingField;

	private ActionWithParam<string> _003COnTextChanged_003Ek__BackingField;

	private bool _003CEditState_003Ek__BackingField;

	private bool _003CHasPopoverContent_003Ek__BackingField;

	[JsonIgnore]
	[DynamicProperty(false)]
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

	[DynamicProperty(false)]
	[JsonIgnore]
	public string TopLeftImage
	{
		get
		{
			return _003CTopLeftImage_003Ek__BackingField;
		}
		set
		{
			_003CTopLeftImage_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public string[] BottomMiddleImage
	{
		get
		{
			return _003CBottomMiddleImage_003Ek__BackingField;
		}
		set
		{
			_003CBottomMiddleImage_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public string BottomIconColor
	{
		get
		{
			return _003CBottomIconColor_003Ek__BackingField;
		}
		set
		{
			_003CBottomIconColor_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public string TopIconColor
	{
		get
		{
			return _003CTopIconColor_003Ek__BackingField;
		}
		set
		{
			_003CTopIconColor_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
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

	[JsonIgnore]
	[DynamicProperty(false)]
	public string Tag
	{
		get
		{
			return _003CTag_003Ek__BackingField;
		}
		set
		{
			_003CTag_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public Guid ParentElement
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CParentElement_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CParentElement_003Ek__BackingField = value;
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

	[DynamicProperty(false)]
	[JsonIgnore]
	public bool HasPopoverContent
	{
		get
		{
			return _003CHasPopoverContent_003Ek__BackingField;
		}
		set
		{
			_003CHasPopoverContent_003Ek__BackingField = value;
		}
	}
}
