using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services;

public class InstanceOf<T>
{
	private static object qtqDd9BxPDdak7Ny9XDO;

	[NotNull]
	public T New { get; private set; }

	public InstanceOf()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				New = InterfaceActivator.Create<T>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private InstanceOf(T instance)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		New = instance;
	}

	public static explicit operator T(InstanceOf<T> instance)
	{
		if (instance != null)
		{
			return instance.New;
		}
		return default(T);
	}

	public static explicit operator InstanceOf<T>(T instance)
	{
		return new InstanceOf<T>(instance);
	}

	internal static bool lhKmZ0Bx1VscullAyvLH()
	{
		return qtqDd9BxPDdak7Ny9XDO == null;
	}

	internal static object UHwKZFBxNuk31brSQIAs()
	{
		return qtqDd9BxPDdak7Ny9XDO;
	}
}
