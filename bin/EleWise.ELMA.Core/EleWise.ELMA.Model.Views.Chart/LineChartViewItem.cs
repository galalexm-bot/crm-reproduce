using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views.Charts;

internal sealed class LineChartViewItem : ChartViewItem
{
	[Component]
	private class ToolboxItem : ChartViewItemToolboxItem<LineChartViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("{634FA12C-D263-4A70-B766-630D8C08BB8E}");

		public override string Name => SR.T("Линейная диаграмма");

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public override string Icon => "general-indicator";

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}
	}

	private Guid _003CLinePropertyUid_003Ek__BackingField;

	private Guid _003CLabelUid_003Ek__BackingField;

	private double? _003CMaxDomain_003Ek__BackingField;

	private double? _003CMinDomain_003Ek__BackingField;

	private ViewItemLineChartViewType _003CViewType_003Ek__BackingField;

	private bool _003CZoom_003Ek__BackingField;

	private bool _003CAnimate_003Ek__BackingField;

	private string _003CUnitMeasure_003Ek__BackingField;

	public Guid LinePropertyUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CLinePropertyUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CLinePropertyUid_003Ek__BackingField = value;
		}
	}

	public Guid LabelUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CLabelUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CLabelUid_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public double? MaxDomain
	{
		get
		{
			return _003CMaxDomain_003Ek__BackingField;
		}
		set
		{
			_003CMaxDomain_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public double? MinDomain
	{
		get
		{
			return _003CMinDomain_003Ek__BackingField;
		}
		set
		{
			_003CMinDomain_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public ViewItemLineChartViewType ViewType
	{
		get
		{
			return _003CViewType_003Ek__BackingField;
		}
		set
		{
			_003CViewType_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool Zoom
	{
		get
		{
			return _003CZoom_003Ek__BackingField;
		}
		set
		{
			_003CZoom_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool Animate
	{
		get
		{
			return _003CAnimate_003Ek__BackingField;
		}
		set
		{
			_003CAnimate_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public string UnitMeasure
	{
		get
		{
			return _003CUnitMeasure_003Ek__BackingField;
		}
		set
		{
			_003CUnitMeasure_003Ek__BackingField = value;
		}
	}
}
