using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class ShortNullInt16RangeConvertTypeWrapper : IConvertTypeWrapper
{
	internal static ShortNullInt16RangeConvertTypeWrapper UBgTaUbENRAgSsl0kLG3;

	public Type OriginalType => BS6AVIbEaNHmsXfYwpYB(typeof(short?).TypeHandle);

	public Type ConvertType => BS6AVIbEaNHmsXfYwpYB(typeof(Int16Range).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 2;
		int num2 = num;
		Int16Range int16Range = default(Int16Range);
		short? num3 = default(short?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				int16Range = default(Int16Range);
				num2 = 3;
				break;
			case 3:
				int16Range.From = num3;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return int16Range;
			default:
				int16Range.To = num3;
				num2 = 4;
				break;
			case 2:
				num3 = (short?)obj;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public ShortNullInt16RangeConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
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

	internal static Type BS6AVIbEaNHmsXfYwpYB(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool rAIkSTbE3aR7LnMb8UU4()
	{
		return UBgTaUbENRAgSsl0kLG3 == null;
	}

	internal static ShortNullInt16RangeConvertTypeWrapper Khuu5gbEptFOPMSkQZpS()
	{
		return UBgTaUbENRAgSsl0kLG3;
	}
}
