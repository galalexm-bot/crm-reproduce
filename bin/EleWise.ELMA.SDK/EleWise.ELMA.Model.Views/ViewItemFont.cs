using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

public class ViewItemFont
{
	private static ViewItemFont dPjt9wokYH4CpTv2Md4B;

	[DefaultValue(null)]
	public FontFamilyType? FamilyType { get; set; }

	[DefaultValue(null)]
	public float? Size { get; set; }

	[DefaultValue(GraphicsUnit.Pixel)]
	public GraphicsUnit Unit
	{
		[CompilerGenerated]
		get
		{
			return _003CUnit_003Ek__BackingField;
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
					_003CUnit_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(null)]
	public FontStyle? Style { get; set; }

	public void Apply(ViewItemFont font)
	{
		//Discarded unreachable code: IL_00f8
		int num = 10;
		FontStyle? style = default(FontStyle?);
		float? size = default(float?);
		FontFamilyType? familyType = default(FontFamilyType?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					FamilyType = font.FamilyType;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 1;
					}
					continue;
				case 0:
					return;
				case 4:
					if (!style.HasValue)
					{
						return;
					}
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 11;
					}
					continue;
				case 10:
					m3lsokokcC4tKIkuODgO(font, mX4Zjvokshmki87EwVTM(0x637E299B ^ 0x637C7467));
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					Unit = font.Unit;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 7;
					}
					continue;
				case 1:
					break;
				case 5:
					if (!size.HasValue)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 7;
				case 9:
					familyType = font.FamilyType;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
				case 12:
					style = font.Style;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 4;
					}
					continue;
				case 3:
					if (familyType.HasValue)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				case 7:
					Size = font.Size;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 8;
					}
					continue;
				case 11:
					Style = font.Style;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			size = font.Size;
			num = 5;
		}
	}

	public ViewItemFont()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GITb8pokzwerZuDg4pS3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool rRca5PokLUBya6vkYsL3()
	{
		return dPjt9wokYH4CpTv2Md4B == null;
	}

	internal static ViewItemFont JkrEOBokUPKV7BJAHFXu()
	{
		return dPjt9wokYH4CpTv2Md4B;
	}

	internal static object mX4Zjvokshmki87EwVTM(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void m3lsokokcC4tKIkuODgO(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void GITb8pokzwerZuDg4pS3()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
