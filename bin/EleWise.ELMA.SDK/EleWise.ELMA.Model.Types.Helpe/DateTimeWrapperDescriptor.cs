using System;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 1000)]
public class DateTimeWrapperDescriptor : ITypeWrapperDescriptor
{
	internal static DateTimeWrapperDescriptor AQu2d1bQvFspOf616kXj;

	public Type OriginalType => typeof(DateTime);

	public Type WrapperType => typeof(DateTimeWrapper);

	public Type[] GenericArgumentsTypes => null;

	public object CreateWrapper(object obj)
	{
		return new DateTimeWrapper((DateTime?)obj);
	}

	public object GetObject(object wrapper)
	{
		return ((DateTimeWrapper)wrapper).Value;
	}

	public bool TestType(Type type)
	{
		return false;
	}

	public DateTimeWrapperDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qGgv6CbQu82VeTg3WfOH();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool gAwdVqbQ8ADE9Pi7YpZO()
	{
		return AQu2d1bQvFspOf616kXj == null;
	}

	internal static DateTimeWrapperDescriptor VUttRqbQZUaE9SRO0YdD()
	{
		return AQu2d1bQvFspOf616kXj;
	}

	internal static void qGgv6CbQu82VeTg3WfOH()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
