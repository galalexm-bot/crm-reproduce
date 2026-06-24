using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events;

public class MethodCallEndEvent : AbstractCallEndEvent<MethodCallInfo>
{
	private static MethodCallEndEvent qFUN0UETpOdaOt1JB6TV;

	public MethodCallEndEvent(MethodCallInfo info)
	{
		//Discarded unreachable code: IL_0031, IL_0036
		SxiwLQETtWJuP07TQkh9();
		this._002Ector((CallContextInfo)LKpu43ETwH3vK99QEM87(info), info);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public MethodCallEndEvent(CallContextInfo callContextInfo, MethodCallInfo info)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SxiwLQETtWJuP07TQkh9();
		base._002Ector(callContextInfo, info);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void SxiwLQETtWJuP07TQkh9()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object LKpu43ETwH3vK99QEM87(object P_0)
	{
		return ((AbstractCallInfo)P_0).ContextInfo;
	}

	internal static bool UdO6NIETam3a23laFfe4()
	{
		return qFUN0UETpOdaOt1JB6TV == null;
	}

	internal static MethodCallEndEvent e6sBTNETDN2FuESbJhpA()
	{
		return qFUN0UETpOdaOt1JB6TV;
	}
}
