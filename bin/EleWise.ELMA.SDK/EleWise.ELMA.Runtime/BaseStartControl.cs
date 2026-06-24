using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime;

public abstract class BaseStartControl : IStartControl
{
	internal static BaseStartControl niQxpIWWGdfffq5XwxIc;

	public abstract void Continue();

	public virtual void Suspend(StartStatus suspendReason)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				Suspend(suspendReason, string.Empty);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public abstract void Suspend(StartStatus suspendReason, string suspendMessage);

	protected BaseStartControl()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fdeGUTWWQmk8EpEeQgxO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool DuSOpdWWEmT7GAF3uJBQ()
	{
		return niQxpIWWGdfffq5XwxIc == null;
	}

	internal static BaseStartControl CuQDcQWWf3jM1KRoUUOE()
	{
		return niQxpIWWGdfffq5XwxIc;
	}

	internal static void fdeGUTWWQmk8EpEeQgxO()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
