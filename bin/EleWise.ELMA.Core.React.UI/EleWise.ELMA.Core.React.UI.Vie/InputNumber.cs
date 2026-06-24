using System;
using Bridge;
using Bridge.Html5;
using Bridge.React;
using EleWise.ELMA.Core.React.UI.Models;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class InputNumber
{
	[ObjectLiteral]
	public sealed class Props : BaseProps, IHasDataTestId
	{
		private string _003CId_003Ek__BackingField;

		private string _003CName_003Ek__BackingField;

		private string _003CPlaceholder_003Ek__BackingField;

		private bool _003CDisabled_003Ek__BackingField;

		private double? _003CMin_003Ek__BackingField;

		private double? _003CMax_003Ek__BackingField;

		private double _003CStep_003Ek__BackingField;

		private string _003CDecimalSeparator_003Ek__BackingField;

		private string _003CGroupSeparator_003Ek__BackingField;

		private int _003CPrecision_003Ek__BackingField;

		private double? _003CValue_003Ek__BackingField;

		private double _003CDefaultValue_003Ek__BackingField;

		private string _003CDataTestId_003Ek__BackingField;

		private Action<Union<double, string>> _003COnChange_003Ek__BackingField;

		private Action<FocusEvent<HTMLInputElement>> _003COnFocus_003Ek__BackingField;

		private Action<FocusEvent<HTMLInputElement>> _003COnBlur_003Ek__BackingField;

		private Action<KeyboardEvent<HTMLInputElement>> _003COnKeyDown_003Ek__BackingField;

		[Name("id")]
		public string Id
		{
			get
			{
				return _003CId_003Ek__BackingField;
			}
			set
			{
				_003CId_003Ek__BackingField = value;
			}
		}

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

		[Name("placeholder")]
		public string Placeholder
		{
			get
			{
				return _003CPlaceholder_003Ek__BackingField;
			}
			set
			{
				_003CPlaceholder_003Ek__BackingField = value;
			}
		}

		[Name("disabled")]
		public bool Disabled
		{
			get
			{
				return _003CDisabled_003Ek__BackingField;
			}
			set
			{
				_003CDisabled_003Ek__BackingField = value;
			}
		}

		[Name("min")]
		public double? Min
		{
			get
			{
				return _003CMin_003Ek__BackingField;
			}
			set
			{
				_003CMin_003Ek__BackingField = value;
			}
		}

		[Name("max")]
		public double? Max
		{
			get
			{
				return _003CMax_003Ek__BackingField;
			}
			set
			{
				_003CMax_003Ek__BackingField = value;
			}
		}

		[Name("step")]
		public double Step
		{
			get
			{
				return _003CStep_003Ek__BackingField;
			}
			set
			{
				_003CStep_003Ek__BackingField = value;
			}
		}

		[Name("decimalSeparator")]
		public string DecimalSeparator
		{
			get
			{
				return _003CDecimalSeparator_003Ek__BackingField;
			}
			set
			{
				_003CDecimalSeparator_003Ek__BackingField = value;
			}
		}

		[Name("groupSeparator")]
		public string GroupSeparator
		{
			get
			{
				return _003CGroupSeparator_003Ek__BackingField;
			}
			set
			{
				_003CGroupSeparator_003Ek__BackingField = value;
			}
		}

		[Name("precision")]
		public int Precision
		{
			get
			{
				return _003CPrecision_003Ek__BackingField;
			}
			set
			{
				_003CPrecision_003Ek__BackingField = value;
			}
		}

		[Name("value")]
		public double? Value
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

		[Name("defaultValue")]
		public double DefaultValue
		{
			get
			{
				return _003CDefaultValue_003Ek__BackingField;
			}
			set
			{
				_003CDefaultValue_003Ek__BackingField = value;
			}
		}

		[Name("dataTestId")]
		public string DataTestId
		{
			get
			{
				return _003CDataTestId_003Ek__BackingField;
			}
			set
			{
				_003CDataTestId_003Ek__BackingField = value;
			}
		}

		[Name("onChange")]
		public Action<Union<double, string>> OnChange
		{
			get
			{
				return _003COnChange_003Ek__BackingField;
			}
			set
			{
				_003COnChange_003Ek__BackingField = value;
			}
		}

		[Name("onFocus")]
		public Action<FocusEvent<HTMLInputElement>> OnFocus
		{
			get
			{
				return _003COnFocus_003Ek__BackingField;
			}
			set
			{
				_003COnFocus_003Ek__BackingField = value;
			}
		}

		[Name("onBlur")]
		public Action<FocusEvent<HTMLInputElement>> OnBlur
		{
			get
			{
				return _003COnBlur_003Ek__BackingField;
			}
			set
			{
				_003COnBlur_003Ek__BackingField = value;
			}
		}

		[Name("onKeyDown")]
		public Action<KeyboardEvent<HTMLInputElement>> OnKeyDown
		{
			get
			{
				return _003COnKeyDown_003Ek__BackingField;
			}
			set
			{
				_003COnKeyDown_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.InputNumber, {props})")]
	public extern InputNumber(Props props);

	public static implicit operator ReactElement(InputNumber source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(InputNumber source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
