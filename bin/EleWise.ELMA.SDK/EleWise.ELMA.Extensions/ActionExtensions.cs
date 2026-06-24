using System;
using System.Threading;
using EleWise.ELMA.Logging;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class ActionExtensions
{
	private static ActionExtensions rHy7wMGweFDxZYLyWP4A;

	public static void ExecuteWithAttempts(Action action, TimeSpan interval, int attemptCount)
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
				ExecuteWithAttempts(action, interval, attemptCount, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void ExecuteWithAttempts(Action action, TimeSpan interval, int attemptCount, Func<Exception, bool> canRetry)
	{
		Contract.ArgumentNotNull(action, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92E0B21));
		int num = 0;
		bool flag = false;
		int num2 = (int)interval.TotalMilliseconds;
		if (num2 <= 0)
		{
			num2 = 1;
		}
		while (!flag && num < attemptCount)
		{
			num++;
			try
			{
				action();
				flag = true;
			}
			catch (Exception ex)
			{
				if (num >= attemptCount || (canRetry != null && !canRetry(ex)))
				{
					throw;
				}
				Logger.Log.Warn(ex);
				Thread.Sleep(num2);
			}
		}
	}

	internal static bool NaUjMxGwPXINfRh82dMl()
	{
		return rHy7wMGweFDxZYLyWP4A == null;
	}

	internal static ActionExtensions Vvin4fGw1t1jg8y6rEG9()
	{
		return rHy7wMGweFDxZYLyWP4A;
	}
}
