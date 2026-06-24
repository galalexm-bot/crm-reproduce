using System;
using System.Threading;
using System.Threading.Tasks;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Locking;

internal class MemoryLockService : LockService<MemoryLockServiceSettings>
{
	internal static MemoryLockService tqVNdshgkwXSYLA5LVTE;

	protected override Lock AcquireLockInternalImpl(string name, TimeSpan maxValidFor, TimeSpan timeout, TimeSpan repeatInterval)
	{
		return new Lock(name, maxValidFor, null);
	}

	protected override Task<Lock> AcquireLockInternalAsyncImpl(string name, CancellationToken token, TimeSpan maxValidFor, TimeSpan timeout, TimeSpan repeatInterval)
	{
		return Task.FromResult(AcquireLockInternalImpl(name, maxValidFor, timeout, repeatInterval));
	}

	protected override string GetInternalLockName(string name)
	{
		return (string)X3UWUPhgeey4JYUfPT53(yQbD2chg2eq2ESKniJSu(0x7C1EE318 ^ 0x7C1D7E32), name);
	}

	public MemoryLockService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool xqHFxPhgnkTloMyTyTp4()
	{
		return tqVNdshgkwXSYLA5LVTE == null;
	}

	internal static MemoryLockService zLGf1ShgOsbhY2h2660S()
	{
		return tqVNdshgkwXSYLA5LVTE;
	}

	internal static object yQbD2chg2eq2ESKniJSu(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object X3UWUPhgeey4JYUfPT53(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}
}
