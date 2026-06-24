using System.Threading;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Threading;

public class SimpleSynchronizationContext : SynchronizationContext
{
	private static SimpleSynchronizationContext AuhmjQBRCfi5KVcxRPbQ;

	public override SynchronizationContext CreateCopy()
	{
		return new SimpleSynchronizationContext();
	}

	public override void Post(SendOrPostCallback d, object state)
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
				d(state);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void Send(SendOrPostCallback d, object state)
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
				d(state);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public SimpleSynchronizationContext()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		I08nnOBRZlU4UD5oydqp();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool NJBuv6BRvPJnQfSXCALr()
	{
		return AuhmjQBRCfi5KVcxRPbQ == null;
	}

	internal static SimpleSynchronizationContext QryRbiBR8CyDGcls0wy5()
	{
		return AuhmjQBRCfi5KVcxRPbQ;
	}

	internal static void I08nnOBRZlU4UD5oydqp()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
