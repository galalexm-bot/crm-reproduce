using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public sealed class ValidationSummaryViewItem : ViewItem
{
	internal static ValidationSummaryViewItem KPck94oRtY0JSNLDFKuq;

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_0057, IL_0066
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (parentViewItem == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return M4EA3CoR6g4pKs0PHC5N(parentViewItem, this);
			case 1:
				return true;
			}
		}
	}

	public ValidationSummaryViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vfaFeMoRHieH5UpJSp1G();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool M4EA3CoR6g4pKs0PHC5N(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}

	internal static bool XTVkK0oRwJ3XKZ7UhXfV()
	{
		return KPck94oRtY0JSNLDFKuq == null;
	}

	internal static ValidationSummaryViewItem gONW5IoR4bOOOqQ2tcGV()
	{
		return KPck94oRtY0JSNLDFKuq;
	}

	internal static void vfaFeMoRHieH5UpJSp1G()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
