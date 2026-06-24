using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views.Diagrammer;

internal sealed class GroupDiagrammerShapeViewItem : BaseDiagrammerVertexShapeViewItem
{
	public static readonly Guid ContainerUid = new Guid("{0D4D7B10-7A64-45C5-A928-C37688360C61}");

	public static readonly Guid ContextMenuUid = new Guid("{5FA023A2-6E0F-4409-8DA0-B39B07EAF890}");

	private string _003CText_003Ek__BackingField;

	private int _003CWidth_003Ek__BackingField;

	private int _003CHeight_003Ek__BackingField;

	private ActionWithParam<string> _003COnTextChanged_003Ek__BackingField;

	private bool _003CEditState_003Ek__BackingField;

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

	[DynamicProperty(false)]
	[JsonIgnore]
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
