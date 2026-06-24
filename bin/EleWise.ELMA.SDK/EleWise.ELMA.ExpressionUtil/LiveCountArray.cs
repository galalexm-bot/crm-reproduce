using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ExpressionUtil;

internal struct LiveCountArray<T>
{
	public int Count;

	public T[] Items;

	public LiveCountArray(T[] items)
	{
		//Discarded unreachable code: IL_0005
		SingletonReader.JJCZtPuTvSt();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				Items = items;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 1:
				Count = items.Length;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public ref T PushSlot()
	{
		int num = 3;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				Items = Expand(Items);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				num3 = ++Count;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				if (num3 > Items.Length)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 1:
				break;
			}
			break;
		}
		return ref Items[Count - 1];
	}

	public void PushSlot(T item)
	{
		if (++Count > Items.Length)
		{
			Items = Expand(Items);
		}
		Items[Count - 1] = item;
	}

	public void Pop()
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
				Count--;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private static T[] Expand(T[] items)
	{
		int num = 3;
		int num2 = num;
		int num3 = default(int);
		T[] array = default(T[]);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (items.Length == 0)
				{
					num2 = 2;
					break;
				}
				num3 = items.Length;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return array;
			default:
				array = new T[num3 << 1];
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				Array.Copy(items, 0, array, 0, num3);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return new T[4];
			}
		}
	}

	internal static bool F8tdaMGrpWgimBlZEV8B()
	{
		return true;
	}

	internal static object E9eOgEGraX4Ekj2IoPei()
	{
		return null;
	}
}
