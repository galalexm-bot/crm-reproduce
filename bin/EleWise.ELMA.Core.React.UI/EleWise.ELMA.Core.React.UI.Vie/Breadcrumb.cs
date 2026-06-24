using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Breadcrumb
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private Union<ReactElement, string> _003CSeparator_003Ek__BackingField;

		[Name("separator")]
		public Union<ReactElement, string> Separator
		{
			get
			{
				return _003CSeparator_003Ek__BackingField;
			}
			set
			{
				_003CSeparator_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Breadcrumb, {props}, {children})")]
	public extern Breadcrumb(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.Breadcrumb, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Breadcrumb(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(Breadcrumb source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Breadcrumb source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
