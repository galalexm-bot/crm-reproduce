using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Events;

public class SqlCommandExecuteStartEvent : AbstractCallStartEvent<SqlQueryInfo>
{
	internal static SqlCommandExecuteStartEvent ropgOjEKlhpgY2wOhfLj;

	public SqlCommandExecuteStartEvent(SqlQueryInfo info)
	{
		//Discarded unreachable code: IL_0021, IL_0026, IL_0091, IL_00a0
		SingletonReader.JJCZtPuTvSt();
		base._002Ector((CallContextInfo)qrVVnXEK54GuKIYM3s2I(info), info);
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 5:
				if (info.Paramaters.Count <= 0)
				{
					num = 4;
					continue;
				}
				break;
			case 2:
				if (info.Paramaters == null)
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num = 1;
					}
					continue;
				}
				goto case 5;
			case 4:
				return;
			case 1:
				return;
			case 0:
				return;
			case 3:
				break;
			}
			base.Message = base.Message + SR.T((string)xfbrinEKjlW1H9UnW7Ix(0x463A0F3C ^ 0x463E590A), ignoreTranslationMode: true) + (string)CEYP9mEKY9CPAJ4FDrO5(info.Paramaters);
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
			{
				num = 0;
			}
		}
	}

	public SqlCommandExecuteStartEvent(CallContextInfo callContextInfo, SqlQueryInfo info)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		HsK7bFEKL44rOkUHU9wL();
		base._002Ector(callContextInfo, info);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				if (info.Paramaters.Count > 0)
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num = 1;
					}
					break;
				}
				return;
			case 1:
				base.Message = base.Message + SR.T((string)xfbrinEKjlW1H9UnW7Ix(-1870892489 ^ -1871174655), ignoreTranslationMode: true) + (string)CEYP9mEKY9CPAJ4FDrO5(info.Paramaters);
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				return;
			default:
				if (info.Paramaters == null)
				{
					return;
				}
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public SqlCommandExecuteStartEvent(CallContextInfo callContextInfo, SqlQueryInfo info, string message)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		HsK7bFEKL44rOkUHU9wL();
		base._002Ector(callContextInfo, info, message);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object qrVVnXEK54GuKIYM3s2I(object P_0)
	{
		return ((AbstractCallInfo)P_0).ContextInfo;
	}

	internal static object xfbrinEKjlW1H9UnW7Ix(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object CEYP9mEKY9CPAJ4FDrO5(object P_0)
	{
		return ClassSerializationHelper.SerializeObjectByJsonNet(P_0);
	}

	internal static bool aCsBCTEKruWQiPEun2Rj()
	{
		return ropgOjEKlhpgY2wOhfLj == null;
	}

	internal static SqlCommandExecuteStartEvent KkfCQvEKgr9IVbLCOBvx()
	{
		return ropgOjEKlhpgY2wOhfLj;
	}

	internal static void HsK7bFEKL44rOkUHU9wL()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
