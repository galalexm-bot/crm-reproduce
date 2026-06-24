using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Diagrammer;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views.Diagrammer;

internal sealed class TransitionDiagrammerShapeViewItem : BaseDiagrammerShapeViewItem, IDiagrammerTransitionViewItem, IDiagrammerShapeViewItem, IViewItem, IReactive
{
	public static readonly Guid ContainerUid = Guid.Parse("DC933E8D-FB98-434B-B617-E62206162635");

	private Guid _003CSource_003Ek__BackingField;

	private double _003CSourceX_003Ek__BackingField;

	private double _003CSourceY_003Ek__BackingField;

	private Guid _003CTarget_003Ek__BackingField;

	private double _003CTargetX_003Ek__BackingField;

	private double _003CTargetY_003Ek__BackingField;

	private string _003CText_003Ek__BackingField;

	private System.Collections.Generic.ICollection<DiagrammerPoint> _003CPath_003Ek__BackingField;

	private string _003CStartMarker_003Ek__BackingField;

	private bool _003CDefault_003Ek__BackingField;

	private int _003CStrokeWidth_003Ek__BackingField;

	private string _003CStrokeColor_003Ek__BackingField;

	private DiagrammerLineStyle _003CLineStyle_003Ek__BackingField;

	private bool _003CDisablePath_003Ek__BackingField;

	private bool _003CHideArrow_003Ek__BackingField;

	[DynamicProperty(false)]
	[JsonIgnore]
	public Guid Source
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CSource_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CSource_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public double SourceX
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

	[DynamicProperty(false)]
	[JsonIgnore]
	public double SourceY
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

	[DynamicProperty(false)]
	[JsonIgnore]
	public Guid Target
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CTarget_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CTarget_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public double TargetX
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

	[DynamicProperty(false)]
	[JsonIgnore]
	public double TargetY
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

	[JsonIgnore]
	[DynamicProperty(false)]
	public System.Collections.Generic.ICollection<DiagrammerPoint> Path
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

	[JsonIgnore]
	[DynamicProperty(false)]
	public string StartMarker
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

	[JsonIgnore]
	[DynamicProperty(false)]
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

	[DynamicProperty(false)]
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

	[DynamicProperty(false)]
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

	[DynamicProperty(false)]
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

	[DynamicProperty(false)]
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

	[DynamicProperty(false)]
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
