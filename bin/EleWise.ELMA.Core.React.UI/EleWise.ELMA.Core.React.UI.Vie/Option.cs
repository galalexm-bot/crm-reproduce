using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Option
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CValue_003Ek__BackingField;

		private string _003CTitle_003Ek__BackingField;

		private bool _003CDisabled_003Ek__BackingField;

		[Name("value")]
		public string Value
		{
			get
			{
				return _003CValue_003Ek__BackingField;
			}
			set
			{
				_003CValue_003Ek__BackingField = value;
			}
		}

		[Name("title")]
		public string Title
		{
			get
			{
				return _003CTitle_003Ek__BackingField;
			}
			set
			{
				_003CTitle_003Ek__BackingField = value;
			}
		}

		[Name("disabled")]
		public bool Disabled
		{
			get
			{
				return _003CDisabled_003Ek__BackingField;
			}
			set
			{
				_003CDisabled_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Option, {props}, {children})")]
	public extern Option(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(Option source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Option source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
