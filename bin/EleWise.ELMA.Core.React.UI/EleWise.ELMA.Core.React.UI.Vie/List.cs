using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class List
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string[] _003CSelectedKeys_003Ek__BackingField;

		private ListType _003CType_003Ek__BackingField;

		[Name("selectedKeys")]
		public string[] SelectedKeys
		{
			get
			{
				return _003CSelectedKeys_003Ek__BackingField;
			}
			set
			{
				_003CSelectedKeys_003Ek__BackingField = value;
			}
		}

		[Name("type")]
		public ListType Type
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
	}

	[Enum(/*Could not decode attribute arguments.*/)]
	[ObjectLiteral]
	public enum ListType
	{
		Default,
		Ol,
		Unmarked,
		Bordered
	}

	[Template("React.createElement(elmaComponents.List, {props}, {children})")]
	public extern List(Props props, params ReactElement[] children);

	[Template("React.createElement(elmaComponents.List, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern List(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(List source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(List source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
