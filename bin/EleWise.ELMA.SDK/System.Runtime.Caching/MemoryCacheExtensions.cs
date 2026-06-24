using System.Collections.Generic;
using System.Linq;

namespace System.Runtime.Caching;

public static class MemoryCacheExtensions
{
	internal static MemoryCacheExtensions CTmswkEusk35y2ZZ3EX;

	public static void Clear(this MemoryCache cache)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass0_.cache = cache;
				num2 = 4;
				break;
			case 4:
				KQQPVPESCC6q802ZmO4(_003C_003Ec__DisplayClass0_.cache, 100);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 3:
				_003C_003Ec__DisplayClass0_.cache.Select((KeyValuePair<string, object> p) => p.Key).ToArray().Select(_003C_003Ec__DisplayClass0_._003CClear_003Eb__1)
					.Count();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static long KQQPVPESCC6q802ZmO4(object P_0, int P_1)
	{
		return ((MemoryCache)P_0).Trim(P_1);
	}

	internal static bool tYCRc1EIOCcHMlT3lQf()
	{
		return CTmswkEusk35y2ZZ3EX == null;
	}

	internal static MemoryCacheExtensions mZSIKYEVLG1Ztd6eoPh()
	{
		return CTmswkEusk35y2ZZ3EX;
	}
}
