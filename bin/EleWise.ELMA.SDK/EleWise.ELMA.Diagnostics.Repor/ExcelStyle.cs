using System;
using System.Drawing;
using Aspose.Cells;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports.Excel;

public class ExcelStyle : IExcelStyle
{
	private static ExcelStyle qhf2QxEEqehfHZHAeW9v;

	public Color? BackColor { get; set; }

	public Color? FontColor { get; set; }

	public int? FontSize { get; set; }

	public bool? FontBold { get; set; }

	public Action<Style, StyleFlag> Action { get; set; }

	public void Apply(Style style, StyleFlag styleFlag)
	{
		//Discarded unreachable code: IL_0095, IL_0104, IL_0113, IL_0122, IL_0247
		int num = 18;
		int? fontSize = default(int?);
		Color? color = default(Color?);
		bool? fontBold = default(bool?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					fontSize = FontSize;
					ExcelStyleHelper.SetFontSize(style, styleFlag, fontSize.Value);
					num2 = 2;
					continue;
				case 7:
					if (!color.HasValue)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 12;
				case 18:
					if (style == null)
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num2 = 13;
						}
						continue;
					}
					if (styleFlag == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					color = BackColor;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					continue;
				case 15:
				case 16:
					goto end_IL_0012;
				case 9:
					return;
				default:
					if (Action == null)
					{
						num2 = 9;
						continue;
					}
					goto case 11;
				case 17:
					throw new ArgumentNullException((string)maeDAnEETPMsjiJNuHSO(-29254301 ^ -29113473));
				case 1:
					throw new ArgumentNullException((string)maeDAnEETPMsjiJNuHSO(0x3CE17B75 ^ 0x3CE54F55));
				case 6:
					if (!fontBold.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 14;
				case 11:
					Action(style, styleFlag);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 10;
					}
					continue;
				case 8:
				case 13:
					fontSize = FontSize;
					num2 = 19;
					continue;
				case 10:
					return;
				case 3:
					if (!color.HasValue)
					{
						num2 = 15;
						continue;
					}
					goto case 20;
				case 19:
					if (fontSize.HasValue)
					{
						num2 = 5;
						continue;
					}
					break;
				case 12:
					color = FontColor;
					pBvMY1EEkWDoOQFs3A24(style, styleFlag, color.Value);
					num2 = 8;
					continue;
				case 20:
					color = BackColor;
					ExcelStyleHelper.SetBackColor(style, styleFlag, color.Value);
					num2 = 16;
					continue;
				case 14:
					fontBold = FontBold;
					uADeToEEnhDxYxCDTGOP(style, styleFlag, fontBold.Value);
					num2 = 4;
					continue;
				case 2:
					break;
				}
				fontBold = FontBold;
				num2 = 6;
				continue;
				end_IL_0012:
				break;
			}
			color = FontColor;
			num = 7;
		}
	}

	public ExcelStyle()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object maeDAnEETPMsjiJNuHSO(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void pBvMY1EEkWDoOQFs3A24(object P_0, object P_1, Color color)
	{
		ExcelStyleHelper.SetFontColor((Style)P_0, (StyleFlag)P_1, color);
	}

	internal static void uADeToEEnhDxYxCDTGOP(object P_0, object P_1, bool isBold)
	{
		ExcelStyleHelper.SetFontBold((Style)P_0, (StyleFlag)P_1, isBold);
	}

	internal static bool tnRLIGEEKvdna0vBNhDy()
	{
		return qhf2QxEEqehfHZHAeW9v == null;
	}

	internal static ExcelStyle NaSDSIEEXlTRD6LVa6iV()
	{
		return qhf2QxEEqehfHZHAeW9v;
	}
}
