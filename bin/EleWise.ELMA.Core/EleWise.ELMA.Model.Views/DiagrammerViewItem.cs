using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Diagrammer;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class DiagrammerViewItem : RootViewItem
{
	public static Guid SettingsContainerUid = new Guid("A8244219-546D-411E-A3BB-A093B756BF16");

	private ActionWithParam<IDiagrammerModel> _003COnModelChange_003Ek__BackingField;

	private ActionWithParam<IDiagrammerChangeEvent[]> _003COnChangeEvents_003Ek__BackingField;

	private bool _003CReadOnlyDiagram_003Ek__BackingField;

	private bool _003CDisplayFullscreen_003Ek__BackingField;

	private bool _003CFullscreen_003Ek__BackingField;

	private DefaultAction _003CFullscreenClicked_003Ek__BackingField;

	private bool _003CDisplayGrid_003Ek__BackingField;

	private ActionWithParam<Guid[]> _003CElementSelectionChanged_003Ek__BackingField;

	private ActionWithParamResult<IDiagrammerChangeEvent, bool> _003CElementCanBeDroppedValidator_003Ek__BackingField;

	private double _003CScaleFactor_003Ek__BackingField;

	private ActionWithParam<double> _003CScaleChangedAction_003Ek__BackingField;

	private DiagrammerExportOptions _003CExportOptions_003Ek__BackingField;

	[DynamicProperty(false)]
	[JsonIgnore]
	public ActionWithParam<IDiagrammerModel> OnModelChange
	{
		get
		{
			return _003COnModelChange_003Ek__BackingField;
		}
		set
		{
			_003COnModelChange_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public ActionWithParam<IDiagrammerChangeEvent[]> OnChangeEvents
	{
		get
		{
			return _003COnChangeEvents_003Ek__BackingField;
		}
		set
		{
			_003COnChangeEvents_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public bool ReadOnlyDiagram
	{
		get
		{
			return _003CReadOnlyDiagram_003Ek__BackingField;
		}
		set
		{
			_003CReadOnlyDiagram_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool DisplayFullscreen
	{
		get
		{
			return _003CDisplayFullscreen_003Ek__BackingField;
		}
		set
		{
			_003CDisplayFullscreen_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool Fullscreen
	{
		get
		{
			return _003CFullscreen_003Ek__BackingField;
		}
		set
		{
			_003CFullscreen_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public DefaultAction FullscreenClicked
	{
		get
		{
			return _003CFullscreenClicked_003Ek__BackingField;
		}
		set
		{
			_003CFullscreenClicked_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool DisplayGrid
	{
		get
		{
			return _003CDisplayGrid_003Ek__BackingField;
		}
		set
		{
			_003CDisplayGrid_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public ActionWithParam<Guid[]> ElementSelectionChanged
	{
		get
		{
			return _003CElementSelectionChanged_003Ek__BackingField;
		}
		set
		{
			_003CElementSelectionChanged_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public ActionWithParamResult<IDiagrammerChangeEvent, bool> ElementCanBeDroppedValidator
	{
		get
		{
			return _003CElementCanBeDroppedValidator_003Ek__BackingField;
		}
		set
		{
			_003CElementCanBeDroppedValidator_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
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
	public ActionWithParam<double> ScaleChangedAction
	{
		get
		{
			return _003CScaleChangedAction_003Ek__BackingField;
		}
		set
		{
			_003CScaleChangedAction_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicPropertyContainer]
	public DiagrammerExportOptions ExportOptions
	{
		get
		{
			return _003CExportOptions_003Ek__BackingField;
		}
		set
		{
			_003CExportOptions_003Ek__BackingField = value;
		}
	}

	public DiagrammerViewItem()
	{
		DiagrammerExportOptions diagrammerExportOptions2 = (ExportOptions = new DiagrammerExportOptions());
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
