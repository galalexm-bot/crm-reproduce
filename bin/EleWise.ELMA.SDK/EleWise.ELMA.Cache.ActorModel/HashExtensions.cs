using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Cache.ActorModel.Partitioning;

internal static class HashExtensions
{
	public static readonly double MaxAngle;

	internal static HashExtensions QbP9TIfXgwr1tHr0GAex;

	public static uint ToHash(this string text)
	{
		//Discarded unreachable code: IL_0059, IL_0068
		int num = 11;
		uint num4 = default(uint);
		char c = default(char);
		string text2 = default(string);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return num4;
				case 1:
					num4 += c;
					num2 = 13;
					continue;
				case 11:
					num4 = 0u;
					num2 = 10;
					continue;
				case 8:
					num4 += num4 << 15;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					num4 += num4 << 10;
					num2 = 12;
					continue;
				case 9:
					num4 ^= num4 >> 11;
					num2 = 8;
					continue;
				case 3:
					num4 += num4 << 3;
					num2 = 9;
					continue;
				case 10:
					text2 = text;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					num3 = 0;
					num2 = 6;
					continue;
				case 4:
					c = FoQ8lFfXY1SL7Kw2FGWW(text2, num3);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
				case 7:
					if (num3 >= text2.Length)
					{
						num2 = 3;
						continue;
					}
					goto case 4;
				case 12:
					num4 ^= num4 >> 6;
					num = 5;
					break;
				case 5:
					num3++;
					num = 7;
					break;
				}
				break;
			}
		}
	}

	public static double ToAngle(this uint hash)
	{
		return (double)hash * MaxAngle / 4294967295.0;
	}

	static HashExtensions()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				MaxAngle = 360.0;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static char FoQ8lFfXY1SL7Kw2FGWW(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static bool sJEShFfX5RaGekLFhqh0()
	{
		return QbP9TIfXgwr1tHr0GAex == null;
	}

	internal static HashExtensions KiIp5yfXjpHjBbC4LJUY()
	{
		return QbP9TIfXgwr1tHr0GAex;
	}
}
