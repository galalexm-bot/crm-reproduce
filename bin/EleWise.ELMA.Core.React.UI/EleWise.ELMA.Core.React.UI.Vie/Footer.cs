using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Footer
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
	}

	[Template("React.createElement(elmaComponents.Footer, {props}, {children})")]
	public extern Footer(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(Footer source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Footer source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
