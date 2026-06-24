using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class AspMvcAreaMasterLocationFormatAttribute : Attribute
{
	private static AspMvcAreaMasterLocationFormatAttribute Wg6BYMfQCTroYtO1vu7Q;

	public string Format
	{
		[CompilerGenerated]
		get
		{
			return _003CFormat_003Ek__BackingField;
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
				case 1:
					_003CFormat_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public AspMvcAreaMasterLocationFormatAttribute(string format)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		P5g9N2fQZvjv0PLuh1fu();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Format = format;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void P5g9N2fQZvjv0PLuh1fu()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool o0ykl5fQvev3mlFYjJae()
	{
		return Wg6BYMfQCTroYtO1vu7Q == null;
	}

	internal static AspMvcAreaMasterLocationFormatAttribute px16MMfQ8BJDh3U9LUNI()
	{
		return Wg6BYMfQCTroYtO1vu7Q;
	}
}
