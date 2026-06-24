using System;
using Aspose.Words;
using Aspose.Words.Tables;

namespace EleWise.TemplateGenerator.Words.Internal;

internal static class WrapperManager
{
	public static NodeWrapper Create(Node node, NodeWrapper parent)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (((object)node).GetType() == typeof(Document))
		{
			return new DocumentWrapper((Document)node);
		}
		if (((object)node).GetType() == typeof(Paragraph))
		{
			return new ParagraphWrapper((Paragraph)node, parent);
		}
		if (((object)node).GetType() == typeof(Table))
		{
			return new TableWrapper((Table)node, parent);
		}
		if (((object)node).GetType() == typeof(Run))
		{
			return new RunWrapper((Run)node, parent);
		}
		if (node is CompositeNode)
		{
			return new CompositeNodeWrapper((CompositeNode)node, parent);
		}
		if (node is Inline)
		{
			return new InlineWrapper((Inline)node, parent);
		}
		return new SimpleNode(node, parent);
	}
}
