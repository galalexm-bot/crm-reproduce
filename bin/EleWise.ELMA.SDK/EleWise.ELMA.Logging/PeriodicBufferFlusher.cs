using System;
using System.Collections.Concurrent;
using System.Threading;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Logging;

internal sealed class PeriodicBufferFlusher
{
	private readonly BlockingCollection<IPeriodicBufferingAppender> queue;

	internal static PeriodicBufferFlusher ij7iNOhJ4GZfXoASy0Kk;

	public static PeriodicBufferFlusher Instance { get; }

	private PeriodicBufferFlusher()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		t3dbIWhJAkuRUrLSqivp();
		queue = new BlockingCollection<IPeriodicBufferingAppender>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			ThreadStarter.StartNewThread(ProcessQueue, delegate(Thread t)
			{
				int num2 = 1;
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 1:
						_003C_003Ec.sdL1cGvHWkvuPltPyxTP(t, true);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
						{
							num3 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			});
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
			{
				num = 1;
			}
		}
	}

	public void Register(IPeriodicBufferingAppender appender)
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
				queue.Add(appender);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void ProcessQueue()
	{
		//Discarded unreachable code: IL_0053, IL_0085, IL_00b8, IL_0117, IL_0126
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				try
				{
					queue.Take().Save();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (ThreadAbortException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex2)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							aLXxVChJxSAuALkS93H8(rT5AZwhJ7Hi2D0cK0xUH(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675345419), ex2));
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
							{
								num5 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				break;
			case 2:
				return;
			case 1:
				break;
			}
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
			{
				num2 = 0;
			}
		}
	}

	static PeriodicBufferFlusher()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				Instance = new PeriodicBufferFlusher();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				t3dbIWhJAkuRUrLSqivp();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void t3dbIWhJAkuRUrLSqivp()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool h19aMkhJ6cXMqLXcnIqC()
	{
		return ij7iNOhJ4GZfXoASy0Kk == null;
	}

	internal static PeriodicBufferFlusher yWPNPFhJHyKaFmw97w13()
	{
		return ij7iNOhJ4GZfXoASy0Kk;
	}

	internal static object rT5AZwhJ7Hi2D0cK0xUH()
	{
		return Logger.Log;
	}

	internal static void aLXxVChJxSAuALkS93H8(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}
}
