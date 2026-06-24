using System;
using System.Collections.Generic;
using Bridge;
using Bridge.Html5;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Scrollbar
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private ScrollbarAxis _003CAxis_003Ek__BackingField;

		private int _003CMaxHeight_003Ek__BackingField;

		private Action<Event<HTMLElement>> _003COnScroll_003Ek__BackingField;

		[Name("axis")]
		public ScrollbarAxis Axis
		{
			get
			{
				return _003CAxis_003Ek__BackingField;
			}
			set
			{
				_003CAxis_003Ek__BackingField = value;
			}
		}

		[Name("maxHeight")]
		public int MaxHeight
		{
			get
			{
				return _003CMaxHeight_003Ek__BackingField;
			}
			set
			{
				_003CMaxHeight_003Ek__BackingField = value;
			}
		}

		[Name("onScroll")]
		public Action<Event<HTMLElement>> OnScroll
		{
			get
			{
				return _003COnScroll_003Ek__BackingField;
			}
			set
			{
				_003COnScroll_003Ek__BackingField = value;
			}
		}
	}

	[Enum(/*Could not decode attribute arguments.*/)]
	[ObjectLiteral]
	public enum ScrollbarAxis
	{
		Default,
		Vertical,
		Horizontal
	}

	[Template("React.createElement(elmaComponents.Scrollbar, {props}, {children})")]
	public extern Scrollbar(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.Scrollbar, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Scrollbar(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(Scrollbar source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Scrollbar source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
