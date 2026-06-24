using System;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework;

public static class ITransformationProviderExtensions
{
	private static ITransformationProviderExtensions uXPFljWOpGv1IUrCoYcu;

	public static void RetryOnDeadlock(this ITransformationProvider provider, Action action)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				chKcqSWOtkr9m52pBFvV(provider, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210695603));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				dsTf8gWOwS9kXSV8hTl5(provider, action, int.MinValue);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void chKcqSWOtkr9m52pBFvV(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void dsTf8gWOwS9kXSV8hTl5(object P_0, object P_1, int retryCount)
	{
		((ITransformationProvider)P_0).RetryOnDeadlock((Action)P_1, retryCount);
	}

	internal static bool OrDh9FWOaPPgcjqQsXTR()
	{
		return uXPFljWOpGv1IUrCoYcu == null;
	}

	internal static ITransformationProviderExtensions nybEVpWODliWU4OFLYbd()
	{
		return uXPFljWOpGv1IUrCoYcu;
	}
}
