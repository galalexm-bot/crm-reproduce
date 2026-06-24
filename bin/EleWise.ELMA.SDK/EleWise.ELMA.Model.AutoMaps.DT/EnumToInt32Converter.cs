using System;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.Converters;

internal sealed class EnumToInt32Converter : ITypeConverter
{
	private static EnumToInt32Converter A0GIu6hmburvs6pqweQ3;

	public Type Type => hSfHMEhmEcNdo6TG2riH(typeof(Enum).TypeHandle);

	public bool CanConvertTo(Type type)
	{
		return ieGnD7hmfaO1TttTr1T2(type, TypeOf<int>.Raw);
	}

	public object ConvertTo(object value, Type destinationType)
	{
		return Convert.ChangeType(value, TypeCode.Int32);
	}

	public EnumToInt32Converter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BgBhwMhmQvuMZ8FGGSDo();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type hSfHMEhmEcNdo6TG2riH(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool ieGnD7hmfaO1TttTr1T2(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool bTB4qOhmhcBNEIvl6Jng()
	{
		return A0GIu6hmburvs6pqweQ3 == null;
	}

	internal static EnumToInt32Converter zIPZXNhmGneKRRRwbHer()
	{
		return A0GIu6hmburvs6pqweQ3;
	}

	internal static void BgBhwMhmQvuMZ8FGGSDo()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
