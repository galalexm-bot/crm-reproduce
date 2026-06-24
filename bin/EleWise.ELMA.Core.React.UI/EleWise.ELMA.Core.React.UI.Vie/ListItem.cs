using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class ListItem
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private bool _003CActive_003Ek__BackingField;

		private bool _003CSelected_003Ek__BackingField;

		[Name("active")]
		public bool Active
		{
			get
			{
				return _003CActive_003Ek__BackingField;
			}
			set
			{
				_003CActive_003Ek__BackingField = value;
			}
		}

		[Name("selected")]
		public bool Selected
		{
			get
			{
				return _003CSelected_003Ek__BackingField;
			}
			set
			{
				_003CSelected_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.ListItem, {props}, {children})")]
	public extern ListItem(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(ListItem source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(ListItem source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
