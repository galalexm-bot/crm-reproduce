using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class IntNullInt32RangeConvertTypeWrapper : IConvertTypeWrapper
{
	internal static IntNullInt32RangeConvertTypeWrapper BGEuf8bfFIq0dyUATdHf;

	public Type OriginalType => typeof(int?);

	public Type ConvertType => lTT2Ebbform1FaIydhSD(typeof(Int32Range).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 2;
		int num2 = num;
		Int32Range int32Range = default(Int32Range);
		int? num3 = default(int?);
		while (true)
		{
			switch (num2)
			{
			case 3:
				int32Range.From = num3;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				num3 = (int?)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				int32Range = default(Int32Range);
				num2 = 3;
				break;
			default:
				return int32Range;
			case 4:
				int32Range.To = num3;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IntNullInt32RangeConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cClNtKbfbY8e9sldboMP();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type lTT2Ebbform1FaIydhSD(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool K10yWIbfBPQYYyeN4Mw3()
	{
		return BGEuf8bfFIq0dyUATdHf == null;
	}

	internal static IntNullInt32RangeConvertTypeWrapper uHgAxPbfW4JwE0YB0hlf()
	{
		return BGEuf8bfFIq0dyUATdHf;
	}

	internal static void cClNtKbfbY8e9sldboMP()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
