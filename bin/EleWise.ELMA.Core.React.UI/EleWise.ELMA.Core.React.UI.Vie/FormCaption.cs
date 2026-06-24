using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views.FormControl;

[External]
public sealed class FormCaption
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private bool _003CIsRequired_003Ek__BackingField;

		[Name("isRequired")]
		public bool IsRequired
		{
			get
			{
				return _003CIsRequired_003Ek__BackingField;
			}
			set
			{
				_003CIsRequired_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.FormCaption, {props}, {children})")]
	public extern FormCaption(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.FormCaption, null, {children})")]
	public extern FormCaption(params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(FormCaption source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(FormCaption source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
