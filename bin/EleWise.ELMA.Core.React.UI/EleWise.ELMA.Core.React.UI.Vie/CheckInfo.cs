using Bridge;

namespace EleWise.ELMA.Core.React.UI.Views;

[ObjectLiteral]
public class CheckInfo
{
	private bool _003Cchecked_003Ek__BackingField;

	private TreeNodeItem _003CNode_003Ek__BackingField;

	[Name("checked")]
	public bool @checked
	{
		get
		{
			return _003Cchecked_003Ek__BackingField;
		}
		set
		{
			_003Cchecked_003Ek__BackingField = value;
		}
	}

	[Name("node")]
	public TreeNodeItem Node
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
}
