using System;
using Bridge;
using Bridge.Html5;
using Bridge.React;
using EleWise.ELMA.Core.React.UI.Models;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class TextArea
{
	[ObjectLiteral]
	public sealed class Props : BaseProps, IHasDataTestId
	{
		private string _003CId_003Ek__BackingField;

		private string _003CName_003Ek__BackingField;

		private string _003CValue_003Ek__BackingField;

		private int _003CMaxLength_003Ek__BackingField;

		private string _003CPlaceholder_003Ek__BackingField;

		private bool _003CDisabled_003Ek__BackingField;

		private bool _003CAutoFocus_003Ek__BackingField;

		private int _003CMinRows_003Ek__BackingField;

		private int _003CMaxRows_003Ek__BackingField;

		private string _003CDataTestId_003Ek__BackingField;

		private Action<ChangeEvent<HTMLInputElement>> _003COnChange_003Ek__BackingField;

		private Action<FocusEvent<HTMLInputElement>> _003COnBlur_003Ek__BackingField;

		private Action<FocusEvent<HTMLInputElement>> _003COnFocus_003Ek__BackingField;

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

		[Name("maxLength")]
		public int MaxLength
		{
			get
			{
				return _003CMaxLength_003Ek__BackingField;
			}
			set
			{
				_003CMaxLength_003Ek__BackingField = value;
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

		[Name("autoFocus")]
		public bool AutoFocus
		{
			get
			{
				return _003CAutoFocus_003Ek__BackingField;
			}
			set
			{
				_003CAutoFocus_003Ek__BackingField = value;
			}
		}

		[Name("minRows")]
		public int MinRows
		{
			get
			{
				return _003CMinRows_003Ek__BackingField;
			}
			set
			{
				_003CMinRows_003Ek__BackingField = value;
			}
		}

		[Name("maxRows")]
		public int MaxRows
		{
			get
			{
				return _003CMaxRows_003Ek__BackingField;
			}
			set
			{
				_003CMaxRows_003Ek__BackingField = value;
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
		public Action<ChangeEvent<HTMLInputElement>> OnChange
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

	[Template("React.createElement(elmaComponents.TextArea, {props})")]
	public extern TextArea(Props props);

	public static implicit operator ReactElement(TextArea source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(TextArea source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
