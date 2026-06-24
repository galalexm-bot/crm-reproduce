using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services.Impl;

public class FakeVariableServiceBase : IContextBoundVariableService, IAbstractBoundVariableService
{
	private static FakeVariableServiceBase mbUt72BMghTuQiAcbv8e;

	public bool Contains(string name)
	{
		return false;
	}

	public T Get<T>(string name)
	{
		return default(T);
	}

	public bool TryGetValue<T>(string name, out T value)
	{
		value = default(T);
		return false;
	}

	public void Set(string name, object value)
	{
	}

	public void Remove(string key)
	{
	}

	public FakeVariableServiceBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		UbY5b4BMYsGeE9gsGibG();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void UbY5b4BMYsGeE9gsGibG()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool kF2uyGBM5AiHn1vOV6Yp()
	{
		return mbUt72BMghTuQiAcbv8e == null;
	}

	internal static FakeVariableServiceBase GpAe54BMjAd0umBihivH()
	{
		return mbUt72BMghTuQiAcbv8e;
	}
}
