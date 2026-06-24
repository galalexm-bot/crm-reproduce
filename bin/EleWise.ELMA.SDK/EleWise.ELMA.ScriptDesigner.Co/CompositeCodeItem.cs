using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ScriptDesigner.CodeItems;

[Serializable]
public abstract class CompositeCodeItem : CodeItem, ICompositeCodeItem, ICodeItem
{
	private static CompositeCodeItem SvvbBsiKg0BwZulTEoH;

	[XmlArrayItem("CompositeCodeItem", typeof(CompositeCodeItem))]
	[XmlArrayItem("CodeItem")]
	[NotNull]
	public List<CodeItem> Items { get; set; }

	public CompositeCodeItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JmM9pDikyWG8P1DNiIn();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Items = new List<CodeItem>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public IEnumerable<ICodeItem> GetAllItems()
	{
		return GetAllItems(this);
	}

	private static IEnumerable<ICodeItem> GetAllItems(object viewItem)
	{
		if (!(viewItem is ICompositeCodeItem compositeCodeItem))
		{
			return new CodeItem[0];
		}
		return compositeCodeItem.Items.SelectMany((CodeItem i) => new CodeItem[1] { i }.Union(GetAllItems(i)));
	}

	public abstract bool IsValidChild(ICodeItem codeItem);

	internal static void JmM9pDikyWG8P1DNiIn()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool xAR8yfiX2KpyWACnAPV()
	{
		return SvvbBsiKg0BwZulTEoH == null;
	}

	internal static CompositeCodeItem E7iFCmiTjO1VltvKK79()
	{
		return SvvbBsiKg0BwZulTEoH;
	}
}
