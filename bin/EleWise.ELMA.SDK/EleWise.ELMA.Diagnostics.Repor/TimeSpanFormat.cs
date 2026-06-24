using System;
using System.Runtime.CompilerServices;
using Aspose.Cells;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports.Excel.Formats;

public class TimeSpanFormat : ExcelCellFormat
{
	internal static TimeSpanFormat i2UdvJEf8A1RdrCka82T;

	public static TimeSpanFormat Default { get; private set; }

	public TimeSpanStyle Style
	{
		[CompilerGenerated]
		get
		{
			return _003CStyle_003Ek__BackingField;
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
				case 1:
					_003CStyle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public TimeSpanFormat()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OgSNj3EfI9SJs9O9rdx6();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public TimeSpanFormat(TimeSpanStyle style)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OgSNj3EfI9SJs9O9rdx6();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Style = style;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void SetCellValue(Cell cell, object value)
	{
		//Discarded unreachable code: IL_00b9, IL_00c8
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (value == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 0:
				return;
			case 4:
				return;
			case 2:
				break;
			case 3:
				return;
			}
			if (!quyyhxEfVUVqcjCyOTHi(value.GetType(), typeof(TimeSpan)))
			{
				cell.set_Value((object)(((TimeSpan)value).TotalHours / 24.0));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 3;
				}
			}
			else
			{
				num2 = 4;
			}
		}
	}

	public override void ApplyFormat(Style style)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				return;
			case 0:
				return;
			case 2:
				if (Style != TimeSpanStyle.HHMMSS)
				{
					sqxj31EfiIPbp9TaOUpy(style, U29OoBEfSp3Gcbhd1aD9(-957824448 ^ -957549006));
					num2 = 3;
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				sqxj31EfiIPbp9TaOUpy(style, U29OoBEfSp3Gcbhd1aD9(0x5F3078B6 ^ 0x5F344CEA));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static TimeSpanFormat()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			default:
				VJ5r6aEfRalM5337v05N(new TimeSpanFormat());
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void OgSNj3EfI9SJs9O9rdx6()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool wMrsMNEfZc9qjyVkFx7x()
	{
		return i2UdvJEf8A1RdrCka82T == null;
	}

	internal static TimeSpanFormat X0uRUnEfuHPF9wn29iRi()
	{
		return i2UdvJEf8A1RdrCka82T;
	}

	internal static bool quyyhxEfVUVqcjCyOTHi(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object U29OoBEfSp3Gcbhd1aD9(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void sqxj31EfiIPbp9TaOUpy(object P_0, object P_1)
	{
		((Style)P_0).set_Custom((string)P_1);
	}

	internal static void VJ5r6aEfRalM5337v05N(object P_0)
	{
		Default = (TimeSpanFormat)P_0;
	}
}
