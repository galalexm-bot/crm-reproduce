using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Threading;

internal class ElmaThreadPool
{
	internal class WorkItem : IElmaThreadPoolWorkItem, IDisposable
	{
		private readonly ElmaThreadPool pool;

		private bool disposed;

		private static WorkItem zpB1AUQCV6S51vHASFFs;

		public ThreadStart Callback
		{
			[CompilerGenerated]
			get
			{
				return _003CCallback_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
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
						_003CCallback_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
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

		public ManualResetEvent WaitThreadEvent
		{
			[CompilerGenerated]
			get
			{
				return _003CWaitThreadEvent_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
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
						_003CWaitThreadEvent_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
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

		public ManualResetEvent WaitExecuteEvent
		{
			[CompilerGenerated]
			get
			{
				return _003CWaitExecuteEvent_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
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
						_003CWaitExecuteEvent_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
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

		public Thread WorkerThread
		{
			[CompilerGenerated]
			get
			{
				return _003CWorkerThread_003Ek__BackingField;
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
						_003CWorkerThread_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
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

		public WorkItem(ThreadStart callback, ElmaThreadPool pool)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 3;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 4:
					WaitExecuteEvent = new ManualResetEvent(initialState: false);
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num = 2;
					}
					break;
				case 2:
					this.pool = pool;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num = 0;
					}
					break;
				case 3:
					Callback = callback;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num = 0;
					}
					break;
				case 1:
					WaitThreadEvent = new ManualResetEvent(initialState: false);
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num = 4;
					}
					break;
				case 0:
					return;
				}
			}
		}

		~WorkItem()
		{
			//Discarded unreachable code: IL_0045, IL_007c, IL_008f, IL_009e
			switch (1)
			{
			case 1:
				try
				{
					Dispose();
					int num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num = 0;
					}
					switch (num)
					{
					case 0:
						break;
					}
					break;
				}
				finally
				{
					YFxq3cQCRjbE95bX9LsR(this);
					int num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					case 0:
						break;
					}
				}
			case 0:
				break;
			}
		}

		public void Dispose()
		{
			//Discarded unreachable code: IL_0099, IL_00a8
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					disposed = true;
					num2 = 6;
					break;
				case 2:
				case 6:
					SbBGhwQCK8fqt3tAx0Hx(this);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 1;
					}
					break;
				default:
					UhpBxDQCqAxpGBWjG5pj(WaitExecuteEvent);
					num2 = 4;
					break;
				case 4:
					UhpBxDQCqAxpGBWjG5pj(WaitThreadEvent);
					num2 = 5;
					break;
				case 1:
					return;
				case 3:
					if (disposed)
					{
						num2 = 2;
						break;
					}
					goto default;
				}
			}
		}

		public void WaitThread()
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
					WaitThreadEvent.WaitOne();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public bool WaitExecute(TimeSpan timeout)
		{
			return or3yZ1QCXrVy4Y42qTy1(WaitExecuteEvent, timeout);
		}

		public void AbortWorkerThread()
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
					x9R3S0QCTaQl6Zp0FIjI(pool, WorkerThread);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static bool cJTfSOQCSm9XOwd91dGS()
		{
			return zpB1AUQCV6S51vHASFFs == null;
		}

		internal static WorkItem qXQdZCQCi1a4bV0BFl8r()
		{
			return zpB1AUQCV6S51vHASFFs;
		}

		internal static void YFxq3cQCRjbE95bX9LsR(object P_0)
		{
			P_0.Finalize();
		}

		internal static void UhpBxDQCqAxpGBWjG5pj(object P_0)
		{
			((WaitHandle)P_0).Close();
		}

		internal static void SbBGhwQCK8fqt3tAx0Hx(object P_0)
		{
			GC.SuppressFinalize(P_0);
		}

		internal static bool or3yZ1QCXrVy4Y42qTy1(object P_0, TimeSpan P_1)
		{
			return ((WaitHandle)P_0).WaitOne(P_1);
		}

		internal static void x9R3S0QCTaQl6Zp0FIjI(object P_0, object P_1)
		{
			((ElmaThreadPool)P_0).AbortThread((Thread)P_1);
		}
	}

	internal interface IThreadPoolPerfomanceCounter
	{
		PerformanceCounter AddCounter(string counterName);
	}

	[Service]
	private class ThreadPoolPerfomanceCounter : IThreadPoolPerfomanceCounter
	{
		private readonly object registrar;

		internal static object AVRsLLQC2KYFs0EPh2ur;

		public ThreadPoolPerfomanceCounter(IPerformanceCategoryRegistrar registrar)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			HglekMQC1gNg8mdGhNj2();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
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
				this.registrar = registrar;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num = 1;
				}
			}
		}

		public PerformanceCounter AddCounter(string counterName)
		{
			//Discarded unreachable code: IL_00b1
			int num = 1;
			int num2 = num;
			string text = default(string);
			while (true)
			{
				switch (num2)
				{
				case 3:
					((IPerformanceCategoryRegistrar)registrar).CreateCategory(text, (string)uNmLMLQCpHgyADJaTHSg(ESCAGLQCN7RKoG0JeGof(0x57A5235E ^ 0x57A05382)), PerformanceCounterCategoryType.SingleInstance, (IEnumerable<CounterCreationData>)new CounterCreationData[1]
					{
						new CounterCreationData(counterName, "", PerformanceCounterType.NumberOfItems32)
					});
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 3;
					}
					break;
				default:
					if (XHymDJQC3Fx9VIKawFNA(text))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 3;
				case 1:
					text = (string)ESCAGLQCN7RKoG0JeGof(0x1A33FE36 ^ 0x1A368EF8) + counterName;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
				case 4:
				{
					PerformanceCounter obj = new PerformanceCounter
					{
						CategoryName = text
					};
					BRI1nsQCawZ2pPc8vdIo(obj, counterName);
					kxJVHhQCDN3basBMeCGf(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217524739));
					dRdB9mQCtXbR3idTcPJq(obj, false);
					S0XuE9QCw3EWgMuQX6IZ(obj, 0L);
					return obj;
				}
				}
			}
		}

		internal static void HglekMQC1gNg8mdGhNj2()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool FS8VnqQCeIeY9GbHOLgQ()
		{
			return AVRsLLQC2KYFs0EPh2ur == null;
		}

		internal static ThreadPoolPerfomanceCounter K8jT2gQCPt2OvgUIIIKP()
		{
			return (ThreadPoolPerfomanceCounter)AVRsLLQC2KYFs0EPh2ur;
		}

		internal static object ESCAGLQCN7RKoG0JeGof(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool XHymDJQC3Fx9VIKawFNA(object P_0)
		{
			return PerformanceCounterCategory.Exists((string)P_0);
		}

		internal static object uNmLMLQCpHgyADJaTHSg(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static void BRI1nsQCawZ2pPc8vdIo(object P_0, object P_1)
		{
			((PerformanceCounter)P_0).CounterName = (string)P_1;
		}

		internal static void kxJVHhQCDN3basBMeCGf(object P_0, object P_1)
		{
			((PerformanceCounter)P_0).MachineName = (string)P_1;
		}

		internal static void dRdB9mQCtXbR3idTcPJq(object P_0, bool P_1)
		{
			((PerformanceCounter)P_0).ReadOnly = P_1;
		}

		internal static void S0XuE9QCw3EWgMuQX6IZ(object P_0, long P_1)
		{
			((PerformanceCounter)P_0).RawValue = P_1;
		}
	}

	private static IThreadPoolPerfomanceCounter poolPerfomanceCounter;

	private readonly PerformanceCounter counter;

	private readonly Queue<WorkItem> queue;

	private readonly IDictionary<Thread, CancellationTokenSource> threadList;

	private int minThreadCount;

	private readonly string appSettingsKey;

	private readonly string threadTimeoutAppSettingsKey;

	private readonly string systemThreadTimeoutAppSettingsKey;

	private int threadsCount;

	private static ElmaThreadPool ygfZcfBSUaDevN6NB6Zo;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
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

	private static IThreadPoolPerfomanceCounter PoolPerfomanceCounter
	{
		get
		{
			int num = 1;
			int num2 = num;
			IThreadPoolPerfomanceCounter threadPoolPerfomanceCounter;
			while (true)
			{
				switch (num2)
				{
				case 1:
					threadPoolPerfomanceCounter = poolPerfomanceCounter;
					if (threadPoolPerfomanceCounter == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					threadPoolPerfomanceCounter = (poolPerfomanceCounter = Locator.GetServiceNotNull<IThreadPoolPerfomanceCounter>());
					break;
				}
				break;
			}
			return threadPoolPerfomanceCounter;
		}
	}

	public ElmaThreadPool(string name, string appSettingsKey, int minThreadCount)
	{
		//Discarded unreachable code: IL_004a
		jr23MtBSzMaWd3dkqKwl();
		queue = new Queue<WorkItem>();
		threadList = new Dictionary<Thread, CancellationTokenSource>();
		base._002Ector();
		int num = 8;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
		{
			num = 5;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				TJYZcQBiBjmZw0SjTef0(appSettingsKey, RbiDJ4BiF2DPweZIfDdM(-672123589 ^ -672059585));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num = 0;
				}
				break;
			case 7:
				counter = (PerformanceCounter)NE36VdBibEcxK72ntGEq(LL8t9MBiogYVq7MvdYgH(), name);
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num = 5;
				}
				break;
			case 9:
				this.minThreadCount = minThreadCount;
				num = 7;
				break;
			case 8:
				TJYZcQBiBjmZw0SjTef0(name, RbiDJ4BiF2DPweZIfDdM(-87337865 ^ -87336863));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num = 1;
				}
				break;
			default:
				Name = name;
				num = 6;
				break;
			case 3:
				return;
			case 6:
				threadTimeoutAppSettingsKey = (string)HSY71CBiWKn7AUqAgjqn(name, RbiDJ4BiF2DPweZIfDdM(--1418440330 ^ 0x548AB40A));
				num = 2;
				break;
			case 5:
				new Thread(ElmaThreadPoolSystem).Start(this);
				num = 3;
				break;
			case 4:
			{
				this.appSettingsKey = appSettingsKey;
				int num2 = 9;
				num = num2;
				break;
			}
			case 2:
				systemThreadTimeoutAppSettingsKey = (string)HSY71CBiWKn7AUqAgjqn(name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606721224));
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public IElmaThreadPoolWorkItem Push(ThreadStart callback)
	{
		//Discarded unreachable code: IL_0067, IL_00ca, IL_0102, IL_0111
		int num = 4;
		int num2 = num;
		WorkItem workItem = default(WorkItem);
		Queue<WorkItem> queue = default(Queue<WorkItem>);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 4:
				workItem = new WorkItem(callback, this);
				num2 = 3;
				break;
			case 2:
				try
				{
					Monitor.Enter(queue, ref lockTaken);
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							this.queue.Enqueue(workItem);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
							{
								num3 = 0;
							}
							break;
						default:
							return workItem;
						case 0:
							return workItem;
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								vyn5RSBihWcgTPEbNkjD(queue);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
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
			case 1:
				lockTaken = false;
				num2 = 2;
				break;
			case 3:
				queue = this.queue;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return workItem;
			}
		}
	}

	internal int GetThreadsCount()
	{
		return threadsCount;
	}

	private static void ElmaThreadPoolSystem(object state)
	{
		//Discarded unreachable code: IL_00c9, IL_0161, IL_018e, IL_01ca, IL_024e, IL_025d, IL_0268, IL_033d, IL_035c, IL_036b, IL_0398, IL_04ff, IL_0533, IL_0542, IL_0574, IL_0583
		int num = 1;
		int num2 = num;
		ElmaThreadPool elmaThreadPool = default(ElmaThreadPool);
		int num4 = default(int);
		int setting = default(int);
		Thread thread = default(Thread);
		CancellationTokenSource cancellationTokenSource = default(CancellationTokenSource);
		IEnumerator<KeyValuePair<Thread, CancellationTokenSource>> enumerator = default(IEnumerator<KeyValuePair<Thread, CancellationTokenSource>>);
		int num5 = default(int);
		KeyValuePair<Thread, CancellationTokenSource> current = default(KeyValuePair<Thread, CancellationTokenSource>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				elmaThreadPool = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				elmaThreadPool = (ElmaThreadPool)state;
				int num3 = 19;
				while (true)
				{
					int num6;
					switch (num3)
					{
					case 2:
						elmaThreadPool.threadsCount += -num4;
						num3 = 7;
						break;
					case 8:
						elmaThreadPool.threadsCount -= num4;
						num6 = 23;
						goto IL_003b;
					case 20:
						num4 = elmaThreadPool.threadsCount - setting;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num3 = 1;
						}
						break;
					case 16:
						if (num4 >= 0)
						{
							num3 = 22;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
							{
								num3 = 22;
							}
							break;
						}
						goto case 21;
					case 14:
					case 19:
						setting = SR.GetSetting(elmaThreadPool.appSettingsKey, elmaThreadPool.minThreadCount);
						num3 = 20;
						break;
					case 15:
						elmaThreadPool.threadList.Add(thread, cancellationTokenSource);
						num3 = 12;
						break;
					case 11:
						GMAu3WBiQCVIjSEIfO4x(SR.GetSetting(elmaThreadPool.systemThreadTimeoutAppSettingsKey, 50));
						num3 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num3 = 4;
						}
						break;
					case 18:
						enumerator = elmaThreadPool.threadList.Take(num4).GetEnumerator();
						num3 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num3 = 6;
						}
						break;
					case 12:
						num5++;
						num3 = 13;
						break;
					case 4:
						thread.Start(new object[2] { elmaThreadPool, cancellationTokenSource });
						num3 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num3 = 0;
						}
						break;
					case 9:
						try
						{
							while (true)
							{
								IL_0301:
								int num7;
								if (!enumerator.MoveNext())
								{
									num7 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
									{
										num7 = 1;
									}
									goto IL_026c;
								}
								goto IL_028a;
								IL_028a:
								current = enumerator.Current;
								num7 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
								{
									num7 = 1;
								}
								goto IL_026c;
								IL_026c:
								while (true)
								{
									switch (num7)
									{
									case 1:
										break;
									case 3:
										elmaThreadPool.threadList.Remove(current.Key);
										num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
										{
											num7 = 0;
										}
										continue;
									default:
										fiqipXBiGGAIOW6vvMGB(current.Value);
										num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
										{
											num7 = 2;
										}
										continue;
									case 2:
										goto IL_0301;
									case 4:
										goto end_IL_0301;
									}
									break;
								}
								goto IL_028a;
								continue;
								end_IL_0301:
								break;
							}
						}
						finally
						{
							int num8;
							if (enumerator == null)
							{
								num8 = 2;
								goto IL_0341;
							}
							goto IL_0376;
							IL_0341:
							switch (num8)
							{
							case 2:
								goto end_IL_032c;
							case 1:
								goto end_IL_032c;
							}
							goto IL_0376;
							IL_0376:
							E2FJZwBiESNcRYti3r6k(enumerator);
							num8 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
							{
								num8 = 0;
							}
							goto IL_0341;
							end_IL_032c:;
						}
						goto case 8;
					case 3:
					case 10:
						thread = new Thread(ExecuteInThread)
						{
							IsBackground = true
						};
						num3 = 5;
						break;
					case 13:
					case 17:
						if (num5 < -num4)
						{
							num3 = 10;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
							{
								num3 = 6;
							}
							break;
						}
						goto case 2;
					case 21:
						num5 = 0;
						num3 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num3 = 14;
						}
						break;
					case 5:
						cancellationTokenSource = new CancellationTokenSource();
						num6 = 4;
						goto IL_003b;
					case 1:
						if (num4 > 0)
						{
							num3 = 18;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
							{
								num3 = 5;
							}
							break;
						}
						goto case 16;
					case 7:
					{
						PerformanceCounter performanceCounter = elmaThreadPool.counter;
						if (performanceCounter == null)
						{
							num3 = 6;
							break;
						}
						sc45sLBif78cu89csyjQ(performanceCounter, -num4);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num3 = 0;
						}
						break;
					}
					default:
						{
							elmaThreadPool.threadsCount -= elmaThreadPool.threadList.RemoveAll((KeyValuePair<Thread, CancellationTokenSource> t) => t.Key.ThreadState.HasFlag(System.Threading.ThreadState.Aborted) || t.Key.ThreadState.HasFlag(System.Threading.ThreadState.Stopped));
							num3 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
							{
								num3 = 8;
							}
							break;
						}
						IL_003b:
						num3 = num6;
						break;
					}
				}
			}
			catch
			{
				int num9 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num9 = 0;
				}
				while (true)
				{
					switch (num9)
					{
					default:
						if (elmaThreadPool == null)
						{
							num9 = 2;
							continue;
						}
						break;
					case 2:
						return;
					case 1:
						break;
					case 3:
						return;
					}
					Hp3RA4BiCvgLA6keVt0j(new Thread(ElmaThreadPoolSystem), elmaThreadPool);
					num9 = 3;
				}
			}
		}
	}

	private static void ExecuteInThread(object state)
	{
		//Discarded unreachable code: IL_0093, IL_0100, IL_0138, IL_0170, IL_017f, IL_018e, IL_026c, IL_028f, IL_02cb, IL_031e, IL_0356, IL_0365, IL_0374, IL_049a, IL_0527, IL_055a, IL_05ab, IL_05ba, IL_0634
		int num = 2;
		int num2 = num;
		bool flag = default(bool);
		CancellationTokenSource cancellationTokenSource = default(CancellationTokenSource);
		WorkItem workItem = default(WorkItem);
		ElmaThreadPool elmaThreadPool = default(ElmaThreadPool);
		IDisposable disposable = default(IDisposable);
		Queue<WorkItem> queue = default(Queue<WorkItem>);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 5:
				flag = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				cancellationTokenSource = null;
				num2 = 5;
				continue;
			case 4:
				return;
			case 2:
				workItem = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				elmaThreadPool = null;
				num2 = 3;
				continue;
			}
			try
			{
				object[] obj = (object[])state;
				elmaThreadPool = (ElmaThreadPool)obj[0];
				cancellationTokenSource = (CancellationTokenSource)obj[1];
				int num3 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num3 = 9;
				}
				while (true)
				{
					switch (num3)
					{
					case 12:
						try
						{
							xBFgWxBiStOYDOkh18yr(oop7ZbBiVhRUbVWVkQP2(workItem));
							int num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
							{
								num6 = 0;
							}
							switch (num6)
							{
							case 0:
								break;
							}
						}
						finally
						{
							if (disposable != null)
							{
								int num7 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
								{
									num7 = 1;
								}
								while (true)
								{
									switch (num7)
									{
									case 1:
										E2FJZwBiESNcRYti3r6k(disposable);
										num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
										{
											num7 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						goto case 13;
					case 10:
						rM3urjBiuU1H6K5S9ho9(TuOpMmBiZKwbPjIiowmG(workItem));
						num3 = 7;
						break;
					case 11:
						Q8YKOIBi8po5poNjQf9f(workItem, Thread.CurrentThread);
						num3 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
						{
							num3 = 7;
						}
						break;
					default:
						queue = elmaThreadPool.queue;
						num3 = 8;
						break;
					case 7:
						disposable = (IDisposable)gThV3vBiI7OiJ7dmutoj();
						num3 = 12;
						break;
					case 13:
						workItem.WaitExecuteEvent.Set();
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num3 = 1;
						}
						break;
					case 4:
						if (cancellationTokenSource.IsCancellationRequested)
						{
							num3 = 6;
							break;
						}
						goto case 3;
					case 2:
						if (workItem == null)
						{
							num3 = 4;
							break;
						}
						goto case 11;
					case 5:
						try
						{
							Monitor.Enter(queue, ref lockTaken);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								object obj2;
								switch (num4)
								{
								default:
									if (l1oVjBBivQgvjjUInVjF(elmaThreadPool.queue) > 0)
									{
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
										{
											num4 = 1;
										}
										continue;
									}
									goto case 2;
								case 2:
									obj2 = null;
									break;
								case 1:
									obj2 = elmaThreadPool.queue.Dequeue();
									break;
								case 3:
									goto end_IL_0270;
								}
								workItem = (WorkItem)obj2;
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
								{
									num4 = 3;
								}
								continue;
								end_IL_0270:
								break;
							}
						}
						finally
						{
							if (lockTaken)
							{
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
								{
									num5 = 1;
								}
								while (true)
								{
									switch (num5)
									{
									case 1:
										vyn5RSBihWcgTPEbNkjD(queue);
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
										{
											num5 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						goto case 2;
					case 6:
						return;
					case 3:
						GMAu3WBiQCVIjSEIfO4x(SR.GetSetting(elmaThreadPool.threadTimeoutAppSettingsKey, 50));
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num3 = 0;
						}
						break;
					case 8:
						lockTaken = false;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num3 = 5;
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				int num8 = 4;
				while (true)
				{
					switch (num8)
					{
					case 6:
						if (workItem != null)
						{
							num8 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
							{
								num8 = 8;
							}
							continue;
						}
						return;
					default:
						workItem.WaitThreadEvent.Set();
						num8 = 5;
						continue;
					case 4:
						QUy40IBiRTiIdtJlWskl(N4WpBpBiisGfoGUkoMYc(), RbiDJ4BiF2DPweZIfDdM(0x307E9FD1 ^ 0x307F8545), ex);
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
						{
							num8 = 3;
						}
						continue;
					case 5:
					{
						rM3urjBiuU1H6K5S9ho9(workItem.WaitExecuteEvent);
						int num9 = 2;
						num8 = num9;
						continue;
					}
					case 1:
						return;
					case 8:
						if (flag)
						{
							num8 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
							{
								num8 = 0;
							}
							continue;
						}
						break;
					case 3:
						flag = ex is ThreadAbortException;
						num8 = 6;
						continue;
					case 7:
						break;
					case 2:
						return;
					}
					workItem.WorkerThread = null;
					num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num8 = 0;
					}
				}
			}
			finally
			{
				int num10;
				if (flag)
				{
					num10 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num10 = 5;
					}
					goto IL_052b;
				}
				goto IL_05c5;
				IL_05e6:
				PerformanceCounter performanceCounter = elmaThreadPool.counter;
				if (performanceCounter == null)
				{
					num10 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num10 = 7;
					}
				}
				else
				{
					rUfqTkBiq4j6mgmINX5u(performanceCounter);
					num10 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num10 = 2;
					}
				}
				goto IL_052b;
				IL_052b:
				while (true)
				{
					switch (num10)
					{
					default:
						if (cancellationTokenSource != null)
						{
							num10 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
							{
								num10 = 2;
							}
							continue;
						}
						break;
					case 6:
						JB8OD4BiKlr0T1Dg2YH4(cancellationTokenSource);
						num10 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num10 = 1;
						}
						continue;
					case 5:
						break;
					case 4:
						goto IL_05c5;
					case 3:
						goto IL_05e6;
					case 1:
						break;
					}
					break;
				}
				goto end_IL_0506;
				IL_05c5:
				if (elmaThreadPool == null)
				{
					num10 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num10 = 0;
					}
					goto IL_052b;
				}
				goto IL_05e6;
				end_IL_0506:;
			}
		}
	}

	private void AbortThread(Thread thread)
	{
		//Discarded unreachable code: IL_00b8
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (thread == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 4:
				return;
			case 3:
				if (!thread.ThreadState.HasFlag(System.Threading.ThreadState.Aborted))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 6:
				WmAEdqBiT1dwClDOONFx(thread);
				num2 = 4;
				break;
			case 1:
				return;
			case 5:
				return;
			default:
				if (!pFLsHIBiXLt3q0LwXXk2(thread).HasFlag(System.Threading.ThreadState.Stopped))
				{
					thread.Abort();
					num2 = 6;
				}
				else
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	internal static void jr23MtBSzMaWd3dkqKwl()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object RbiDJ4BiF2DPweZIfDdM(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void TJYZcQBiBjmZw0SjTef0(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static object HSY71CBiWKn7AUqAgjqn(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object LL8t9MBiogYVq7MvdYgH()
	{
		return PoolPerfomanceCounter;
	}

	internal static object NE36VdBibEcxK72ntGEq(object P_0, object P_1)
	{
		return ((IThreadPoolPerfomanceCounter)P_0).AddCounter((string)P_1);
	}

	internal static bool xfnTsmBSsHfjGnljrhEd()
	{
		return ygfZcfBSUaDevN6NB6Zo == null;
	}

	internal static ElmaThreadPool VPDR3kBScIfy2WsbUNmd()
	{
		return ygfZcfBSUaDevN6NB6Zo;
	}

	internal static void vyn5RSBihWcgTPEbNkjD(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static void fiqipXBiGGAIOW6vvMGB(object P_0)
	{
		((CancellationTokenSource)P_0).Cancel();
	}

	internal static void E2FJZwBiESNcRYti3r6k(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static long sc45sLBif78cu89csyjQ(object P_0, long P_1)
	{
		return ((PerformanceCounter)P_0).IncrementBy(P_1);
	}

	internal static void GMAu3WBiQCVIjSEIfO4x(int P_0)
	{
		Thread.Sleep(P_0);
	}

	internal static void Hp3RA4BiCvgLA6keVt0j(object P_0, object P_1)
	{
		((Thread)P_0).Start(P_1);
	}

	internal static int l1oVjBBivQgvjjUInVjF(object P_0)
	{
		return ((Queue<WorkItem>)P_0).Count;
	}

	internal static void Q8YKOIBi8po5poNjQf9f(object P_0, object P_1)
	{
		((WorkItem)P_0).WorkerThread = (Thread)P_1;
	}

	internal static object TuOpMmBiZKwbPjIiowmG(object P_0)
	{
		return ((WorkItem)P_0).WaitThreadEvent;
	}

	internal static bool rM3urjBiuU1H6K5S9ho9(object P_0)
	{
		return ((EventWaitHandle)P_0).Set();
	}

	internal static object gThV3vBiI7OiJ7dmutoj()
	{
		return ELMAContext.Create();
	}

	internal static object oop7ZbBiVhRUbVWVkQP2(object P_0)
	{
		return ((WorkItem)P_0).Callback;
	}

	internal static void xBFgWxBiStOYDOkh18yr(object P_0)
	{
		P_0();
	}

	internal static object N4WpBpBiisGfoGUkoMYc()
	{
		return Logger.Log;
	}

	internal static void QUy40IBiRTiIdtJlWskl(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static long rUfqTkBiq4j6mgmINX5u(object P_0)
	{
		return ((PerformanceCounter)P_0).Decrement();
	}

	internal static void JB8OD4BiKlr0T1Dg2YH4(object P_0)
	{
		((CancellationTokenSource)P_0).Dispose();
	}

	internal static System.Threading.ThreadState pFLsHIBiXLt3q0LwXXk2(object P_0)
	{
		return ((Thread)P_0).ThreadState;
	}

	internal static void WmAEdqBiT1dwClDOONFx(object P_0)
	{
		((Thread)P_0).Join();
	}
}
