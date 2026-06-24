using System;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public class TimeSpan
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CName_003Ek__BackingField;

		private int? _003CValueDays_003Ek__BackingField;

		private int? _003CValueHours_003Ek__BackingField;

		private int? _003CValueMinutes_003Ek__BackingField;

		private int? _003CValueSeconds_003Ek__BackingField;

		private string _003CDaysLabel_003Ek__BackingField;

		private string _003CHoursLabel_003Ek__BackingField;

		private string _003CMinutesLabel_003Ek__BackingField;

		private string _003CSecondsLabel_003Ek__BackingField;

		private int _003CDaysMax_003Ek__BackingField;

		private int _003CHoursMax_003Ek__BackingField;

		private int _003CMinutesMax_003Ek__BackingField;

		private int _003CSecondsMax_003Ek__BackingField;

		private int _003CDaysStep_003Ek__BackingField;

		private int _003CHoursStep_003Ek__BackingField;

		private int _003CMinutesStep_003Ek__BackingField;

		private int _003CSecondsStep_003Ek__BackingField;

		private bool _003CDisabledValidationDays_003Ek__BackingField;

		private bool _003CDisabledValidationHours_003Ek__BackingField;

		private bool _003CDisabledValidationMinutes_003Ek__BackingField;

		private Action<int> _003COnChangeDays_003Ek__BackingField;

		private Action<int> _003COnChangeHours_003Ek__BackingField;

		private Action<int> _003COnChangeMinutes_003Ek__BackingField;

		private Action<int> _003COnChangeSeconds_003Ek__BackingField;

		private Action _003COnFocus_003Ek__BackingField;

		private Action _003COnBlur_003Ek__BackingField;

		private bool _003CShowDays_003Ek__BackingField;

		private bool _003CShowHours_003Ek__BackingField;

		private bool _003CShowMinutes_003Ek__BackingField;

		private bool _003CShowSeconds_003Ek__BackingField;

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

		[Name("valueDays")]
		public int? ValueDays
		{
			get
			{
				return _003CValueDays_003Ek__BackingField;
			}
			set
			{
				_003CValueDays_003Ek__BackingField = value;
			}
		}

		[Name("valueHours")]
		public int? ValueHours
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
		public int? ValueMinutes
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

		[Name("valueSeconds")]
		public int? ValueSeconds
		{
			get
			{
				return _003CValueSeconds_003Ek__BackingField;
			}
			set
			{
				_003CValueSeconds_003Ek__BackingField = value;
			}
		}

		[Name("daysLabel")]
		public string DaysLabel
		{
			get
			{
				return _003CDaysLabel_003Ek__BackingField;
			}
			set
			{
				_003CDaysLabel_003Ek__BackingField = value;
			}
		}

		[Name("hoursLabel")]
		public string HoursLabel
		{
			get
			{
				return _003CHoursLabel_003Ek__BackingField;
			}
			set
			{
				_003CHoursLabel_003Ek__BackingField = value;
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

		[Name("secondsLabel")]
		public string SecondsLabel
		{
			get
			{
				return _003CSecondsLabel_003Ek__BackingField;
			}
			set
			{
				_003CSecondsLabel_003Ek__BackingField = value;
			}
		}

		[Name("daysMax")]
		public int DaysMax
		{
			get
			{
				return _003CDaysMax_003Ek__BackingField;
			}
			set
			{
				_003CDaysMax_003Ek__BackingField = value;
			}
		}

		[Name("hoursMax")]
		public int HoursMax
		{
			get
			{
				return _003CHoursMax_003Ek__BackingField;
			}
			set
			{
				_003CHoursMax_003Ek__BackingField = value;
			}
		}

		[Name("minutesMax")]
		public int MinutesMax
		{
			get
			{
				return _003CMinutesMax_003Ek__BackingField;
			}
			set
			{
				_003CMinutesMax_003Ek__BackingField = value;
			}
		}

		[Name("secondsMax")]
		public int SecondsMax
		{
			get
			{
				return _003CSecondsMax_003Ek__BackingField;
			}
			set
			{
				_003CSecondsMax_003Ek__BackingField = value;
			}
		}

		[Name("daysStep")]
		public int DaysStep
		{
			get
			{
				return _003CDaysStep_003Ek__BackingField;
			}
			set
			{
				_003CDaysStep_003Ek__BackingField = value;
			}
		}

		[Name("hoursStep")]
		public int HoursStep
		{
			get
			{
				return _003CHoursStep_003Ek__BackingField;
			}
			set
			{
				_003CHoursStep_003Ek__BackingField = value;
			}
		}

		[Name("minutesStep")]
		public int MinutesStep
		{
			get
			{
				return _003CMinutesStep_003Ek__BackingField;
			}
			set
			{
				_003CMinutesStep_003Ek__BackingField = value;
			}
		}

		[Name("secondsStep")]
		public int SecondsStep
		{
			get
			{
				return _003CSecondsStep_003Ek__BackingField;
			}
			set
			{
				_003CSecondsStep_003Ek__BackingField = value;
			}
		}

		[Name("disabledValidationDays")]
		public bool DisabledValidationDays
		{
			get
			{
				return _003CDisabledValidationDays_003Ek__BackingField;
			}
			set
			{
				_003CDisabledValidationDays_003Ek__BackingField = value;
			}
		}

		[Name("disabledValidationHours")]
		public bool DisabledValidationHours
		{
			get
			{
				return _003CDisabledValidationHours_003Ek__BackingField;
			}
			set
			{
				_003CDisabledValidationHours_003Ek__BackingField = value;
			}
		}

		[Name("disabledValidationMinutes")]
		public bool DisabledValidationMinutes
		{
			get
			{
				return _003CDisabledValidationMinutes_003Ek__BackingField;
			}
			set
			{
				_003CDisabledValidationMinutes_003Ek__BackingField = value;
			}
		}

		[Name("onChangeDays")]
		public Action<int> OnChangeDays
		{
			get
			{
				return _003COnChangeDays_003Ek__BackingField;
			}
			set
			{
				_003COnChangeDays_003Ek__BackingField = value;
			}
		}

		[Name("onChangeHours")]
		public Action<int> OnChangeHours
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
		public Action<int> OnChangeMinutes
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

		[Name("onChangeSeconds")]
		public Action<int> OnChangeSeconds
		{
			get
			{
				return _003COnChangeSeconds_003Ek__BackingField;
			}
			set
			{
				_003COnChangeSeconds_003Ek__BackingField = value;
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

		[Name("onBlur")]
		public Action OnBlur
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

		[Name("showDays")]
		public bool ShowDays
		{
			get
			{
				return _003CShowDays_003Ek__BackingField;
			}
			set
			{
				_003CShowDays_003Ek__BackingField = value;
			}
		}

		[Name("showHours")]
		public bool ShowHours
		{
			get
			{
				return _003CShowHours_003Ek__BackingField;
			}
			set
			{
				_003CShowHours_003Ek__BackingField = value;
			}
		}

		[Name("showMinutes")]
		public bool ShowMinutes
		{
			get
			{
				return _003CShowMinutes_003Ek__BackingField;
			}
			set
			{
				_003CShowMinutes_003Ek__BackingField = value;
			}
		}

		[Name("showSeconds")]
		public bool ShowSeconds
		{
			get
			{
				return _003CShowSeconds_003Ek__BackingField;
			}
			set
			{
				_003CShowSeconds_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.TimeSpan, {props}, {children})")]
	public extern TimeSpan(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(TimeSpan source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(TimeSpan source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
