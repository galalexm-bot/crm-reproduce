using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

public class RequiredAttribute : Attribute
{
	private static RequiredAttribute tureY3oIimmGYndjCE9D;

	public bool Required
	{
		[CompilerGenerated]
		get
		{
			return _003CRequired_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CRequired_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public RequiredAttribute(bool required)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		O7vWxQoIKxF7UKYS8VwG();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
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
			Required = required;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
			{
				num = 1;
			}
		}
	}

	internal static bool WQTiOvoIRdeC2HG6BKCf()
	{
		return tureY3oIimmGYndjCE9D == null;
	}

	internal static RequiredAttribute bUGBfuoIqZkxAykLqJ4B()
	{
		return tureY3oIimmGYndjCE9D;
	}

	internal static void O7vWxQoIKxF7UKYS8VwG()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
