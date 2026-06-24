using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Col
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private int _003CSpan_003Ek__BackingField;

		private int _003COrder_003Ek__BackingField;

		private int _003COffset_003Ek__BackingField;

		private int _003CPush_003Ek__BackingField;

		private int _003CPull_003Ek__BackingField;

		private int _003CSm_003Ek__BackingField;

		private int _003CMd_003Ek__BackingField;

		private int _003CLg_003Ek__BackingField;

		private int _003CXl_003Ek__BackingField;

		private bool _003CHide_003Ek__BackingField;

		private ColumnSize _003CSize_003Ek__BackingField;

		[Name("span")]
		public int Span
		{
			get
			{
				return _003CSpan_003Ek__BackingField;
			}
			set
			{
				_003CSpan_003Ek__BackingField = value;
			}
		}

		[Name("order")]
		public int Order
		{
			get
			{
				return _003COrder_003Ek__BackingField;
			}
			set
			{
				_003COrder_003Ek__BackingField = value;
			}
		}

		[Name("offset")]
		public int Offset
		{
			get
			{
				return _003COffset_003Ek__BackingField;
			}
			set
			{
				_003COffset_003Ek__BackingField = value;
			}
		}

		[Name("push")]
		public int Push
		{
			get
			{
				return _003CPush_003Ek__BackingField;
			}
			set
			{
				_003CPush_003Ek__BackingField = value;
			}
		}

		[Name("pull")]
		public int Pull
		{
			get
			{
				return _003CPull_003Ek__BackingField;
			}
			set
			{
				_003CPull_003Ek__BackingField = value;
			}
		}

		[Name("sm")]
		public int Sm
		{
			get
			{
				return _003CSm_003Ek__BackingField;
			}
			set
			{
				_003CSm_003Ek__BackingField = value;
			}
		}

		[Name("md")]
		public int Md
		{
			get
			{
				return _003CMd_003Ek__BackingField;
			}
			set
			{
				_003CMd_003Ek__BackingField = value;
			}
		}

		[Name("lg")]
		public int Lg
		{
			get
			{
				return _003CLg_003Ek__BackingField;
			}
			set
			{
				_003CLg_003Ek__BackingField = value;
			}
		}

		[Name("xl")]
		public int Xl
		{
			get
			{
				return _003CXl_003Ek__BackingField;
			}
			set
			{
				_003CXl_003Ek__BackingField = value;
			}
		}

		[Name("hide")]
		public bool Hide
		{
			get
			{
				return _003CHide_003Ek__BackingField;
			}
			set
			{
				_003CHide_003Ek__BackingField = value;
			}
		}

		[Name("size")]
		public ColumnSize Size
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
	}

	[Enum(/*Could not decode attribute arguments.*/)]
	[ObjectLiteral]
	public enum ColumnSize
	{
		Quarter,
		OneThird,
		OneHalth,
		Auto
	}

	[Template("React.createElement(elmaComponents.Col, {props}, {children})")]
	public extern Col(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.Col, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Col(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(Col source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Col source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
