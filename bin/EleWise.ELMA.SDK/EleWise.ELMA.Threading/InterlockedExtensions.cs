using System.Threading;

namespace EleWise.ELMA.Threading;

public static class InterlockedExtensions
{
	internal static InterlockedExtensions N9FZN1Bi1pjX82NZi0xr;

	public static bool IncrementIfLess(ref int location, int comparand)
	{
		int num = 4;
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return false;
				case 7:
					num3 = Interlocked.CompareExchange(ref location, num4 + 1, num4);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					return true;
				case 3:
					break;
				case 6:
					if (num4 >= comparand)
					{
						num3 = location;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
						{
							num2 = 2;
						}
					}
					else
					{
						num2 = 7;
					}
					continue;
				case 4:
					num3 = location;
					num2 = 3;
					continue;
				case 1:
					if (num3 == num4)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 2:
					if (num3 == num4)
					{
						num2 = 5;
						continue;
					}
					break;
				}
				break;
			}
			num4 = num3;
			num = 6;
		}
	}

	internal static bool C5Xp1MBiN1yc5RufqOvn()
	{
		return N9FZN1Bi1pjX82NZi0xr == null;
	}

	internal static InterlockedExtensions oRtmHCBi3UBJ43YDFYGZ()
	{
		return N9FZN1Bi1pjX82NZi0xr;
	}
}
