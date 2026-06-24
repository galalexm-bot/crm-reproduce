using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Services;

internal class CompletedAsyncResult : AsyncResult
{
	private static CompletedAsyncResult vn8QfTAvpW4XUcMSJKy;

	public CompletedAsyncResult(AsyncCallback callback, object state)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector(callback, state);
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Complete(completedSynchronously: true);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public static void End(IAsyncResult result)
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
				AsyncResult.End<CompletedAsyncResult>(result);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool qv3ntOAYp2ndnAgUtxk()
	{
		return vn8QfTAvpW4XUcMSJKy == null;
	}

	internal static CompletedAsyncResult a5TwVYA8iJDDHKjdTEx()
	{
		return vn8QfTAvpW4XUcMSJKy;
	}
}
internal class CompletedAsyncResult<T> : AsyncResult
{
	private T data;

	public CompletedAsyncResult(T data, AsyncCallback callback, object state)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector(callback, state);
		this.data = data;
		Complete(completedSynchronously: true);
	}

	public static T End(IAsyncResult result)
	{
		return AsyncResult.End<CompletedAsyncResult<T>>(result).data;
	}
}
