using System;
using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class TreeNode
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private bool _003CDisabled_003Ek__BackingField;

		private Union<ReactElement, string> _003CTitle_003Ek__BackingField;

		private Func<TreeNode, bool> _003CFilterTreeNode_003Ek__BackingField;

		private bool _003CForceExpand_003Ek__BackingField;

		private bool _003CSelected_003Ek__BackingField;

		private bool _003CUnselectable_003Ek__BackingField;

		private bool _003CIsLeaf_003Ek__BackingField;

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

		[Name("filterTreeNode")]
		public Func<TreeNode, bool> FilterTreeNode
		{
			get
			{
				return _003CFilterTreeNode_003Ek__BackingField;
			}
			set
			{
				_003CFilterTreeNode_003Ek__BackingField = value;
			}
		}

		[Name("forceExpand")]
		public bool ForceExpand
		{
			get
			{
				return _003CForceExpand_003Ek__BackingField;
			}
			set
			{
				_003CForceExpand_003Ek__BackingField = value;
			}
		}

		[Name("selected")]
		public bool Selected
		{
			get
			{
				return _003CSelected_003Ek__BackingField;
			}
			set
			{
				_003CSelected_003Ek__BackingField = value;
			}
		}

		[Name("unselectable")]
		public bool Unselectable
		{
			get
			{
				return _003CUnselectable_003Ek__BackingField;
			}
			set
			{
				_003CUnselectable_003Ek__BackingField = value;
			}
		}

		[Name("isLeaf")]
		public bool IsLeaf
		{
			get
			{
				return _003CIsLeaf_003Ek__BackingField;
			}
			set
			{
				_003CIsLeaf_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.TreeNode, {props}, {children})")]
	public extern TreeNode(Props props, params ReactElement[] children);

	[Template("React.createElement(elmaComponents.TreeNode, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern TreeNode(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(TreeNode source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(TreeNode source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
