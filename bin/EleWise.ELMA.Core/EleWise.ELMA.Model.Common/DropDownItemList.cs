using System;
using System.Text;
using EleWise.ELMA.Collections;

namespace EleWise.ELMA.Model.Common;

public class DropDownItemList : ReactiveCollection<DropDownItem>
{
	private const string F_N = "{{N}}";

	private const string F_R = "{{R}}";

	public void ParseTree(string itemsString)
	{
		Clear();
		if (!string.IsNullOrEmpty(itemsString))
		{
			string[] array = itemsString.Split("\r\n".ToCharArray(), (StringSplitOptions)1);
			foreach (string stringValue in array)
			{
				Add(new TreeModel(stringValue));
			}
		}
	}

	public void Parse(string itemsString)
	{
		Clear();
		if (!string.IsNullOrEmpty(itemsString))
		{
			string[] array = itemsString.Split("\r\n".ToCharArray(), (StringSplitOptions)1);
			foreach (string text in array)
			{
				Add(new DropDownItem(text.Replace("{{R}}", "\r").Replace("{{N}}", "\n")));
			}
		}
	}

	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		for (int i = 0; i < base.Count; i++)
		{
			if (i > 0)
			{
				val.Append("\r\n");
			}
			val.Append(((object)base[i]).ToString().Replace("\r", "{{R}}").Replace("\n", "{{N}}"));
		}
		return ((object)val).ToString();
	}
}
