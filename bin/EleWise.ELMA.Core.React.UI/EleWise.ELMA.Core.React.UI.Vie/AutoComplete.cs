using System;
using Bridge;
using Bridge.Html5;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class AutoComplete
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CName_003Ek__BackingField;

		private string _003CValue_003Ek__BackingField;

		private OptionData[] _003COptions_003Ek__BackingField;

		private Action<string> _003COnChange_003Ek__BackingField;

		private Action<string> _003COnSearch_003Ek__BackingField;

		private Action<string, object> _003COnSelect_003Ek__BackingField;

		private Action _003COnFocus_003Ek__BackingField;

		private Action<FocusEvent<HTMLInputElement>> _003COnBlur_003Ek__BackingField;

		private string _003COptionLabelProp_003Ek__BackingField;

		private bool _003CDisabled_003Ek__BackingField;

		private string _003CPlaceholder_003Ek__BackingField;

		private bool _003CAllowClear_003Ek__BackingField;

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
		public string Value
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

		[Name("options")]
		public OptionData[] Options
		{
			get
			{
				return _003COptions_003Ek__BackingField;
			}
			set
			{
				_003COptions_003Ek__BackingField = value;
			}
		}

		[Name("onChange")]
		public Action<string> OnChange
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

		[Name("onSearch")]
		public Action<string> OnSearch
		{
			get
			{
				return _003COnSearch_003Ek__BackingField;
			}
			set
			{
				_003COnSearch_003Ek__BackingField = value;
			}
		}

		[Name("onSelect")]
		public Action<string, object> OnSelect
		{
			get
			{
				return _003COnSelect_003Ek__BackingField;
			}
			set
			{
				_003COnSelect_003Ek__BackingField = value;
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

		[Name("optionLabelProp")]
		public string OptionLabelProp
		{
			get
			{
				return _003COptionLabelProp_003Ek__BackingField;
			}
			set
			{
				_003COptionLabelProp_003Ek__BackingField = value;
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

		[Name("allowClear")]
		public bool AllowClear
		{
			get
			{
				return _003CAllowClear_003Ek__BackingField;
			}
			set
			{
				_003CAllowClear_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.AutoComplete, {props})")]
	public extern AutoComplete(Props props);

	public static implicit operator ReactElement(AutoComplete source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(AutoComplete source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
