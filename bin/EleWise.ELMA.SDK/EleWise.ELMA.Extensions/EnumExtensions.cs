using System;

namespace EleWise.ELMA.Extensions;

public static class EnumExtensions
{
	internal static EnumExtensions g31uKTG6WEYhtLLtNSXZ;

	public static bool In(this Enum value, params Enum[] values)
	{
		//Discarded unreachable code: IL_00d0, IL_00df
		int num = 3;
		int num3 = default(int);
		Enum obj = default(Enum);
		Enum[] array = default(Enum[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return false;
				case 2:
					num3 = 0;
					num2 = 4;
					continue;
				case 7:
					if (value.Equals(obj))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num3++;
						num2 = 6;
					}
					continue;
				case 3:
					break;
				case 4:
				case 6:
					if (num3 >= array.Length)
					{
						num2 = 5;
						continue;
					}
					goto case 1;
				case 1:
					obj = array[num3];
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 7;
					}
					continue;
				default:
					return true;
				}
				break;
			}
			array = values;
			num = 2;
		}
	}

	internal static bool afW4ujG6oQsa57veNPGX()
	{
		return g31uKTG6WEYhtLLtNSXZ == null;
	}

	internal static EnumExtensions vRpgyCG6bKt8V9YAaA77()
	{
		return g31uKTG6WEYhtLLtNSXZ;
	}
}
