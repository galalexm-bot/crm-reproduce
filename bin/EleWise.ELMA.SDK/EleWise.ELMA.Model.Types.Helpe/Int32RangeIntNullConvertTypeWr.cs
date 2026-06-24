using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class Int32RangeIntNullConvertTypeWrapper : IConvertTypeWrapper
{
	internal static Int32RangeIntNullConvertTypeWrapper NlRRSjbElfQRvXMA4lRT;

	public Type OriginalType => SHdVnybE56By1js2CBWV(typeof(Int32Range).TypeHandle);

	public Type ConvertType => typeof(int?);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 1;
		int num2 = num;
		Int32Range int32Range = default(Int32Range);
		while (true)
		{
			switch (num2)
			{
			default:
				return int32Range.From;
			case 1:
				int32Range = (Int32Range)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public Int32RangeIntNullConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nCJhZFbEj7cMyCAsgXh2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type SHdVnybE56By1js2CBWV(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool gbfvEpbErV6tjxfDFG2g()
	{
		return NlRRSjbElfQRvXMA4lRT == null;
	}

	internal static Int32RangeIntNullConvertTypeWrapper m9xwa3bEgUcInOsCSxXB()
	{
		return NlRRSjbElfQRvXMA4lRT;
	}

	internal static void nCJhZFbEj7cMyCAsgXh2()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
