using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[ObjectLiteral]
public class TreeNodeData
{
	private TreeNodeData[] _003CChildren_003Ek__BackingField;

	private bool _003CDisabled_003Ek__BackingField;

	private bool _003CIsLeaf_003Ek__BackingField;

	private Union<int, string> _003CKey_003Ek__BackingField;

	private Union<ReactElement, string> _003CTitle_003Ek__BackingField;

	private bool _003CSelectable_003Ek__BackingField = true;

	[Name("children")]
	public TreeNodeData[] Children
	{
		get
		{
			return _003CChildren_003Ek__BackingField;
		}
		set
		{
			_003CChildren_003Ek__BackingField = value;
		}
	}

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

	[Name("key")]
	public Union<int, string> Key
	{
		get
		{
			return _003CKey_003Ek__BackingField;
		}
		set
		{
			_003CKey_003Ek__BackingField = value;
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
}
