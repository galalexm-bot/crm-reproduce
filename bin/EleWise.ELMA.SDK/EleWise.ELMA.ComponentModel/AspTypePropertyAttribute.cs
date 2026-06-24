using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.Property)]
public sealed class AspTypePropertyAttribute : Attribute
{
	private static AspTypePropertyAttribute G6Ef3Rfvi0AJyxOZT6xl;

	public bool CreateConstructorReferences
	{
		[CompilerGenerated]
		get
		{
			return _003CCreateConstructorReferences_003Ek__BackingField;
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
					_003CCreateConstructorReferences_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public AspTypePropertyAttribute(bool createConstructorReferences)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Ur2m4OfvKVvAixjFACM4();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
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
				CreateConstructorReferences = createConstructorReferences;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static bool txgXqdfvRfX6pkTiBdtc()
	{
		return G6Ef3Rfvi0AJyxOZT6xl == null;
	}

	internal static AspTypePropertyAttribute UCmNynfvqrgmYjOvl5c3()
	{
		return G6Ef3Rfvi0AJyxOZT6xl;
	}

	internal static void Ur2m4OfvKVvAixjFACM4()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
