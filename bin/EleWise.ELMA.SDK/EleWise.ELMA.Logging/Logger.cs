#define TRACE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Logging;

public static class Logger
{
	private class LazyInitLogger : ILogger
	{
		private readonly object name;

		private object logger;

		private readonly Type type;

		internal static object eTWRMyvAoCWb8YC0EO6e;

		public event EventHandler ConfigurationChanged
		{
			[CompilerGenerated]
			add
			{
				int num = 3;
				int num2 = num;
				EventHandler eventHandler2 = default(EventHandler);
				EventHandler value2 = default(EventHandler);
				EventHandler eventHandler = default(EventHandler);
				while (true)
				{
					switch (num2)
					{
					case 1:
						return;
					case 3:
						eventHandler2 = this.ConfigurationChanged;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num2 = 2;
						}
						continue;
					default:
						value2 = (EventHandler)zu8V0YvAZfeFwLft6jbY(eventHandler, value);
						num2 = 5;
						continue;
					case 4:
						if ((object)eventHandler2 == eventHandler)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					case 5:
						eventHandler2 = Interlocked.CompareExchange(ref this.ConfigurationChanged, value2, eventHandler);
						num2 = 4;
						continue;
					case 2:
						break;
					}
					eventHandler = eventHandler2;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
				}
			}
			[CompilerGenerated]
			remove
			{
				int num = 2;
				int num2 = num;
				EventHandler value2 = default(EventHandler);
				EventHandler eventHandler2 = default(EventHandler);
				EventHandler eventHandler = default(EventHandler);
				while (true)
				{
					switch (num2)
					{
					default:
						value2 = (EventHandler)lfZ5ZDvAuQU7rOarNr5K(eventHandler2, value);
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 0;
						}
						break;
					case 1:
						eventHandler2 = eventHandler;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						return;
					case 2:
						eventHandler = this.ConfigurationChanged;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
						{
							num2 = 1;
						}
						break;
					case 4:
						eventHandler = Interlocked.CompareExchange(ref this.ConfigurationChanged, value2, eventHandler2);
						num2 = 5;
						break;
					case 5:
						if ((object)eventHandler == eventHandler2)
						{
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 1;
					}
				}
			}
		}

		internal LazyInitLogger(string name)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			WCgPF6vAGyibikOQfcPn();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
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
				this.name = name;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num = 1;
				}
			}
		}

		internal LazyInitLogger(Type type)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			WCgPF6vAGyibikOQfcPn();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
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
				this.type = type;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num = 1;
				}
			}
		}

		private ILogger GetLogger()
		{
			//Discarded unreachable code: IL_006b, IL_0165, IL_0174, IL_0183, IL_0193, IL_01a2, IL_0214, IL_027e, IL_02cd, IL_02dc
			int num = 6;
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				default:
					return NullLogger.Instance;
				case 1:
					num2 = 2;
					continue;
				case 2:
					try
					{
						ILoggerFactory service = Locator.GetService<ILoggerFactory>();
						int num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
							case 8:
								if (Qk3ciWvAfg5NK3yDClL5(type, null))
								{
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto default;
							case 9:
								logger = service.CreateLogger((string)name);
								num3 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
								{
									num3 = 1;
								}
								continue;
							default:
								if (logger != null)
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
									{
										num3 = 7;
									}
									continue;
								}
								break;
							case 3:
								if (service == null)
								{
									num3 = 2;
									continue;
								}
								goto case 6;
							case 4:
								logger = service.CreateLogger(type);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
								{
									num3 = 0;
								}
								continue;
							case 2:
								break;
							case 7:
								DXkdZ2vAQ0hGF0SEkXZ0(logger, new EventHandler(OnConfigurationChanged));
								num3 = 5;
								continue;
							case 6:
								if (name == null)
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 9;
							case 5:
								break;
							}
							break;
						}
					}
					catch (Exception exception)
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
								TraceLogger.Instance.Log(LogLevel.Error, exception, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463FC016), name, type);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 3;
				case 5:
					return (ILogger)logger;
				case 6:
					if (logger == null)
					{
						if (KXmNUFvAEk7P2ibPSAM5())
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto default;
					}
					num2 = 5;
					continue;
				case 3:
					obj = logger;
					if (obj != null)
					{
						break;
					}
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
					obj = X113davAC96oZM6Uy0dF();
					break;
				}
				break;
			}
			return (ILogger)obj;
		}

		private void OnConfigurationChanged(object sender, EventArgs e)
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
					qHaaMPvAvIK5cWluFaTV(this.ConfigurationChanged, sender, e);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public bool IsEnabled(LogLevel level)
		{
			return lekndovA84syfMAC54Aw(GetLogger(), level);
		}

		public void Log(LogLevel level, Exception exception, string format, params object[] args)
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
					GetLogger().Log(level, exception, format, args);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal static void WCgPF6vAGyibikOQfcPn()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool TmJ55xvAbJrLiGUC03VW()
		{
			return eTWRMyvAoCWb8YC0EO6e == null;
		}

		internal static LazyInitLogger seaHsXvAhhvr0B0Vcj83()
		{
			return (LazyInitLogger)eTWRMyvAoCWb8YC0EO6e;
		}

		internal static bool KXmNUFvAEk7P2ibPSAM5()
		{
			return Locator.Initialized;
		}

		internal static bool Qk3ciWvAfg5NK3yDClL5(Type P_0, Type P_1)
		{
			return P_0 != P_1;
		}

		internal static void DXkdZ2vAQ0hGF0SEkXZ0(object P_0, object P_1)
		{
			((ILogger)P_0).ConfigurationChanged += (EventHandler)P_1;
		}

		internal static object X113davAC96oZM6Uy0dF()
		{
			return NullLogger.Instance;
		}

		internal static void qHaaMPvAvIK5cWluFaTV(object P_0, object P_1, object P_2)
		{
			((Delegate)P_0).RaiseSafe(P_1, (EventArgs)P_2);
		}

		internal static bool lekndovA84syfMAC54Aw(object P_0, LogLevel level)
		{
			return ((ILogger)P_0).IsEnabled(level);
		}

		internal static object zu8V0YvAZfeFwLft6jbY(object P_0, object P_1)
		{
			return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
		}

		internal static object lfZ5ZDvAuQU7rOarNr5K(object P_0, object P_1)
		{
			return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
		}
	}

	public class DebugLogger : ILogger
	{
		public static DebugLogger Instance;

		private static DebugLogger WCIZ1nvAIMOSeYKrqqpq;

		public event EventHandler ConfigurationChanged
		{
			[CompilerGenerated]
			add
			{
				int num = 4;
				int num2 = num;
				EventHandler eventHandler2 = default(EventHandler);
				EventHandler eventHandler = default(EventHandler);
				EventHandler value2 = default(EventHandler);
				while (true)
				{
					switch (num2)
					{
					case 5:
						return;
					default:
						if ((object)eventHandler2 == eventHandler)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
							{
								num2 = 5;
							}
							break;
						}
						goto case 3;
					case 3:
						eventHandler = eventHandler2;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						eventHandler2 = Interlocked.CompareExchange(ref this.ConfigurationChanged, value2, eventHandler);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 0;
						}
						break;
					case 4:
						eventHandler2 = this.ConfigurationChanged;
						num2 = 3;
						break;
					case 1:
						value2 = (EventHandler)wClFJcvAR5luTfinnTPl(eventHandler, value);
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			}
			[CompilerGenerated]
			remove
			{
				int num = 4;
				int num2 = num;
				EventHandler eventHandler = default(EventHandler);
				EventHandler value2 = default(EventHandler);
				EventHandler eventHandler2 = default(EventHandler);
				while (true)
				{
					switch (num2)
					{
					case 5:
						eventHandler = Interlocked.CompareExchange(ref this.ConfigurationChanged, value2, eventHandler2);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
						{
							num2 = 0;
						}
						break;
					default:
						if ((object)eventHandler == eventHandler2)
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
							{
								num2 = 2;
							}
							break;
						}
						goto case 3;
					case 3:
						eventHandler2 = eventHandler;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 1;
						}
						break;
					case 2:
						return;
					case 1:
						value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 5;
						}
						break;
					case 4:
						eventHandler = this.ConfigurationChanged;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 3;
						}
						break;
					}
				}
			}
		}

		public bool IsEnabled(LogLevel level)
		{
			return true;
		}

		public void Log(LogLevel level, Exception exception, string format, params object[] args)
		{
			//Discarded unreachable code: IL_0031, IL_0040
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
					if (args == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 3:
					return;
				case 2:
					break;
				}
				jVLlxMvAiXGmt5R43yrA(format, args);
				num2 = 3;
			}
		}

		public DebugLogger()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			TLlia7vAqPhukrPN09J7();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static DebugLogger()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					TLlia7vAqPhukrPN09J7();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				default:
					Instance = new DebugLogger();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		internal static object jVLlxMvAiXGmt5R43yrA(object P_0, object P_1)
		{
			return string.Format((string)P_0, (object[])P_1);
		}

		internal static bool jCuIVMvAVGCF8RT4Myhu()
		{
			return WCIZ1nvAIMOSeYKrqqpq == null;
		}

		internal static DebugLogger S5L1slvASEmZcgF2CIb3()
		{
			return WCIZ1nvAIMOSeYKrqqpq;
		}

		internal static object wClFJcvAR5luTfinnTPl(object P_0, object P_1)
		{
			return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
		}

		internal static void TLlia7vAqPhukrPN09J7()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	public class TraceLogger : ILogger
	{
		public static TraceLogger Instance;

		internal static TraceLogger NxZ2wKvAKL6bkS7GOBI8;

		public event EventHandler ConfigurationChanged
		{
			[CompilerGenerated]
			add
			{
				int num = 1;
				int num2 = num;
				EventHandler value2 = default(EventHandler);
				EventHandler eventHandler = default(EventHandler);
				EventHandler eventHandler2 = default(EventHandler);
				while (true)
				{
					switch (num2)
					{
					case 5:
						value2 = (EventHandler)EWU6XIvA28u6FRM37dO0(eventHandler, value);
						num2 = 3;
						break;
					case 2:
						return;
					case 4:
						if ((object)eventHandler2 == eventHandler)
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
							{
								num2 = 1;
							}
							break;
						}
						goto default;
					default:
						eventHandler = eventHandler2;
						num2 = 5;
						break;
					case 1:
						eventHandler2 = this.ConfigurationChanged;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						eventHandler2 = Interlocked.CompareExchange(ref this.ConfigurationChanged, value2, eventHandler);
						num2 = 4;
						break;
					}
				}
			}
			[CompilerGenerated]
			remove
			{
				int num = 1;
				int num2 = num;
				EventHandler eventHandler2 = default(EventHandler);
				EventHandler value2 = default(EventHandler);
				EventHandler eventHandler = default(EventHandler);
				while (true)
				{
					switch (num2)
					{
					case 3:
						eventHandler2 = Interlocked.CompareExchange(ref this.ConfigurationChanged, value2, eventHandler);
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 2;
						}
						continue;
					case 4:
						if ((object)eventHandler2 == eventHandler)
						{
							num2 = 5;
							continue;
						}
						break;
					case 1:
						eventHandler2 = this.ConfigurationChanged;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						value2 = (EventHandler)rWwnTOvAeCtKrCZowsr7(eventHandler, value);
						num2 = 3;
						continue;
					case 5:
						return;
					}
					eventHandler = eventHandler2;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 0;
					}
				}
			}
		}

		public bool IsEnabled(LogLevel level)
		{
			return true;
		}

		public void Log(LogLevel level, Exception exception, string format, params object[] args)
		{
			//Discarded unreachable code: IL_00cc, IL_00eb
			int num = 2;
			int num2 = num;
			string text2 = default(string);
			while (true)
			{
				string text;
				switch (num2)
				{
				case 4:
					return;
				case 2:
					if (args != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 3;
				default:
					Mbouo0vAOLgG0S8MFUjX(a6Uiv1vAnuPwFySBTGOw(new object[6]
					{
						CkojPOvAklSCx7QyLQ1K(-1633514411 ^ -1633205283),
						level,
						CkojPOvAklSCx7QyLQ1K(-1633514411 ^ -1633499785),
						text2,
						CkojPOvAklSCx7QyLQ1K(-1837662597 ^ -1837680807),
						exception
					}));
					num2 = 5;
					continue;
				case 5:
					Trace.Flush();
					num2 = 4;
					continue;
				case 3:
					text = format;
					break;
				case 1:
					text = string.Format(format, args);
					break;
				}
				text2 = text;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 0;
				}
			}
		}

		public TraceLogger()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			q9BjDivAPjfuOMJx5D6M();
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

		static TraceLogger()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					Instance = new TraceLogger();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				case 1:
					SingletonReader.JJCZtPuTvSt();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static object CkojPOvAklSCx7QyLQ1K(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object a6Uiv1vAnuPwFySBTGOw(object P_0)
		{
			return string.Concat((object[])P_0);
		}

		internal static void Mbouo0vAOLgG0S8MFUjX(object P_0)
		{
			Trace.WriteLine((string)P_0);
		}

		internal static bool BTIKBfvAX2egS6eWltcp()
		{
			return NxZ2wKvAKL6bkS7GOBI8 == null;
		}

		internal static TraceLogger OfhXiBvATBfCav63vFIG()
		{
			return NxZ2wKvAKL6bkS7GOBI8;
		}

		internal static object EWU6XIvA28u6FRM37dO0(object P_0, object P_1)
		{
			return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
		}

		internal static object rWwnTOvAeCtKrCZowsr7(object P_0, object P_1)
		{
			return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
		}

		internal static void q9BjDivAPjfuOMJx5D6M()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	public class ConsoleLogger : ILogger
	{
		public static ConsoleLogger Instance;

		internal static ConsoleLogger VqYmQnvA1vok7wadNpVO;

		public event EventHandler ConfigurationChanged
		{
			[CompilerGenerated]
			add
			{
				int num = 5;
				int num2 = num;
				EventHandler eventHandler = default(EventHandler);
				EventHandler value2 = default(EventHandler);
				EventHandler eventHandler2 = default(EventHandler);
				while (true)
				{
					switch (num2)
					{
					case 5:
						eventHandler = this.ConfigurationChanged;
						num2 = 4;
						break;
					case 1:
						eventHandler = Interlocked.CompareExchange(ref this.ConfigurationChanged, value2, eventHandler2);
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 2;
						}
						break;
					default:
						value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 1;
						}
						break;
					case 4:
						eventHandler2 = eventHandler;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						if ((object)eventHandler == eventHandler2)
						{
							num2 = 3;
							break;
						}
						goto case 4;
					case 3:
						return;
					}
				}
			}
			[CompilerGenerated]
			remove
			{
				int num = 2;
				int num2 = num;
				EventHandler eventHandler2 = default(EventHandler);
				EventHandler eventHandler = default(EventHandler);
				EventHandler value2 = default(EventHandler);
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 2:
						eventHandler2 = this.ConfigurationChanged;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
						{
							num2 = 0;
						}
						break;
					case 1:
						eventHandler = eventHandler2;
						num2 = 5;
						break;
					case 4:
						eventHandler2 = Interlocked.CompareExchange(ref this.ConfigurationChanged, value2, eventHandler);
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 3;
						}
						break;
					case 3:
						if ((object)eventHandler2 == eventHandler)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 1;
					case 5:
						value2 = (EventHandler)EeZjOQvAtWNlfDhU0J9w(eventHandler, value);
						num2 = 4;
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool IsEnabled(LogLevel level)
		{
			return true;
		}

		public void Log(LogLevel level, Exception exception, string format, params object[] args)
		{
			//Discarded unreachable code: IL_0037, IL_00f0, IL_00ff
			int num = 2;
			int num2 = num;
			string text2 = default(string);
			while (true)
			{
				string text;
				switch (num2)
				{
				case 3:
					return;
				case 4:
					text = format;
					break;
				default:
					qc26divADDjwbQlINRE7(r3mtTfvAaSSkq0jYKoUQ(new object[7]
					{
						DateTime.Now,
						VMifd4vApar76f4xl2Ib(0x7C1EE318 ^ 0x7C1E20BE),
						level,
						VMifd4vApar76f4xl2Ib(-29254301 ^ -29240255),
						text2,
						VMifd4vApar76f4xl2Ib(-1824388195 ^ -1824374081),
						exception
					}));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					if (args != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 4;
				case 1:
					text = string.Format(format, args);
					break;
				}
				text2 = text;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 0;
				}
			}
		}

		public ConsoleLogger()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static ConsoleLogger()
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
					Instance = new ConsoleLogger();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					SingletonReader.JJCZtPuTvSt();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static object VMifd4vApar76f4xl2Ib(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object r3mtTfvAaSSkq0jYKoUQ(object P_0)
		{
			return string.Concat((object[])P_0);
		}

		internal static void qc26divADDjwbQlINRE7(object P_0)
		{
			Console.WriteLine((string)P_0);
		}

		internal static bool X39YGgvANTeXaQZbD0Pq()
		{
			return VqYmQnvA1vok7wadNpVO == null;
		}

		internal static ConsoleLogger Iso9cqvA33djn7DCDNCm()
		{
			return VqYmQnvA1vok7wadNpVO;
		}

		internal static object EeZjOQvAtWNlfDhU0J9w(object P_0, object P_1)
		{
			return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
		}
	}

	private static ILogger log;

	internal static Logger nQ3LWfhl01eGXhS9XokJ;

	public static ILogger Log
	{
		get
		{
			//Discarded unreachable code: IL_0038, IL_008a, IL_0111, IL_014d, IL_015c
			int num = 2;
			int num2 = num;
			ILogger result = default(ILogger);
			while (true)
			{
				switch (num2)
				{
				case 4:
					return result;
				case 3:
					return NullLogger.Instance;
				case 1:
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					if (KGjwF3hlMhhQ1aIWW2Jy())
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 3;
				}
				try
				{
					ILogger logger = log;
					int num3;
					if (logger == null)
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num3 = 2;
						}
						goto IL_008e;
					}
					goto IL_00af;
					IL_008e:
					switch (num3)
					{
					default:
						return result;
					case 0:
						return result;
					case 2:
						break;
					case 1:
						goto IL_00d0;
					}
					logger = (log = Locator.GetService<ILogger>());
					goto IL_00af;
					IL_00d5:
					result = logger;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num3 = 0;
					}
					goto IL_008e;
					IL_00af:
					if (logger == null)
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
						{
							num3 = 1;
						}
						goto IL_008e;
					}
					goto IL_00d5;
					IL_00d0:
					logger = NullLogger.Instance;
					goto IL_00d5;
				}
				catch
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							return result;
						case 0:
							return result;
						case 1:
							result = (ILogger)uwB94IhlJKw4Nj91KZMa();
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				}
			}
		}
	}

	public static bool LogDllImport => true;

	public static event LogEventHandler Logged
	{
		add
		{
			niviyChl5WBYF2rU34js(value);
		}
		remove
		{
			SfZjdQhljbTHsdIk2kI5(value);
		}
	}

	public static ILogger GetLogger(Type componentType)
	{
		return new LazyInitLogger(componentType);
	}

	public static ILogger GetLogger(string name)
	{
		return new LazyInitLogger(name);
	}

	private static void AddEvent(object logged)
	{
		//Discarded unreachable code: IL_0082, IL_0090, IL_011d, IL_0155, IL_0164
		int num = 1;
		int num2 = num;
		IEnumerator<ILoggerEventHandler> enumerator = default(IEnumerator<ILoggerEventHandler>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (lCGajkhl9hbicwvaU9wk())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 2:
				return;
			default:
				enumerator = ((ComponentManager)xMAosEhldm4lyNjhfNEp()).GetExtensionPoints<ILoggerEventHandler>().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!QS5oSUhlrw09cK3VS9Up(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
							{
								num3 = 0;
							}
							goto IL_0094;
						}
						goto IL_00d0;
						IL_00d0:
						NGB91phlls1wt9Pbqvib(enumerator.Current, logged);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num3 = 1;
						}
						goto IL_0094;
						IL_0094:
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							break;
						case 2:
							goto IL_00d0;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								BR8nnbhlgaggZFhp5jd6(enumerator);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			}
		}
	}

	private static void RemoveEvent(object logged)
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_0056, IL_0065, IL_0070, IL_00ed, IL_0125, IL_0134
		int num = 2;
		int num2 = num;
		IEnumerator<ILoggerEventHandler> enumerator = default(IEnumerator<ILoggerEventHandler>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 3:
				return;
			case 4:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
							{
								num3 = 0;
							}
							goto IL_0074;
						}
						goto IL_008a;
						IL_008a:
						enumerator.Current.Logged -= (LogEventHandler)logged;
						num3 = 2;
						goto IL_0074;
						IL_0074:
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							break;
						case 2:
							continue;
						}
						goto IL_008a;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								BR8nnbhlgaggZFhp5jd6(enumerator);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			default:
				enumerator = ((ComponentManager)xMAosEhldm4lyNjhfNEp()).GetExtensionPoints<ILoggerEventHandler>().GetEnumerator();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				if (!lCGajkhl9hbicwvaU9wk())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	internal static string GetConfigFile(string fileName)
	{
		//Discarded unreachable code: IL_0065, IL_0074
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return fileName;
			case 1:
				return Path.Combine((string)CnZf1ghlLAbC9jV4V7PD(AppDomain.CurrentDomain), fileName);
			case 2:
				if (!cmQ3L0hlYsEGOPrL2s1s(fileName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	internal static bool KGjwF3hlMhhQ1aIWW2Jy()
	{
		return Locator.Initialized;
	}

	internal static object uwB94IhlJKw4Nj91KZMa()
	{
		return NullLogger.Instance;
	}

	internal static bool v27mmvhlmucHsD2RCP1C()
	{
		return nQ3LWfhl01eGXhS9XokJ == null;
	}

	internal static Logger DT0Yurhly9epVsI8V067()
	{
		return nQ3LWfhl01eGXhS9XokJ;
	}

	internal static bool lCGajkhl9hbicwvaU9wk()
	{
		return ComponentManager.Initialized;
	}

	internal static object xMAosEhldm4lyNjhfNEp()
	{
		return ComponentManager.Current;
	}

	internal static void NGB91phlls1wt9Pbqvib(object P_0, object P_1)
	{
		((ILoggerEventHandler)P_0).Logged += (LogEventHandler)P_1;
	}

	internal static bool QS5oSUhlrw09cK3VS9Up(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void BR8nnbhlgaggZFhp5jd6(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void niviyChl5WBYF2rU34js(object P_0)
	{
		AddEvent(P_0);
	}

	internal static void SfZjdQhljbTHsdIk2kI5(object P_0)
	{
		RemoveEvent(P_0);
	}

	internal static bool cmQ3L0hlYsEGOPrL2s1s(object P_0)
	{
		return Path.IsPathRooted((string)P_0);
	}

	internal static object CnZf1ghlLAbC9jV4V7PD(object P_0)
	{
		return ((AppDomain)P_0).BaseDirectory;
	}
}
