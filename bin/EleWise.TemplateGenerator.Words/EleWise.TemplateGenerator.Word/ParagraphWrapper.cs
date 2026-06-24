using System;
using System.Collections.Generic;
using System.Linq;
using Aspose.Words;

namespace EleWise.TemplateGenerator.Words.Internal;

internal class ParagraphWrapper : CompositeNodeWrapper
{
	public ParagraphWrapper(Paragraph par, NodeWrapper parent)
		: base((CompositeNode)(object)par, parent)
	{
	}

	public override bool PasteUp(List<NodeWrapper> newWrappers, int pastePosition)
	{
		if (newWrappers.All((NodeWrapper w) => w is ParagraphWrapper || w is TableWrapper))
		{
			return PasteUpParagraphs(newWrappers, pastePosition);
		}
		if (newWrappers.All((NodeWrapper w) => w is InlineWrapper || w is SimpleNode || w is ShapeWrapper))
		{
			return PasteUpInlines(newWrappers, pastePosition);
		}
		return base.PasteUp(newWrappers, pastePosition);
	}

	private bool PasteUpParagraphs(List<NodeWrapper> newWrappers, int pastePosition)
	{
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		if (pastePosition == base.Start)
		{
			CompositeNodeWrapper compositeNodeWrapper = (CompositeNodeWrapper)base.Parent;
			int num = compositeNodeWrapper.ChildWrappers.IndexOf(this);
			foreach (NodeWrapper newWrapper in newWrappers)
			{
				compositeNodeWrapper.InsertChild(num, newWrapper);
				num++;
			}
			return true;
		}
		int i;
		for (i = 0; i < base.ChildWrappers.Count && base.ChildWrappers[i].Stop <= pastePosition; i++)
		{
		}
		if (i < base.ChildWrappers.Count)
		{
			ParagraphWrapper paragraphWrapper;
			if (base.ChildWrappers[i].Start == pastePosition)
			{
				paragraphWrapper = (ParagraphWrapper)Clone(base.Parent, isCloneChildren: false);
				List<NodeWrapper> list = base.ChildWrappers.ToList();
				for (int j = i; j < list.Count; j++)
				{
					NodeWrapper w = list[j].Clone(paragraphWrapper, isCloneChildren: true);
					paragraphWrapper.AddChild(w);
					RemoveChild(list[j]);
				}
			}
			else
			{
				if (((object)base.ChildWrappers[i].Node).GetType() != typeof(Run))
				{
					throw new InvalidOperationException("Cannot split element of type " + ((object)base.ChildWrappers[i].Node).GetType().FullName);
				}
				paragraphWrapper = (ParagraphWrapper)Clone(base.Parent, isCloneChildren: false);
				List<NodeWrapper> list2 = base.ChildWrappers.ToList();
				for (int k = i; k < list2.Count; k++)
				{
					NodeWrapper nodeWrapper = list2[k].Clone(paragraphWrapper, isCloneChildren: true);
					paragraphWrapper.AddChild(nodeWrapper);
					if (k == i)
					{
						Run val = (Run)list2[k].Node;
						Run val2 = (Run)nodeWrapper.Node;
						string text = val.get_Text();
						val.set_Text(text.Substring(0, pastePosition - list2[k].Start));
						val2.set_Text(text.Substring(pastePosition - list2[k].Start));
					}
					else
					{
						RemoveChild(list2[k]);
					}
				}
			}
			CompositeNodeWrapper compositeNodeWrapper2 = (CompositeNodeWrapper)base.Parent;
			int num2 = compositeNodeWrapper2.ChildWrappers.IndexOf(this) + 1;
			foreach (NodeWrapper newWrapper2 in newWrappers)
			{
				compositeNodeWrapper2.InsertChild(num2, newWrapper2);
				num2++;
			}
			compositeNodeWrapper2.InsertChild(num2, paragraphWrapper);
			return true;
		}
		return false;
	}

	private bool PasteUpInlines(List<NodeWrapper> newWrappers, int pastePosition)
	{
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		int i;
		for (i = 0; i < base.ChildWrappers.Count && base.ChildWrappers[i].Stop <= pastePosition; i++)
		{
		}
		if (i < base.ChildWrappers.Count)
		{
			NodeWrapper nodeWrapper = base.ChildWrappers[i];
			if (nodeWrapper.Start == pastePosition)
			{
				foreach (NodeWrapper newWrapper in newWrappers)
				{
					InsertChild(i, newWrapper);
					i++;
				}
			}
			else
			{
				if (((object)nodeWrapper.Node).GetType() != typeof(Run))
				{
					throw new InvalidOperationException("Cannot split element of type " + ((object)base.ChildWrappers[i].Node).GetType().FullName);
				}
				NodeWrapper nodeWrapper2 = base.ChildWrappers[i].Clone(this, isCloneChildren: true);
				Run val = (Run)base.ChildWrappers[i].Node;
				Run val2 = (Run)nodeWrapper2.Node;
				string text = val.get_Text();
				val.set_Text(text.Substring(0, pastePosition - nodeWrapper.Start));
				val2.set_Text(text.Substring(pastePosition - nodeWrapper.Start));
				i++;
				foreach (NodeWrapper newWrapper2 in newWrappers)
				{
					InsertChild(i, newWrapper2);
					i++;
				}
				InsertChild(i, nodeWrapper2);
			}
			return true;
		}
		return false;
	}
}
