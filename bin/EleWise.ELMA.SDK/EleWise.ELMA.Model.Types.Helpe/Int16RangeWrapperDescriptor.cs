using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 1000)]
public class Int16RangeWrapperDescriptor : ITypeWrapperDescriptor
{
	private static Int16RangeWrapperDescriptor RfTXPubEECh7PTFBSSwu;

	public Type OriginalType => y0uU5NbECRax1hRKKCTH(typeof(Int16Range).TypeHandle);

	public Type WrapperType => y0uU5NbECRax1hRKKCTH(typeof(Int16RangeWrapper).TypeHandle);

	public Type[] GenericArgumentsTypes => null;

	public object CreateWrapper(object obj)
	{
		return new Int16RangeWrapper((Int16Range)obj);
	}

	public object GetObject(object wrapper)
	{
		//Discarded unreachable code: IL_009f, IL_00ae
		int num = 2;
		int num2 = num;
		Int16Range int16Range = default(Int16Range);
		Int16RangeWrapper int16RangeWrapper = default(Int16RangeWrapper);
		while (true)
		{
			switch (num2)
			{
			default:
				int16Range = default(Int16Range);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 7;
				}
				break;
			case 2:
				int16RangeWrapper = wrapper as Int16RangeWrapper;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return int16Range;
			case 6:
				int16Range = default(Int16Range);
				num2 = 5;
				break;
			case 1:
				if (int16RangeWrapper == null)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto default;
			case 5:
				return int16Range;
			case 7:
				int16Range.From = (mjf3pnbEvd0hG7FrQ6AQ(int16RangeWrapper) ? new short?(int16RangeWrapper.From) : null);
				num2 = 3;
				break;
			case 3:
				int16Range.To = (ESCDfobE8w4xZyZGxiEY(int16RangeWrapper) ? new short?(rjL7HMbEZ1OVaaSHy20b(int16RangeWrapper)) : null);
				num2 = 4;
				break;
			}
		}
	}

	public bool TestType(Type type)
	{
		return false;
	}

	public Int16RangeWrapperDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SXprYebEuttXdtrmDams();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type y0uU5NbECRax1hRKKCTH(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool o3FymQbEf9NOZ31VLYGe()
	{
		return RfTXPubEECh7PTFBSSwu == null;
	}

	internal static Int16RangeWrapperDescriptor Dk6GjLbEQ1HxWOTud1Ir()
	{
		return RfTXPubEECh7PTFBSSwu;
	}

	internal static bool mjf3pnbEvd0hG7FrQ6AQ(object P_0)
	{
		return ((Int16RangeWrapper)P_0).HasFromValue;
	}

	internal static bool ESCDfobE8w4xZyZGxiEY(object P_0)
	{
		return ((Int16RangeWrapper)P_0).HasToValue;
	}

	internal static short rjL7HMbEZ1OVaaSHy20b(object P_0)
	{
		return ((Int16RangeWrapper)P_0).To;
	}

	internal static void SXprYebEuttXdtrmDams()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
