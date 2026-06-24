using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class Int64RangeLongConvertTypeWrapper : IConvertTypeWrapper
{
	private static Int64RangeLongConvertTypeWrapper hbABRsbG6pHJFtNrHLwS;

	public Type OriginalType => typeof(Int64Range);

	public Type ConvertType => Tp0Rj6bG7YU30UD7vQBB(typeof(long).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		//Discarded unreachable code: IL_0081, IL_008b
		int num = 2;
		int num2 = num;
		long? from = default(long?);
		Int64Range int64Range = default(Int64Range);
		long num3;
		while (true)
		{
			switch (num2)
			{
			case 1:
				from = int64Range.From;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				from = int64Range.From;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 3;
				}
				continue;
			case 4:
				num3 = 0L;
				break;
			case 2:
				int64Range = (Int64Range)obj;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 1;
				}
				continue;
			default:
				if (from.HasValue)
				{
					num2 = 5;
					continue;
				}
				goto case 4;
			case 3:
				num3 = from.Value;
				break;
			}
			break;
		}
		return num3;
	}

	public Int64RangeLongConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SQlGggbGxVpbCeIOdgQ8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type Tp0Rj6bG7YU30UD7vQBB(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool A9fdjXbGHNxtxxmhnX3p()
	{
		return hbABRsbG6pHJFtNrHLwS == null;
	}

	internal static Int64RangeLongConvertTypeWrapper XQtD86bGAgplWTSs2QSy()
	{
		return hbABRsbG6pHJFtNrHLwS;
	}

	internal static void SQlGggbGxVpbCeIOdgQ8()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
