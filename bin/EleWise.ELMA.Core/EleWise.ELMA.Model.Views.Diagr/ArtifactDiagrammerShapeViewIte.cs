using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views.Diagrammer;

internal sealed class ArtifactDiagrammerShapeViewItem : BaseDiagrammerVertexShapeViewItem
{
	public static readonly Guid ContainerUid = Guid.Parse("F8EA6E22-0BDB-4DC2-B5D5-C2C8A776CF1C");

	public static readonly Guid ContextMenuUid = Guid.Parse("12F9B266-A9B7-428F-ACFC-58A4845E0BBA");

	private int _003CWidth_003Ek__BackingField;

	private int _003CHeight_003Ek__BackingField;

	private string _003CMainImage_003Ek__BackingField;

	private string _003CMainImageColor_003Ek__BackingField;

	private string _003CText_003Ek__BackingField;

	private ActionWithParam<string> _003COnTextChanged_003Ek__BackingField;

	private bool _003CEditState_003Ek__BackingField;

	private string _003CTag_003Ek__BackingField;

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

	[JsonIgnore]
	[DynamicProperty(false)]
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
	public string MainImage
	{
		get
		{
			return _003CMainImage_003Ek__BackingField;
		}
		set
		{
			_003CMainImage_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public string MainImageColor
	{
		get
		{
			return _003CMainImageColor_003Ek__BackingField;
		}
		set
		{
			_003CMainImageColor_003Ek__BackingField = value;
		}
	}

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
}
