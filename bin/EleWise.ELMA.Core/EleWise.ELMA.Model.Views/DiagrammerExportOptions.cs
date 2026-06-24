using System.Collections.Generic;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

public class DiagrammerExportOptions : Reactive
{
	private bool _003CEnabled_003Ek__BackingField;

	private int? _003CDefaultPageHeight_003Ek__BackingField;

	private int? _003CDefaultPageWidth_003Ek__BackingField;

	private int? _003CTotalHeight_003Ek__BackingField;

	private int? _003CTotalWidth_003Ek__BackingField;

	private bool _003CPageSplitting_003Ek__BackingField;

	private System.Collections.Generic.ICollection<int> _003CPageSplittingListX_003Ek__BackingField;

	private System.Collections.Generic.ICollection<int> _003CPageSplittingListY_003Ek__BackingField;

	private bool _003CShowPageNumber_003Ek__BackingField;

	private bool _003CLandscapeOrientation_003Ek__BackingField;

	private ActionWithParam<DiagrammerOnExportResult> _003COnExport_003Ek__BackingField;

	private ActionWithParam<DiagrammerOnPageResizeResult> _003COnPageResize_003Ek__BackingField;

	private bool _003CStartExport_003Ek__BackingField;

	[DynamicProperty(false)]
	public bool Enabled
	{
		get
		{
			return _003CEnabled_003Ek__BackingField;
		}
		set
		{
			_003CEnabled_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public int? DefaultPageHeight
	{
		get
		{
			return _003CDefaultPageHeight_003Ek__BackingField;
		}
		set
		{
			_003CDefaultPageHeight_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public int? DefaultPageWidth
	{
		get
		{
			return _003CDefaultPageWidth_003Ek__BackingField;
		}
		set
		{
			_003CDefaultPageWidth_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public int? TotalHeight
	{
		get
		{
			return _003CTotalHeight_003Ek__BackingField;
		}
		set
		{
			_003CTotalHeight_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public int? TotalWidth
	{
		get
		{
			return _003CTotalWidth_003Ek__BackingField;
		}
		set
		{
			_003CTotalWidth_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool PageSplitting
	{
		get
		{
			return _003CPageSplitting_003Ek__BackingField;
		}
		set
		{
			_003CPageSplitting_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public System.Collections.Generic.ICollection<int> PageSplittingListX
	{
		get
		{
			return _003CPageSplittingListX_003Ek__BackingField;
		}
		set
		{
			_003CPageSplittingListX_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public System.Collections.Generic.ICollection<int> PageSplittingListY
	{
		get
		{
			return _003CPageSplittingListY_003Ek__BackingField;
		}
		set
		{
			_003CPageSplittingListY_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool ShowPageNumber
	{
		get
		{
			return _003CShowPageNumber_003Ek__BackingField;
		}
		set
		{
			_003CShowPageNumber_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool LandscapeOrientation
	{
		get
		{
			return _003CLandscapeOrientation_003Ek__BackingField;
		}
		set
		{
			_003CLandscapeOrientation_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public ActionWithParam<DiagrammerOnExportResult> OnExport
	{
		get
		{
			return _003COnExport_003Ek__BackingField;
		}
		set
		{
			_003COnExport_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public ActionWithParam<DiagrammerOnPageResizeResult> OnPageResize
	{
		get
		{
			return _003COnPageResize_003Ek__BackingField;
		}
		set
		{
			_003COnPageResize_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool StartExport
	{
		get
		{
			return _003CStartExport_003Ek__BackingField;
		}
		set
		{
			_003CStartExport_003Ek__BackingField = value;
		}
	}
}
