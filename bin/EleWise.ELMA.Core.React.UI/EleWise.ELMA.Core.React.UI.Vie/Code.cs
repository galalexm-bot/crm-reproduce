using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Code
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private bool _003CShowLineNumbers_003Ek__BackingField;

		private string _003CLanguage_003Ek__BackingField;

		[Name("showLineNumbers")]
		public bool ShowLineNumbers
		{
			get
			{
				return _003CShowLineNumbers_003Ek__BackingField;
			}
			set
			{
				_003CShowLineNumbers_003Ek__BackingField = value;
			}
		}

		[Name("language")]
		public string Language
		{
			get
			{
				return _003CLanguage_003Ek__BackingField;
			}
			set
			{
				_003CLanguage_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Code, {props}, {children})")]
	public extern Code(Props props, params string[] children);

	public static implicit operator ReactElement(Code source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Code source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
