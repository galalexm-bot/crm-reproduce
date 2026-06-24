using System;
using Bridge;
using Bridge.Html5;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public class WorkTime
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string[] _003CHoursOptionsData_003Ek__BackingField;

		private string[] _003CMinutesOpitonsData_003Ek__BackingField;

		private string _003CHourLabel_003Ek__BackingField;

		private string _003CMinutesLabel_003Ek__BackingField;

		private string _003CValueHours_003Ek__BackingField;

		private string _003CValueMinutes_003Ek__BackingField;

		private bool _003CDisabledHours_003Ek__BackingField;

		private bool _003CDisabledMinutes_003Ek__BackingField;

		private bool _003CIsErrorValidationHours_003Ek__BackingField;

		private bool _003CIsErrorValidationMinutes_003Ek__BackingField;

		private Action<string> _003COnChangeHours_003Ek__BackingField;

		private Action<string> _003COnChangeMinutes_003Ek__BackingField;

		private Action<FormEvent<HTMLInputElement>> _003COnFocus_003Ek__BackingField;

		private Action<FormEvent<HTMLInputElement>> _003COnBlur_003Ek__BackingField;

		[Name("hoursOptionsData")]
		public string[] HoursOptionsData
		{
			get
			{
				return _003CHoursOptionsData_003Ek__BackingField;
			}
			set
			{
				_003CHoursOptionsData_003Ek__BackingField = value;
			}
		}

		[Name("minutesOpitonsData")]
		public string[] MinutesOpitonsData
		{
			get
			{
				return _003CMinutesOpitonsData_003Ek__BackingField;
			}
			set
			{
				_003CMinutesOpitonsData_003Ek__BackingField = value;
			}
		}

		[Name("hourLabel")]
		public string HourLabel
		{
			get
			{
				return _003CHourLabel_003Ek__BackingField;
			}
			set
			{
				_003CHourLabel_003Ek__BackingField = value;
			}
		}

		[Name("minutesLabel")]
		public string MinutesLabel
		{
			get
			{
				return _003CMinutesLabel_003Ek__BackingField;
			}
			set
			{
				_003CMinutesLabel_003Ek__BackingField = value;
			}
		}

		[Name("valueHours")]
		public string ValueHours
		{
			get
			{
				return _003CValueHours_003Ek__BackingField;
			}
			set
			{
				_003CValueHours_003Ek__BackingField = value;
			}
		}

		[Name("valueMinutes")]
		public string ValueMinutes
		{
			get
			{
				return _003CValueMinutes_003Ek__BackingField;
			}
			set
			{
				_003CValueMinutes_003Ek__BackingField = value;
			}
		}

		[Name("disabledHours")]
		public bool DisabledHours
		{
			get
			{
				return _003CDisabledHours_003Ek__BackingField;
			}
			set
			{
				_003CDisabledHours_003Ek__BackingField = value;
			}
		}

		[Name("disabledMinutes")]
		public bool DisabledMinutes
		{
			get
			{
				return _003CDisabledMinutes_003Ek__BackingField;
			}
			set
			{
				_003CDisabledMinutes_003Ek__BackingField = value;
			}
		}

		[Name("isErrorValidationHours")]
		public bool IsErrorValidationHours
		{
			get
			{
				return _003CIsErrorValidationHours_003Ek__BackingField;
			}
			set
			{
				_003CIsErrorValidationHours_003Ek__BackingField = value;
			}
		}

		[Name("isErrorValidationMinutes")]
		public bool IsErrorValidationMinutes
		{
			get
			{
				return _003CIsErrorValidationMinutes_003Ek__BackingField;
			}
			set
			{
				_003CIsErrorValidationMinutes_003Ek__BackingField = value;
			}
		}

		[Name("onChangeHours")]
		public Action<string> OnChangeHours
		{
			get
			{
				return _003COnChangeHours_003Ek__BackingField;
			}
			set
			{
				_003COnChangeHours_003Ek__BackingField = value;
			}
		}

		[Name("onChangeMinutes")]
		public Action<string> OnChangeMinutes
		{
			get
			{
				return _003COnChangeMinutes_003Ek__BackingField;
			}
			set
			{
				_003COnChangeMinutes_003Ek__BackingField = value;
			}
		}

		[Name("onFocus")]
		public Action<FormEvent<HTMLInputElement>> OnFocus
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
		public Action<FormEvent<HTMLInputElement>> OnBlur
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
	}

	[Template("React.createElement(elmaComponents.WorkTime, {props}, {children})")]
	public extern WorkTime(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(WorkTime source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(WorkTime source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
