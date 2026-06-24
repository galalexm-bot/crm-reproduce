using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Radio
{
	[ObjectLiteral]
	public sealed class Props : AbstractCheckboxProps<RadioChangeEvent>
	{
	}

	[Template("React.createElement(elmaComponents.Radio, {props}, {children})")]
	public extern Radio(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(Radio source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Radio source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
