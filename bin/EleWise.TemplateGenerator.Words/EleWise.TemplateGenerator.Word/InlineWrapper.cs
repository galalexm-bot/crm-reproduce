using System.Collections.Generic;
using System.Linq;
using Aspose.Words;

namespace EleWise.TemplateGenerator.Words.Internal;

internal class InlineWrapper : SimpleNode
{
	private const string InlineText = "/*IL*/";

	public override string FullText => "/*IL*/";

	public InlineWrapper(Inline inline, NodeWrapper parent)
		: base((Node)(object)inline, parent)
	{
	}

	public override void RecalcRange()
	{
		base.Stop = base.Start + "/*IL*/".Length;
	}

	public override bool PasteUp(List<NodeWrapper> newWrappers, int pastePosition)
	{
		if (!newWrappers.All((NodeWrapper w) => w is InlineWrapper || w is SimpleNode))
		{
			return base.PasteUp(newWrappers, pastePosition);
		}
		if (pastePosition == base.Start)
		{
			ParagraphWrapper paragraphWrapper = (ParagraphWrapper)base.Parent;
			int num = paragraphWrapper.ChildWrappers.IndexOf(this);
			foreach (NodeWrapper newWrapper in newWrappers)
			{
				paragraphWrapper.InsertChild(num, newWrapper);
				num++;
			}
			return true;
		}
		return base.PasteUp(newWrappers, pastePosition);
	}
}
