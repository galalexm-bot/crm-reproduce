using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class BreadcrumbItem
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CTo_003Ek__BackingField;

		[Name("to")]
		public string To
		{
			get
			{
				return _003CTo_003Ek__BackingField;
			}
			set
			{
				_003CTo_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.BreadcrumbItem, {props}, {children})")]
	public extern BreadcrumbItem(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(BreadcrumbItem source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(BreadcrumbItem source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
