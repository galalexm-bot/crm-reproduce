using Aspose.Words;

namespace EleWise.TemplateGenerator.Words.Internal;

internal class RunWrapper : InlineWrapper
{
	public override string FullText => ((Run)base.Node).get_Text();

	public RunWrapper(Run run, NodeWrapper parent)
		: base((Inline)(object)run, parent)
	{
	}

	public override void RecalcRange()
	{
		base.Stop = base.Start + (FullText ?? "").Length;
	}

	public override bool ReplaceText(int start, int stop, string text)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if (start >= base.Stop)
		{
			return false;
		}
		if (stop < base.Start)
		{
			return false;
		}
		string fullText = FullText;
		string text2 = "";
		if (start > base.Start)
		{
			text2 = fullText.Substring(0, start - base.Start);
		}
		if (!string.IsNullOrEmpty(text))
		{
			text2 += text;
		}
		int num = base.Stop - stop - 1;
		if (num > 0)
		{
			text2 += fullText.Substring(fullText.Length - num);
		}
		((Run)base.Node).set_Text(text2);
		return true;
	}
}
