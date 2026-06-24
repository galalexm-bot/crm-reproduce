using System;
using System.Collections.Generic;
using Bridge;
using Bridge.Html5;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class ContentNavigationNode
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private Union<ReactElement, string> _003CTitle_003Ek__BackingField;

		private bool _003CMultiLineTitle_003Ek__BackingField;

		private bool _003CAnimate_003Ek__BackingField;

		private bool _003CForceRender_003Ek__BackingField;

		private bool _003CFixedHeight_003Ek__BackingField;

		private Action<MouseEvent<HTMLElement>> _003COnMouseEnter_003Ek__BackingField;

		private Action<MouseEvent<HTMLElement>> _003COnMouseLeave_003Ek__BackingField;

		private Action<KeyboardEvent<HTMLElement>> _003COnKeyDown_003Ek__BackingField;

		[Name("title")]
		public Union<ReactElement, string> Title
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

		[Name("multiLineTitle")]
		public bool MultiLineTitle
		{
			get
			{
				return _003CMultiLineTitle_003Ek__BackingField;
			}
			set
			{
				_003CMultiLineTitle_003Ek__BackingField = value;
			}
		}

		[Name("animate")]
		public bool Animate
		{
			get
			{
				return _003CAnimate_003Ek__BackingField;
			}
			set
			{
				_003CAnimate_003Ek__BackingField = value;
			}
		}

		[Name("forceRender")]
		public bool ForceRender
		{
			get
			{
				return _003CForceRender_003Ek__BackingField;
			}
			set
			{
				_003CForceRender_003Ek__BackingField = value;
			}
		}

		[Name("fixedHeight")]
		public bool FixedHeight
		{
			get
			{
				return _003CFixedHeight_003Ek__BackingField;
			}
			set
			{
				_003CFixedHeight_003Ek__BackingField = value;
			}
		}

		[Name("onMouseEnter")]
		public Action<MouseEvent<HTMLElement>> OnMouseEnter
		{
			get
			{
				return _003COnMouseEnter_003Ek__BackingField;
			}
			set
			{
				_003COnMouseEnter_003Ek__BackingField = value;
			}
		}

		[Name("onMouseLeave")]
		public Action<MouseEvent<HTMLElement>> OnMouseLeave
		{
			get
			{
				return _003COnMouseLeave_003Ek__BackingField;
			}
			set
			{
				_003COnMouseLeave_003Ek__BackingField = value;
			}
		}

		[Name("onKeyDown")]
		public Action<KeyboardEvent<HTMLElement>> OnKeyDown
		{
			get
			{
				return _003COnKeyDown_003Ek__BackingField;
			}
			set
			{
				_003COnKeyDown_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.ContentNavigationNode, {props}, {children})")]
	public extern ContentNavigationNode(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.ContentNavigationNode, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern ContentNavigationNode(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(ContentNavigationNode source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(ContentNavigationNode source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
