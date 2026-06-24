using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Cache.Attributes;

public class ComplexCacheAttribute : Attribute
{
	internal static ComplexCacheAttribute c6V5y4fXCJoHPSFVF82l;

	public string TimestampKey
	{
		[CompilerGenerated]
		get
		{
			return _003CTimestampKey_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CTimestampKey_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ComplexCacheAttribute(string timestampKey)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fPkUTpfXZ2aUvfR9BMgt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			TimestampKey = timestampKey;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
			{
				num = 0;
			}
		}
	}

	internal static void fPkUTpfXZ2aUvfR9BMgt()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool uAUnjLfXvLY6LJtK08KL()
	{
		return c6V5y4fXCJoHPSFVF82l == null;
	}

	internal static ComplexCacheAttribute mhR8B3fX81nE5OsOWkBX()
	{
		return c6V5y4fXCJoHPSFVF82l;
	}
}
