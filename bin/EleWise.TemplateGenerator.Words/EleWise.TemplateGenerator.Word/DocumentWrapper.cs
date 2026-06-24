using System;
using System.Collections.Generic;
using System.Linq;
using Aspose.Words;

namespace EleWise.TemplateGenerator.Words.Internal;

internal class DocumentWrapper : CompositeNodeWrapper
{
	public DocumentWrapper(Document document)
		: base((CompositeNode)(object)document, null)
	{
	}

	public void CopyPaste(int start, int stop, int pastePosition)
	{
		List<Tuple<NodeWrapper, NodeWrapper>> list = Copy(start, stop);
		foreach (Tuple<NodeWrapper, NodeWrapper> item in list)
		{
			item.Item2.Start = 0;
			item.Item2.RecalcRange();
			int start2 = item.Item1.Start;
			int num = start - start2;
			int num2 = stop - start2;
			item.Item2.ReplaceText(num2 + 1, int.MaxValue, "");
			item.Item2.RecalcRange();
			item.Item2.ReplaceText(-2147483647, num - 1, "");
		}
		List<NodeWrapper> newWrappers = list.Select((Tuple<NodeWrapper, NodeWrapper> t) => t.Item2).ToList();
		if (!PasteDown(newWrappers, pastePosition))
		{
			throw new InvalidOperationException("Cannot paste document fragment");
		}
	}
}
