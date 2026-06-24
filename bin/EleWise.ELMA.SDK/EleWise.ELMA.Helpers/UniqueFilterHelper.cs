using System;
using System.Collections.Concurrent;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Helpers;

public static class UniqueFilterHelper
{
	private static readonly ConcurrentDictionary<Guid, IUniqueFilterExtension> CachedMap;

	private static UniqueFilterHelper usftLHhsdLXOhvMlDxTW;

	public static Type GetUniqueFilterType(Guid uid)
	{
		//Discarded unreachable code: IL_005c, IL_006b
		int num = 3;
		int num2 = num;
		IUniqueFilterExtension uniqueFilterExtension = default(IUniqueFilterExtension);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				return m0dtk2hs5lm9jpp4Arci(uniqueFilterExtension);
			case 2:
				if (uniqueFilterExtension != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 3:
				uniqueFilterExtension = (IUniqueFilterExtension)f1XkgwhsgwXL7O9YvRfW(uid);
				num2 = 2;
				break;
			}
		}
	}

	public static Type GetUniqueFilterEntityType(Guid uid)
	{
		int num = 1;
		int num2 = num;
		IUniqueFilterExtension uniqueFilterExtension = default(IUniqueFilterExtension);
		while (true)
		{
			switch (num2)
			{
			case 1:
				uniqueFilterExtension = (IUniqueFilterExtension)f1XkgwhsgwXL7O9YvRfW(uid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return null;
			}
			if (uniqueFilterExtension == null)
			{
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 2;
				}
				continue;
			}
			return hc4BV4hsjsSphC6SA7n0(uniqueFilterExtension);
		}
	}

	public static IUniqueFilterExtension GetExtension(Guid uid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return CachedMap.GetOrAdd(_003C_003Ec__DisplayClass3_.uid, _003C_003Ec__DisplayClass3_._003CGetExtension_003Eb__0);
			case 1:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass3_.uid = uid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	static UniqueFilterHelper()
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				CachedMap = new ConcurrentDictionary<Guid, IUniqueFilterExtension>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static object f1XkgwhsgwXL7O9YvRfW(Guid uid)
	{
		return GetExtension(uid);
	}

	internal static Type m0dtk2hs5lm9jpp4Arci(object P_0)
	{
		return ((IUniqueFilterExtension)P_0).FilterType;
	}

	internal static bool moOw90hslxq1eLwjFFIP()
	{
		return usftLHhsdLXOhvMlDxTW == null;
	}

	internal static UniqueFilterHelper eTcmCdhsrmp5l8WHKsRr()
	{
		return usftLHhsdLXOhvMlDxTW;
	}

	internal static Type hc4BV4hsjsSphC6SA7n0(object P_0)
	{
		return ((IUniqueFilterExtension)P_0).EntityType;
	}
}
