using System;
using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class CheckboxGroup
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string[] _003CValue_003Ek__BackingField;

		private bool _003CDisabled_003Ek__BackingField;

		private Action<string[]> _003COnChange_003Ek__BackingField;

		private CheckboxType _003CType_003Ek__BackingField;

		[Name("value")]
		public string[] Value
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

		[Name("onChange")]
		public Action<string[]> OnChange
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

		[Name("type")]
		public CheckboxType Type
		{
			get
			{
				return _003CType_003Ek__BackingField;
			}
			set
			{
				_003CType_003Ek__BackingField = value;
			}
		}
	}

	[Enum(/*Could not decode attribute arguments.*/)]
	[ObjectLiteral]
	public enum CheckboxType
	{
		Horizontal,
		Vertical
	}

	[Template("React.createElement(elmaComponents.CheckboxGroup, {props}, {children})")]
	public extern CheckboxGroup(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.CheckboxGroup, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern CheckboxGroup(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(CheckboxGroup source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(CheckboxGroup source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
