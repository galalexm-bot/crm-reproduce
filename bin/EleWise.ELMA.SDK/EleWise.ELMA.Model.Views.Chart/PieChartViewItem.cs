using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Charts;

[Serializable]
public class PieChartViewItem : ChartViewItem
{
	internal static PieChartViewItem extaSboDzedrc4gHiLuL;

	[DefaultValue(ViewItemPieChartViewType.Ring)]
	public ViewItemPieChartViewType ViewType
	{
		[CompilerGenerated]
		get
		{
			return _003CViewType_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CViewType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PieChartViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		p2bZSIotWaWKZ5120VUA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			ViewType = ViewItemPieChartViewType.Ring;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
			{
				num = 0;
			}
		}
	}

	internal static void p2bZSIotWaWKZ5120VUA()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool PHFur2otFOPcWy6UNfIV()
	{
		return extaSboDzedrc4gHiLuL == null;
	}

	internal static PieChartViewItem f57VniotBgjBRvL4IC3i()
	{
		return extaSboDzedrc4gHiLuL;
	}
}
