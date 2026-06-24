using System;
using System.Collections.Generic;
using Bridge;
using Bridge.Html5;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Row
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private int _003CHeight_003Ek__BackingField;

		private int _003CGutter_003Ek__BackingField;

		private RowType? _003CType_003Ek__BackingField;

		private RowAlign _003CAlign_003Ek__BackingField;

		private RowJustify _003CJustify_003Ek__BackingField;

		private RowContainerType _003CContainerType_003Ek__BackingField;

		private Action<MouseEvent<HTMLElement>> _003COnMouseEnter_003Ek__BackingField;

		private Action<MouseEvent<HTMLElement>> _003COnMouseLeave_003Ek__BackingField;

		private Action<KeyboardEvent<HTMLElement>> _003COnKeyDown_003Ek__BackingField;

		[Name("height")]
		public int Height
		{
			get
			{
				return _003CHeight_003Ek__BackingField;
			}
			set
			{
				_003CHeight_003Ek__BackingField = value;
			}
		}

		[Name("gutter")]
		public int Gutter
		{
			get
			{
				return _003CGutter_003Ek__BackingField;
			}
			set
			{
				_003CGutter_003Ek__BackingField = value;
			}
		}

		[Name("type")]
		public RowType? Type
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

		[Name("align")]
		public RowAlign Align
		{
			get
			{
				return _003CAlign_003Ek__BackingField;
			}
			set
			{
				_003CAlign_003Ek__BackingField = value;
			}
		}

		[Name("justify")]
		public RowJustify Justify
		{
			get
			{
				return _003CJustify_003Ek__BackingField;
			}
			set
			{
				_003CJustify_003Ek__BackingField = value;
			}
		}

		[Name("containerType")]
		public RowContainerType ContainerType
		{
			get
			{
				return _003CContainerType_003Ek__BackingField;
			}
			set
			{
				_003CContainerType_003Ek__BackingField = value;
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

	[Template("React.createElement(elmaComponents.Row, {props}, {children})")]
	public extern Row(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.Row, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Row(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(Row source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Row source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
