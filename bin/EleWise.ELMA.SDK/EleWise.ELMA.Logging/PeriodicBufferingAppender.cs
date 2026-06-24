using System;
using System.Threading;
using j3AmrhgkCleVTGdEwA;
using log4net.Appender;
using log4net.Core;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Logging;

public sealed class PeriodicBufferingAppender : BufferingForwardingAppender, IPeriodicBufferingAppender
{
	private static readonly int DefaultPeriod;

	private TimeSpan timespanPeriod;

	private int period;

	private readonly Timer timer;

	private static PeriodicBufferingAppender JIIO27hJ0AbSoBIUBdvm;

	public int Period
	{
		get
		{
			return period;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					timespanPeriod = TimeSpan.FromSeconds(value);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					return;
				default:
					throw new ArgumentOutOfRangeException((string)RMxJBChJJt9calWIafYE(-1317790512 ^ -1317564852), (string)xxvyhWhJ9oCAZHGKDt6T(RMxJBChJJt9calWIafYE(-1867198571 ^ -1867031239)));
				case 1:
					if (value > 0)
					{
						period = value;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 2;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 0;
						}
					}
					break;
				}
			}
		}
	}

	public PeriodicBufferingAppender()
	{
		//Discarded unreachable code: IL_001e
		mhJgLOhJMywaeaLKsx65();
		((BufferingForwardingAppender)this)._002Ector();
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				timer = new Timer(TimerRegister, null, -1, -1);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				Period = DefaultPeriod;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void Save()
	{
		//Discarded unreachable code: IL_004b, IL_007e, IL_00db, IL_00ea
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				try
				{
					jZmmxbhJd1qFdYqgIEf0(this, true);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							MyQLCMhJl5tdgVA4l5PY(((AppenderSkeleton)this).get_ErrorHandler(), xxvyhWhJ9oCAZHGKDt6T(RMxJBChJJt9calWIafYE(-583745292 ^ -583576580)), ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
							{
								num4 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				break;
			}
			MoveTimer();
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
			{
				num2 = 2;
			}
		}
	}

	public override void ActivateOptions()
	{
		int num = 2;
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
				MoveTimer();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				((BufferingAppenderSkeleton)this).ActivateOptions();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override void SendBuffer(LoggingEvent[] events)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				((BufferingForwardingAppender)this).SendBuffer(events);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				MoveTimer();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void TimerRegister(object obj)
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
				((PeriodicBufferFlusher)TPAg6WhJrPFTTNaaoi6C()).Register((IPeriodicBufferingAppender)this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void MoveTimer()
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
				yJ0gsmhJ5qXggoFoibk7(timer, timespanPeriod, ARbIo9hJgg3AkFosyJLc(-1.0));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static PeriodicBufferingAppender()
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
				DefaultPeriod = 10;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				mhJgLOhJMywaeaLKsx65();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void mhJgLOhJMywaeaLKsx65()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool KvusXHhJm77qBNPAKYx2()
	{
		return JIIO27hJ0AbSoBIUBdvm == null;
	}

	internal static PeriodicBufferingAppender MccYJIhJyFlQfWfaeQFh()
	{
		return JIIO27hJ0AbSoBIUBdvm;
	}

	internal static object RMxJBChJJt9calWIafYE(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object xxvyhWhJ9oCAZHGKDt6T(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void jZmmxbhJd1qFdYqgIEf0(object P_0, bool P_1)
	{
		((BufferingAppenderSkeleton)P_0).Flush(P_1);
	}

	internal static void MyQLCMhJl5tdgVA4l5PY(object P_0, object P_1, object P_2)
	{
		((IErrorHandler)P_0).Error((string)P_1, (Exception)P_2);
	}

	internal static object TPAg6WhJrPFTTNaaoi6C()
	{
		return PeriodicBufferFlusher.Instance;
	}

	internal static TimeSpan ARbIo9hJgg3AkFosyJLc(double P_0)
	{
		return TimeSpan.FromMilliseconds(P_0);
	}

	internal static bool yJ0gsmhJ5qXggoFoibk7(object P_0, TimeSpan P_1, TimeSpan P_2)
	{
		return ((Timer)P_0).Change(P_1, P_2);
	}
}
