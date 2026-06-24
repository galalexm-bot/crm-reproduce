using System;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Toolbar;

[Serializable]
public class ToolbarItemList : EventedList<ToolbarItem>, IXsiType
{
	internal static ToolbarItemList r89Z0OotNdyq8TbyYcOM;

	public ToolbarItemList(ToolbarItem parent)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		F71jrvotarBprPAWWOok();
		base._002Ector(parent);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override Exception ListAddingException(ToolbarItem parent, ToolbarItem item)
	{
		return new ToolbarItemListAddingException(parent, item);
	}

	protected override ToolbarItem GetParent(ToolbarItem item)
	{
		return (ToolbarItem)Sw8bkRotDqWZQJYndu33(item);
	}

	protected override void SetParent(ToolbarItem item, ToolbarItem parent)
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
				vDuM3JottXH1BM0dGZVY(item, (RootToolbarItem)parent);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override void RemoveFromParent(ToolbarItem item)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				((EventedList<ToolbarItem>)Hj6k13otw9cbrUSNEEYl(Sw8bkRotDqWZQJYndu33(item))).Remove(item);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (Sw8bkRotDqWZQJYndu33(item) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 2:
				return;
			}
		}
	}

	internal static void F71jrvotarBprPAWWOok()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool xqsvgXot3fnWEpDiBoGg()
	{
		return r89Z0OotNdyq8TbyYcOM == null;
	}

	internal static ToolbarItemList oFwh5IotpyFfejBnMKPW()
	{
		return r89Z0OotNdyq8TbyYcOM;
	}

	internal static object Sw8bkRotDqWZQJYndu33(object P_0)
	{
		return ((ToolbarItem)P_0).Parent;
	}

	internal static void vDuM3JottXH1BM0dGZVY(object P_0, object P_1)
	{
		((ToolbarItem)P_0).Parent = (RootToolbarItem)P_1;
	}

	internal static object Hj6k13otw9cbrUSNEEYl(object P_0)
	{
		return ((RootToolbarItem)P_0).Items;
	}
}
