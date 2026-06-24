using System;
using System.Collections.Generic;
using Bridge;
using Bridge.Html5;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class TreeNodeStructure
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private Union<ReactElement, string> _003CImg_003Ek__BackingField;

		private Union<ReactElement, string> _003CTitle_003Ek__BackingField;

		private Union<ReactElement, string> _003CAttachment_003Ek__BackingField;

		private Func<Union<ReactElement, string>> _003CContentImportant_003Ek__BackingField;

		private NodeType _003CNodeType_003Ek__BackingField;

		private Union<ReactElement, string> _003CPopoverContent_003Ek__BackingField;

		private string _003CParentKey_003Ek__BackingField;

		private bool _003CAutoFocus_003Ek__BackingField;

		private Action<FormEvent<HTMLInputElement>> _003COnClick_003Ek__BackingField;

		[Name("img")]
		public Union<ReactElement, string> Img
		{
			get
			{
				return _003CImg_003Ek__BackingField;
			}
			set
			{
				_003CImg_003Ek__BackingField = value;
			}
		}

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

		[Name("attachment")]
		public Union<ReactElement, string> Attachment
		{
			get
			{
				return _003CAttachment_003Ek__BackingField;
			}
			set
			{
				_003CAttachment_003Ek__BackingField = value;
			}
		}

		[Name("contentImportant")]
		public Func<Union<ReactElement, string>> ContentImportant
		{
			get
			{
				return _003CContentImportant_003Ek__BackingField;
			}
			set
			{
				_003CContentImportant_003Ek__BackingField = value;
			}
		}

		[Name("nodeType")]
		public NodeType NodeType
		{
			get
			{
				return _003CNodeType_003Ek__BackingField;
			}
			set
			{
				_003CNodeType_003Ek__BackingField = value;
			}
		}

		[Name("popoverContent")]
		public Union<ReactElement, string> PopoverContent
		{
			get
			{
				return _003CPopoverContent_003Ek__BackingField;
			}
			set
			{
				_003CPopoverContent_003Ek__BackingField = value;
			}
		}

		[Name("parentKey")]
		public string ParentKey
		{
			get
			{
				return _003CParentKey_003Ek__BackingField;
			}
			set
			{
				_003CParentKey_003Ek__BackingField = value;
			}
		}

		[Name("autoFocus")]
		public bool AutoFocus
		{
			get
			{
				return _003CAutoFocus_003Ek__BackingField;
			}
			set
			{
				_003CAutoFocus_003Ek__BackingField = value;
			}
		}

		[Name("onClick")]
		public Action<FormEvent<HTMLInputElement>> OnClick
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

	[Enum(/*Could not decode attribute arguments.*/)]
	[ObjectLiteral]
	public enum NodeType
	{
		Horizontal,
		Vertical
	}

	[Template("React.createElement(elmaComponents.TreeNodeStructure, {props}, {children})")]
	public extern TreeNodeStructure(Props props, params TreeNodeStructure[] children);

	[Template("React.createElement(elmaComponents.TreeNodeStructure, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern TreeNodeStructure(Props props, global::System.Collections.Generic.IEnumerable<TreeNodeStructure> children);

	public static implicit operator ReactElement(TreeNodeStructure source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(TreeNodeStructure source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
