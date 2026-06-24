using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 1000)]
public class MoneyWrapperDescriptor : ITypeWrapperDescriptor
{
	private static MoneyWrapperDescriptor BG17j1bf6NhsLc0CkIp6;

	public Type OriginalType => MutU6ebf7Ys1cZTRbJCt(typeof(Money).TypeHandle);

	public Type WrapperType => MutU6ebf7Ys1cZTRbJCt(typeof(MoneyWrapper).TypeHandle);

	public Type[] GenericArgumentsTypes => null;

	public object CreateWrapper(object obj)
	{
		return new MoneyWrapper((Money)obj);
	}

	public object GetObject(object wrapper)
	{
		return ((MoneyWrapper)wrapper).Value;
	}

	public bool TestType(Type type)
	{
		return false;
	}

	public MoneyWrapperDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type MutU6ebf7Ys1cZTRbJCt(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool Dhe8EHbfHm9gCHvdiTic()
	{
		return BG17j1bf6NhsLc0CkIp6 == null;
	}

	internal static MoneyWrapperDescriptor cyqakUbfAh3ie854L1qF()
	{
		return BG17j1bf6NhsLc0CkIp6;
	}
}
