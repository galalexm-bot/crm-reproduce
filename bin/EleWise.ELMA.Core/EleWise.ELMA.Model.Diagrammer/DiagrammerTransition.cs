using Bridge.Html5;

namespace EleWise.ELMA.Model.Diagrammer;

public sealed class DiagrammerTransition : DiagrammerElement<DiagrammerTransition>, IDiagrammerTransition, IDiagrammerElement, ICloneableObjectLiteral
{
	private string _003CSource_003Ek__BackingField;

	private string _003CTarget_003Ek__BackingField;

	private double? _003CSourceX_003Ek__BackingField;

	private double? _003CSourceY_003Ek__BackingField;

	private double? _003CTargetX_003Ek__BackingField;

	private double? _003CTargetY_003Ek__BackingField;

	private DiagrammerPoint[] _003CPath_003Ek__BackingField;

	private HTMLElement _003CStartMarker_003Ek__BackingField;

	private string _003CStartMarkerId_003Ek__BackingField;

	private bool _003CDefault_003Ek__BackingField;

	private int _003CStrokeWidth_003Ek__BackingField;

	private string _003CStrokeColor_003Ek__BackingField;

	private DiagrammerLineStyle _003CLineStyle_003Ek__BackingField;

	private bool _003CDisablePath_003Ek__BackingField;

	private bool _003CHideArrow_003Ek__BackingField;

	public string Source
	{
		get
		{
			return _003CSource_003Ek__BackingField;
		}
		set
		{
			_003CSource_003Ek__BackingField = value;
		}
	}

	public string Target
	{
		get
		{
			return _003CTarget_003Ek__BackingField;
		}
		set
		{
			_003CTarget_003Ek__BackingField = value;
		}
	}

	public double? SourceX
	{
		get
		{
			return _003CSourceX_003Ek__BackingField;
		}
		set
		{
			_003CSourceX_003Ek__BackingField = value;
		}
	}

	public double? SourceY
	{
		get
		{
			return _003CSourceY_003Ek__BackingField;
		}
		set
		{
			_003CSourceY_003Ek__BackingField = value;
		}
	}

	public double? TargetX
	{
		get
		{
			return _003CTargetX_003Ek__BackingField;
		}
		set
		{
			_003CTargetX_003Ek__BackingField = value;
		}
	}

	public double? TargetY
	{
		get
		{
			return _003CTargetY_003Ek__BackingField;
		}
		set
		{
			_003CTargetY_003Ek__BackingField = value;
		}
	}

	public DiagrammerPoint[] Path
	{
		get
		{
			return _003CPath_003Ek__BackingField;
		}
		set
		{
			_003CPath_003Ek__BackingField = value;
		}
	}

	public override DiagrammerElementKind Kind => DiagrammerElementKind.Transition;

	public HTMLElement StartMarker
	{
		get
		{
			return _003CStartMarker_003Ek__BackingField;
		}
		set
		{
			_003CStartMarker_003Ek__BackingField = value;
		}
	}

	public string StartMarkerId
	{
		get
		{
			return _003CStartMarkerId_003Ek__BackingField;
		}
		set
		{
			_003CStartMarkerId_003Ek__BackingField = value;
		}
	}

	public bool Default
	{
		get
		{
			return _003CDefault_003Ek__BackingField;
		}
		set
		{
			_003CDefault_003Ek__BackingField = value;
		}
	}

	public int StrokeWidth
	{
		get
		{
			return _003CStrokeWidth_003Ek__BackingField;
		}
		set
		{
			_003CStrokeWidth_003Ek__BackingField = value;
		}
	}

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

	public DiagrammerLineStyle LineStyle
	{
		get
		{
			return _003CLineStyle_003Ek__BackingField;
		}
		set
		{
			_003CLineStyle_003Ek__BackingField = value;
		}
	}

	public bool DisablePath
	{
		get
		{
			return _003CDisablePath_003Ek__BackingField;
		}
		set
		{
			_003CDisablePath_003Ek__BackingField = value;
		}
	}

	public bool HideArrow
	{
		get
		{
			return _003CHideArrow_003Ek__BackingField;
		}
		set
		{
			_003CHideArrow_003Ek__BackingField = value;
		}
	}
}
