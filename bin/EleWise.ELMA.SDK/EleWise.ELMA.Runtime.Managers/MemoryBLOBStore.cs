using System.Collections.Concurrent;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.Managers;

public class MemoryBLOBStore : IBLOBStore
{
	private readonly ConcurrentDictionary<string, byte[]> dictionary;

	internal static MemoryBLOBStore AuBpoyWJfmnuOnnYW5yC;

	public void Save(string key, byte[] value)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				_003C_003Ec__DisplayClass1_.value = value;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				dictionary.AddOrUpdate(key, _003C_003Ec__DisplayClass1_.value, _003C_003Ec__DisplayClass1_._003CSave_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 3:
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				num2 = 2;
				break;
			}
		}
	}

	public byte[] LoadOrNull(string key)
	{
		int num = 1;
		int num2 = num;
		byte[] value = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return value;
			case 1:
				dictionary.TryGetValue(key, out value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Remove(string key)
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
			{
				dictionary.TryRemove(key, out var _);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public MemoryBLOBStore()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		dictionary = new ConcurrentDictionary<string, byte[]>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool DVMbE8WJQB1Pf1pXKlC9()
	{
		return AuBpoyWJfmnuOnnYW5yC == null;
	}

	internal static MemoryBLOBStore g1YVBoWJCRw6He4TMRfN()
	{
		return AuBpoyWJfmnuOnnYW5yC;
	}
}
