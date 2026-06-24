using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Tooltip
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private Union<ReactElement, string> _003CTitle_003Ek__BackingField;

		private TooltipPlacement _003CPlacement_003Ek__BackingField;

		[Name("title")]
		public Union<ReactElement, string> Title
		{
			get
			{
				return _003CTitle_003Ek__BackingField;
			}
			set
			{
				_003CTitle_003Ek__BackingField = value;
			}
		}

		[Name("placement")]
		public TooltipPlacement Placement
		{
			get
			{
				return _003CPlacement_003Ek__BackingField;
			}
			set
			{
				_003CPlacement_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Tooltip, {props}, {children})")]
	public extern Tooltip(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(Tooltip source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Tooltip source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
