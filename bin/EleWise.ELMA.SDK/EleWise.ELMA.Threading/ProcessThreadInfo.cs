using System;
using System.Collections;
using System.Diagnostics;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Threading;

internal static class ProcessThreadInfo
{
	private static readonly Process CurrentProcess;

	private static ProcessThreadInfo pWj3ReBitwTvpLyk9UUE;

	public static TimeSpan TotalProcessorTime
	{
		get
		{
			//Discarded unreachable code: IL_0047, IL_0056, IL_00af, IL_00e7, IL_0127, IL_0136, IL_0142
			int num = 4;
			int num2 = num;
			ProcessThread processThread2 = default(ProcessThread);
			ProcessThread processThread = default(ProcessThread);
			while (true)
			{
				switch (num2)
				{
				default:
					processThread2 = processThread;
					num2 = 5;
					break;
				case 3:
					if (processThread == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				case 1:
				case 2:
					return TimeSpan.Zero;
				case 5:
					try
					{
						TimeSpan timeSpan = oDsqQ9Bi0UuXUlpmAYTD(processThread);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => timeSpan, 
							_ => timeSpan, 
						};
					}
					finally
					{
						int num4;
						if (processThread2 == null)
						{
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
							{
								num4 = 0;
							}
							goto IL_00eb;
						}
						goto IL_0101;
						IL_0101:
						ftddWCBimE4j1FHMcZLM(processThread2);
						num4 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
						{
							num4 = 1;
						}
						goto IL_00eb;
						IL_00eb:
						switch (num4)
						{
						case 1:
							goto end_IL_00c6;
						case 2:
							goto end_IL_00c6;
						}
						goto IL_0101;
						end_IL_00c6:;
					}
				case 4:
					processThread = (ProcessThread)G5XX76BixWtdk4eOGSQ5();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}
	}

	public static TimeSpan UserProcessorTime
	{
		get
		{
			//Discarded unreachable code: IL_0039, IL_0048, IL_00bf, IL_00f7, IL_012f, IL_013e
			int num = 3;
			ProcessThread processThread = default(ProcessThread);
			ProcessThread processThread2 = default(ProcessThread);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						processThread = (ProcessThread)G5XX76BixWtdk4eOGSQ5();
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 0;
						}
						continue;
					case 4:
						processThread2 = processThread;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num2 = 1;
						}
						continue;
					default:
						return TimeSpan.Zero;
					case 1:
						try
						{
							TimeSpan timeSpan = eRpFttBiysmjAqXrVa21(processThread);
							int num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
							{
								num3 = 0;
							}
							return num3 switch
							{
								0 => timeSpan, 
								_ => timeSpan, 
							};
						}
						finally
						{
							if (processThread2 != null)
							{
								int num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
								{
									num4 = 0;
								}
								while (true)
								{
									switch (num4)
									{
									default:
										((IDisposable)processThread2).Dispose();
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
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
						}
					case 2:
						if (processThread == null)
						{
							break;
						}
						goto case 4;
					}
					break;
				}
				num = 5;
			}
		}
	}

	public static TimeSpan PrivilegedProcessorTime
	{
		get
		{
			//Discarded unreachable code: IL_0077, IL_009f, IL_00df, IL_00ee, IL_00fa, IL_0109, IL_0119, IL_0128
			int num = 1;
			int num2 = num;
			ProcessThread processThread2 = default(ProcessThread);
			ProcessThread processThread = default(ProcessThread);
			while (true)
			{
				switch (num2)
				{
				case 3:
					processThread2 = processThread;
					num2 = 4;
					break;
				default:
					if (processThread == null)
					{
						num2 = 5;
						break;
					}
					goto case 3;
				case 4:
					try
					{
						TimeSpan timeSpan = SX56oDBiMK55SvrayuXM(processThread);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => timeSpan, 
							_ => timeSpan, 
						};
					}
					finally
					{
						int num4;
						if (processThread2 == null)
						{
							num4 = 2;
							goto IL_00a3;
						}
						goto IL_00b9;
						IL_00a3:
						switch (num4)
						{
						default:
							goto end_IL_008e;
						case 1:
							break;
						case 2:
							goto end_IL_008e;
						case 0:
							goto end_IL_008e;
						}
						goto IL_00b9;
						IL_00b9:
						((IDisposable)processThread2).Dispose();
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num4 = 0;
						}
						goto IL_00a3;
						end_IL_008e:;
					}
				case 2:
				case 5:
					return TimeSpan.Zero;
				case 1:
					processThread = (ProcessThread)G5XX76BixWtdk4eOGSQ5();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public static ProcessThread GetCurrentProcessThread()
	{
		//Discarded unreachable code: IL_005d, IL_006c, IL_010a, IL_0119, IL_014c, IL_0180, IL_01ac, IL_01bb
		int num = 3;
		int num2 = num;
		IEnumerator enumerator = default(IEnumerator);
		ProcessThread result = default(ProcessThread);
		ProcessThread processThread = default(ProcessThread);
		int currentThreadId = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				enumerator = (IEnumerator)axypKvBiH1ocZSqGdQGf(hvXs7aBi6VGVSQLTLMgo(CurrentProcess));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			default:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							goto IL_007b;
						}
						goto IL_00ed;
						IL_007b:
						while (true)
						{
							switch (num3)
							{
							case 2:
								result = processThread;
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
								{
									num3 = 1;
								}
								continue;
							case 5:
								if (Fmxtb5Bi7RND6eFLRI2n(processThread) == currentThreadId)
								{
									int num4 = 2;
									num3 = num4;
									continue;
								}
								break;
							case 4:
								goto IL_00ed;
							case 3:
								goto end_IL_00d7;
							case 1:
								return result;
							}
							break;
						}
						continue;
						IL_00ed:
						processThread = (ProcessThread)zEFtGhBiAS7TcNAjVag0(enumerator);
						num3 = 5;
						goto IL_007b;
						continue;
						end_IL_00d7:
						break;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						case 2:
							disposable.Dispose();
							num5 = 3;
							continue;
						case 1:
							break;
						default:
							if (disposable == null)
							{
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
								{
									num5 = 1;
								}
								continue;
							}
							goto case 2;
						case 3:
							break;
						}
						break;
					}
				}
				goto case 1;
			case 1:
				return null;
			case 3:
				currentThreadId = AppDomain.GetCurrentThreadId();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	static ProcessThreadInfo()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				CurrentProcess = Process.GetCurrentProcess();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object hvXs7aBi6VGVSQLTLMgo(object P_0)
	{
		return ((Process)P_0).Threads;
	}

	internal static object axypKvBiH1ocZSqGdQGf(object P_0)
	{
		return ((ReadOnlyCollectionBase)P_0).GetEnumerator();
	}

	internal static object zEFtGhBiAS7TcNAjVag0(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static int Fmxtb5Bi7RND6eFLRI2n(object P_0)
	{
		return ((ProcessThread)P_0).Id;
	}

	internal static bool E9y61BBiwxJifGZ4P4wO()
	{
		return pWj3ReBitwTvpLyk9UUE == null;
	}

	internal static ProcessThreadInfo Q3goFFBi45GdSxcQGYdk()
	{
		return pWj3ReBitwTvpLyk9UUE;
	}

	internal static object G5XX76BixWtdk4eOGSQ5()
	{
		return GetCurrentProcessThread();
	}

	internal static TimeSpan oDsqQ9Bi0UuXUlpmAYTD(object P_0)
	{
		return ((ProcessThread)P_0).TotalProcessorTime;
	}

	internal static void ftddWCBimE4j1FHMcZLM(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static TimeSpan eRpFttBiysmjAqXrVa21(object P_0)
	{
		return ((ProcessThread)P_0).UserProcessorTime;
	}

	internal static TimeSpan SX56oDBiMK55SvrayuXM(object P_0)
	{
		return ((ProcessThread)P_0).PrivilegedProcessorTime;
	}
}
