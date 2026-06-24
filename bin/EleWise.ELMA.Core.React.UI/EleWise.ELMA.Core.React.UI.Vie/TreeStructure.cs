using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class TreeStructure
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private TreeStructureModel _003CNode_003Ek__BackingField;

		[Name("node")]
		public TreeStructureModel Node
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

	[Template("React.createElement(elmaComponents.TreeStructure, {props})")]
	public extern TreeStructure(Props props);

	public static implicit operator ReactElement(TreeStructure source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(TreeStructure source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
