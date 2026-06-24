using System.ComponentModel;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

public class ViewItemBorder
{
	internal static ViewItemBorder JuoPGbokT2joUFAoKjZW;

	[DefaultValue(null)]
	public int? Width { get; set; }

	[DefaultValue(null)]
	public ViewItemColor Color
	{
		[CompilerGenerated]
		get
		{
			return _003CColor_003Ek__BackingField;
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
					_003CColor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public void Apply(ViewItemBorder border)
	{
		//Discarded unreachable code: IL_00aa, IL_00b9
		int num = 2;
		int num2 = num;
		int? width = default(int?);
		while (true)
		{
			switch (num2)
			{
			case 5:
				Width = border.Width;
				num2 = 3;
				break;
			default:
				if (EEa3bYokeQRJPD7gDPJO(border) != null)
				{
					num2 = 7;
					break;
				}
				return;
			case 7:
				Color = (ViewItemColor)m3ifxEokPEYaxpeZAOHp(border.Color);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				width = border.Width;
				num2 = 6;
				break;
			case 4:
				return;
			case 2:
				uuv3S5ok2xecg1lfAeCh(border, SQ1sWnokOXj7PucDCI4v(0x571EA399 ^ 0x571CFE53));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				if (!width.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	public ViewItemBorder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BfOAQqok1Dyqsx8YH9Xq();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool VitKIwokkioSFpjevE7O()
	{
		return JuoPGbokT2joUFAoKjZW == null;
	}

	internal static ViewItemBorder fFJF2Yokn0irdHip8VtC()
	{
		return JuoPGbokT2joUFAoKjZW;
	}

	internal static object SQ1sWnokOXj7PucDCI4v(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void uuv3S5ok2xecg1lfAeCh(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object EEa3bYokeQRJPD7gDPJO(object P_0)
	{
		return ((ViewItemBorder)P_0).Color;
	}

	internal static object m3ifxEokPEYaxpeZAOHp(object P_0)
	{
		return ((ViewItemColor)P_0).Clone();
	}

	internal static void BfOAQqok1Dyqsx8YH9Xq()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
