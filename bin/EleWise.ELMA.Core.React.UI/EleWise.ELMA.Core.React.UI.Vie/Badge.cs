using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Badge
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private ButtonStyle _003CStyle_003Ek__BackingField;

		private string _003CText_003Ek__BackingField;

		private bool _003CDot_003Ek__BackingField;

		private bool _003CIsEmpty_003Ek__BackingField;

		[Name("style")]
		public ButtonStyle Style
		{
			get
			{
				return _003CStyle_003Ek__BackingField;
			}
			set
			{
				_003CStyle_003Ek__BackingField = value;
			}
		}

		[Name("text")]
		public string Text
		{
			get
			{
				return _003CText_003Ek__BackingField;
			}
			set
			{
				_003CText_003Ek__BackingField = value;
			}
		}

		[Name("dot")]
		public bool Dot
		{
			get
			{
				return _003CDot_003Ek__BackingField;
			}
			set
			{
				_003CDot_003Ek__BackingField = value;
			}
		}

		[Name("isEmpty")]
		public bool IsEmpty
		{
			get
			{
				return _003CIsEmpty_003Ek__BackingField;
			}
			set
			{
				_003CIsEmpty_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Badge, {props}, {children})")]
	public extern Badge(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(Badge source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Badge source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
