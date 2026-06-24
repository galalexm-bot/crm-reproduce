using System;
using System.Collections.Generic;
using System.Linq;
using Aspose.Words;

namespace EleWise.TemplateGenerator.Words.Internal;

internal class CompositeNodeWrapper : NodeWrapper
{
	private List<NodeWrapper> childWrappers = new List<NodeWrapper>();

	public List<NodeWrapper> ChildWrappers => childWrappers;

	public override string FullText => string.Concat(childWrappers.Select((NodeWrapper p) => p.FullText));

	public CompositeNodeWrapper(CompositeNode node, NodeWrapper parent)
		: base((Node)(object)node, parent)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (node.get_ChildNodes() != null)
		{
			foreach (Node childNode in node.get_ChildNodes())
			{
				childWrappers.Add(WrapperManager.Create(childNode, this));
			}
		}
		RecalcRange();
	}

	public override void RecalcRange()
	{
		base.Stop = base.Start;
		foreach (NodeWrapper childWrapper in childWrappers)
		{
			childWrapper.Start = base.Stop;
			childWrapper.RecalcRange();
			base.Stop = childWrapper.Stop;
		}
	}

	public void AddChild(NodeWrapper w)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		childWrappers.Add(w);
		w.parent = this;
		((CompositeNode)base.Node).get_ChildNodes().Add(w.Node);
	}

	public void InsertChild(int index, NodeWrapper w)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		childWrappers.Insert(index, w);
		w.parent = this;
		((CompositeNode)base.Node).get_ChildNodes().Insert(index, w.Node);
	}

	public override bool Cut(int start, int stop)
	{
		List<NodeWrapper> list = childWrappers.ToList();
		bool flag = false;
		foreach (NodeWrapper item in list)
		{
			if (item.Start >= start && item.Stop - 1 <= stop && !string.IsNullOrEmpty(item.FullText))
			{
				RemoveChild(item);
				flag = true;
			}
			else if (flag && item.Start > start && item.Stop - 1 < stop)
			{
				RemoveChild(item);
				flag = true;
			}
			else if (item.Stop > start && item.Start <= stop && item.Cut(start, stop))
			{
				flag = true;
			}
		}
		return flag;
	}

	public override bool ReplaceText(int start, int stop, string text)
	{
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Invalid comparison between Unknown and I4
		string textToPaste = text;
		bool flag = false;
		List<NodeWrapper> list = childWrappers.ToList();
		if (!text.Contains("\r\n") && !text.Contains("\n"))
		{
			return Paste(list, start, stop, textToPaste);
		}
		textToPaste = text.Replace("\r\n", "\n").Replace("\n", "\r\n");
		string[] array = textToPaste.Split(new string[1] { "\r\n" }, StringSplitOptions.None);
		if (array.Length == 0)
		{
			return Paste(list, start, stop, "");
		}
		if (array.Length == 1)
		{
			return Paste(list, start, stop, array[0]);
		}
		List<NodeWrapper> list2 = new List<NodeWrapper>();
		NodeWrapper nodeWrapper = null;
		CompositeNodeWrapper compositeNodeWrapper = null;
		if (list.Count > 0)
		{
			if (list[0].Root != null)
			{
				nodeWrapper = list[0].Root;
			}
			else
			{
				if (list[0].Parent != null)
				{
					nodeWrapper = list[0].Parent;
				}
				else
				{
					foreach (NodeWrapper item in list)
					{
						if (item.Parent != null)
						{
							nodeWrapper = item;
							break;
						}
					}
				}
				while (nodeWrapper.Node != null && (int)nodeWrapper.Node.get_NodeType() != 1 && nodeWrapper.Parent != null)
				{
					nodeWrapper = nodeWrapper.Parent;
				}
			}
			if (nodeWrapper == null)
			{
				nodeWrapper = list[0];
			}
			NodeWrapper nodeWrapper2 = FindNode(nodeWrapper, start, stop);
			if (!nodeWrapper2.Node.get_IsComposite())
			{
				nodeWrapper2 = nodeWrapper2.Parent;
			}
			compositeNodeWrapper = ((nodeWrapper2.Parent == null) ? ((CompositeNodeWrapper)nodeWrapper2) : ((CompositeNodeWrapper)nodeWrapper2.Parent));
			int num = compositeNodeWrapper.ChildWrappers.IndexOf(nodeWrapper2);
			if (num == -1)
			{
				num = Find(compositeNodeWrapper, start, stop, -1);
			}
			if (num == -1 && compositeNodeWrapper.Parent != null)
			{
				num = ((CompositeNodeWrapper)compositeNodeWrapper.Parent).ChildWrappers.IndexOf(compositeNodeWrapper);
				compositeNodeWrapper = (CompositeNodeWrapper)compositeNodeWrapper.Parent;
			}
			nodeWrapper = ((num == -1) ? compositeNodeWrapper : compositeNodeWrapper.ChildWrappers[num]);
			try
			{
				for (int i = 0; i < array.Length; i++)
				{
					list2.Add(nodeWrapper.Clone(nodeWrapper.Parent, isCloneChildren: true));
				}
				for (int j = 0; j < list2.Count; j++)
				{
					if (j == 0)
					{
						list2[j].ReplaceText(stop - nodeWrapper.Start + 1, nodeWrapper.Stop - nodeWrapper.Start, "");
						list2[j].RecalcRange();
						list2[j].ReplaceText(start - nodeWrapper.Start, list2[j].Stop, array[j]);
						list2[j].RecalcRange();
					}
					else if (j == list2.Count - 1)
					{
						list2[j].ReplaceText(0, start - nodeWrapper.Start - 1, "");
						list2[j].RecalcRange();
						list2[j].ReplaceText(0, stop - start, array[j]);
						list2[j].RecalcRange();
					}
					else
					{
						list2[j].ReplaceText(0, start - nodeWrapper.Start - 1, "");
						list2[j].RecalcRange();
						list2[j].ReplaceText(0, stop - start, array[j]);
						list2[j].RecalcRange();
						list2[j].ReplaceText(array[j].Length, list2[j].Stop, "");
						list2[j].RecalcRange();
					}
				}
			}
			catch
			{
				textToPaste = textToPaste.Replace("\r\n", " ").Replace("\n", " ");
				Paste(list, start, stop, textToPaste);
				return false;
			}
			if (num == -1)
			{
				textToPaste = textToPaste.Replace("\r\n", " ").Replace("\n", " ");
				Paste(list, start, stop, textToPaste);
				return false;
			}
			int num2 = 0;
			try
			{
				for (int k = 1; k < list2.Count; k++)
				{
					compositeNodeWrapper.InsertChild(num + k, list2[k]);
					num2++;
				}
			}
			catch
			{
				for (int num3 = num2; num3 > 0; num3--)
				{
					compositeNodeWrapper.RemoveChild(compositeNodeWrapper.ChildWrappers[num + num3]);
				}
				textToPaste = textToPaste.Replace("\r\n", " ").Replace("\n", " ");
				Paste(list, start, stop, textToPaste);
				return false;
			}
			compositeNodeWrapper.ChildWrappers[num].ReplaceText(stop, compositeNodeWrapper.ChildWrappers[num].Stop, "");
			compositeNodeWrapper.RecalcRange();
			compositeNodeWrapper.ChildWrappers[num].ReplaceText(start, compositeNodeWrapper.ChildWrappers[num].Stop, array[0]);
			compositeNodeWrapper.RecalcRange();
			try
			{
				double num4 = 0.0;
				double num5 = 0.0;
				Node obj3 = compositeNodeWrapper.ChildWrappers[num].Node;
				Paragraph val = (Paragraph)(object)((obj3 is Paragraph) ? obj3 : null);
				if (val != null)
				{
					num4 = val.get_ParagraphFormat().get_FirstLineIndent();
					num5 = val.get_ParagraphFormat().get_LeftIndent();
				}
				for (int l = num; l < num + list2.Count; l++)
				{
					Node obj4 = compositeNodeWrapper.ChildWrappers[l].Node;
					Paragraph val2 = (Paragraph)(object)((obj4 is Paragraph) ? obj4 : null);
					if (val2 != null)
					{
						if (l > num && val2.get_ListFormat() != null && val2.get_IsListItem())
						{
							val2.get_ListFormat().RemoveNumbers();
							val2.get_ParagraphFormat().set_LeftIndent(0.0 - Math.Abs(num4) + num5 - num4);
							val2.get_ParagraphFormat().set_FirstLineIndent(0.0);
						}
						if (l < num + list2.Count - 1)
						{
							val2.get_ParagraphFormat().set_NoSpaceBetweenParagraphsOfSameStyle(true);
						}
					}
				}
			}
			catch
			{
			}
			compositeNodeWrapper.RecalcRange();
			return true;
		}
		return false;
	}

	private bool Paste(List<NodeWrapper> wrappersCopy, int start, int stop, string textToPaste)
	{
		bool flag = false;
		foreach (NodeWrapper item in wrappersCopy)
		{
			if (flag && item.Start > start && item.Stop - 1 < stop)
			{
				RemoveChild(item);
			}
			else if (item.Stop > start && item.Start <= stop && item.ReplaceText(start, stop, textToPaste))
			{
				textToPaste = "";
				flag = true;
			}
		}
		return flag;
	}

	private NodeWrapper FindNode(NodeWrapper node, int start, int stop)
	{
		List<NodeWrapper> list = new List<NodeWrapper>();
		if (node.Node != null && node.Node.get_IsComposite())
		{
			try
			{
				list = ((CompositeNodeWrapper)node).ChildWrappers;
			}
			catch
			{
				return node;
			}
			{
				foreach (NodeWrapper item in list)
				{
					if (item.Stop - item.Start >= stop - start && item.Start <= start + 2 && item.Stop + 1 >= stop)
					{
						return FindNode(item, start, stop);
					}
				}
				return node;
			}
		}
		return node;
	}

	private int Find(NodeWrapper node, int start, int stop, int currentIndex)
	{
		List<NodeWrapper> list = new List<NodeWrapper>();
		if (node.Node != null && node.Node.get_IsComposite())
		{
			try
			{
				list = ((CompositeNodeWrapper)node).ChildWrappers;
			}
			catch
			{
				return currentIndex;
			}
			int num = -1;
			{
				foreach (NodeWrapper item in list)
				{
					num++;
					if (item.Stop - item.Start >= stop - start && item.Start <= start && item.Stop >= stop)
					{
						return Find(item, start, stop, num);
					}
				}
				return currentIndex;
			}
		}
		return currentIndex;
	}

	protected virtual List<Tuple<NodeWrapper, NodeWrapper>> Copy(int start, int stop)
	{
		List<NodeWrapper> list = childWrappers.ToList();
		List<Tuple<NodeWrapper, NodeWrapper>> list2 = new List<Tuple<NodeWrapper, NodeWrapper>>();
		foreach (NodeWrapper item4 in list)
		{
			if (start == item4.Start && stop <= item4.Stop - 1)
			{
				NodeWrapper item = WrapperManager.Create(item4.Node.Clone(true), this);
				list2.Add(new Tuple<NodeWrapper, NodeWrapper>(item4, item));
				return list2;
			}
			if (start >= item4.Start && stop <= item4.Stop - 1)
			{
				if (item4 is CompositeNodeWrapper)
				{
					list2.AddRange(((CompositeNodeWrapper)item4).Copy(start, stop));
					return list2;
				}
				NodeWrapper item2 = WrapperManager.Create(item4.Node.Clone(true), this);
				list2.Add(new Tuple<NodeWrapper, NodeWrapper>(item4, item2));
				return list2;
			}
			if (stop >= item4.Start && start <= item4.Stop - 1)
			{
				NodeWrapper item3 = WrapperManager.Create(item4.Node.Clone(true), this);
				list2.Add(new Tuple<NodeWrapper, NodeWrapper>(item4, item3));
			}
		}
		return list2;
	}

	public virtual bool PasteDown(List<NodeWrapper> newWrappers, int pastePosition)
	{
		foreach (NodeWrapper item in childWrappers.ToList())
		{
			if (pastePosition >= item.Start && pastePosition < item.Stop)
			{
				if (!(item is CompositeNodeWrapper))
				{
					return item.PasteUp(newWrappers, pastePosition);
				}
				if (((CompositeNodeWrapper)item).PasteDown(newWrappers, pastePosition))
				{
					return true;
				}
			}
		}
		return false;
	}

	protected virtual void RemoveChild(NodeWrapper wrapper)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((CompositeNode)base.Node).get_ChildNodes().Remove(wrapper.Node);
		childWrappers.Remove(wrapper);
	}
}
