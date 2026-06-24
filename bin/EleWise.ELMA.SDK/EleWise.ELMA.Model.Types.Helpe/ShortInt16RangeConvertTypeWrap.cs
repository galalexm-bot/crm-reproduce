using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class ShortInt16RangeConvertTypeWrapper : IConvertTypeWrapper
{
	internal static ShortInt16RangeConvertTypeWrapper ol4rGebEnb848U8tj9H5;

	public Type OriginalType => mRovxHbEeMUR5wvyS8b0(typeof(short).TypeHandle);

	public Type ConvertType => mRovxHbEeMUR5wvyS8b0(typeof(Int16Range).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 4;
		int num2 = num;
		Int16Range int16Range = default(Int16Range);
		short value = default(short);
		while (true)
		{
			switch (num2)
			{
			default:
				int16Range.To = value;
				num2 = 2;
				break;
			case 1:
				int16Range.From = value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				int16Range = default(Int16Range);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return int16Range;
			case 4:
				value = URW689bEPkG8y7x2m6np(obj);
				num2 = 3;
				break;
			}
		}
	}

	public ShortInt16RangeConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		DFXAuFbE1S7B4sgQZ6RR();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type mRovxHbEeMUR5wvyS8b0(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static short URW689bEPkG8y7x2m6np(object P_0)
	{
		return Convert.ToInt16(P_0);
	}

	internal static bool NnbcDXbEOriPojJ5aE4N()
	{
		return ol4rGebEnb848U8tj9H5 == null;
	}

	internal static ShortInt16RangeConvertTypeWrapper OhyfoebE2Jvm1AWbAhAJ()
	{
		return ol4rGebEnb848U8tj9H5;
	}

	internal static void DFXAuFbE1S7B4sgQZ6RR()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
