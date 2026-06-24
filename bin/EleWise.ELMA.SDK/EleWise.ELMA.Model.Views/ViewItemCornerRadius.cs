using System.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

public class ViewItemCornerRadius
{
	internal static ViewItemCornerRadius Sg61jgokNEPG2vTEG9RD;

	[DefaultValue(null)]
	public int? TopLeft { get; set; }

	[DefaultValue(null)]
	public int? TopRight { get; set; }

	[DefaultValue(null)]
	public int? BottomRight { get; set; }

	[DefaultValue(null)]
	public int? BottomLeft { get; set; }

	public ViewItemCornerRadius()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MNvrAAokawKfvS9B0l5L();
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

	public ViewItemCornerRadius(int? topLeft, int? topRight, int? bottomRight, int? bottomLeft)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		TopLeft = topLeft;
		TopRight = topRight;
		BottomRight = bottomRight;
		BottomLeft = bottomLeft;
	}

	public ViewItemCornerRadius(int? all)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		TopLeft = all;
		TopRight = all;
		BottomRight = all;
		BottomLeft = all;
	}

	public void Apply(ViewItemCornerRadius radius)
	{
		//Discarded unreachable code: IL_0114, IL_0123, IL_01ab
		int num = 9;
		int? num3 = default(int?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (!num3.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 3;
						}
						continue;
					}
					break;
				case 15:
					TopRight = radius.TopRight;
					num2 = 7;
					continue;
				case 3:
				case 13:
					num3 = radius.BottomLeft;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
					if (num3.HasValue)
					{
						num2 = 15;
						continue;
					}
					goto case 7;
				case 8:
					num3 = radius.TopLeft;
					num2 = 11;
					continue;
				case 2:
					return;
				case 5:
					BottomLeft = radius.BottomLeft;
					num2 = 2;
					continue;
				case 11:
					if (!num3.HasValue)
					{
						num2 = 6;
						continue;
					}
					goto case 4;
				case 1:
					if (!num3.HasValue)
					{
						return;
					}
					num2 = 5;
					continue;
				case 7:
					num3 = radius.BottomRight;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					TopLeft = radius.TopLeft;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 9;
					}
					continue;
				case 14:
					break;
				case 6:
				case 10:
					num3 = radius.TopRight;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 12;
					}
					continue;
				case 9:
					MkJpNjoktkUHlxXnfx4a(radius, av4ksWokDXfrcPk4KQ49(0x4EA5403C ^ 0x4EA71DE6));
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			}
			BottomRight = radius.BottomRight;
			num = 13;
		}
	}

	internal static void MNvrAAokawKfvS9B0l5L()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Upai0ook3jEIep9qgGPd()
	{
		return Sg61jgokNEPG2vTEG9RD == null;
	}

	internal static ViewItemCornerRadius GgX0sRokpWKtKmT1AckG()
	{
		return Sg61jgokNEPG2vTEG9RD;
	}

	internal static object av4ksWokDXfrcPk4KQ49(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void MkJpNjoktkUHlxXnfx4a(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}
}
