using Bridge;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Spinner
{
	[ObjectLiteral]
	public sealed class Props : SpinProps
	{
	}

	[Template("new elmaComponents.Spinner({options})")]
	public extern Spinner(Props options);

	[Name("show")]
	public extern void Show(string key, bool permanent = false);

	[Name("hide")]
	public extern void Hide(string key);
}
