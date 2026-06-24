using System;
using System.Collections.Generic;
using Bridge;
using Bridge.Html5;
using Bridge.React;
using EleWise.ELMA.Core.React.UI.Enums;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Drawer
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private Union<ReactElement, string> _003CTitle_003Ek__BackingField;

		private ReactElement _003CFooter_003Ek__BackingField;

		private ComponentPlacement _003CPlacement_003Ek__BackingField;

		private bool _003CMaskClosable_003Ek__BackingField;

		private bool _003CMaskTransparent_003Ek__BackingField;

		private ComponentSize _003CSize_003Ek__BackingField;

		private bool _003CVisible_003Ek__BackingField;

		private bool _003CForceRender_003Ek__BackingField;

		private Action<Union<KeyboardEvent<HTMLDivElement>, MouseEvent<HTMLDivElement>, MouseEvent<HTMLButtonElement>>> _003COnClose_003Ek__BackingField;

		private Union<string, HTMLElement, Func<HTMLElement>, bool> _003CGetContainer_003Ek__BackingField;

		private bool _003CDestroyOnClose_003Ek__BackingField;

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

		[Name("footer")]
		public ReactElement Footer
		{
			get
			{
				return _003CFooter_003Ek__BackingField;
			}
			set
			{
				_003CFooter_003Ek__BackingField = value;
			}
		}

		[Name("placement")]
		public ComponentPlacement Placement
		{
			get
			{
				return _003CPlacement_003Ek__BackingField;
			}
			set
			{
				_003CPlacement_003Ek__BackingField = value;
			}
		}

		[Name("maskClosable")]
		public bool MaskClosable
		{
			get
			{
				return _003CMaskClosable_003Ek__BackingField;
			}
			set
			{
				_003CMaskClosable_003Ek__BackingField = value;
			}
		}

		[Name("maskTransparent")]
		public bool MaskTransparent
		{
			get
			{
				return _003CMaskTransparent_003Ek__BackingField;
			}
			set
			{
				_003CMaskTransparent_003Ek__BackingField = value;
			}
		}

		[Name("size")]
		public ComponentSize Size
		{
			get
			{
				return _003CSize_003Ek__BackingField;
			}
			set
			{
				_003CSize_003Ek__BackingField = value;
			}
		}

		[Name("visible")]
		public bool Visible
		{
			get
			{
				return _003CVisible_003Ek__BackingField;
			}
			set
			{
				_003CVisible_003Ek__BackingField = value;
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

		[Name("onClose")]
		public Action<Union<KeyboardEvent<HTMLDivElement>, MouseEvent<HTMLDivElement>, MouseEvent<HTMLButtonElement>>> OnClose
		{
			get
			{
				return _003COnClose_003Ek__BackingField;
			}
			set
			{
				_003COnClose_003Ek__BackingField = value;
			}
		}

		[Name("getContainer")]
		public Union<string, HTMLElement, Func<HTMLElement>, bool> GetContainer
		{
			get
			{
				return _003CGetContainer_003Ek__BackingField;
			}
			set
			{
				_003CGetContainer_003Ek__BackingField = value;
			}
		}

		[Name("destroyOnClose")]
		public bool DestroyOnClose
		{
			get
			{
				return _003CDestroyOnClose_003Ek__BackingField;
			}
			set
			{
				_003CDestroyOnClose_003Ek__BackingField = value;
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

	[Template("React.createElement(elmaComponents.Drawer, {props}, {children})")]
	public extern Drawer(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.Drawer, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Drawer(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(Drawer source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Drawer source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
