using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class ClassMapAttribute : Attribute
{
	private Type mapType;

	internal static ClassMapAttribute TSi8h8oug85MyBkmerrg;

	public Type MapType => mapType;

	public ClassMapAttribute(Type mapType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JhV4m8ouY64VXNmrwYVn();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.mapType = mapType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void JhV4m8ouY64VXNmrwYVn()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool u8HQXIou5i5p029n9bEh()
	{
		return TSi8h8oug85MyBkmerrg == null;
	}

	internal static ClassMapAttribute hnYsMyoujybAAs2nIMJY()
	{
		return TSi8h8oug85MyBkmerrg;
	}
}
