using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views.FormControl;

[External]
public sealed class FormDescription
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
	}

	[Template("React.createElement(elmaComponents.FormDescription, {props}, {children})")]
	public extern FormDescription(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.FormDescription, null, {children})")]
	public extern FormDescription(params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(FormDescription source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(FormDescription source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
