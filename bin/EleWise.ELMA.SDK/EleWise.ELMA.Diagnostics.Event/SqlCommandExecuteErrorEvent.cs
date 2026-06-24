using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Events;

public class SqlCommandExecuteErrorEvent : AbstractCallErrorEvent<SqlQueryInfo>
{
	private static SqlCommandExecuteErrorEvent BYOgyOEXsox6Dv1KSCSl;

	public SqlCommandExecuteErrorEvent(SqlQueryInfo info)
	{
		//Discarded unreachable code: IL_0031, IL_0036
		CUGKoyETFxqes9M4elaO();
		this._002Ector((CallContextInfo)uRhwblETBQaC9LY7k5Um(info), info);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public SqlCommandExecuteErrorEvent(CallContextInfo callContextInfo, SqlQueryInfo info)
	{
		//Discarded unreachable code: IL_0032, IL_0037
		CUGKoyETFxqes9M4elaO();
		this._002Ector(callContextInfo, info, (string)yJNbS3ETWsw2qXZ0TtvJ(info));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public SqlCommandExecuteErrorEvent(CallContextInfo callContextInfo, SqlQueryInfo info, string message)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		CUGKoyETFxqes9M4elaO();
		base._002Ector(callContextInfo, info, message);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void CUGKoyETFxqes9M4elaO()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object uRhwblETBQaC9LY7k5Um(object P_0)
	{
		return ((AbstractCallInfo)P_0).ContextInfo;
	}

	internal static bool cgdI6bEXcQdX5TI94ewY()
	{
		return BYOgyOEXsox6Dv1KSCSl == null;
	}

	internal static SqlCommandExecuteErrorEvent OTXs1qEXzIrMKMBjYDAh()
	{
		return BYOgyOEXsox6Dv1KSCSl;
	}

	internal static object yJNbS3ETWsw2qXZ0TtvJ(object P_0)
	{
		return ((AbstractCallInfo)P_0).Description;
	}
}
