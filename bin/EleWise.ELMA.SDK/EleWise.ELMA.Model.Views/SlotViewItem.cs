using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

[Serializable]
public class SlotViewItem : RootViewItem
{
	public static Guid TypeUid;

	private static SlotViewItem ex9heboKJtt2WDuhhoNk;

	public Guid PlaceholderUid
	{
		[CompilerGenerated]
		get
		{
			return _003CPlaceholderUid_003Ek__BackingField;
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
					_003CPlaceholderUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return d1qu5roKlC9VAU8XihRE(parentViewItem, this);
			case 1:
				return true;
			case 2:
				if (parentViewItem == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public SlotViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		guiGyZoKr6PcxZq0rcMY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static SlotViewItem()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				guiGyZoKr6PcxZq0rcMY();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				TypeUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4787E6C9));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool abv8v4oK9LMLh02Kb8Gp()
	{
		return ex9heboKJtt2WDuhhoNk == null;
	}

	internal static SlotViewItem VRfCFGoKdtJvUE6irlbC()
	{
		return ex9heboKJtt2WDuhhoNk;
	}

	internal static bool d1qu5roKlC9VAU8XihRE(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}

	internal static void guiGyZoKr6PcxZq0rcMY()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
