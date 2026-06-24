using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

public class DateModifiedAttribute : Attribute
{
	private DateTime _value;

	private static DateModifiedAttribute Ea1YbOouCLgbEPGcyRHj;

	public DateTime Value
	{
		get
		{
			return _value;
		}
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
					_value = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
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

	public DateModifiedAttribute(long ticks)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sDLvIcouZdi67U60rF2T();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
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
				_value = new DateTime(ticks);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void sDLvIcouZdi67U60rF2T()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool KjWgtFouvwZqkAy2cTeZ()
	{
		return Ea1YbOouCLgbEPGcyRHj == null;
	}

	internal static DateModifiedAttribute QGeusOou8kbHNw5ENW26()
	{
		return Ea1YbOouCLgbEPGcyRHj;
	}
}
