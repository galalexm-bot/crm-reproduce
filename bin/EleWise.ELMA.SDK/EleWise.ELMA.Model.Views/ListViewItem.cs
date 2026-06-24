using System;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class ListViewItem : EventedList<ViewItem>, IXsiType
{
	private static ListViewItem yk4Yk4o2YJc8N771AltK;

	public ListViewItem(ViewItem parent)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		DQOZ82o2s8aqt35VxuNH();
		base._002Ector(parent);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override Exception ListAddingException(ViewItem parent, ViewItem item)
	{
		return new ListViewItemAddingException(parent, item);
	}

	protected override ViewItem GetParent(ViewItem item)
	{
		return (ViewItem)H6PhABo2c48fHyQ4fXkf(item);
	}

	protected override void SetParent(ViewItem item, ViewItem parent)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				item.Parent = (RootViewItem)parent;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override void RemoveFromParent(ViewItem item)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (item.Parent != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 1:
				((EventedList<ViewItem>)rDE7Ffo2zHiP0d2KHJ20(H6PhABo2c48fHyQ4fXkf(item))).Remove(item);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void DQOZ82o2s8aqt35VxuNH()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool s3ZEhro2LaIa224avpJN()
	{
		return yk4Yk4o2YJc8N771AltK == null;
	}

	internal static ListViewItem PkLcFDo2UD55DdVQiN4M()
	{
		return yk4Yk4o2YJc8N771AltK;
	}

	internal static object H6PhABo2c48fHyQ4fXkf(object P_0)
	{
		return ((ViewItem)P_0).Parent;
	}

	internal static object rDE7Ffo2zHiP0d2KHJ20(object P_0)
	{
		return ((RootViewItem)P_0).Items;
	}
}
