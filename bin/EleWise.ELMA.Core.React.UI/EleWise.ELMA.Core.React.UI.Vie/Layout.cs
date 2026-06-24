using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Layout
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private LayoutType _003CType_003Ek__BackingField;

		[Name("type")]
		public LayoutType Type
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
	public enum LayoutType
	{
		Default,
		Primary
	}

	[Template("React.createElement(elmaComponents.Layout, {props}, {children})")]
	public extern Layout(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(Layout source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Layout source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
