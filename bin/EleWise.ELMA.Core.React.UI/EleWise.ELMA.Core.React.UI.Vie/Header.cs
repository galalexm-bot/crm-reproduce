using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Header
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
	}

	[Template("React.createElement(elmaComponents.Header, {props}, {children})")]
	public extern Header(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(Header source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Header source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
