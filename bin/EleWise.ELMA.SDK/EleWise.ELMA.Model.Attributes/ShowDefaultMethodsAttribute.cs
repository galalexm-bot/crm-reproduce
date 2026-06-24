using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

public class ShowDefaultMethodsAttribute : Attribute
{
	private static ShowDefaultMethodsAttribute YiALDkoCfeZwNa6w5wID;

	public bool ShowDefaultMethods
	{
		[CompilerGenerated]
		get
		{
			return _003CShowDefaultMethods_003Ek__BackingField;
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
				case 1:
					_003CShowDefaultMethods_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
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

	public ShowDefaultMethodsAttribute(bool show)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		lfT2c7oCvBgE2LH6yOMv();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
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
				ShowDefaultMethods = show;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool rq0Wu8oCQC2AErJVfrpx()
	{
		return YiALDkoCfeZwNa6w5wID == null;
	}

	internal static ShowDefaultMethodsAttribute pwpAUPoCC59gdJou3lPs()
	{
		return YiALDkoCfeZwNa6w5wID;
	}

	internal static void lfT2c7oCvBgE2LH6yOMv()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
