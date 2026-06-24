using Aspose.Words;

namespace EleWise.TemplateGenerator.Words.Internal;

internal class SimpleNode : NodeWrapper
{
	public override string FullText => "";

	public SimpleNode(Node node, NodeWrapper parent)
		: base(node, parent)
	{
	}

	public override void RecalcRange()
	{
		base.Stop = base.Start;
	}

	public override bool ReplaceText(int start, int stop, string text)
	{
		return false;
	}
}
