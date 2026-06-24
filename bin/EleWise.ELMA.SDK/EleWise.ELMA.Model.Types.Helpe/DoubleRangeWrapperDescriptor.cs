using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 1000)]
public class DoubleRangeWrapperDescriptor : ITypeWrapperDescriptor
{
	private static DoubleRangeWrapperDescriptor aOnKZXbGoUxquWMnUJNU;

	public Type OriginalType => typeof(DoubleRange);

	public Type WrapperType => typeof(DoubleRangeWrapper);

	public Type[] GenericArgumentsTypes => null;

	public object CreateWrapper(object obj)
	{
		return new DoubleRangeWrapper((DoubleRange)obj);
	}

	public object GetObject(object wrapper)
	{
		//Discarded unreachable code: IL_006b, IL_007a
		int num = 3;
		int num2 = num;
		DoubleRangeWrapper doubleRangeWrapper = default(DoubleRangeWrapper);
		DoubleRange doubleRange = default(DoubleRange);
		while (true)
		{
			switch (num2)
			{
			case 3:
				doubleRangeWrapper = wrapper as DoubleRangeWrapper;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				return doubleRange;
			case 6:
				doubleRange = default(DoubleRange);
				num2 = 4;
				break;
			case 1:
				return doubleRange;
			default:
				doubleRange = default(DoubleRange);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 7;
				}
				break;
			case 2:
				if (doubleRangeWrapper == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			case 4:
				doubleRange.From = (mGFU3AbGGJ8lUDIEEwdR(doubleRangeWrapper) ? new double?(wI5WnRbGERrSFG6AxeDL(doubleRangeWrapper)) : null);
				num2 = 5;
				break;
			case 5:
				doubleRange.To = (doubleRangeWrapper.HasToValue ? new double?(dkwlFEbGfX6c3bk9ssIS(doubleRangeWrapper)) : null);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool TestType(Type type)
	{
		return false;
	}

	public DoubleRangeWrapperDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool RH0iltbGbmTLUu7q7l4H()
	{
		return aOnKZXbGoUxquWMnUJNU == null;
	}

	internal static DoubleRangeWrapperDescriptor EVUJ17bGhbEaTuYHnxEF()
	{
		return aOnKZXbGoUxquWMnUJNU;
	}

	internal static bool mGFU3AbGGJ8lUDIEEwdR(object P_0)
	{
		return ((DoubleRangeWrapper)P_0).HasFromValue;
	}

	internal static double wI5WnRbGERrSFG6AxeDL(object P_0)
	{
		return ((DoubleRangeWrapper)P_0).From;
	}

	internal static double dkwlFEbGfX6c3bk9ssIS(object P_0)
	{
		return ((DoubleRangeWrapper)P_0).To;
	}
}
