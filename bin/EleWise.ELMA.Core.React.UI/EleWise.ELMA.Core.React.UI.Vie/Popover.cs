using System;
using System.Collections.Generic;
using Bridge;
using Bridge.Html5;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Popover
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private Union<ReactElement, string> _003CTitle_003Ek__BackingField;

		private Union<ReactElement, string> _003CContent_003Ek__BackingField;

		private TooltipPlacement _003CPlacement_003Ek__BackingField;

		private bool _003CVisible_003Ek__BackingField;

		private Action<bool> _003COnVisibleChange_003Ek__BackingField;

		private bool _003CDefaultVisible_003Ek__BackingField;

		private PopoverTrigger _003CTrigger_003Ek__BackingField;

		private Func<HTMLElement, HTMLElement> _003CGetPopupContainer_003Ek__BackingField;

		private PopoverSize _003CSize_003Ek__BackingField;

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

		[Name("content")]
		public Union<ReactElement, string> Content
		{
			get
			{
				return _003CContent_003Ek__BackingField;
			}
			set
			{
				_003CContent_003Ek__BackingField = value;
			}
		}

		[Name("placement")]
		public TooltipPlacement Placement
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

		[Name("onVisibleChange")]
		public Action<bool> OnVisibleChange
		{
			get
			{
				return _003COnVisibleChange_003Ek__BackingField;
			}
			set
			{
				_003COnVisibleChange_003Ek__BackingField = value;
			}
		}

		[Name("defaultVisible")]
		public bool DefaultVisible
		{
			get
			{
				return _003CDefaultVisible_003Ek__BackingField;
			}
			set
			{
				_003CDefaultVisible_003Ek__BackingField = value;
			}
		}

		[Name("trigger")]
		public PopoverTrigger Trigger
		{
			get
			{
				return _003CTrigger_003Ek__BackingField;
			}
			set
			{
				_003CTrigger_003Ek__BackingField = value;
			}
		}

		[Name("getPopupContainer")]
		public Func<HTMLElement, HTMLElement> GetPopupContainer
		{
			get
			{
				return _003CGetPopupContainer_003Ek__BackingField;
			}
			set
			{
				_003CGetPopupContainer_003Ek__BackingField = value;
			}
		}

		[Name("size")]
		public PopoverSize Size
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

		public Props()
		{
			Visible = Script.Write<bool>("undefined", new object[0]);
			DefaultVisible = Script.Write<bool>("undefined", new object[0]);
			OnVisibleChange = Script.Write<Action<bool>>("undefined", new object[0]);
		}
	}

	[Template("React.createElement(elmaComponents.Popover, {props}, {children})")]
	public extern Popover(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.Popover, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Popover(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(Popover source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Popover source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
