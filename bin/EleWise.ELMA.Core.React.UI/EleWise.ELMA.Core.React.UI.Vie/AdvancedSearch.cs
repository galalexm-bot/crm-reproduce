using System;
using Bridge;
using Bridge.Html5;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class AdvancedSearch
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CId_003Ek__BackingField;

		private string _003CName_003Ek__BackingField;

		private string _003CValue_003Ek__BackingField;

		private string _003CPlaceholder_003Ek__BackingField;

		private bool _003CPopoverVisible_003Ek__BackingField;

		private bool _003CDisabled_003Ek__BackingField;

		private Action<bool> _003COnPopoverVisibleChange_003Ek__BackingField;

		private Action<FormEvent<HTMLInputElement>> _003COnSearchKeyUp_003Ek__BackingField;

		private Action<KeyboardEvent<HTMLElement>> _003COnKeyDown_003Ek__BackingField;

		private Action<FormEvent<HTMLInputElement>> _003COnSearchChange_003Ek__BackingField;

		private Action<FocusEvent<HTMLInputElement>> _003COnSearchFocus_003Ek__BackingField;

		private Action<FocusEvent<HTMLInputElement>> _003COnBlur_003Ek__BackingField;

		private Action _003COnClearValue_003Ek__BackingField;

		private ReactElement _003CSelectedValues_003Ek__BackingField;

		private bool _003CIsLoading_003Ek__BackingField;

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

		[Name("popoverVisible")]
		public bool PopoverVisible
		{
			get
			{
				return _003CPopoverVisible_003Ek__BackingField;
			}
			set
			{
				_003CPopoverVisible_003Ek__BackingField = value;
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

		[Name("onPopoverVisibleChange")]
		public Action<bool> OnPopoverVisibleChange
		{
			get
			{
				return _003COnPopoverVisibleChange_003Ek__BackingField;
			}
			set
			{
				_003COnPopoverVisibleChange_003Ek__BackingField = value;
			}
		}

		[Name("onSearchKeyUp")]
		public Action<FormEvent<HTMLInputElement>> OnSearchKeyUp
		{
			get
			{
				return _003COnSearchKeyUp_003Ek__BackingField;
			}
			set
			{
				_003COnSearchKeyUp_003Ek__BackingField = value;
			}
		}

		[Name("onKeyDown")]
		public Action<KeyboardEvent<HTMLElement>> OnKeyDown
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

		[Name("onSearchChange")]
		public Action<FormEvent<HTMLInputElement>> OnSearchChange
		{
			get
			{
				return _003COnSearchChange_003Ek__BackingField;
			}
			set
			{
				_003COnSearchChange_003Ek__BackingField = value;
			}
		}

		[Name("onSearchFocus")]
		public Action<FocusEvent<HTMLInputElement>> OnSearchFocus
		{
			get
			{
				return _003COnSearchFocus_003Ek__BackingField;
			}
			set
			{
				_003COnSearchFocus_003Ek__BackingField = value;
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

		[Name("onClearValue")]
		public Action OnClearValue
		{
			get
			{
				return _003COnClearValue_003Ek__BackingField;
			}
			set
			{
				_003COnClearValue_003Ek__BackingField = value;
			}
		}

		[Name("selectedValues")]
		public ReactElement SelectedValues
		{
			get
			{
				return _003CSelectedValues_003Ek__BackingField;
			}
			set
			{
				_003CSelectedValues_003Ek__BackingField = value;
			}
		}

		[Name("isLoading")]
		public bool IsLoading
		{
			get
			{
				return _003CIsLoading_003Ek__BackingField;
			}
			set
			{
				_003CIsLoading_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.AdvancedSearch, {props}, {children})")]
	public extern AdvancedSearch(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(AdvancedSearch source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(AdvancedSearch source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
