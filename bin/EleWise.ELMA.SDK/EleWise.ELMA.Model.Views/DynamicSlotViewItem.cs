using System;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[DisplayName(typeof(__Resources_DynamicSlotViewItem), "DisplayName")]
public class DynamicSlotViewItem : SlotViewItem
{
	private static DynamicSlotViewItem zneZQAoqjUENeaPgjMkN;

	public override bool IsChildValid(ViewItem childViewItem)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				if (base.Parent is DynamicListViewItem)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_0066;
			case 3:
				return childViewItem is ComponentViewItem;
			default:
				if (childViewItem is ButtonViewItem)
				{
					return true;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			{
				RootViewItem parent = base.Parent;
				if (parent == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 4;
					}
					break;
				}
				obj = parent.Parent;
				goto IL_00c4;
			}
			case 4:
				{
					obj = null;
					goto IL_00c4;
				}
				IL_00c4:
				if (obj is ButtonViewItem)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0066;
				IL_0066:
				return true;
			}
		}
	}

	public DynamicSlotViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		XwFCLjoqUNb43iOK0jaj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool WuKkwNoqYRRZ0uPvW4VT()
	{
		return zneZQAoqjUENeaPgjMkN == null;
	}

	internal static DynamicSlotViewItem lsQbnCoqLTFmyFi64XCB()
	{
		return zneZQAoqjUENeaPgjMkN;
	}

	internal static void XwFCLjoqUNb43iOK0jaj()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
