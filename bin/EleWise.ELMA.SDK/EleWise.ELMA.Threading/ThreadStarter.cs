using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Context;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Threading;

public static class ThreadStarter
{
	private class PrivateThreadStarter
	{
		private Guid createdParentContextInfoUid;

		internal static PrivateThreadStarter uiB9t6QCMlivvHrMg4Px;

		private ThreadStart Start
		{
			[CompilerGenerated]
			get
			{
				return _003CStart_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CStart_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		private ParameterizedThreadStart ParametrizedStart
		{
			[CompilerGenerated]
			get
			{
				return _003CParametrizedStart_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CParametrizedStart_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		private WaitCallback Callback
		{
			[CompilerGenerated]
			get
			{
				return _003CCallback_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CCallback_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		private int MaxStackSize
		{
			[CompilerGenerated]
			get
			{
				return _003CMaxStackSize_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CMaxStackSize_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		private CultureInfo CurrentCulture
		{
			[CompilerGenerated]
			get
			{
				return _003CCurrentCulture_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CCurrentCulture_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		private object State
		{
			[CompilerGenerated]
			get
			{
				return _003CState_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
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
						_003CState_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		private Action<Thread> BeforeThreadStart { get; set; }

		public PrivateThreadStarter(ThreadStart start, int maxStackSize, CultureInfo currentCulture, object state, Action<Thread> beforeThreadStart)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			Start = start;
			MaxStackSize = maxStackSize;
			CurrentCulture = currentCulture;
			State = state;
			BeforeThreadStart = beforeThreadStart;
		}

		public PrivateThreadStarter(ParameterizedThreadStart parametrizedStart, int maxStackSize, CultureInfo currentCulture, object state, Action<Thread> beforeThreadStart)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			ParametrizedStart = parametrizedStart;
			MaxStackSize = maxStackSize;
			CurrentCulture = currentCulture;
			State = state;
			BeforeThreadStart = beforeThreadStart;
		}

		public PrivateThreadStarter(WaitCallback callback, CultureInfo cultureInfo, object state)
		{
			//Discarded unreachable code: IL_001a, IL_001f
			C9yB4oQCdRpBBmw1g66a();
			base._002Ector();
			int num = 3;
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 2:
					CurrentCulture = cultureInfo;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num = 1;
					}
					break;
				case 3:
					Callback = callback;
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num = 2;
					}
					break;
				case 1:
					State = state;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public bool QueueThread()
		{
			//Discarded unreachable code: IL_0049, IL_0108, IL_015c, IL_016b
			bool result = default(bool);
			switch (1)
			{
			case 1:
				try
				{
					int num;
					if (HNNs93QClGC4h7sgBr9a())
					{
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num = 1;
						}
						goto IL_004d;
					}
					goto IL_00a3;
					IL_00a3:
					result = ThreadPool.QueueUserWorkItem(InternalThread, this);
					num = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num = 3;
					}
					goto IL_004d;
					IL_004d:
					CallContextInfo currentDiagnosticSession = default(CallContextInfo);
					while (true)
					{
						switch (num)
						{
						case 4:
							if (currentDiagnosticSession != null)
							{
								num = 2;
								continue;
							}
							break;
						case 2:
							createdParentContextInfoUid = LD9HqnQCgrjfWh12JmAq(currentDiagnosticSession);
							num = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
							{
								num = 0;
							}
							continue;
						case 1:
							currentDiagnosticSession = ((DiagnosticsManager)h8GfXhQCry9p3IUe6Try()).GetCurrentDiagnosticSession();
							num = 4;
							continue;
						case 3:
							return result;
						}
						break;
					}
					goto IL_00a3;
				}
				catch (Exception ex)
				{
					int num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							throw;
						}
						eigeFTQCjqRvdBQK97Pj(VYwLpNQC5ZJRLcHGaE7i(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889283718), ex);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
						{
							num2 = 1;
						}
					}
				}
			default:
				return result;
			}
		}

		public Thread StartThread()
		{
			//Discarded unreachable code: IL_0049, IL_0148, IL_015b, IL_016a, IL_019c, IL_0238, IL_0286, IL_0295
			Thread result = default(Thread);
			switch (1)
			{
			case 1:
				try
				{
					int num;
					if (!HNNs93QClGC4h7sgBr9a())
					{
						num = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num = 5;
						}
						goto IL_004d;
					}
					goto IL_00e7;
					IL_00e7:
					CallContextInfo callContextInfo = (CallContextInfo)Lbics8QCY2jZqYE4ra3A(h8GfXhQCry9p3IUe6Try());
					num = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num = 12;
					}
					goto IL_004d;
					IL_004d:
					Thread thread = default(Thread);
					while (true)
					{
						switch (num)
						{
						case 3:
						case 5:
						case 7:
							thread = new Thread(InternalThread, MaxStackSize);
							num = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
							{
								num = 5;
							}
							continue;
						case 9:
							if (BeforeThreadStart == null)
							{
								num = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
								{
									num = 4;
								}
								continue;
							}
							goto case 12;
						case 8:
							VIxL4yQvFfIfBqjSD9TF(thread, (CultureInfo)TenrktQCsQA9SLMak92l(t6C4yUQCzZjTPQGyHvGQ(Thread.CurrentThread)));
							num = 9;
							continue;
						case 13:
							if (callContextInfo == null)
							{
								num = 7;
								continue;
							}
							goto case 2;
						case 4:
						case 10:
							e6LG42QvBtTUaNCvsqKW(thread, this);
							num = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
							{
								num = 1;
							}
							continue;
						case 11:
							tjSlc8QCcRp71XbL9OtG(thread, (CultureInfo)TenrktQCsQA9SLMak92l(XF7UqWQCUKaYZXCEEpAG(wVlqhcQCLbI7q9ds6rU9())));
							num = 8;
							continue;
						case 12:
							BeforeThreadStart(thread);
							num = 10;
							continue;
						case 2:
							createdParentContextInfoUid = LD9HqnQCgrjfWh12JmAq(callContextInfo);
							num = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
							{
								num = 3;
							}
							continue;
						case 1:
							result = thread;
							num = 6;
							continue;
						case 6:
							return result;
						}
						break;
					}
					goto IL_00e7;
				}
				catch (Exception exception)
				{
					int num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							throw;
						}
						((ILogger)VYwLpNQC5ZJRLcHGaE7i()).Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A29238), exception);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 1;
						}
					}
				}
			default:
				return result;
			}
		}

		private static void InternalThread(object state)
		{
			//Discarded unreachable code: IL_00ae, IL_012f, IL_013e, IL_014d, IL_01a8, IL_022e, IL_0241, IL_0321, IL_0395, IL_043f, IL_047f, IL_048e, IL_049a
			int num = 3;
			int num2 = num;
			PrivateThreadStarter privateThreadStarter = default(PrivateThreadStarter);
			IDisposable disposable = default(IDisposable);
			while (true)
			{
				switch (num2)
				{
				case 3:
					privateThreadStarter = state as PrivateThreadStarter;
					num2 = 2;
					continue;
				case 2:
					if (privateThreadStarter != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					return;
				case 1:
					disposable = (IDisposable)pKDxBVQvWRCgStSj2KUp(isolatedContext: false);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return;
				}
				try
				{
					int num3;
					if (vnmxJEQvo2Q1yYe55wY2(privateThreadStarter) != null)
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
						{
							num3 = 0;
						}
						goto IL_00b2;
					}
					goto IL_0114;
					IL_036e:
					if (privateThreadStarter.Callback == null)
					{
						num3 = 7;
						goto IL_00b2;
					}
					goto IL_0215;
					IL_02ef:
					FBcg0nQv8HBQH2J2Yu5k(ISZlYTQvvdmBBSm3UTiS(privateThreadStarter), cyPLu9QvQjRD9PLT6oxu(privateThreadStarter));
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num3 = 0;
					}
					goto IL_00b2;
					IL_0114:
					if (D4G9Y4QvbN3qqdDnFjAr(privateThreadStarter) != null)
					{
						num3 = 14;
						goto IL_00b2;
					}
					goto IL_029c;
					IL_0215:
					if (HNNs93QClGC4h7sgBr9a())
					{
						num3 = 5;
						goto IL_00b2;
					}
					goto IL_02ef;
					IL_029c:
					if (muJ52JQvfvmUDwyYBQ0r(privateThreadStarter) != null)
					{
						num3 = 3;
						goto IL_00b2;
					}
					goto IL_036e;
					IL_00b2:
					while (true)
					{
						switch (num3)
						{
						case 16:
							return;
						case 18:
							return;
						case 9:
							break;
						case 21:
							((DiagnosticsManager)h8GfXhQCry9p3IUe6Try()).BackgroundThreadStart((MethodInfo)xypiSGQvh2oEupPqSUwN(privateThreadStarter.Start), privateThreadStarter.createdParentContextInfoUid, (string)mMVC9xQvGAk1Vst91HkY(-542721635 ^ -542914497));
							num3 = 13;
							continue;
						case 14:
							if (!HNNs93QClGC4h7sgBr9a())
							{
								num3 = 2;
								continue;
							}
							goto case 21;
						case 12:
							((DiagnosticsManager)h8GfXhQCry9p3IUe6Try()).BackgroundThreadEnd((Exception)null);
							num3 = 16;
							continue;
						default:
						{
							object obj = wVlqhcQCLbI7q9ds6rU9();
							CultureInfo cultureInfo;
							tjSlc8QCcRp71XbL9OtG(wVlqhcQCLbI7q9ds6rU9(), cultureInfo = (CultureInfo)vnmxJEQvo2Q1yYe55wY2(privateThreadStarter));
							VIxL4yQvFfIfBqjSD9TF(obj, cultureInfo);
							num3 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num3 = 7;
							}
							continue;
						}
						case 3:
							if (!HNNs93QClGC4h7sgBr9a())
							{
								num3 = 10;
								continue;
							}
							goto case 15;
						case 6:
							goto IL_0215;
						case 1:
						case 7:
						case 19:
						case 20:
							if (!HNNs93QClGC4h7sgBr9a())
							{
								num3 = 18;
								continue;
							}
							goto case 12;
						case 5:
							((DiagnosticsManager)h8GfXhQCry9p3IUe6Try()).BackgroundThreadStart((MethodInfo)xypiSGQvh2oEupPqSUwN(ISZlYTQvvdmBBSm3UTiS(privateThreadStarter)), privateThreadStarter.createdParentContextInfoUid, (string)mMVC9xQvGAk1Vst91HkY(-957824448 ^ -957501362));
							num3 = 4;
							continue;
						case 11:
							goto IL_029c;
						case 15:
							((DiagnosticsManager)h8GfXhQCry9p3IUe6Try()).BackgroundThreadStart(privateThreadStarter.ParametrizedStart.Method, privateThreadStarter.createdParentContextInfoUid, (string)mMVC9xQvGAk1Vst91HkY(0x8317432 ^ 0x83405FE));
							num3 = 8;
							continue;
						case 4:
							goto IL_02ef;
						case 8:
						case 10:
							aP2EiWQvCNLnjqDVA9Xu(muJ52JQvfvmUDwyYBQ0r(privateThreadStarter), cyPLu9QvQjRD9PLT6oxu(privateThreadStarter));
							num3 = 19;
							continue;
						case 2:
						case 13:
							Y7tqKTQvE5U55ppuJo4k(D4G9Y4QvbN3qqdDnFjAr(privateThreadStarter));
							num3 = 20;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
							{
								num3 = 3;
							}
							continue;
						case 17:
							goto IL_036e;
						}
						break;
					}
					goto IL_0114;
				}
				catch (Exception ex)
				{
					int num4 = 2;
					while (true)
					{
						switch (num4)
						{
						case 1:
							return;
						case 3:
							eigeFTQCjqRvdBQK97Pj(VYwLpNQC5ZJRLcHGaE7i(), mMVC9xQvGAk1Vst91HkY(-1633514411 ^ -1633157525), ex);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
							{
								num4 = 1;
							}
							break;
						default:
							((DiagnosticsManager)h8GfXhQCry9p3IUe6Try()).BackgroundThreadEnd(ex);
							num4 = 3;
							break;
						case 2:
							if (HNNs93QClGC4h7sgBr9a())
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
								{
									num4 = 0;
								}
								break;
							}
							goto case 3;
						}
					}
				}
				finally
				{
					int num5;
					if (disposable == null)
					{
						num5 = 2;
						goto IL_0443;
					}
					goto IL_0459;
					IL_0443:
					switch (num5)
					{
					default:
						goto end_IL_042e;
					case 1:
						break;
					case 2:
						goto end_IL_042e;
					case 0:
						goto end_IL_042e;
					}
					goto IL_0459;
					IL_0459:
					myrsVWQvZwDWKUSi7RGU(disposable);
					num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num5 = 0;
					}
					goto IL_0443;
					end_IL_042e:;
				}
			}
		}

		internal static void C9yB4oQCdRpBBmw1g66a()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool iZ0CpYQCJxgi8t9PudDo()
		{
			return uiB9t6QCMlivvHrMg4Px == null;
		}

		internal static PrivateThreadStarter N8msX9QC9XTN50GEPfYr()
		{
			return uiB9t6QCMlivvHrMg4Px;
		}

		internal static bool HNNs93QClGC4h7sgBr9a()
		{
			return DiagnosticsManager.Enabled;
		}

		internal static object h8GfXhQCry9p3IUe6Try()
		{
			return DiagnosticsManager.Instance;
		}

		internal static Guid LD9HqnQCgrjfWh12JmAq(object P_0)
		{
			return ((CallContextInfo)P_0).Uid;
		}

		internal static object VYwLpNQC5ZJRLcHGaE7i()
		{
			return Logger.Log;
		}

		internal static void eigeFTQCjqRvdBQK97Pj(object P_0, object P_1, object P_2)
		{
			((ILogger)P_0).Error(P_1, (Exception)P_2);
		}

		internal static object Lbics8QCY2jZqYE4ra3A(object P_0)
		{
			return ((DiagnosticsManager)P_0).GetCurrentDiagnosticSession();
		}

		internal static object wVlqhcQCLbI7q9ds6rU9()
		{
			return Thread.CurrentThread;
		}

		internal static object XF7UqWQCUKaYZXCEEpAG(object P_0)
		{
			return ((Thread)P_0).CurrentUICulture;
		}

		internal static object TenrktQCsQA9SLMak92l(object P_0)
		{
			return ((CultureInfo)P_0).Clone();
		}

		internal static void tjSlc8QCcRp71XbL9OtG(object P_0, object P_1)
		{
			((Thread)P_0).CurrentUICulture = (CultureInfo)P_1;
		}

		internal static object t6C4yUQCzZjTPQGyHvGQ(object P_0)
		{
			return ((Thread)P_0).CurrentCulture;
		}

		internal static void VIxL4yQvFfIfBqjSD9TF(object P_0, object P_1)
		{
			((Thread)P_0).CurrentCulture = (CultureInfo)P_1;
		}

		internal static void e6LG42QvBtTUaNCvsqKW(object P_0, object P_1)
		{
			((Thread)P_0).Start(P_1);
		}

		internal static object pKDxBVQvWRCgStSj2KUp(bool isolatedContext)
		{
			return ELMAContext.Create(isolatedContext);
		}

		internal static object vnmxJEQvo2Q1yYe55wY2(object P_0)
		{
			return ((PrivateThreadStarter)P_0).CurrentCulture;
		}

		internal static object D4G9Y4QvbN3qqdDnFjAr(object P_0)
		{
			return ((PrivateThreadStarter)P_0).Start;
		}

		internal static object xypiSGQvh2oEupPqSUwN(object P_0)
		{
			return ((Delegate)P_0).Method;
		}

		internal static object mMVC9xQvGAk1Vst91HkY(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void Y7tqKTQvE5U55ppuJo4k(object P_0)
		{
			P_0();
		}

		internal static object muJ52JQvfvmUDwyYBQ0r(object P_0)
		{
			return ((PrivateThreadStarter)P_0).ParametrizedStart;
		}

		internal static object cyPLu9QvQjRD9PLT6oxu(object P_0)
		{
			return ((PrivateThreadStarter)P_0).State;
		}

		internal static void aP2EiWQvCNLnjqDVA9Xu(object P_0, object P_1)
		{
			P_0(P_1);
		}

		internal static object ISZlYTQvvdmBBSm3UTiS(object P_0)
		{
			return ((PrivateThreadStarter)P_0).Callback;
		}

		internal static void FBcg0nQv8HBQH2J2Yu5k(object P_0, object P_1)
		{
			P_0(P_1);
		}

		internal static void myrsVWQvZwDWKUSi7RGU(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}
	}

	internal static ThreadStarter Q8XGkUBRuCT0nBV5DRnu;

	public static bool QueueThread(WaitCallback callback)
	{
		return SEdVkgBRSrp8E3ufh8gG(callback, null);
	}

	public static bool QueueThread(ThreadStart callback)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return dGkRulBRTrgfBtM98DHe(new PrivateThreadStarter(callback, 0, (CultureInfo)br6hZRBRXbUTpJHmMxVy(MQBxKMBRKanwTb8Jt7VL(I3GWVSBRqjuIGCCeplLG())), null, null));
			case 1:
				YnAkxYBRRfepxk4cgu7x(callback, V73cDsBRixbJhg6WZESH(-1867198571 ^ -1867131751));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static bool QueueThread(WaitCallback callback, object state)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return dGkRulBRTrgfBtM98DHe(new PrivateThreadStarter(callback, (CultureInfo)br6hZRBRXbUTpJHmMxVy(Thread.CurrentThread.CurrentCulture), state));
			case 1:
				Contract.ArgumentNotNull(callback, (string)V73cDsBRixbJhg6WZESH(-29254301 ^ -29325713));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static Thread StartNewThread(ParameterizedThreadStart start)
	{
		return (Thread)ySpRIpBRkHBJJibwE2Ub(start, null);
	}

	public static Thread StartNewThread(ParameterizedThreadStart start, object state)
	{
		return StartNewThread(start, 0, state, null);
	}

	public static Thread StartNewThread(ParameterizedThreadStart start, object state, Action<Thread> beforeStart)
	{
		return StartNewThread(start, 0, state, beforeStart);
	}

	public static Thread StartNewThread(ParameterizedThreadStart start, int maxStackSize, object state, Action<Thread> beforeStart)
	{
		Contract.ArgumentNotNull(start, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105128766));
		return new PrivateThreadStarter(start, maxStackSize, (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone(), state, beforeStart).StartThread();
	}

	public static Thread StartNewThread(ThreadStart start)
	{
		return StartNewThread(start, null);
	}

	public static Thread StartNewThread(ThreadStart start, Action<Thread> beforeStart)
	{
		return StartNewThread(start, 0, beforeStart);
	}

	public static Thread StartNewThread(ThreadStart start, int maxStackSize, Action<Thread> beforeStart)
	{
		Contract.ArgumentNotNull(start, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979310319));
		return new PrivateThreadStarter(start, maxStackSize, (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone(), null, beforeStart).StartThread();
	}

	public static void JoinThread(this Thread thread)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				DiagnosticsManager.StartCall(_003C_003Ec__DisplayClass11_._003CJoinThread_003Eb__0, _003C_003Ec__DisplayClass11_.thread.Join);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass11_.thread = thread;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			default:
				YnAkxYBRRfepxk4cgu7x(_003C_003Ec__DisplayClass11_.thread, V73cDsBRixbJhg6WZESH(-1088304168 ^ -1088368394));
				num2 = 4;
				break;
			}
		}
	}

	public static bool JoinThread(this Thread thread, int millisecondsTimeout)
	{
		//Discarded unreachable code: IL_0082, IL_00ba, IL_00d9, IL_0109, IL_0118
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		ThreadJoinCallInfo threadJoinCallInfo = default(ThreadJoinCallInfo);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return result;
			case 5:
				_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				_003C_003Ec__DisplayClass12_.thread = thread;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				threadJoinCallInfo = DiagnosticsManager.StartCall(_003C_003Ec__DisplayClass12_._003CJoinThread_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				YnAkxYBRRfepxk4cgu7x(_003C_003Ec__DisplayClass12_.thread, V73cDsBRixbJhg6WZESH(-138018305 ^ -137946415));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			try
			{
				result = rJ1OhXBRn3DX0JZAVsSu(_003C_003Ec__DisplayClass12_.thread, millisecondsTimeout);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				int num4;
				if (threadJoinCallInfo == null)
				{
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num4 = 0;
					}
					goto IL_00be;
				}
				goto IL_00e7;
				IL_00e7:
				REF558BROKjYWofJ6tId(threadJoinCallInfo);
				num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num4 = 1;
				}
				goto IL_00be;
				IL_00be:
				switch (num4)
				{
				default:
					goto end_IL_0099;
				case 0:
					goto end_IL_0099;
				case 2:
					break;
				case 1:
					goto end_IL_0099;
				}
				goto IL_00e7;
				end_IL_0099:;
			}
		}
	}

	public static bool JoinThread(this Thread thread, TimeSpan timeout)
	{
		//Discarded unreachable code: IL_00a5, IL_00dd, IL_011d, IL_0128
		int num = 4;
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
		ThreadJoinCallInfo threadJoinCallInfo = default(ThreadJoinCallInfo);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					_003C_003Ec__DisplayClass13_.thread = thread;
					num = 2;
					break;
				default:
					threadJoinCallInfo = DiagnosticsManager.StartCall(_003C_003Ec__DisplayClass13_._003CJoinThread_003Eb__0);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					return flag;
				case 1:
					try
					{
						flag = cnH65ZBR2ihNPEtO5Wbv(_003C_003Ec__DisplayClass13_.thread, timeout);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => flag, 
							_ => flag, 
						};
					}
					finally
					{
						int num4;
						if (threadJoinCallInfo == null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
							{
								num4 = 0;
							}
							goto IL_00e1;
						}
						goto IL_00f7;
						IL_00f7:
						REF558BROKjYWofJ6tId(threadJoinCallInfo);
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num4 = 0;
						}
						goto IL_00e1;
						IL_00e1:
						switch (num4)
						{
						default:
							goto end_IL_00bc;
						case 2:
							break;
						case 0:
							goto end_IL_00bc;
						case 1:
							goto end_IL_00bc;
						}
						goto IL_00f7;
						end_IL_00bc:;
					}
				case 4:
					_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
					num = 3;
					break;
				case 2:
					Contract.ArgumentNotNull(_003C_003Ec__DisplayClass13_.thread, (string)V73cDsBRixbJhg6WZESH(-867826612 ^ -867754142));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static bool SEdVkgBRSrp8E3ufh8gG(object P_0, object P_1)
	{
		return QueueThread((WaitCallback)P_0, P_1);
	}

	internal static bool HeA0yMBRImLH8twty4u9()
	{
		return Q8XGkUBRuCT0nBV5DRnu == null;
	}

	internal static ThreadStarter hdOjVLBRVRnH7vJ3pVVF()
	{
		return Q8XGkUBRuCT0nBV5DRnu;
	}

	internal static object V73cDsBRixbJhg6WZESH(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void YnAkxYBRRfepxk4cgu7x(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object I3GWVSBRqjuIGCCeplLG()
	{
		return Thread.CurrentThread;
	}

	internal static object MQBxKMBRKanwTb8Jt7VL(object P_0)
	{
		return ((Thread)P_0).CurrentCulture;
	}

	internal static object br6hZRBRXbUTpJHmMxVy(object P_0)
	{
		return ((CultureInfo)P_0).Clone();
	}

	internal static bool dGkRulBRTrgfBtM98DHe(object P_0)
	{
		return ((PrivateThreadStarter)P_0).QueueThread();
	}

	internal static object ySpRIpBRkHBJJibwE2Ub(object P_0, object P_1)
	{
		return StartNewThread((ParameterizedThreadStart)P_0, P_1);
	}

	internal static bool rJ1OhXBRn3DX0JZAVsSu(object P_0, int P_1)
	{
		return ((Thread)P_0).Join(P_1);
	}

	internal static void REF558BROKjYWofJ6tId(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool cnH65ZBR2ihNPEtO5Wbv(object P_0, TimeSpan P_1)
	{
		return ((Thread)P_0).Join(P_1);
	}
}
