using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events;

public class SqlCommandExecuteEndEvent : AbstractCallEndEvent<SqlQueryInfo>
{
	private static SqlCommandExecuteEndEvent xKoijVEX9fxS6ww5gB83;

	public SqlCommandExecuteEndEvent(SqlQueryInfo info)
	{
		//Discarded unreachable code: IL_0031, IL_0036
		SingletonReader.JJCZtPuTvSt();
		this._002Ector((CallContextInfo)JaJUwKEXr7pHR5LVsG2p(info), info);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public SqlCommandExecuteEndEvent(CallContextInfo callContextInfo, SqlQueryInfo info)
	{
		//Discarded unreachable code: IL_0032, IL_0037
		JfbUYMEXgsUVnbt0eJ3b();
		this._002Ector(callContextInfo, info, (string)uth0XVEX5QAxhRKFKDqN(info));
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

	public SqlCommandExecuteEndEvent(CallContextInfo callContextInfo, SqlQueryInfo info, string message)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		JfbUYMEXgsUVnbt0eJ3b();
		base._002Ector(callContextInfo, info, message);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object JaJUwKEXr7pHR5LVsG2p(object P_0)
	{
		return ((AbstractCallInfo)P_0).ContextInfo;
	}

	internal static bool mYAE9JEXdXHN7rabAfTu()
	{
		return xKoijVEX9fxS6ww5gB83 == null;
	}

	internal static SqlCommandExecuteEndEvent KUJd6vEXlsueryTwmutm()
	{
		return xKoijVEX9fxS6ww5gB83;
	}

	internal static void JfbUYMEXgsUVnbt0eJ3b()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object uth0XVEX5QAxhRKFKDqN(object P_0)
	{
		return ((AbstractCallInfo)P_0).Description;
	}
}
