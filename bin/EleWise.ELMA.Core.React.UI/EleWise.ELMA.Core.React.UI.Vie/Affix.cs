using System;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Affix
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private int _003COffsetTop_003Ek__BackingField;

		private int? _003COffsetBottom_003Ek__BackingField;

		private Action<bool> _003COnChange_003Ek__BackingField;

		[Name("offsetTop")]
		public int OffsetTop
		{
			get
			{
				return _003COffsetTop_003Ek__BackingField;
			}
			set
			{
				_003COffsetTop_003Ek__BackingField = value;
			}
		}

		[Name("offsetBottom")]
		public int? OffsetBottom
		{
			get
			{
				return _003COffsetBottom_003Ek__BackingField;
			}
			set
			{
				_003COffsetBottom_003Ek__BackingField = value;
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

	[Template("React.createElement(elmaComponents.Affix, {props}, {children})")]
	public extern Affix(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(Affix source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Affix source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
