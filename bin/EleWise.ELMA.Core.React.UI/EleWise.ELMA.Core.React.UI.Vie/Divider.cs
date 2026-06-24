using System.Collections.Generic;
using Bridge;
using Bridge.React;
using EleWise.ELMA.Core.React.UI.Enums;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Divider
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private DirectionType _003CDirection_003Ek__BackingField;

		[Name("direction")]
		public DirectionType Direction
		{
			get
			{
				return _003CDirection_003Ek__BackingField;
			}
			set
			{
				_003CDirection_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Divider, {props}, {children})")]
	public extern Divider(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.Divider, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Divider(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	[Template("React.createElement(elmaComponents.Divider, null, {children})")]
	public extern Divider(params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.Divider, null, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Divider(global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(Divider source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Divider source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
