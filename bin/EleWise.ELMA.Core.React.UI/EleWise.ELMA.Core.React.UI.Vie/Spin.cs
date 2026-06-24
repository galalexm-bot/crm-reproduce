using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Spin
{
	[ObjectLiteral]
	public sealed class Props : SpinProps
	{
	}

	[Template("React.createElement(elmaComponents.Spin, {props}, {children})")]
	public extern Spin(Props props, params ReactElement[] children);

	public static implicit operator ReactElement(Spin source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Spin source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
