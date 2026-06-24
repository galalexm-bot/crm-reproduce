using System;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[DisplayName(typeof(__Resources_ColumnsLayoutViewItem), "DisplayName")]
public class ColumnsLayoutViewItem : RootViewItem, ILayoutViewItem
{
	internal static ColumnsLayoutViewItem BTn4GYoOh2OPdZiRN81Y;

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (parentViewItem == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return usD9cboOf8lMcXdVX4Pm(parentViewItem, this);
			default:
				return true;
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is ColumnViewItem;
	}

	public ColumnsLayoutViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ydJdOEoOQuHe0b3L6LCb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool usD9cboOf8lMcXdVX4Pm(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}

	internal static bool WVl0BDoOGtDJNguGaZfo()
	{
		return BTn4GYoOh2OPdZiRN81Y == null;
	}

	internal static ColumnsLayoutViewItem PATh5EoOE0MuOPcDVXEt()
	{
		return BTn4GYoOh2OPdZiRN81Y;
	}

	internal static void ydJdOEoOQuHe0b3L6LCb()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
