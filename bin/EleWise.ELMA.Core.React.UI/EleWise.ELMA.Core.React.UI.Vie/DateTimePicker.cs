using System;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class DateTimePicker
{
	[ObjectLiteral]
	public class Props : BaseProps
	{
		private string _003CValueTime_003Ek__BackingField;

		private int _003CStepTime_003Ek__BackingField;

		private string _003CFormatDate_003Ek__BackingField;

		private bool _003CShowDatePicker_003Ek__BackingField;

		private bool _003CShowTimePicker_003Ek__BackingField;

		private string _003CDateMask_003Ek__BackingField;

		private bool _003CDisabled_003Ek__BackingField;

		private string _003CValueDate_003Ek__BackingField;

		private Func<string, string> _003CValueDateToJsFormat_003Ek__BackingField;

		private string _003CPlaceholder_003Ek__BackingField;

		private string _003CLocale_003Ek__BackingField;

		private string _003CMinDate_003Ek__BackingField;

		private string _003CMaxDate_003Ek__BackingField;

		private string _003CMinTime_003Ek__BackingField;

		private string _003CMaxTime_003Ek__BackingField;

		private Action<string, string> _003COnChange_003Ek__BackingField;

		private Action _003COnFocus_003Ek__BackingField;

		[Name("valueTime")]
		public string ValueTime
		{
			get
			{
				return _003CValueTime_003Ek__BackingField;
			}
			set
			{
				_003CValueTime_003Ek__BackingField = value;
			}
		}

		[Name("stepTime")]
		public int StepTime
		{
			get
			{
				return _003CStepTime_003Ek__BackingField;
			}
			set
			{
				_003CStepTime_003Ek__BackingField = value;
			}
		}

		[Name("formatDate")]
		public string FormatDate
		{
			get
			{
				return _003CFormatDate_003Ek__BackingField;
			}
			set
			{
				_003CFormatDate_003Ek__BackingField = value;
			}
		}

		[Name("showDatePicker")]
		public bool ShowDatePicker
		{
			get
			{
				return _003CShowDatePicker_003Ek__BackingField;
			}
			set
			{
				_003CShowDatePicker_003Ek__BackingField = value;
			}
		}

		[Name("showTimePicker")]
		public bool ShowTimePicker
		{
			get
			{
				return _003CShowTimePicker_003Ek__BackingField;
			}
			set
			{
				_003CShowTimePicker_003Ek__BackingField = value;
			}
		}

		[Name("dateMask")]
		public string DateMask
		{
			get
			{
				return _003CDateMask_003Ek__BackingField;
			}
			set
			{
				_003CDateMask_003Ek__BackingField = value;
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

		[Name("valueDate")]
		public string ValueDate
		{
			get
			{
				return _003CValueDate_003Ek__BackingField;
			}
			set
			{
				_003CValueDate_003Ek__BackingField = value;
			}
		}

		[Name("valueDateToJsFormat")]
		public Func<string, string> ValueDateToJsFormat
		{
			get
			{
				return _003CValueDateToJsFormat_003Ek__BackingField;
			}
			set
			{
				_003CValueDateToJsFormat_003Ek__BackingField = value;
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

		[Name("locale")]
		public string Locale
		{
			get
			{
				return _003CLocale_003Ek__BackingField;
			}
			set
			{
				_003CLocale_003Ek__BackingField = value;
			}
		}

		[Name("minDate")]
		public string MinDate
		{
			get
			{
				return _003CMinDate_003Ek__BackingField;
			}
			set
			{
				_003CMinDate_003Ek__BackingField = value;
			}
		}

		[Name("maxDate")]
		public string MaxDate
		{
			get
			{
				return _003CMaxDate_003Ek__BackingField;
			}
			set
			{
				_003CMaxDate_003Ek__BackingField = value;
			}
		}

		[Name("minTime")]
		public string MinTime
		{
			get
			{
				return _003CMinTime_003Ek__BackingField;
			}
			set
			{
				_003CMinTime_003Ek__BackingField = value;
			}
		}

		[Name("maxTime")]
		public string MaxTime
		{
			get
			{
				return _003CMaxTime_003Ek__BackingField;
			}
			set
			{
				_003CMaxTime_003Ek__BackingField = value;
			}
		}

		[Name("onChange")]
		public Action<string, string> OnChange
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
		public Action OnFocus
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
	}

	[Template("React.createElement(elmaComponents.DateTimePicker, {props})")]
	public extern DateTimePicker(Props props);

	public static implicit operator ReactElement(DateTimePicker source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(DateTimePicker source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
