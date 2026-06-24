using Bridge;
using Bridge.React;
using EleWise.ELMA.Core.React.UI.Enums;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Sidebar
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private SidebarPlacement _003CPlacement_003Ek__BackingField;

		[Name("placement")]
		public SidebarPlacement Placement
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

	[Template("React.createElement(elmaComponents.Sidebar, {props}, {children})")]
	public extern Sidebar(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(Sidebar source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Sidebar source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
