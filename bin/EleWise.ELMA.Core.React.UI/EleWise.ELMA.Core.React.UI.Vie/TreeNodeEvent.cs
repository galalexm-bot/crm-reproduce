using Bridge;

namespace EleWise.ELMA.Core.React.UI.Views;

[ObjectLiteral]
public sealed class TreeNodeEvent
{
	private string _003CEvent_003Ek__BackingField;

	private TreeNode _003CNode_003Ek__BackingField;

	private bool _003CCheck_003Ek__BackingField;

	private TreeNode[] _003CCheckedNodes_003Ek__BackingField;

	private bool _003CSelected_003Ek__BackingField;

	private TreeNode[] _003CSelectedNodes_003Ek__BackingField;

	[Name("event")]
	public string Event
	{
		get
		{
			return _003CEvent_003Ek__BackingField;
		}
		set
		{
			_003CEvent_003Ek__BackingField = value;
		}
	}

	[Name("node")]
	public TreeNode Node
	{
		get
		{
			return _003CNode_003Ek__BackingField;
		}
		set
		{
			_003CNode_003Ek__BackingField = value;
		}
	}

	[Name("checked")]
	public bool Check
	{
		get
		{
			return _003CCheck_003Ek__BackingField;
		}
		set
		{
			_003CCheck_003Ek__BackingField = value;
		}
	}

	[Name("checkedNodes")]
	public TreeNode[] CheckedNodes
	{
		get
		{
			return _003CCheckedNodes_003Ek__BackingField;
		}
		set
		{
			_003CCheckedNodes_003Ek__BackingField = value;
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

	[Name("selectedNodes")]
	public TreeNode[] SelectedNodes
	{
		get
		{
			return _003CSelectedNodes_003Ek__BackingField;
		}
		set
		{
			_003CSelectedNodes_003Ek__BackingField = value;
		}
	}
}
