using System;
using Bridge;
using Bridge.React;
using EleWise.ELMA.Core.React.UI.Models;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Switch
{
	[ObjectLiteral]
	public sealed class Props : BaseProps, IHasDataTestId
	{
		private bool _003CDisabled_003Ek__BackingField;

		private bool _003CChecked_003Ek__BackingField;

		private bool _003CDefaultChecked_003Ek__BackingField;

		private string _003CCheckedLabel_003Ek__BackingField;

		private string _003CUnCheckedLabel_003Ek__BackingField;

		private string _003CDataTestId_003Ek__BackingField;

		private Union<ReactElement, string> _003CRightText_003Ek__BackingField;

		private Action<bool> _003COnChange_003Ek__BackingField;

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

		[Name("checked")]
		public bool Checked
		{
			get
			{
				return _003CChecked_003Ek__BackingField;
			}
			set
			{
				_003CChecked_003Ek__BackingField = value;
			}
		}

		[Name("defaultChecked")]
		public bool DefaultChecked
		{
			get
			{
				return _003CDefaultChecked_003Ek__BackingField;
			}
			set
			{
				_003CDefaultChecked_003Ek__BackingField = value;
			}
		}

		[Name("checkedLabel")]
		public string CheckedLabel
		{
			get
			{
				return _003CCheckedLabel_003Ek__BackingField;
			}
			set
			{
				_003CCheckedLabel_003Ek__BackingField = value;
			}
		}

		[Name("unCheckedLabel")]
		public string UnCheckedLabel
		{
			get
			{
				return _003CUnCheckedLabel_003Ek__BackingField;
			}
			set
			{
				_003CUnCheckedLabel_003Ek__BackingField = value;
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

		[Name("rightText")]
		public Union<ReactElement, string> RightText
		{
			get
			{
				return _003CRightText_003Ek__BackingField;
			}
			set
			{
				_003CRightText_003Ek__BackingField = value;
			}
		}

		[Name("onChange")]
		public Action<bool> OnChange
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
	}

	[Template("React.createElement(elmaComponents.Switch, {props})")]
	public extern Switch(Props props);

	public static implicit operator ReactElement(Switch source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Switch source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
