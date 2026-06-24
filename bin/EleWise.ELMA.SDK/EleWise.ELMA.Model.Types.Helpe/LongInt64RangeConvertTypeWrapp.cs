using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class LongInt64RangeConvertTypeWrapper : IConvertTypeWrapper
{
	private static LongInt64RangeConvertTypeWrapper ITDRMlbG9mr7dT9TiPWT;

	public Type OriginalType => cVWwRJbGrnqUkb7TQQkK(typeof(long).TypeHandle);

	public Type ConvertType => cVWwRJbGrnqUkb7TQQkK(typeof(Int64Range).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 3;
		Int64Range int64Range = default(Int64Range);
		long value = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return int64Range;
				case 2:
					break;
				case 1:
					int64Range.To = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					value = OwbDaMbGgnLguHk2J54h(obj);
					num2 = 2;
					continue;
				case 4:
					int64Range.From = value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			int64Range = default(Int64Range);
			num = 4;
		}
	}

	public LongInt64RangeConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		y8KmZLbG5jtTLEnJHRse();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type cVWwRJbGrnqUkb7TQQkK(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static long OwbDaMbGgnLguHk2J54h(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static bool LSXsdDbGdZNMgQVKiObv()
	{
		return ITDRMlbG9mr7dT9TiPWT == null;
	}

	internal static LongInt64RangeConvertTypeWrapper fex6uKbGlGtVWVtbWnjF()
	{
		return ITDRMlbG9mr7dT9TiPWT;
	}

	internal static void y8KmZLbG5jtTLEnJHRse()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
