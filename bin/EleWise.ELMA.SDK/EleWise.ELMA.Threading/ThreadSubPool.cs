using System;
using System.Collections.Generic;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Context;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Threading;

public class ThreadSubPool : IThreadSubPool, IThreadPool, IElmaThreadPool
{
	private struct TaskInfo
	{
		public static TaskInfo Empty;

		public ThreadStart Task;

		public string TaskName;

		public Action<Exception> ExceptionHandler;

		public Action FinallyHandler;

		private static object cXonJdQvOaH6nKoW2NKU;

		public bool Equals(TaskInfo info)
		{
			//Discarded unreachable code: IL_0099, IL_00a8
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (H0t3M1QvPXd6OIoxwikd(Task, info.Task))
					{
						num2 = 3;
						break;
					}
					goto case 1;
				default:
					return H0t3M1QvPXd6OIoxwikd(FinallyHandler, info.FinallyHandler);
				case 1:
					return false;
				case 3:
					if (TaskName == info.TaskName)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 1;
				case 2:
					if (!H0t3M1QvPXd6OIoxwikd(ExceptionHandler, info.ExceptionHandler))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		}

		static TaskInfo()
		{
			int num = 6;
			int num2 = num;
			TaskInfo empty = default(TaskInfo);
			while (true)
			{
				switch (num2)
				{
				case 2:
					Empty = empty;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 4;
					}
					break;
				case 4:
					return;
				case 5:
					empty = default(TaskInfo);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					empty.FinallyHandler = null;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					SingletonReader.JJCZtPuTvSt();
					num2 = 5;
					break;
				default:
					empty.ExceptionHandler = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					empty.Task = null;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 7;
					}
					break;
				case 7:
					empty.TaskName = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static bool H0t3M1QvPXd6OIoxwikd(object P_0, object P_1)
		{
			return (Delegate)P_0 == (Delegate)P_1;
		}

		internal static bool CVFkfYQv2PePZVhMNomE()
		{
			return cXonJdQvOaH6nKoW2NKU == null;
		}

		internal static object BLjfx9Qve3GXuG9XBEko()
		{
			return cXonJdQvOaH6nKoW2NKU;
		}
	}

	private readonly Queue<TaskInfo> queue;

	private readonly string logPrefix;

	private readonly string appSettingsKey;

	private readonly ElmaThreadPool threadPool;

	private readonly bool useElmaThreadPool;

	private int threadCount;

	private int maxThreadCount;

	internal static ThreadSubPool y3jgQHBRe6Lww5n3Z7lk;

	public int MaxThreadCount
	{
		get
		{
			//Discarded unreachable code: IL_005d, IL_006c
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (appSettingsKey == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					return maxThreadCount;
				case 2:
					break;
				}
				maxThreadCount = SR.GetSetting(appSettingsKey, maxThreadCount);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	public int ActiveThreadCount => threadCount;

	public ThreadSubPool(int maxThreadCount)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		XeQJHfBRN0fqVRE1D3dt();
		this._002Ector(maxThreadCount, null);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ThreadSubPool(int maxThreadCount, string logPrefix)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		queue = new Queue<TaskInfo>();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				this.maxThreadCount = maxThreadCount;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
				this.logPrefix = ((!cs8q8gBR3jkMxXNSCAWV(logPrefix)) ? logPrefix : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -672059899));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public ThreadSubPool(string appSettingsKey, int minThreadCount)
	{
		//Discarded unreachable code: IL_0032, IL_0037
		XeQJHfBRN0fqVRE1D3dt();
		this._002Ector(eNkHXfBRpDtwZQmovukb(appSettingsKey, minThreadCount), null);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
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
			this.appSettingsKey = appSettingsKey;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
			{
				num = 1;
			}
		}
	}

	public ThreadSubPool(string appSettingsKey, int minThreadCount, string logPrefix)
	{
		//Discarded unreachable code: IL_0032, IL_0037
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(eNkHXfBRpDtwZQmovukb(appSettingsKey, minThreadCount), logPrefix);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.appSettingsKey = appSettingsKey;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public ThreadSubPool(string appSettingsKey, int minThreadCount, string logPrefix, bool useElmaThreadPool, string elmaThreadPoolName)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		XeQJHfBRN0fqVRE1D3dt();
		this._002Ector(appSettingsKey, minThreadCount, logPrefix);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				this.useElmaThreadPool = useElmaThreadPool;
				num = 2;
				break;
			case 2:
				if (useElmaThreadPool)
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num = 0;
					}
					break;
				}
				return;
			default:
				threadPool = new ElmaThreadPool(elmaThreadPoolName, appSettingsKey, minThreadCount);
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	public void Queue([NotNull] ThreadStart task)
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
				QueueInternal(task, null, null, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Queue(ThreadStart task, Action<Exception> exceptionHandler, Action finallyHandler)
	{
		QueueInternal(task, null, exceptionHandler, finallyHandler);
	}

	public void Queue([NotNull] ThreadStart task, string taskName)
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
				QueueInternal(task, taskName, null, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	IElmaThreadPoolWorkItem IElmaThreadPool.Push(ThreadStart callback)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (useElmaThreadPool)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				throw new InvalidOperationException((string)l0UyYVBRDBSvVguMcVp0(XdIKDPBRaXn0TYsEsF5l(0xA592A41 ^ 0xA58311D)));
			default:
				return QueueInternal(callback, null, null, null);
			}
		}
	}

	IElmaThreadPoolWorkItem IElmaThreadPool.Push(ThreadStart callback, Action<Exception> exceptionHandler, Action finallyHandler)
	{
		if (!useElmaThreadPool)
		{
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4784A751)));
		}
		return QueueInternal(callback, null, exceptionHandler, finallyHandler);
	}

	public void Queue(ThreadStart task, string taskName, Action<Exception> exceptionHandler, Action finallyHandler)
	{
		QueueInternal(task, taskName, exceptionHandler, finallyHandler);
	}

	public IElmaThreadPoolWorkItem QueueInternal(ThreadStart task, string taskName, Action<Exception> exceptionHandler, Action finallyHandler)
	{
		Contract.ArgumentNotNull(task, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70101546));
		int count;
		lock (queue)
		{
			queue.Enqueue(new TaskInfo
			{
				Task = task,
				TaskName = ((!string.IsNullOrEmpty(taskName)) ? taskName : task.ToString()),
				ExceptionHandler = exceptionHandler,
				FinallyHandler = finallyHandler
			});
			count = queue.Count;
		}
		int num = Interlocked.CompareExchange(ref threadCount, MaxThreadCount, MaxThreadCount);
		bool flag = num < MaxThreadCount;
		if (Logger.Log.IsDebugEnabled())
		{
			Logger.Log.Debug(logPrefix + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633447849) + count + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70067419) + flag.ToString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886580281) + num);
		}
		if (flag)
		{
			Interlocked.Increment(ref threadCount);
			if (useElmaThreadPool)
			{
				return threadPool.Push(ExecuteInThread);
			}
			ThreadStarter.QueueThread(ExecuteInThread);
		}
		return null;
	}

	private static int LoadAppSettingsValue(object key, int minThreadCount)
	{
		return SR.GetSetting((string)key, minThreadCount);
	}

	private TaskInfo Dequeue()
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_00d7, IL_0151, IL_0183, IL_01a2, IL_01b1, IL_01de, IL_01ed
		int num = 6;
		int num2 = num;
		bool lockTaken = default(bool);
		TaskInfo result = default(TaskInfo);
		Queue<TaskInfo> queue = default(Queue<TaskInfo>);
		int count = default(int);
		while (true)
		{
			switch (num2)
			{
			case 5:
				lockTaken = false;
				num2 = 4;
				break;
			case 1:
				if (!((ILogger)HZqrJbBR4CIyLcHpxuJh()).IsDebugEnabled())
				{
					num2 = 2;
					break;
				}
				goto case 3;
			default:
				return result;
			case 7:
				if (result.Equals(TaskInfo.Empty))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 4:
				try
				{
					Monitor.Enter(queue, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						TaskInfo taskInfo;
						switch (num3)
						{
						case 2:
							count = this.queue.Count;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
							{
								num3 = 1;
							}
							continue;
						default:
							if (zo3OhsBRtjG4ie9UESuD(this.queue) <= 0)
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
								{
									num3 = 3;
								}
								continue;
							}
							taskInfo = this.queue.Dequeue();
							break;
						case 3:
							taskInfo = TaskInfo.Empty;
							break;
						case 1:
							goto end_IL_00db;
						}
						result = taskInfo;
						num3 = 2;
						continue;
						end_IL_00db:
						break;
					}
				}
				finally
				{
					int num4;
					if (!lockTaken)
					{
						num4 = 2;
						goto IL_0187;
					}
					goto IL_01bc;
					IL_0187:
					switch (num4)
					{
					default:
						goto end_IL_0172;
					case 2:
						goto end_IL_0172;
					case 1:
						break;
					case 0:
						goto end_IL_0172;
					}
					goto IL_01bc;
					IL_01bc:
					IXHOSpBRwutDgNayqCkh(queue);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num4 = 0;
					}
					goto IL_0187;
					end_IL_0172:;
				}
				goto case 7;
			case 3:
				JGGlvyBR6f8hwi9cVHIs(HZqrJbBR4CIyLcHpxuJh(), string.Concat(logPrefix, XdIKDPBRaXn0TYsEsF5l(-583745292 ^ -583672676), count));
				num2 = 8;
				break;
			case 6:
				queue = this.queue;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void ExecuteInThread()
	{
		//Discarded unreachable code: IL_00a6, IL_0102, IL_0125, IL_01be, IL_0248, IL_0257, IL_0262, IL_0266, IL_026f, IL_029f, IL_02dc, IL_02eb, IL_0341, IL_0350, IL_035b, IL_035f, IL_0368, IL_0383, IL_03a2, IL_03b1, IL_03de, IL_03ed, IL_03fd, IL_0478, IL_04e5, IL_0558, IL_0567
		switch (1)
		{
		case 1:
			try
			{
				int num2;
				if (!QfB08MBRHf7m2RxGGQal(HZqrJbBR4CIyLcHpxuJh()))
				{
					int num = 6;
					num2 = num;
					goto IL_0047;
				}
				goto IL_0071;
				IL_0047:
				_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_;
				TaskInfo info = default(TaskInfo);
				ThreadSubPoolCallInfo threadSubPoolCallInfo = default(ThreadSubPoolCallInfo);
				TaskInfo taskInfo = default(TaskInfo);
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 3:
						break;
					case 2:
						_003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
						_003C_003Ec__DisplayClass26_.info = info;
						threadSubPoolCallInfo = DiagnosticsManager.StartCall(() => new ThreadSubPoolCallInfo(_003C_003Ec__DisplayClass26_0.p1HBv0QvDNW85gadOc7m(_003C_003Ec__DisplayClass26_0.OpQ4NqQvaXOP6picUqSu(_003C_003Ec__DisplayClass26_.info.Task)), _003C_003Ec__DisplayClass26_.info.Task.Method));
						num2 = 5;
						continue;
					case 5:
						try
						{
							try
							{
								DkPRJVBRAnKGrPVFhAbi(info.Task);
								int num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
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
								int num4 = 3;
								while (true)
								{
									switch (num4)
									{
									default:
										threadSubPoolCallInfo.Exception = ex;
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
										{
											num4 = 4;
										}
										continue;
									case 3:
										if (info.ExceptionHandler == null)
										{
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
											{
												num4 = 1;
											}
											continue;
										}
										goto case 5;
									case 1:
									case 2:
										if (threadSubPoolCallInfo != null)
										{
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
											{
												num4 = 0;
											}
											continue;
										}
										break;
									case 5:
										info.ExceptionHandler(ex);
										num4 = 2;
										continue;
									case 4:
										break;
									case 6:
										goto end_IL_0129;
									}
									a5UZFNBRxeCl57YrcAEi(HZqrJbBR4CIyLcHpxuJh(), SIq9SqBR7cM6Dyw9eA7N(logPrefix, XdIKDPBRaXn0TYsEsF5l(-2099751081 ^ -2099757309), string.Format((string)XdIKDPBRaXn0TYsEsF5l(-1633514411 ^ -1633447705), info.TaskName)), ex);
									num4 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
									{
										num4 = 3;
									}
									continue;
									end_IL_0129:
									break;
								}
							}
							finally
							{
								int num5;
								if (info.FinallyHandler == null)
								{
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
									{
										num5 = 3;
									}
									goto IL_02a3;
								}
								goto IL_02f6;
								IL_02f6:
								jqhwEmBR0ltigXc39tK6(info.FinallyHandler);
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
								{
									num5 = 0;
								}
								goto IL_02a3;
								IL_02a3:
								while (true)
								{
									switch (num5)
									{
									case 1:
									case 3:
									{
										IDictionary<string, object> items = ELMAContext.Items;
										if (items == null)
										{
											num5 = 2;
											continue;
										}
										HBpWmnBRmhIdF1VTood4(items);
										num5 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
										{
											num5 = 4;
										}
										continue;
									}
									case 2:
										goto end_IL_02a3;
									case 4:
										goto end_IL_02a3;
									}
									goto IL_02f6;
									continue;
									end_IL_02a3:
									break;
								}
							}
						}
						finally
						{
							int num6;
							if (threadSubPoolCallInfo == null)
							{
								num6 = 2;
								goto IL_0387;
							}
							goto IL_03bc;
							IL_0387:
							switch (num6)
							{
							default:
								goto end_IL_0372;
							case 2:
								goto end_IL_0372;
							case 1:
								break;
							case 0:
								goto end_IL_0372;
							}
							goto IL_03bc;
							IL_03bc:
							WSIoYoBRyKRokbWZN6ya(threadSubPoolCallInfo);
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
							{
								num6 = 0;
							}
							goto IL_0387;
							end_IL_0372:;
						}
						goto case 4;
					case 1:
						if (taskInfo.Equals(TaskInfo.Empty))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 2;
					case 4:
					case 6:
					case 7:
						taskInfo = (info = Dequeue());
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num2 = 0;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
				goto IL_0071;
				IL_0071:
				JGGlvyBR6f8hwi9cVHIs(HZqrJbBR4CIyLcHpxuJh(), logPrefix + (string)XdIKDPBRaXn0TYsEsF5l(--1867379187 ^ 0x6F4CED7D));
				num2 = 4;
				goto IL_0047;
			}
			catch (Exception ex2)
			{
				int num7 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num7 = 0;
				}
				while (true)
				{
					switch (num7)
					{
					case 1:
						return;
					}
					a5UZFNBRxeCl57YrcAEi(HZqrJbBR4CIyLcHpxuJh(), logPrefix, ex2);
					num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num7 = 1;
					}
				}
			}
			finally
			{
				Interlocked.Decrement(ref threadCount);
				int num8 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num8 = 0;
				}
				while (true)
				{
					switch (num8)
					{
					default:
						if (QfB08MBRHf7m2RxGGQal(HZqrJbBR4CIyLcHpxuJh()))
						{
							num8 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
							{
								num8 = 1;
							}
							continue;
						}
						break;
					case 1:
						JGGlvyBR6f8hwi9cVHIs(HZqrJbBR4CIyLcHpxuJh(), ojEJONBRMt47gVgB2Nfx(logPrefix, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463B13CA)));
						num8 = 2;
						continue;
					case 2:
						break;
					}
					break;
				}
			}
		case 0:
			break;
		}
	}

	internal static void XeQJHfBRN0fqVRE1D3dt()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool nQ6SdXBRPB4Qk7hNXWcO()
	{
		return y3jgQHBRe6Lww5n3Z7lk == null;
	}

	internal static ThreadSubPool CgOU6QBR15MHcx4ibwtP()
	{
		return y3jgQHBRe6Lww5n3Z7lk;
	}

	internal static bool cs8q8gBR3jkMxXNSCAWV(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static int eNkHXfBRpDtwZQmovukb(object P_0, int minThreadCount)
	{
		return LoadAppSettingsValue(P_0, minThreadCount);
	}

	internal static object XdIKDPBRaXn0TYsEsF5l(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object l0UyYVBRDBSvVguMcVp0(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static int zo3OhsBRtjG4ie9UESuD(object P_0)
	{
		return ((Queue<TaskInfo>)P_0).Count;
	}

	internal static void IXHOSpBRwutDgNayqCkh(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object HZqrJbBR4CIyLcHpxuJh()
	{
		return Logger.Log;
	}

	internal static void JGGlvyBR6f8hwi9cVHIs(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static bool QfB08MBRHf7m2RxGGQal(object P_0)
	{
		return ((ILogger)P_0).IsDebugEnabled();
	}

	internal static void DkPRJVBRAnKGrPVFhAbi(object P_0)
	{
		P_0();
	}

	internal static object SIq9SqBR7cM6Dyw9eA7N(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void a5UZFNBRxeCl57YrcAEi(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void jqhwEmBR0ltigXc39tK6(object P_0)
	{
		P_0();
	}

	internal static void HBpWmnBRmhIdF1VTood4(object P_0)
	{
		((ICollection<KeyValuePair<string, object>>)P_0).Clear();
	}

	internal static void WSIoYoBRyKRokbWZN6ya(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object ojEJONBRMt47gVgB2Nfx(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}
}
