using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Fullscreen
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private bool _003CFullscreen_003Ek__BackingField;

		[Name("fullscreen")]
		public bool Fullscreen
		{
			get
			{
				return _003CFullscreen_003Ek__BackingField;
			}
			set
			{
				_003CFullscreen_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Fullscreen, {props}, {children})")]
	public extern Fullscreen(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(Fullscreen source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Fullscreen source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
