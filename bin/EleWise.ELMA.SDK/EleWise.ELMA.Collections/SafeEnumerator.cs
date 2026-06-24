using System;
using System.Collections;
using System.Threading;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Collections;

public sealed class SafeEnumerator : IEnumerator, IDisposable
{
	private readonly IEnumerator inner;

	private readonly ReaderWriterLockSlim lockSlim;

	private static SafeEnumerator arSBp10yMb3WQM9R0E7;

	public object Current => bRiWQn0r0DxIC154NNF(inner);

	public SafeEnumerator(IEnumerator inner, ReaderWriterLockSlim lockSlim)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		NBiTsV09N0Y6icnZ0tZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				this.inner = inner;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num = 1;
				}
				break;
			case 3:
				return;
			case 2:
				fYEgma0dKEMHRWCWBpp(lockSlim);
				num = 3;
				break;
			case 1:
				this.lockSlim = lockSlim;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public void Dispose()
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
				d1ENNO0lRisEFwfRCg1(lockSlim);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool MoveNext()
	{
		return inner.MoveNext();
	}

	public void Reset()
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
				inner.Reset();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void NBiTsV09N0Y6icnZ0tZ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void fYEgma0dKEMHRWCWBpp(object P_0)
	{
		((ReaderWriterLockSlim)P_0).EnterUpgradeableReadLock();
	}

	internal static bool ki9LUg0MCvyGn8ouOiI()
	{
		return arSBp10yMb3WQM9R0E7 == null;
	}

	internal static SafeEnumerator hLgeI30JtPua3fsP9P8()
	{
		return arSBp10yMb3WQM9R0E7;
	}

	internal static void d1ENNO0lRisEFwfRCg1(object P_0)
	{
		((ReaderWriterLockSlim)P_0).ExitUpgradeableReadLock();
	}

	internal static object bRiWQn0r0DxIC154NNF(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}
}
