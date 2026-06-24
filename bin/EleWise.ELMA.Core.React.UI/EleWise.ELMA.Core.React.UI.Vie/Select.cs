using System;
using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Select
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private SelectMode _003CMode_003Ek__BackingField;

		private Union<string, string[]> _003CValue_003Ek__BackingField;

		private string _003CDefaultValue_003Ek__BackingField;

		private string _003CPlaceholder_003Ek__BackingField;

		private bool _003CDisabled_003Ek__BackingField;

		private bool _003CAllowClear_003Ek__BackingField;

		private string _003COptionLabelProp_003Ek__BackingField;

		private Action<string> _003COnSearch_003Ek__BackingField;

		private Action<string, string[]> _003COnChange_003Ek__BackingField;

		private Action<string, object> _003COnSelect_003Ek__BackingField;

		private Action<string> _003COnDeselect_003Ek__BackingField;

		private Action _003COnBlur_003Ek__BackingField;

		private Action _003COnFocus_003Ek__BackingField;

		private bool _003CShowSearch_003Ek__BackingField;

		private string _003COptionFilterProp_003Ek__BackingField;

		private string _003CNotFoundContent_003Ek__BackingField;

		private Action<bool> _003COnClickOpenDropdown_003Ek__BackingField;

		private bool _003COpen_003Ek__BackingField;

		[Name("mode")]
		public SelectMode Mode
		{
			get
			{
				return _003CMode_003Ek__BackingField;
			}
			set
			{
				_003CMode_003Ek__BackingField = value;
			}
		}

		[Name("value")]
		public Union<string, string[]> Value
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
		public string DefaultValue
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

		[Name("onChange")]
		public Action<string, string[]> OnChange
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

		[Name("onDeselect")]
		public Action<string> OnDeselect
		{
			get
			{
				return _003COnDeselect_003Ek__BackingField;
			}
			set
			{
				_003COnDeselect_003Ek__BackingField = value;
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

		[Name("showSearch")]
		public bool ShowSearch
		{
			get
			{
				return _003CShowSearch_003Ek__BackingField;
			}
			set
			{
				_003CShowSearch_003Ek__BackingField = value;
			}
		}

		[Name("optionFilterProp")]
		public string OptionFilterProp
		{
			get
			{
				return _003COptionFilterProp_003Ek__BackingField;
			}
			set
			{
				_003COptionFilterProp_003Ek__BackingField = value;
			}
		}

		[Name("notFoundContent")]
		public string NotFoundContent
		{
			get
			{
				return _003CNotFoundContent_003Ek__BackingField;
			}
			set
			{
				_003CNotFoundContent_003Ek__BackingField = value;
			}
		}

		[Name("onClickOpenDropdown")]
		public Action<bool> OnClickOpenDropdown
		{
			get
			{
				return _003COnClickOpenDropdown_003Ek__BackingField;
			}
			set
			{
				_003COnClickOpenDropdown_003Ek__BackingField = value;
			}
		}

		[Name("open")]
		public bool Open
		{
			get
			{
				return _003COpen_003Ek__BackingField;
			}
			set
			{
				_003COpen_003Ek__BackingField = value;
			}
		}
	}

	[Enum(/*Could not decode attribute arguments.*/)]
	[ObjectLiteral]
	public enum SelectMode
	{
		Default,
		Multiple,
		Tags
	}

	[Template("React.createElement(elmaComponents.Select, {props}, {children})")]
	public extern Select(Props props, params ReactElement[] children);

	[Template("React.createElement(elmaComponents.Select, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Select(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(Select source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Select source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
