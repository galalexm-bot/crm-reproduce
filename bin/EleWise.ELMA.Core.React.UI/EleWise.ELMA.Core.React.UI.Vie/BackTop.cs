using System;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class BackTop
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private int _003CVisibilityHeight_003Ek__BackingField;

		private Action _003COnClick_003Ek__BackingField;

		[Name("visibilityHeight")]
		public int VisibilityHeight
		{
			get
			{
				return _003CVisibilityHeight_003Ek__BackingField;
			}
			set
			{
				_003CVisibilityHeight_003Ek__BackingField = value;
			}
		}

		[Name("onClick")]
		public Action OnClick
		{
			get
			{
				return _003COnClick_003Ek__BackingField;
			}
			set
			{
				_003COnClick_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.BackTop, {props}, {children})")]
	public extern BackTop(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(BackTop source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(BackTop source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
