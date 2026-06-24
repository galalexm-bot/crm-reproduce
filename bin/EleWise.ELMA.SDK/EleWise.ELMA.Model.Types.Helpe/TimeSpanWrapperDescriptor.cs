using System;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 1000)]
public class TimeSpanWrapperDescriptor : ITypeWrapperDescriptor
{
	private static TimeSpanWrapperDescriptor HRd3cbbbny5kaGXvkiFs;

	public Type OriginalType => cJhCxAbbe2qwsU75bXhH(typeof(TimeSpan).TypeHandle);

	public Type WrapperType => cJhCxAbbe2qwsU75bXhH(typeof(TimeSpanWrapper).TypeHandle);

	public Type[] GenericArgumentsTypes => null;

	public object CreateWrapper(object obj)
	{
		return new TimeSpanWrapper((TimeSpan?)obj);
	}

	public object GetObject(object wrapper)
	{
		return ((TimeSpanWrapper)wrapper).Value;
	}

	public bool TestType(Type type)
	{
		return false;
	}

	public TimeSpanWrapperDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		CUJk6ObbPnhufhdIGj9t();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type cJhCxAbbe2qwsU75bXhH(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool tdrjJLbbOxqnI5wQXfA6()
	{
		return HRd3cbbbny5kaGXvkiFs == null;
	}

	internal static TimeSpanWrapperDescriptor FKYRZDbb2k4797MGt0k5()
	{
		return HRd3cbbbny5kaGXvkiFs;
	}

	internal static void CUJk6ObbPnhufhdIGj9t()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
