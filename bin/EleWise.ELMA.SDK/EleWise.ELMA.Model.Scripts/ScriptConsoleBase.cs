using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts;

public abstract class ScriptConsoleBase : IScriptConsole
{
	internal static ScriptConsoleBase d6nr6SbiPH8Ti5mCukbg;

	public abstract void Write(string message);

	public virtual void WriteLine(string message)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				wxWSgZbia9T99xSjYF33(this, z92R4dbipSvCYQ7U3J6p(message, rRcgOPbi3hVhidHH33wE(0x7E6E5A0B ^ 0x7E6E3935)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected ScriptConsoleBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		iNC2SHbiDoZ7tJKV8tCa();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object rRcgOPbi3hVhidHH33wE(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object z92R4dbipSvCYQ7U3J6p(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void wxWSgZbia9T99xSjYF33(object P_0, object P_1)
	{
		((ScriptConsoleBase)P_0).Write((string)P_1);
	}

	internal static bool nAndw1bi1tKmuSsHsd7Z()
	{
		return d6nr6SbiPH8Ti5mCukbg == null;
	}

	internal static ScriptConsoleBase l9Qr5SbiNcrc5vFuvQQ8()
	{
		return d6nr6SbiPH8Ti5mCukbg;
	}

	internal static void iNC2SHbiDoZ7tJKV8tCa()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
