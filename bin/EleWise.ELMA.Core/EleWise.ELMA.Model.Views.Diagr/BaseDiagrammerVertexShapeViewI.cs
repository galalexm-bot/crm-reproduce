using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Diagrammer;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views.Diagrammer;

internal abstract class BaseDiagrammerVertexShapeViewItem : BaseDiagrammerShapeViewItem, IDiagrammerVertexViewItem, IDiagrammerShapeViewItem, IViewItem, IReactive
{
	private int _003CX_003Ek__BackingField;

	private int _003CY_003Ek__BackingField;

	private string _003CBackgroundColor_003Ek__BackingField;

	private string _003CBorderColor_003Ek__BackingField;

	private int _003CBorderWidth_003Ek__BackingField;

	private DiagrammerLineStyle _003CBorderStyle_003Ek__BackingField;

	[DynamicProperty(false)]
	[JsonIgnore]
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

	[DynamicProperty(false)]
	[JsonIgnore]
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

	[DynamicProperty(false)]
	[JsonIgnore]
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

	[JsonIgnore]
	[DynamicProperty(false)]
	public string BorderColor
	{
		get
		{
			return _003CBorderColor_003Ek__BackingField;
		}
		set
		{
			_003CBorderColor_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public int BorderWidth
	{
		get
		{
			return _003CBorderWidth_003Ek__BackingField;
		}
		set
		{
			_003CBorderWidth_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public DiagrammerLineStyle BorderStyle
	{
		get
		{
			return _003CBorderStyle_003Ek__BackingField;
		}
		set
		{
			_003CBorderStyle_003Ek__BackingField = value;
		}
	}
}
