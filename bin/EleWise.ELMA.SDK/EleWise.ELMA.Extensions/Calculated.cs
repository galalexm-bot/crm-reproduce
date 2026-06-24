using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Extensions;

public class Calculated<T>
{
	private bool calculated;

	private T value;

	private static object CfL77TG44L1XcTYPUEig;

	public T Value(Func<T> func)
	{
		if (!calculated)
		{
			value = func();
			calculated = true;
		}
		return value;
	}

	public Calculated()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool v3MmK0G46qAMCXuqch6S()
	{
		return CfL77TG44L1XcTYPUEig == null;
	}

	internal static object XY1VkuG4HKqXdP1nwfbd()
	{
		return CfL77TG44L1XcTYPUEig;
	}
}
