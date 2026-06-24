namespace EleWise.ELMA.Extensions;

public static class ByteArrayConstTimeEqualityExtension
{
	internal static ByteArrayConstTimeEqualityExtension aMpSC5GtuT25xwq5o1qx;

	public static bool Equals(byte[] x, byte[] y)
	{
		//Discarded unreachable code: IL_00db, IL_00ea
		int num = 3;
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					break;
				case 4:
					num4 |= x[num3] ^ y[num3];
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					if (num3 >= y.Length)
					{
						num2 = 6;
						continue;
					}
					goto case 4;
				case 1:
					num3++;
					num2 = 7;
					continue;
				default:
					if (num3 < x.Length)
					{
						num2 = 5;
						continue;
					}
					goto case 6;
				case 6:
					return num4 == 0;
				case 2:
					num3 = 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			num4 = x.Length ^ y.Length;
			num = 2;
		}
	}

	internal static bool d0abRPGtI4f25925Y4hB()
	{
		return aMpSC5GtuT25xwq5o1qx == null;
	}

	internal static ByteArrayConstTimeEqualityExtension WAW8J6GtVbpgF2RforKg()
	{
		return aMpSC5GtuT25xwq5o1qx;
	}
}
