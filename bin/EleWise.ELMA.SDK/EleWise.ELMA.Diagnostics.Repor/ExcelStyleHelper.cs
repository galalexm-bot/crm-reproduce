using System.Drawing;
using Aspose.Cells;

namespace EleWise.ELMA.Diagnostics.Reports.Excel;

public static class ExcelStyleHelper
{
	private static ExcelStyleHelper XBMF7BEGgln5Lqi8BUm2;

	public static void SetBackColor(Style style, StyleFlag styleFlag, Color color)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			default:
				fAaKikEGLXMOyApUBTfM(style, (BackgroundType)1);
				num2 = 3;
				break;
			case 2:
				AyhR6CEGY4Q97Q0FgawQ(styleFlag, true);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				style.set_ForegroundColor(color);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void SetFontColor(Style style, StyleFlag styleFlag, Color color)
	{
		int num = 2;
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
				TxAeMTEGs6DjhgKestwO(style.get_Font(), color);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				dSuuhnEGUqEsgBmDk5bX(styleFlag, true);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static void SetFontSize(Style style, StyleFlag styleFlag, int size)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				uNBnjmEGz88uUYTqGe0o(style.get_Font(), size);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				J6yM6rEGcG13Syg1G5Xa(styleFlag, true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public static void SetFontBold(Style style, StyleFlag styleFlag, bool isBold)
	{
		int num = 2;
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
				SdQlmfEEB19wX17yf46K(style.get_Font(), isBold);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				E98C56EEFqMEIyiWh43n(styleFlag, true);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void SetIndentLevel(Style style, StyleFlag styleFlag, int level)
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
				QKwRawEEWiKH2oTHqJ4R(styleFlag, true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				GCrCg3EEoFrQHGlUfjCF(style, level);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void SetHorizontalAlignment(Style style, StyleFlag styleFlag, TextAlignmentType alignment)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				woeUP5EEbEMXBfgjrtvC(styleFlag, true);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				oS26yeEEhMwj7VlkYUnn(style, alignment);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void AyhR6CEGY4Q97Q0FgawQ(object P_0, bool P_1)
	{
		((StyleFlag)P_0).set_CellShading(P_1);
	}

	internal static void fAaKikEGLXMOyApUBTfM(object P_0, BackgroundType P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Style)P_0).set_Pattern(P_1);
	}

	internal static bool zlc154EG5cAtjcsexiDh()
	{
		return XBMF7BEGgln5Lqi8BUm2 == null;
	}

	internal static ExcelStyleHelper z0ZdI9EGj0upM0e5TWGN()
	{
		return XBMF7BEGgln5Lqi8BUm2;
	}

	internal static void dSuuhnEGUqEsgBmDk5bX(object P_0, bool P_1)
	{
		((StyleFlag)P_0).set_FontColor(P_1);
	}

	internal static void TxAeMTEGs6DjhgKestwO(object P_0, Color P_1)
	{
		((Font)P_0).set_Color(P_1);
	}

	internal static void J6yM6rEGcG13Syg1G5Xa(object P_0, bool P_1)
	{
		((StyleFlag)P_0).set_FontSize(P_1);
	}

	internal static void uNBnjmEGz88uUYTqGe0o(object P_0, int P_1)
	{
		((Font)P_0).set_Size(P_1);
	}

	internal static void E98C56EEFqMEIyiWh43n(object P_0, bool P_1)
	{
		((StyleFlag)P_0).set_FontBold(P_1);
	}

	internal static void SdQlmfEEB19wX17yf46K(object P_0, bool P_1)
	{
		((Font)P_0).set_IsBold(P_1);
	}

	internal static void QKwRawEEWiKH2oTHqJ4R(object P_0, bool P_1)
	{
		((StyleFlag)P_0).set_Indent(P_1);
	}

	internal static void GCrCg3EEoFrQHGlUfjCF(object P_0, int P_1)
	{
		((Style)P_0).set_IndentLevel(P_1);
	}

	internal static void woeUP5EEbEMXBfgjrtvC(object P_0, bool P_1)
	{
		((StyleFlag)P_0).set_HorizontalAlignment(P_1);
	}

	internal static void oS26yeEEhMwj7VlkYUnn(object P_0, TextAlignmentType P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Style)P_0).set_HorizontalAlignment(P_1);
	}
}
