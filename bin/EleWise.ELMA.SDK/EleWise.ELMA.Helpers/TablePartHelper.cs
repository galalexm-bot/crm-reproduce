using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public static class TablePartHelper
{
	internal static TablePartHelper TQau6ehL383pNcbTf7mb;

	public static long GetLastTemporaryId()
	{
		return ContextVars.GetOrAdd((string)yXGMJihLDujRb9bF6aWJ(-1638402543 ^ -1638638033), () => 0L);
	}

	public static void SetLastTemporaryId(long id)
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
				ContextVars.Set((string)yXGMJihLDujRb9bF6aWJ(-1852837372 ^ -1853072838), id);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static long GetNextTemporaryId()
	{
		long num = GetLastTemporaryId() - 1;
		WT40Z9hLtaKt2cKQ14Tp(num);
		return num;
	}

	internal static object yXGMJihLDujRb9bF6aWJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool e5oUbwhLp7Po3cCAwrCs()
	{
		return TQau6ehL383pNcbTf7mb == null;
	}

	internal static TablePartHelper NkbbUGhLavR1yTyD1ZcC()
	{
		return TQau6ehL383pNcbTf7mb;
	}

	internal static void WT40Z9hLtaKt2cKQ14Tp(long id)
	{
		SetLastTemporaryId(id);
	}
}
