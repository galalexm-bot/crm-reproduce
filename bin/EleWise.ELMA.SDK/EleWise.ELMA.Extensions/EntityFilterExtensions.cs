using System.Collections.Generic;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Extensions;

public static class EntityFilterExtensions
{
	private static EntityFilterExtensions fjBN4wGafCcIFuSxTVFZ;

	public static void SetQueryWithParameters(this IEntityFilter filter, string query, params KeyValuePair<string, object>[] queryParameters)
	{
		//Discarded unreachable code: IL_0045, IL_0054
		int num = 2;
		int num2 = num;
		int num3 = default(int);
		KeyValuePair<string, object>[] array = default(KeyValuePair<string, object>[]);
		KeyValuePair<string, object> keyValuePair = default(KeyValuePair<string, object>);
		while (true)
		{
			switch (num2)
			{
			case 7:
				num3++;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return;
			case 1:
				array = queryParameters;
				num2 = 4;
				break;
			default:
				if (num3 >= array.Length)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 6;
			case 3:
				qMvjh9GaZuOm8kXJnnIv(sMubjHGa8XBeXcKHsEMf(filter), keyValuePair.Key, keyValuePair.Value);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 7;
				}
				break;
			case 4:
				num3 = 0;
				num2 = 8;
				break;
			case 6:
				keyValuePair = array[num3];
				num2 = 3;
				break;
			case 2:
				n1DqOcGavBaJKICZbI3v(filter, query);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void n1DqOcGavBaJKICZbI3v(object P_0, object P_1)
	{
		((IEntityFilter)P_0).Query = (string)P_1;
	}

	internal static object sMubjHGa8XBeXcKHsEMf(object P_0)
	{
		return ((IEntityFilter)P_0).QueryParameters;
	}

	internal static object qMvjh9GaZuOm8kXJnnIv(object P_0, object P_1, object P_2)
	{
		return ((QueryParameters)P_0).Set((string)P_1, P_2);
	}

	internal static bool J4FOqjGaQIO6VcyjqPZE()
	{
		return fjBN4wGafCcIFuSxTVFZ == null;
	}

	internal static EntityFilterExtensions WJBZgZGaCN2wgWlqPnQG()
	{
		return fjBN4wGafCcIFuSxTVFZ;
	}
}
