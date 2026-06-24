using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class InputGroup
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
	}

	[Template("React.createElement(elmaComponents.InputGroup, {props}, {children})")]
	public extern InputGroup(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.InputGroup, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern InputGroup(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(InputGroup source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(InputGroup source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
