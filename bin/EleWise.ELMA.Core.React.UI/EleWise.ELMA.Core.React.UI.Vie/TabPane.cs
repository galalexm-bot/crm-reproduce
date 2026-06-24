using System;
using System.Collections.Generic;
using Bridge;
using Bridge.Html5;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class TabPane
{
	[ObjectLiteral]
	public class Props : BaseProps
	{
		private TabType _003CType_003Ek__BackingField;

		private Union<ReactElement, string> _003CTab_003Ek__BackingField;

		private bool _003CDisabled_003Ek__BackingField;

		private bool _003CForceRender_003Ek__BackingField;

		private bool _003CClosable_003Ek__BackingField;

		private bool _003CFixedHeight_003Ek__BackingField;

		private Action<MouseEvent<HTMLElement>> _003COnMouseEnter_003Ek__BackingField;

		private Action<MouseEvent<HTMLElement>> _003COnMouseLeave_003Ek__BackingField;

		private Action<KeyboardEvent<HTMLElement>> _003COnKeyDown_003Ek__BackingField;

		[Name("type")]
		public TabType Type
		{
			get
			{
				return _003CType_003Ek__BackingField;
			}
			set
			{
				_003CType_003Ek__BackingField = value;
			}
		}

		[Name("tab")]
		public Union<ReactElement, string> Tab
		{
			get
			{
				return _003CTab_003Ek__BackingField;
			}
			set
			{
				_003CTab_003Ek__BackingField = value;
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

		[Name("closable")]
		public bool Closable
		{
			get
			{
				return _003CClosable_003Ek__BackingField;
			}
			set
			{
				_003CClosable_003Ek__BackingField = value;
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

	[ObjectLiteral]
	[Enum(/*Could not decode attribute arguments.*/)]
	public enum TabType
	{
		Static,
		Dynamic
	}

	[Template("React.createElement(elmaComponents.TabPane, {props}, {children})")]
	public extern TabPane(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.TabPane, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern TabPane(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(TabPane source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(TabPane source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
