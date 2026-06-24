using System;
using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Console
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private bool _003CShow_003Ek__BackingField;

		private ConsoleListItem[] _003CData_003Ek__BackingField;

		private ConsoleSort _003CSort_003Ek__BackingField;

		private Action<ConsoleEvent> _003COnAction_003Ek__BackingField;

		private Action<ConsoleType, string> _003COpenModal_003Ek__BackingField;

		[Name("show")]
		public bool Show
		{
			get
			{
				return _003CShow_003Ek__BackingField;
			}
			set
			{
				_003CShow_003Ek__BackingField = value;
			}
		}

		[Name("data")]
		public ConsoleListItem[] Data
		{
			get
			{
				return _003CData_003Ek__BackingField;
			}
			set
			{
				_003CData_003Ek__BackingField = value;
			}
		}

		[Name("sort")]
		public ConsoleSort Sort
		{
			get
			{
				return _003CSort_003Ek__BackingField;
			}
			set
			{
				_003CSort_003Ek__BackingField = value;
			}
		}

		[Name("onAction")]
		public Action<ConsoleEvent> OnAction
		{
			get
			{
				return _003COnAction_003Ek__BackingField;
			}
			set
			{
				_003COnAction_003Ek__BackingField = value;
			}
		}

		[Name("openModal")]
		public Action<ConsoleType, string> OpenModal
		{
			get
			{
				return _003COpenModal_003Ek__BackingField;
			}
			set
			{
				_003COpenModal_003Ek__BackingField = value;
			}
		}
	}

	[ObjectLiteral]
	public sealed class ConsoleListItem
	{
		private string _003CId_003Ek__BackingField;

		private ConsoleType _003CType_003Ek__BackingField;

		private string _003CContent_003Ek__BackingField;

		private Action<object> _003COnClick_003Ek__BackingField;

		[Name("id")]
		public string Id
		{
			get
			{
				return _003CId_003Ek__BackingField;
			}
			set
			{
				_003CId_003Ek__BackingField = value;
			}
		}

		[Name("type")]
		public ConsoleType Type
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

		[Name("content")]
		public string Content
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

		[Name("onClick")]
		public Action<object> OnClick
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

	[ObjectLiteral]
	public sealed class ConsoleEvent
	{
		private ConsoleAction _003CAction_003Ek__BackingField;

		[Name("action")]
		public ConsoleAction Action
		{
			get
			{
				return _003CAction_003Ek__BackingField;
			}
			set
			{
				_003CAction_003Ek__BackingField = value;
			}
		}
	}

	[Enum(/*Could not decode attribute arguments.*/)]
	[ObjectLiteral]
	public enum ConsoleType
	{
		Info,
		Error,
		Warning
	}

	[ObjectLiteral]
	[Enum(/*Could not decode attribute arguments.*/)]
	public enum ConsoleAction
	{
		Show,
		Close,
		Clear
	}

	[Enum(/*Could not decode attribute arguments.*/)]
	[ObjectLiteral]
	public enum ConsoleSort
	{
		Asc,
		Desc
	}

	[Template("React.createElement(elmaComponents.Console, {props}, {children})")]
	public extern Console(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.Console, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Console(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(Console source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Console source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
