using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Placeholder
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
	}

	[Template("React.createElement(elmaComponents.Placeholder, {props}, {children})")]
	public extern Placeholder(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.Placeholder, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Placeholder(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(Placeholder source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Placeholder source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
