using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class Int16RangeShortNullConvertTypeWrapper : IConvertTypeWrapper
{
	internal static Int16RangeShortNullConvertTypeWrapper hJPDbRbEq31JbPIpb2s9;

	public Type OriginalType => SrfLGhbETUE5MI0gC7ij(typeof(Int16Range).TypeHandle);

	public Type ConvertType => SrfLGhbETUE5MI0gC7ij(typeof(short?).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 1;
		int num2 = num;
		Int16Range int16Range = default(Int16Range);
		while (true)
		{
			switch (num2)
			{
			default:
				return int16Range.From;
			case 1:
				int16Range = (Int16Range)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public Int16RangeShortNullConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WCmfgBbEkya9YwuFq3yP();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type SrfLGhbETUE5MI0gC7ij(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool zocjTHbEKSbbaSXnJ5jk()
	{
		return hJPDbRbEq31JbPIpb2s9 == null;
	}

	internal static Int16RangeShortNullConvertTypeWrapper ew41lAbEX6Yj0b9sH81R()
	{
		return hJPDbRbEq31JbPIpb2s9;
	}

	internal static void WCmfgBbEkya9YwuFq3yP()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
