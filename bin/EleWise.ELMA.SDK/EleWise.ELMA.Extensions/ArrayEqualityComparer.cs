using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Extensions;

public sealed class ArrayEqualityComparer<T> : IEqualityComparer<T[]>
{
	private static readonly EqualityComparer<T> elementComparer;

	internal static object QuNwpqGwNjioLdmHZrnb;

	public bool Equals(T[] first, T[] second)
	{
		//Discarded unreachable code: IL_0076, IL_0085, IL_0110
		int num = 5;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				if (num3 < first.Length)
				{
					num2 = 10;
					break;
				}
				goto case 3;
			case 5:
				if (first == second)
				{
					num2 = 4;
					break;
				}
				if (first != null)
				{
					num2 = 9;
					break;
				}
				goto case 2;
			case 9:
				if (second != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 2;
			case 3:
				return true;
			case 4:
				return true;
			case 2:
				return false;
			case 8:
				if (first.Length != second.Length)
				{
					num2 = 7;
					break;
				}
				num3 = 0;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				return false;
			case 1:
				return false;
			case 10:
			case 11:
				if (elementComparer.Equals(first[num3], second[num3]))
				{
					num3++;
					num2 = 6;
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public int GetHashCode(T[] array)
	{
		//Discarded unreachable code: IL_004d, IL_009a
		int num = 3;
		int num2 = num;
		int num4 = default(int);
		T obj = default(T);
		int num3 = default(int);
		T[] array2 = default(T[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num4 = num4 * 31 + elementComparer.GetHashCode(obj);
				num2 = 10;
				break;
			case 7:
				num3 = 0;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 4;
				}
				break;
			case 9:
				return num4;
			default:
				if (num3 < array2.Length)
				{
					num2 = 6;
					break;
				}
				goto case 9;
			case 5:
				array2 = array;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 7;
				}
				break;
			case 6:
			case 8:
				obj = array2[num3];
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (array == null)
				{
					num2 = 2;
					break;
				}
				num4 = 17;
				num2 = 5;
				break;
			case 10:
				num3++;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return 0;
			}
		}
	}

	public ArrayEqualityComparer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ArrayEqualityComparer()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				elementComparer = EqualityComparer<T>.Default;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool RImyGIGw33iNwhOODGRW()
	{
		return QuNwpqGwNjioLdmHZrnb == null;
	}

	internal static object tOKMjtGwprkGWMLNa8CL()
	{
		return QuNwpqGwNjioLdmHZrnb;
	}
}
