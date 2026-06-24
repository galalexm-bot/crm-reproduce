using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Timers;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Scheduling;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scheduling;

[PublicApiMember("SchedulerServicesApi", "SR.M('Сервис управления планировщиком')", "SR.M('\r\n    /// <code>\r\n    /// //С помощью данного сервиса мы можем запускать уже существующие триггеры\r\n    /// //Идентификаторы работы и триггера можно узнать в веб части (Администрирование -> Система -> Планировщик)\r\n    /// \r\n    /// //запуск триггера с передачей гуидов\r\n    /// PublicAPI.Services.Scheduler.Run(new Guid(\"*тут гуид работы*\"), new Guid(\"*тут гуид тригера*\"));\r\n    /// \r\n    /// //запуск триггера с передачей строк\r\n    /// PublicAPI.Services.Scheduler.Run(\"*тут гуид работы*\", \"*тут гуид тригера*\"); \r\n    /// </code>')")]
[Service(Type = ComponentType.Server)]
[DeveloperApi(DeveloperApiType.Service)]
public class Scheduler
{
	private class HandlerExecutor
	{
		private readonly object _owner;

		private readonly object _handler;

		private readonly object _threadPool;

		private static object EnTnTZQZLM72R1AyeNxb;

		public HandlerExecutor(Scheduler owner, ISweepHandler handler, IThreadPool threadPool)
		{
			//Discarded unreachable code: IL_001a, IL_001f
			HDgBsuQZcf1fwrPeqTbk();
			base._002Ector();
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 2:
					return;
				case 1:
					_threadPool = threadPool;
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num = 2;
					}
					break;
				default:
					_handler = handler;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num = 1;
					}
					break;
				case 3:
					_owner = owner;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		public void Execute()
		{
			int num = 3;
			int num2 = num;
			_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
			while (true)
			{
				switch (num2)
				{
				default:
					j234yVQZzFD47k2BMjJC(_threadPool, new ThreadStart(_003C_003Ec__DisplayClass4_._003CExecute_003Eb__0), _003C_003Ec__DisplayClass4_.type.FullName);
					num2 = 4;
					break;
				case 3:
					_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
					num2 = 2;
					break;
				case 2:
					_003C_003Ec__DisplayClass4_._003C_003E4__this = this;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return;
				case 1:
					_003C_003Ec__DisplayClass4_.type = _handler.GetType().GetTypeWithoutProxy();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void HDgBsuQZcf1fwrPeqTbk()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool yVea88QZUlHTIugSlx9y()
		{
			return EnTnTZQZLM72R1AyeNxb == null;
		}

		internal static HandlerExecutor YglCN9QZskn157BgdUqr()
		{
			return (HandlerExecutor)EnTnTZQZLM72R1AyeNxb;
		}

		internal static void j234yVQZzFD47k2BMjJC(object P_0, object P_1, object P_2)
		{
			((IThreadPool)P_0).Queue((ThreadStart)P_1, (string)P_2);
		}
	}

	private class SweepHandlerComposition : ISweepHandler
	{
		private readonly object _scheduler;

		internal static object NbQ8lcQuFvHOO03jh85N;

		public SweepHandlerComposition(Scheduler scheduler)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			oESiH7QuoU7wPtlVlWvX();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
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
				_scheduler = scheduler;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num = 0;
				}
			}
		}

		public void Execute()
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
					UTiyF1Qub4Iv1Rv68DVy(_scheduler);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void oESiH7QuoU7wPtlVlWvX()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool SITvvjQuB9sX4JbBVQY4()
		{
			return NbQ8lcQuFvHOO03jh85N == null;
		}

		internal static SweepHandlerComposition oHbnrIQuWQRsHxJ2w4Zs()
		{
			return (SweepHandlerComposition)NbQ8lcQuFvHOO03jh85N;
		}

		internal static void UTiyF1Qub4Iv1Rv68DVy(object P_0)
		{
			((Scheduler)P_0).ExecuteHandlers();
		}
	}

	private readonly IActorModelRuntime actorModelRuntime;

	private readonly IFeatureFlagService featureFlagService;

	private System.Timers.Timer _timer;

	private ThreadSubPool _threadPool;

	private SweepHandlerComposition _handlerComposition;

	private readonly ConcurrentDictionary<ISweepHandler, object> _executingHandlers;

	private CultureInfo currentCulture;

	private CultureInfo currentUICulture;

	internal static Scheduler lkpYKbBKzNX9WGmrQctg;

	public IEnumerable<ISchedulerJobRepository> SchedulerJobRepositories { get; set; }

	public ISweepHandler SweepHandler
	{
		get
		{
			int num = 2;
			int num2 = num;
			SweepHandlerComposition sweepHandlerComposition = default(SweepHandlerComposition);
			SweepHandlerComposition sweepHandlerComposition2;
			while (true)
			{
				switch (num2)
				{
				case 1:
					sweepHandlerComposition = (_handlerComposition = new SweepHandlerComposition(this));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					sweepHandlerComposition2 = _handlerComposition;
					if (sweepHandlerComposition2 != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					sweepHandlerComposition2 = sweepHandlerComposition;
					break;
				}
				break;
			}
			return sweepHandlerComposition2;
		}
	}

	public IEnumerable<ISweepHandler> SweepHandlers => Locator.GetServiceNotNull<IEnumerable<ISweepHandler>>();

	public Scheduler(IActorModelRuntime actorModelRuntime, IFeatureFlagService featureFlagService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oMEtqYBXWiPfLoVKtYtu();
		_executingHandlers = new ConcurrentDictionary<ISweepHandler, object>();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				this.actorModelRuntime = actorModelRuntime;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num = 1;
				}
				break;
			case 1:
				this.featureFlagService = featureFlagService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[PublicApiNodeId("SchedulerServicesApi")]
	public void Run(Guid id, Guid triggerId)
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
				actorModelRuntime.GetActor<ISchedulerActor>(Guid.Empty).ForceRunJob(triggerId, id);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[PublicApiNodeId("SchedulerServicesApi")]
	public void Run(string id, string triggerId)
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
				Run(new Guid(id), new Guid(triggerId));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Start()
	{
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 5:
				num3 = 10;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				currentCulture = (CultureInfo)s32xdUBXhCdWWE3NSZV4(Y5ZiMSBXbftr6mxZXWHN());
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 3;
				}
				break;
			case 9:
				currentUICulture = (CultureInfo)xZSiXUBXGJqhVxWwP7l1(Y5ZiMSBXbftr6mxZXWHN());
				num2 = 4;
				break;
			case 1:
				_threadPool = new ThreadSubPool(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138085742), 5);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				_timer = new System.Timers.Timer(num3 * 1000);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				_timer.Start();
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				num3 = SR.GetSetting((string)bK0k3uBXoLEu2P6NeihY(-420743386 ^ -420812072), 10);
				num2 = 8;
				break;
			case 8:
				if (num3 <= 0)
				{
					num2 = 5;
					break;
				}
				goto case 3;
			case 2:
				_timer.Elapsed += TimerElapsed;
				num2 = 7;
				break;
			case 6:
				return;
			}
		}
	}

	protected virtual void ExecuteHandlers()
	{
		//Discarded unreachable code: IL_0056, IL_0064, IL_0136, IL_0145, IL_0174, IL_021c, IL_022b, IL_024c, IL_025b
		int num = 2;
		int num2 = num;
		IEnumerator<ISweepHandler> enumerator = default(IEnumerator<ISweepHandler>);
		IThreadPoolContainer threadPoolContainer = default(IThreadPoolContainer);
		ISweepHandler current = default(ISweepHandler);
		IThreadPool threadPool2 = default(IThreadPool);
		IThreadPool threadPool = default(IThreadPool);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				enumerator = SweepHandlers.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				try
				{
					while (true)
					{
						IL_011b:
						int num3;
						if (!SiAyiuBXfDrpRdnHK2iM(enumerator))
						{
							num3 = 7;
							goto IL_0068;
						}
						goto IL_009e;
						IL_0068:
						while (true)
						{
							object obj;
							switch (num3)
							{
							case 7:
								return;
							case 8:
								break;
							case 10:
								if (threadPoolContainer != null)
								{
									num3 = 5;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto case 4;
							case 5:
								if (Fgb5kEBXEoq03KgEQVRf(threadPoolContainer) == null)
								{
									num3 = 4;
									continue;
								}
								obj = Fgb5kEBXEoq03KgEQVRf(threadPoolContainer);
								goto IL_01cb;
							case 6:
								threadPoolContainer = current as IThreadPoolContainer;
								num3 = 9;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
								{
									num3 = 10;
								}
								continue;
							case 1:
							case 2:
								goto IL_011b;
							case 9:
								if (!_executingHandlers.TryAdd(current, null))
								{
									num3 = 2;
									continue;
								}
								goto case 6;
							default:
								obj = threadPool2;
								goto IL_01cb;
							case 4:
								threadPool2 = _threadPool;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								{
									new HandlerExecutor(this, current, threadPool).Execute();
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
									{
										num3 = 0;
									}
									continue;
								}
								IL_01cb:
								threadPool = (IThreadPool)obj;
								num3 = 3;
								continue;
							}
							break;
						}
						goto IL_009e;
						IL_009e:
						current = enumerator.Current;
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num3 = 9;
						}
						goto IL_0068;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num4 = 0;
						}
						goto IL_0201;
					}
					goto IL_0236;
					IL_0236:
					enumerator.Dispose();
					int num5 = 2;
					num4 = num5;
					goto IL_0201;
					IL_0201:
					switch (num4)
					{
					default:
						goto end_IL_01dc;
					case 0:
						goto end_IL_01dc;
					case 1:
						break;
					case 2:
						goto end_IL_01dc;
					}
					goto IL_0236;
					end_IL_01dc:;
				}
			}
		}
	}

	private void TimerElapsed(object sender, ElapsedEventArgs e)
	{
		//Discarded unreachable code: IL_0089, IL_00e4, IL_0120
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return;
				case 3:
					utW911BXCwQwSdKEEWWi(Thread.CurrentThread, currentUICulture);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					try
					{
						_timer.Stop();
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							}
							hhAH2FBXvZAm7ZHLRd81(this);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
							{
								num3 = 1;
							}
						}
					}
					finally
					{
						jyG9AQBX8xcKXsQi6iPK(this);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								LmvNhrBXZa55upJ4iD1m(_timer);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
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
				default:
					if (Monitor.TryEnter(this))
					{
						num2 = 6;
						break;
					}
					goto end_IL_0012;
				case 2:
					if (!featureFlagService.Enabled((string)bK0k3uBXoLEu2P6NeihY(-882126494 ^ -882183056), defaultEnabled: true))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						fYCNkxBXQNmRt8KYeqNi(Y5ZiMSBXbftr6mxZXWHN(), currentCulture);
						num2 = 3;
					}
					break;
				case 4:
					return;
				case 1:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	internal static void oMEtqYBXWiPfLoVKtYtu()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool b5D60jBXFSfqL4MeGm21()
	{
		return lkpYKbBKzNX9WGmrQctg == null;
	}

	internal static Scheduler hWwtBSBXB7hWCmvlccmB()
	{
		return lkpYKbBKzNX9WGmrQctg;
	}

	internal static object bK0k3uBXoLEu2P6NeihY(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Y5ZiMSBXbftr6mxZXWHN()
	{
		return Thread.CurrentThread;
	}

	internal static object s32xdUBXhCdWWE3NSZV4(object P_0)
	{
		return ((Thread)P_0).CurrentCulture;
	}

	internal static object xZSiXUBXGJqhVxWwP7l1(object P_0)
	{
		return ((Thread)P_0).CurrentUICulture;
	}

	internal static object Fgb5kEBXEoq03KgEQVRf(object P_0)
	{
		return ((IThreadPoolContainer)P_0).Pool;
	}

	internal static bool SiAyiuBXfDrpRdnHK2iM(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void fYCNkxBXQNmRt8KYeqNi(object P_0, object P_1)
	{
		((Thread)P_0).CurrentCulture = (CultureInfo)P_1;
	}

	internal static void utW911BXCwQwSdKEEWWi(object P_0, object P_1)
	{
		((Thread)P_0).CurrentUICulture = (CultureInfo)P_1;
	}

	internal static void hhAH2FBXvZAm7ZHLRd81(object P_0)
	{
		((Scheduler)P_0).ExecuteHandlers();
	}

	internal static void jyG9AQBX8xcKXsQi6iPK(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static void LmvNhrBXZa55upJ4iD1m(object P_0)
	{
		((System.Timers.Timer)P_0).Start();
	}
}
