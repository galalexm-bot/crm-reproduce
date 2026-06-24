using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views.FormControl;

[External]
public sealed class FormError
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private bool _003CHide_003Ek__BackingField;

		[Name("hide")]
		public bool Hide
		{
			get
			{
				return _003CHide_003Ek__BackingField;
			}
			set
			{
				_003CHide_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.FormError, {props}, {children})")]
	public extern FormError(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.FormError, null, {children})")]
	public extern FormError(params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(FormError source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(FormError source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
