using System;
using Bridge;
using Bridge.React;
using EleWise.ELMA.Core.React.UI.Enums;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class PieChart
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CTitle_003Ek__BackingField;

		private ChartLegendViewType _003CLegendViewType_003Ek__BackingField;

		private PieChartViewType _003CViewType_003Ek__BackingField;

		private PieChartData[] _003CData_003Ek__BackingField;

		private Action<PieChartData> _003COnMouseEnterElement_003Ek__BackingField;

		private Action<PieChartData> _003COnMouseLeaveElement_003Ek__BackingField;

		private Action<PieChartData> _003COnClickElement_003Ek__BackingField;

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

		[Name("viewType")]
		public PieChartViewType ViewType
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

		[Name("data")]
		public PieChartData[] Data
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

		[Name("onMouseEnterElement")]
		public Action<PieChartData> OnMouseEnterElement
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
		public Action<PieChartData> OnMouseLeaveElement
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
		public Action<PieChartData> OnClickElement
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
	}

	[ObjectLiteral]
	public sealed class PieChartData
	{
		private string _003CName_003Ek__BackingField;

		private Union<string, double> _003CValue_003Ek__BackingField;

		private string _003CValueLabel_003Ek__BackingField;

		private object _003CItem_003Ek__BackingField;

		[Name("name")]
		public string Name
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

		[Name("value")]
		public Union<string, double> Value
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

	[Template("React.createElement(elmaComponents.PieChart, {props})")]
	public extern PieChart(Props props);

	public static implicit operator ReactElement(PieChart source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(PieChart source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
