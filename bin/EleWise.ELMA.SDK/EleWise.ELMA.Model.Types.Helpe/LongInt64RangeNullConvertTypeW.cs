using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class LongInt64RangeNullConvertTypeWrapper : IConvertTypeWrapper
{
	private static LongInt64RangeNullConvertTypeWrapper qK8wwAbGjua3Jf0fX7Yp;

	public Type OriginalType => typeof(long?);

	public Type ConvertType => typeof(Int64Range);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 1;
		int num2 = num;
		Int64Range int64Range = default(Int64Range);
		long? num3 = default(long?);
		while (true)
		{
			switch (num2)
			{
			case 2:
				int64Range.From = num3;
				num2 = 4;
				break;
			default:
				int64Range = default(Int64Range);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return int64Range;
			case 4:
				int64Range.To = num3;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				num3 = (long?)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public LongInt64RangeNullConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GuPICJbGUcakEOywyr2o();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool pMeGyibGYVX7TZmfiij0()
	{
		return qK8wwAbGjua3Jf0fX7Yp == null;
	}

	internal static LongInt64RangeNullConvertTypeWrapper SIh4ZqbGLqH0gjtj8yTt()
	{
		return qK8wwAbGjua3Jf0fX7Yp;
	}

	internal static void GuPICJbGUcakEOywyr2o()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
