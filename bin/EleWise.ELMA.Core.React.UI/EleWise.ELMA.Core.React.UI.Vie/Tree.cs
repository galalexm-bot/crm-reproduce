using System;
using System.Threading.Tasks;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Tree
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private bool _003CMultiple_003Ek__BackingField;

		private bool _003CAutoExpandParent_003Ek__BackingField;

		private bool _003CCheckable_003Ek__BackingField;

		private bool _003CDefaultExpandAll_003Ek__BackingField;

		private string[] _003CDefaultExpandedKeys_003Ek__BackingField;

		private string[] _003CExpandedKeys_003Ek__BackingField;

		private string[] _003CCheckedKeys_003Ek__BackingField;

		private string[] _003CDefaultCheckedKeys_003Ek__BackingField;

		private string[] _003CSelectedKeys_003Ek__BackingField;

		private bool _003CSelectable_003Ek__BackingField;

		private string[] _003CDefaultSelectedKeys_003Ek__BackingField;

		private TreeType _003CType_003Ek__BackingField;

		private TreeSize _003CSize_003Ek__BackingField;

		private Action _003CExpandAll_003Ek__BackingField;

		private Action _003CCollapseAll_003Ek__BackingField;

		private Action<string[], string, bool> _003COnExpand_003Ek__BackingField;

		private Action<string[], CheckInfo> _003COnCheck_003Ek__BackingField;

		private Action<string[], TreeNodeEvent> _003COnSelect_003Ek__BackingField;

		private Func<TreeNode, global::System.Threading.Tasks.Task> _003CLoadData_003Ek__BackingField;

		private Func<TreeNode, bool> _003CFilterTreeNode_003Ek__BackingField;

		private bool _003CDraggable_003Ek__BackingField;

		private Action<DropEvent> _003COnDrop_003Ek__BackingField;

		private bool _003CShowTreeButtons_003Ek__BackingField;

		private TreeNodeData[] _003CTreeData_003Ek__BackingField;

		[Name("multiple")]
		public bool Multiple
		{
			get
			{
				return _003CMultiple_003Ek__BackingField;
			}
			set
			{
				_003CMultiple_003Ek__BackingField = value;
			}
		}

		[Name("autoExpandParent")]
		public bool AutoExpandParent
		{
			get
			{
				return _003CAutoExpandParent_003Ek__BackingField;
			}
			set
			{
				_003CAutoExpandParent_003Ek__BackingField = value;
			}
		}

		[Name("checkable")]
		public bool Checkable
		{
			get
			{
				return _003CCheckable_003Ek__BackingField;
			}
			set
			{
				_003CCheckable_003Ek__BackingField = value;
			}
		}

		[Name("defaultExpandAll")]
		public bool DefaultExpandAll
		{
			get
			{
				return _003CDefaultExpandAll_003Ek__BackingField;
			}
			set
			{
				_003CDefaultExpandAll_003Ek__BackingField = value;
			}
		}

		[Name("defaultExpandedKeys")]
		public string[] DefaultExpandedKeys
		{
			get
			{
				return _003CDefaultExpandedKeys_003Ek__BackingField;
			}
			set
			{
				_003CDefaultExpandedKeys_003Ek__BackingField = value;
			}
		}

		[Name("expandedKeys")]
		public string[] ExpandedKeys
		{
			get
			{
				return _003CExpandedKeys_003Ek__BackingField;
			}
			set
			{
				_003CExpandedKeys_003Ek__BackingField = value;
			}
		}

		[Name("checkedKeys")]
		public string[] CheckedKeys
		{
			get
			{
				return _003CCheckedKeys_003Ek__BackingField;
			}
			set
			{
				_003CCheckedKeys_003Ek__BackingField = value;
			}
		}

		[Name("defaultCheckedKeys")]
		public string[] DefaultCheckedKeys
		{
			get
			{
				return _003CDefaultCheckedKeys_003Ek__BackingField;
			}
			set
			{
				_003CDefaultCheckedKeys_003Ek__BackingField = value;
			}
		}

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

		[Name("selectable")]
		public bool Selectable
		{
			get
			{
				return _003CSelectable_003Ek__BackingField;
			}
			set
			{
				_003CSelectable_003Ek__BackingField = value;
			}
		}

		[Name("defaultSelectedKeys")]
		public string[] DefaultSelectedKeys
		{
			get
			{
				return _003CDefaultSelectedKeys_003Ek__BackingField;
			}
			set
			{
				_003CDefaultSelectedKeys_003Ek__BackingField = value;
			}
		}

		[Name("type")]
		public TreeType Type
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

		[Name("treeSize")]
		public TreeSize Size
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

		[Name("expandAll")]
		public Action ExpandAll
		{
			get
			{
				return _003CExpandAll_003Ek__BackingField;
			}
			set
			{
				_003CExpandAll_003Ek__BackingField = value;
			}
		}

		[Name("collapseAll")]
		public Action CollapseAll
		{
			get
			{
				return _003CCollapseAll_003Ek__BackingField;
			}
			set
			{
				_003CCollapseAll_003Ek__BackingField = value;
			}
		}

		[Name("onExpand")]
		public Action<string[], string, bool> OnExpand
		{
			get
			{
				return _003COnExpand_003Ek__BackingField;
			}
			set
			{
				_003COnExpand_003Ek__BackingField = value;
			}
		}

		[Name("onCheck")]
		public Action<string[], CheckInfo> OnCheck
		{
			get
			{
				return _003COnCheck_003Ek__BackingField;
			}
			set
			{
				_003COnCheck_003Ek__BackingField = value;
			}
		}

		[Name("onSelect")]
		public Action<string[], TreeNodeEvent> OnSelect
		{
			get
			{
				return _003COnSelect_003Ek__BackingField;
			}
			set
			{
				_003COnSelect_003Ek__BackingField = value;
			}
		}

		[Name("loadData")]
		public Func<TreeNode, global::System.Threading.Tasks.Task> LoadData
		{
			get
			{
				return _003CLoadData_003Ek__BackingField;
			}
			set
			{
				_003CLoadData_003Ek__BackingField = value;
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

		[Name("draggable")]
		public bool Draggable
		{
			get
			{
				return _003CDraggable_003Ek__BackingField;
			}
			set
			{
				_003CDraggable_003Ek__BackingField = value;
			}
		}

		[Name("onDrop")]
		public Action<DropEvent> OnDrop
		{
			get
			{
				return _003COnDrop_003Ek__BackingField;
			}
			set
			{
				_003COnDrop_003Ek__BackingField = value;
			}
		}

		[Name("showTreeButtons")]
		public bool ShowTreeButtons
		{
			get
			{
				return _003CShowTreeButtons_003Ek__BackingField;
			}
			set
			{
				_003CShowTreeButtons_003Ek__BackingField = value;
			}
		}

		[Name("treeData")]
		public TreeNodeData[] TreeData
		{
			get
			{
				return _003CTreeData_003Ek__BackingField;
			}
			set
			{
				_003CTreeData_003Ek__BackingField = value;
			}
		}
	}

	[Enum(/*Could not decode attribute arguments.*/)]
	[ObjectLiteral]
	public enum DropType
	{
		Before,
		Inner,
		After
	}

	[ObjectLiteral]
	public class DropEvent
	{
		private readonly string _003CTargetKey_003Ek__BackingField;

		private readonly string _003CDropKey_003Ek__BackingField;

		private readonly DropType _003CDropType_003Ek__BackingField;

		[Name("targetKey")]
		public string TargetKey => _003CTargetKey_003Ek__BackingField;

		[Name("dropKey")]
		public string DropKey => _003CDropKey_003Ek__BackingField;

		[Name("dropType")]
		public DropType DropType => _003CDropType_003Ek__BackingField;
	}

	[Template("React.createElement(elmaComponents.Tree, {props})")]
	public extern Tree(Props props);

	public static implicit operator ReactElement(Tree source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Tree source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
