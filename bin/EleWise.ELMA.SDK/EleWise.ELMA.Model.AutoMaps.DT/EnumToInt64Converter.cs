using System;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.Converters;

internal sealed class EnumToInt64Converter : ITypeConverter
{
	private static EnumToInt64Converter HB3mkKh0sF0mTRwdCtJU;

	public Type Type => pd5FYvhmFRM6oV2lvODd(typeof(Enum).TypeHandle);

	public bool CanConvertTo(Type type)
	{
		return j2dZnYhmB3YmDuZAGsH3(type, TypeOf<long>.Raw);
	}

	public object ConvertTo(object value, Type destinationType)
	{
		return gJtOJBhmW0Mt5umyXQIo(value, TypeCode.Int64);
	}

	public EnumToInt64Converter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hZI0nphmoXfb4m08HpJE();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type pd5FYvhmFRM6oV2lvODd(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool j2dZnYhmB3YmDuZAGsH3(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool eYrlaoh0cpRr8l3n1ZP6()
	{
		return HB3mkKh0sF0mTRwdCtJU == null;
	}

	internal static EnumToInt64Converter SdscJEh0zMk5qlximYXx()
	{
		return HB3mkKh0sF0mTRwdCtJU;
	}

	internal static object gJtOJBhmW0Mt5umyXQIo(object P_0, TypeCode P_1)
	{
		return Convert.ChangeType(P_0, P_1);
	}

	internal static void hZI0nphmoXfb4m08HpJE()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
