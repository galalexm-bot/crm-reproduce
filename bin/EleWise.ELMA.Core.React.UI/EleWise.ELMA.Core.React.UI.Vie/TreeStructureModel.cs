using System;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[ObjectLiteral]
public class TreeStructureModel
{
	private string _003CKey_003Ek__BackingField;

	private Func<Union<ReactElement, string>> _003CContent_003Ek__BackingField;

	private TreeNodeStructure.NodeType _003CNodeType_003Ek__BackingField;

	private TreeStructureModel[] _003CNodes_003Ek__BackingField;

	[Name("key")]
	public string Key
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

	[Name("content")]
	public Func<Union<ReactElement, string>> Content
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

	[Name("nodeType")]
	public TreeNodeStructure.NodeType NodeType
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

	[Name("nodes")]
	public TreeStructureModel[] Nodes
	{
		get
		{
			return _003CNodes_003Ek__BackingField;
		}
		set
		{
			_003CNodes_003Ek__BackingField = value;
		}
	}
}
