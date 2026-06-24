using System;
using Bridge;
using Bridge.React;
using EleWise.ELMA.Core.React.UI.Enums;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class LineChart
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CTitle_003Ek__BackingField;

		private LineChartData[] _003CData_003Ek__BackingField;

		private LineChartViewType _003CViewType_003Ek__BackingField;

		private ChartLegendViewType _003CLegendViewType_003Ek__BackingField;

		private double? _003CMaxDomain_003Ek__BackingField;

		private double? _003CMinDomain_003Ek__BackingField;

		private Action<LineChartDotData> _003COnMouseEnterElement_003Ek__BackingField;

		private Action<LineChartDotData> _003COnMouseLeaveElement_003Ek__BackingField;

		private Action<LineChartDotData> _003COnClickElement_003Ek__BackingField;

		private string _003CUnitMeasure_003Ek__BackingField;

		private bool _003CZoom_003Ek__BackingField;

		private bool _003CAnimate_003Ek__BackingField;

		private string _003CXAxisLabel_003Ek__BackingField;

		private string _003CYAxisLabel_003Ek__BackingField;

		private bool _003CXIsDate_003Ek__BackingField;

		private bool _003CYIsDate_003Ek__BackingField;

		private Func<object, bool, string> _003CGetValueLabel_003Ek__BackingField;

		[Name("title")]
		public string Title
		{
			get
			{
				return _003CTitle_003Ek__BackingField;
			}
			set
			{
				_003CTitle_003Ek__BackingField = value;
			}
		}

		[Name("data")]
		public LineChartData[] Data
		{
			get
			{
				return _003CData_003Ek__BackingField;
			}
			set
			{
				_003CData_003Ek__BackingField = value;
			}
		}

		[Name("viewType")]
		public LineChartViewType ViewType
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

		[Name("legendViewType")]
		public ChartLegendViewType LegendViewType
		{
			get
			{
				return _003CLegendViewType_003Ek__BackingField;
			}
			set
			{
				_003CLegendViewType_003Ek__BackingField = value;
			}
		}

		[Name("maxDomain")]
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

		[Name("minDomain")]
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

		[Name("onMouseEnterElement")]
		public Action<LineChartDotData> OnMouseEnterElement
		{
			get
			{
				return _003COnMouseEnterElement_003Ek__BackingField;
			}
			set
			{
				_003COnMouseEnterElement_003Ek__BackingField = value;
			}
		}

		[Name("onMouseLeaveElement")]
		public Action<LineChartDotData> OnMouseLeaveElement
		{
			get
			{
				return _003COnMouseLeaveElement_003Ek__BackingField;
			}
			set
			{
				_003COnMouseLeaveElement_003Ek__BackingField = value;
			}
		}

		[Name("onClickElement")]
		public Action<LineChartDotData> OnClickElement
		{
			get
			{
				return _003COnClickElement_003Ek__BackingField;
			}
			set
			{
				_003COnClickElement_003Ek__BackingField = value;
			}
		}

		[Name("unitMeasure")]
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

		[Name("zoom")]
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

		[Name("animate")]
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

		[Name("xAxisLabel")]
		public string XAxisLabel
		{
			get
			{
				return _003CXAxisLabel_003Ek__BackingField;
			}
			set
			{
				_003CXAxisLabel_003Ek__BackingField = value;
			}
		}

		[Name("yAxisLabel")]
		public string YAxisLabel
		{
			get
			{
				return _003CYAxisLabel_003Ek__BackingField;
			}
			set
			{
				_003CYAxisLabel_003Ek__BackingField = value;
			}
		}

		[Name("xIsDate")]
		public bool XIsDate
		{
			get
			{
				return _003CXIsDate_003Ek__BackingField;
			}
			set
			{
				_003CXIsDate_003Ek__BackingField = value;
			}
		}

		[Name("yIsDate")]
		public bool YIsDate
		{
			get
			{
				return _003CYIsDate_003Ek__BackingField;
			}
			set
			{
				_003CYIsDate_003Ek__BackingField = value;
			}
		}

		[Name("getValueLabel")]
		public Func<object, bool, string> GetValueLabel
		{
			get
			{
				return _003CGetValueLabel_003Ek__BackingField;
			}
			set
			{
				_003CGetValueLabel_003Ek__BackingField = value;
			}
		}
	}

	[ObjectLiteral]
	public sealed class LineChartData
	{
		private LineChartDotData[] _003CItems_003Ek__BackingField;

		private string _003CLabel_003Ek__BackingField;

		private object _003CLineUid_003Ek__BackingField;

		[Name("items")]
		public LineChartDotData[] Items
		{
			get
			{
				return _003CItems_003Ek__BackingField;
			}
			set
			{
				_003CItems_003Ek__BackingField = value;
			}
		}

		[Name("label")]
		public string Label
		{
			get
			{
				return _003CLabel_003Ek__BackingField;
			}
			set
			{
				_003CLabel_003Ek__BackingField = value;
			}
		}

		public object LineUid
		{
			get
			{
				return _003CLineUid_003Ek__BackingField;
			}
			set
			{
				_003CLineUid_003Ek__BackingField = value;
			}
		}
	}

	[ObjectLiteral]
	public sealed class LineChartDotData
	{
		private object _003CName_003Ek__BackingField;

		private string _003CNameLabel_003Ek__BackingField;

		private object _003CValue_003Ek__BackingField;

		private string _003CValueLabel_003Ek__BackingField;

		private object _003CItem_003Ek__BackingField;

		[Name("name")]
		public object Name
		{
			get
			{
				return _003CName_003Ek__BackingField;
			}
			set
			{
				_003CName_003Ek__BackingField = value;
			}
		}

		[Name("nameLabel")]
		public string NameLabel
		{
			get
			{
				return _003CNameLabel_003Ek__BackingField;
			}
			set
			{
				_003CNameLabel_003Ek__BackingField = value;
			}
		}

		[Name("value")]
		public object Value
		{
			get
			{
				return _003CValue_003Ek__BackingField;
			}
			set
			{
				_003CValue_003Ek__BackingField = value;
			}
		}

		[Name("valueLabel")]
		public string ValueLabel
		{
			get
			{
				return _003CValueLabel_003Ek__BackingField;
			}
			set
			{
				_003CValueLabel_003Ek__BackingField = value;
			}
		}

		[Name("item")]
		public object Item
		{
			get
			{
				return _003CItem_003Ek__BackingField;
			}
			set
			{
				_003CItem_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.LineChart, {props})")]
	public extern LineChart(Props props);

	public static implicit operator ReactElement(LineChart source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(LineChart source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
