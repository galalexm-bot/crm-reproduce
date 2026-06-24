using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 1000)]
public class Int64RangeWrapperDescriptor : ITypeWrapperDescriptor
{
	private static Int64RangeWrapperDescriptor c4wZ61bG3vQdgYL8emft;

	public Type OriginalType => typeof(Int64Range);

	public Type WrapperType => typeof(Int64RangeWrapper);

	public Type[] GenericArgumentsTypes => null;

	public object CreateWrapper(object obj)
	{
		return new Int64RangeWrapper((Int64Range)obj);
	}

	public object GetObject(object wrapper)
	{
		//Discarded unreachable code: IL_005f
		int num = 2;
		Int64Range int64Range = default(Int64Range);
		Int64RangeWrapper int64RangeWrapper = default(Int64RangeWrapper);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					return int64Range;
				case 4:
					int64Range = default(Int64Range);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					int64RangeWrapper = wrapper as Int64RangeWrapper;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					if (int64RangeWrapper == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 5:
					return int64Range;
				case 3:
					int64Range.From = (yPY5vGbGDU7kn5udrlMQ(int64RangeWrapper) ? new long?(TKU95WbGt1FykBNiLVdg(int64RangeWrapper)) : null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 7;
					}
					continue;
				case 7:
					int64Range.To = (KIsFVZbGwWmYAf6asVpY(int64RangeWrapper) ? new long?(int64RangeWrapper.To) : null);
					num2 = 6;
					continue;
				}
				break;
			}
			int64Range = default(Int64Range);
			num = 5;
		}
	}

	public bool TestType(Type type)
	{
		return false;
	}

	public Int64RangeWrapperDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		g2qTTfbG4PfsarEfsVg3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool zccrJMbGplE3raXVm6C1()
	{
		return c4wZ61bG3vQdgYL8emft == null;
	}

	internal static Int64RangeWrapperDescriptor qAkm6KbGaULn2GJ37l9k()
	{
		return c4wZ61bG3vQdgYL8emft;
	}

	internal static bool yPY5vGbGDU7kn5udrlMQ(object P_0)
	{
		return ((Int64RangeWrapper)P_0).HasFromValue;
	}

	internal static long TKU95WbGt1FykBNiLVdg(object P_0)
	{
		return ((Int64RangeWrapper)P_0).From;
	}

	internal static bool KIsFVZbGwWmYAf6asVpY(object P_0)
	{
		return ((Int64RangeWrapper)P_0).HasToValue;
	}

	internal static void g2qTTfbG4PfsarEfsVg3()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
