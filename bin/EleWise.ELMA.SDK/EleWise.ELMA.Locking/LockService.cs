using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Provider;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Locking;

public abstract class LockService : ProviderBase, ILockService, IAsyncLockService
{
	private class ThreadSafeSemaphoreSlim : IDisposable
	{
		private static readonly ConditionalWeakTable<object, ThreadSafeSemaphoreSlim> Semaphores;

		private static readonly AsyncLocal<ThreadSafeSemaphoreSlim[]> TreadSemaphores;

		private readonly object semaphore;

		private readonly object key;

		private bool disposed;

		internal static object W4vlkyvAwIFejZX2FV1E;

		public static ThreadSafeSemaphoreSlim Get(object key)
		{
			ThreadSafeSemaphoreSlim value = Semaphores.GetValue(key, (object k) => new ThreadSafeSemaphoreSlim(k));
			d4l3xgvAHdZYjDoXrUqR();
			return value;
		}

		private ThreadSafeSemaphoreSlim(object key)
		{
			//Discarded unreachable code: IL_003c, IL_0041
			Yn7yvvvAAxgqHeJ9jyrf();
			semaphore = new SemaphoreSlim(1, 1);
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
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
					this.key = new WeakReference(key);
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		[AsyncStateMachine(typeof(_003CWaitAsync_003Ed__7))]
		public Task<bool> WaitAsync(TimeSpan timeout, CancellationToken cancellationToken)
		{
			_003CWaitAsync_003Ed__7 stateMachine = default(_003CWaitAsync_003Ed__7);
			stateMachine._003C_003E4__this = this;
			stateMachine.timeout = timeout;
			stateMachine.cancellationToken = cancellationToken;
			stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
			stateMachine._003C_003E1__state = -1;
			AsyncTaskMethodBuilder<bool> _003C_003Et__builder = stateMachine._003C_003Et__builder;
			_003C_003Et__builder.Start(ref stateMachine);
			return stateMachine._003C_003Et__builder.Task;
		}

		public bool Wait(TimeSpan timeout)
		{
			//Discarded unreachable code: IL_005f
			int num = 1;
			int num2 = num;
			bool flag = default(bool);
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 3:
					SaveLockTread(flag);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 2;
					}
					continue;
				default:
					num3 = (dZ7QRwvA7iR2HsFTslEp(semaphore, timeout) ? 1 : 0);
					break;
				case 1:
					if (!CheckLockTread())
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num2 = 0;
						}
						continue;
					}
					num3 = 1;
					break;
				case 2:
					return flag;
				}
				flag = (byte)num3 != 0;
				num2 = 3;
			}
		}

		public void Release()
		{
			//Discarded unreachable code: IL_0056, IL_0065
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (ClearLockTread())
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 0:
					return;
				case 2:
					break;
				case 3:
					return;
				}
				ONWHBBvAxkylHBBlbSG0(semaphore);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 2;
				}
			}
		}

		private bool CheckLockTread()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return Array.IndexOf(TreadSemaphores.Value, this) >= 0;
				case 1:
					if (TreadSemaphores.Value == null)
					{
						return false;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		private static void PrepareLockTread()
		{
			//Discarded unreachable code: IL_004a, IL_008f, IL_009e
			int num = 1;
			ThreadSafeSemaphoreSlim[] value = default(ThreadSafeSemaphoreSlim[]);
			ThreadSafeSemaphoreSlim[] array = default(ThreadSafeSemaphoreSlim[]);
			int num4 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 5:
						num3 = 0;
						goto IL_0166;
					default:
						if (value != null)
						{
							num2 = 6;
							continue;
						}
						goto case 2;
					case 2:
						TreadSemaphores.Value = new ThreadSafeSemaphoreSlim[1];
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num2 = 3;
						}
						continue;
					case 4:
						return;
					case 6:
						if (Array.IndexOf(value, null) != -1)
						{
							num2 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
							{
								num2 = 5;
							}
							continue;
						}
						num3 = 1;
						goto IL_0166;
					case 3:
						array = new ThreadSafeSemaphoreSlim[value.Length + num4];
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 4;
						}
						continue;
					case 1:
						value = TreadSemaphores.Value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 0;
						}
						continue;
					case 8:
						return;
					case 7:
						Pwrov4vA0YZvMhlMDS6c(value, 0, array, num4, value.Length);
						num = 9;
						break;
					case 9:
						{
							TreadSemaphores.Value = array;
							num2 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
							{
								num2 = 7;
							}
							continue;
						}
						IL_0166:
						num4 = num3;
						num = 3;
						break;
					}
					break;
				}
			}
		}

		private void SaveLockTread(bool entered)
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
				{
					ThreadSafeSemaphoreSlim[] value = TreadSemaphores.Value;
					value[Array.IndexOf(value, null)] = this;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 2;
					}
					break;
				}
				case 1:
					if (!entered)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		private bool ClearLockTread()
		{
			//Discarded unreachable code: IL_0080, IL_008f
			int num = 2;
			int num3 = default(int);
			ThreadSafeSemaphoreSlim[] value = default(ThreadSafeSemaphoreSlim[]);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 7:
						return false;
					case 3:
						num3 = Array.IndexOf(value, this);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
						{
							num2 = 4;
						}
						continue;
					case 1:
						if (value != null)
						{
							num = 3;
							break;
						}
						goto case 7;
					default:
						return false;
					case 4:
						if (num3 != -1)
						{
							if (value.Length == 1)
							{
								num = 6;
								break;
							}
							value[num3] = null;
							num2 = 5;
							continue;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num2 = 0;
						}
						continue;
					case 5:
						return Array.IndexOf(value, this, num3 + 1) != -1;
					case 6:
						TreadSemaphores.Value = null;
						num2 = 8;
						continue;
					case 2:
						value = TreadSemaphores.Value;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num2 = 1;
						}
						continue;
					case 8:
						return false;
					}
					break;
				}
			}
		}

		~ThreadSafeSemaphoreSlim()
		{
			//Discarded unreachable code: IL_0046, IL_007d, IL_0090, IL_009f
			switch (1)
			{
			case 1:
				try
				{
					Dispose(disposing: false);
					int num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
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
					uYq7bTvAmdl1yXVMfiYK(this);
					int num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
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
					RE0prrvAyTIkG3KnbXGx(this);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					Dispose(disposing: true);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		private void Dispose(bool disposing)
		{
			//Discarded unreachable code: IL_00fa, IL_0109
			int num = 7;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 6:
				{
					object obj = semaphore;
					if (obj == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num2 = 2;
						}
					}
					else
					{
						IqXwamvAMxjn1rlkl5EX(obj);
						num2 = 4;
					}
					continue;
				}
				case 1:
					return;
				case 7:
					if (disposed)
					{
						return;
					}
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
				case 4:
					if (GkTgCHvAJN7ZN4OOILE7(key))
					{
						num2 = 3;
						continue;
					}
					break;
				case 3:
					Semaphores.Remove(FXSIiEvA9R6hr3eInCW3(key));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					break;
				}
				disposed = true;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 1;
				}
			}
		}

		static ThreadSafeSemaphoreSlim()
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
					Semaphores = new ConditionalWeakTable<object, ThreadSafeSemaphoreSlim>();
					num2 = 3;
					break;
				case 3:
					TreadSemaphores = new AsyncLocal<ThreadSafeSemaphoreSlim[]>();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					Yn7yvvvAAxgqHeJ9jyrf();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void d4l3xgvAHdZYjDoXrUqR()
		{
			PrepareLockTread();
		}

		internal static bool PZmhkOvA4waRucyumvbG()
		{
			return W4vlkyvAwIFejZX2FV1E == null;
		}

		internal static ThreadSafeSemaphoreSlim DDTop1vA641YfXsIU5Ax()
		{
			return (ThreadSafeSemaphoreSlim)W4vlkyvAwIFejZX2FV1E;
		}

		internal static void Yn7yvvvAAxgqHeJ9jyrf()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool dZ7QRwvA7iR2HsFTslEp(object P_0, TimeSpan P_1)
		{
			return ((SemaphoreSlim)P_0).Wait(P_1);
		}

		internal static int ONWHBBvAxkylHBBlbSG0(object P_0)
		{
			return ((SemaphoreSlim)P_0).Release();
		}

		internal static void Pwrov4vA0YZvMhlMDS6c(object P_0, int P_1, object P_2, int P_3, int P_4)
		{
			Array.Copy((Array)P_0, P_1, (Array)P_2, P_3, P_4);
		}

		internal static void uYq7bTvAmdl1yXVMfiYK(object P_0)
		{
			P_0.Finalize();
		}

		internal static void RE0prrvAyTIkG3KnbXGx(object P_0)
		{
			GC.SuppressFinalize(P_0);
		}

		internal static void IqXwamvAMxjn1rlkl5EX(object P_0)
		{
			((SemaphoreSlim)P_0).Dispose();
		}

		internal static bool GkTgCHvAJN7ZN4OOILE7(object P_0)
		{
			return ((WeakReference)P_0).IsAlive;
		}

		internal static object FXSIiEvA9R6hr3eInCW3(object P_0)
		{
			return ((WeakReference)P_0).Target;
		}
	}

	protected readonly TimeSpan DEFAULT_VALID_FOR;

	protected readonly TimeSpan DEFAULT_REPEAT_INTERVAL;

	private readonly ConcurrentDictionary<IDisposable, Lock> locks;

	protected static TimeSpan InfiniteTimeSpan;

	internal static LockService EGJHU2hrvh3ZDlpJuh7n;

	public IApplicationEnvironmentService ApplicationEnvironment
	{
		[CompilerGenerated]
		get
		{
			return _003CApplicationEnvironment_003Ek__BackingField;
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
					_003CApplicationEnvironment_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
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

	public ILogger Logger
	{
		[CompilerGenerated]
		get
		{
			return _003CLogger_003Ek__BackingField;
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
					_003CLogger_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
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

	public ILockKeyFactory LockKeyFactory
	{
		[CompilerGenerated]
		get
		{
			return _003CLockKeyFactory_003Ek__BackingField;
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
					_003CLockKeyFactory_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual Task<ILock> TryAcquireLockAsync(string name, TimeSpan? maxValidFor, TimeSpan? timeout, CancellationToken token = default(CancellationToken))
	{
		return TryAcquireLockAsync(name, token, maxValidFor, timeout, null);
	}

	public virtual Task<ILock> AcquireLockAsync(string name, TimeSpan? maxValidFor, TimeSpan? timeout, CancellationToken token = default(CancellationToken))
	{
		return AcquireLockAsync(name, token, maxValidFor, timeout, null);
	}

	protected virtual Task<ILock> AcquireLockAsync(string name, CancellationToken token, TimeSpan? maxValidFor, TimeSpan? timeout, TimeSpan? repeatInterval)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.name = name;
		return AcquireLockInternalAsync(CS_0024_003C_003E8__locals0.name, token, maxValidFor, timeout, null, throwOnTimeout: true, isAsync: true).AsTask().ContinueWith(delegate(Task<ILock> t)
		{
			if (t.IsFaulted)
			{
				CS_0024_003C_003E8__locals0._003C_003E4__this.Logger.Error(t.Exception, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234141884), CS_0024_003C_003E8__locals0.name);
				throw t.Exception;
			}
			CS_0024_003C_003E8__locals0._003C_003E4__this.Logger.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889687474), CS_0024_003C_003E8__locals0.name));
			return t.Result;
		});
	}

	protected virtual Task<ILock> TryAcquireLockAsync(string name, CancellationToken token, TimeSpan? maxValidFor, TimeSpan? timeout, TimeSpan? repeatInterval)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.name = name;
		CS_0024_003C_003E8__locals0.timeout = timeout;
		return AcquireLockInternalAsync(CS_0024_003C_003E8__locals0.name, token, maxValidFor, CS_0024_003C_003E8__locals0.timeout, null, throwOnTimeout: false, isAsync: true).AsTask().ContinueWith(delegate(Task<ILock> t)
		{
			if (t.IsFaulted)
			{
				CS_0024_003C_003E8__locals0._003C_003E4__this.Logger.Error(t.Exception, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7EF8D6B), CS_0024_003C_003E8__locals0.name);
			}
			else
			{
				if (t.Result != null)
				{
					CS_0024_003C_003E8__locals0._003C_003E4__this.Logger.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B353307), CS_0024_003C_003E8__locals0.name));
					return t.Result;
				}
				CS_0024_003C_003E8__locals0._003C_003E4__this.Logger.Warn(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x46399796), CS_0024_003C_003E8__locals0.name, CS_0024_003C_003E8__locals0.timeout));
			}
			return null;
		});
	}

	private System.Threading.Tasks.ValueTask<ILock> AcquireLockInternalAsync(string name, CancellationToken token, TimeSpan? maxValidFor, TimeSpan? timeout, TimeSpan? repeatInterval, bool throwOnTimeout, bool isAsync)
	{
		string internalLockName = GetInternalLockName(name);
		Logger.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487153386), internalLockName, timeout));
		IDisposable disposable = LockKeyFactory.Get(ApplicationEnvironment.GetEnvironmentId() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x6381C4A9) + internalLockName);
		ThreadSafeSemaphoreSlim semaphore = ThreadSafeSemaphoreSlim.Get(disposable);
		return AcquireLockInternalAsync(internalLockName, token, maxValidFor, timeout, repeatInterval, throwOnTimeout, isAsync, disposable, semaphore);
	}

	[AsyncStateMachine(typeof(_003CAcquireLockInternalAsync_003Ed__6))]
	private System.Threading.Tasks.ValueTask<ILock> AcquireLockInternalAsync(string internalName, CancellationToken token, TimeSpan? maxValidFor, TimeSpan? timeout, TimeSpan? repeatInterval, bool throwOnTimeout, bool isAsync, IDisposable monitorObj, ThreadSafeSemaphoreSlim semaphore)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		_003CAcquireLockInternalAsync_003Ed__6 _003CAcquireLockInternalAsync_003Ed__ = default(_003CAcquireLockInternalAsync_003Ed__6);
		_003CAcquireLockInternalAsync_003Ed__._003C_003E4__this = this;
		_003CAcquireLockInternalAsync_003Ed__.internalName = internalName;
		_003CAcquireLockInternalAsync_003Ed__.token = token;
		_003CAcquireLockInternalAsync_003Ed__.maxValidFor = maxValidFor;
		_003CAcquireLockInternalAsync_003Ed__.timeout = timeout;
		_003CAcquireLockInternalAsync_003Ed__.repeatInterval = repeatInterval;
		_003CAcquireLockInternalAsync_003Ed__.throwOnTimeout = throwOnTimeout;
		_003CAcquireLockInternalAsync_003Ed__.isAsync = isAsync;
		_003CAcquireLockInternalAsync_003Ed__.monitorObj = monitorObj;
		_003CAcquireLockInternalAsync_003Ed__.semaphore = semaphore;
		_003CAcquireLockInternalAsync_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder<ILock>.Create();
		_003CAcquireLockInternalAsync_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder<ILock> _003C_003Et__builder = _003CAcquireLockInternalAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CAcquireLockInternalAsync_003Ed__6>(ref _003CAcquireLockInternalAsync_003Ed__);
		return _003CAcquireLockInternalAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	protected abstract Task<Lock> AcquireLockInternalAsyncImpl(string name, CancellationToken token, TimeSpan maxValidFor, TimeSpan timeout, TimeSpan repeatInterval);

	public virtual ILock AcquireLock(string name, TimeSpan? maxValidFor, TimeSpan? timeout)
	{
		return AcquireLock(name, maxValidFor, timeout, null);
	}

	public virtual bool TryAcquireLock(string name, TimeSpan? maxValidFor, TimeSpan? timeout, out ILock @lock)
	{
		return TryAcquireLock(name, maxValidFor, timeout, null, out @lock);
	}

	public abstract void Configure(ProviderSettingsSection settings, RuntimeConfiguration configuration);

	protected virtual ILock AcquireLock(string name, TimeSpan? maxValidFor, TimeSpan? timeout, TimeSpan? repeatInterval)
	{
		try
		{
			ILock result = AcquireLockInternal(name, maxValidFor, timeout, null, throwOnTimeout: true);
			Logger.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998377164), name));
			return result;
		}
		catch (Exception exception)
		{
			Logger.Error(exception, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606820024), name);
			throw;
		}
	}

	protected virtual bool TryAcquireLock(string name, TimeSpan? maxValidFor, TimeSpan? timeout, TimeSpan? repeatInterval, out ILock @lock)
	{
		try
		{
			@lock = AcquireLockInternal(name, maxValidFor, timeout, null, throwOnTimeout: false);
			if (@lock != null)
			{
				Logger.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x341BC65B), name));
				return true;
			}
			Logger.Warn(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195776065), name, timeout));
		}
		catch (Exception exception)
		{
			Logger.Error(exception, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2025821B), name);
		}
		@lock = null;
		return false;
	}

	protected virtual ILock AcquireLockInternal(string name, TimeSpan? maxValidFor, TimeSpan? timeout, TimeSpan? repeatInterval, bool throwOnTimeout)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		return AcquireLockInternalAsync(name, CancellationToken.None, maxValidFor, timeout, repeatInterval, throwOnTimeout, isAsync: false).GetAwaiter().GetResult();
	}

	protected abstract Lock AcquireLockInternalImpl(string name, TimeSpan maxValidFor, TimeSpan timeout, TimeSpan repeatInterval);

	protected virtual string GetInternalLockName(string name)
	{
		return (string)KG22hDhruneBH8lvPMfx(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886415711), name);
	}

	protected LockService()
	{
		//Discarded unreachable code: IL_006c, IL_0071
		uvZarnhrIcMDRyHFEdMS();
		DEFAULT_VALID_FOR = ix1d8QhrVwhBofT4Apuo(1.0);
		DEFAULT_REPEAT_INTERVAL = mVGmRyhrSh05JeABNbQx(500.0);
		locks = new ConcurrentDictionary<IDisposable, Lock>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static LockService()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				InfiniteTimeSpan = new TimeSpan(0, 0, 0, 0, -1);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				uvZarnhrIcMDRyHFEdMS();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool aYV7LRhr8NoLAkCO9Hqe()
	{
		return EGJHU2hrvh3ZDlpJuh7n == null;
	}

	internal static LockService o5ZYZOhrZV3L3YAmrwC4()
	{
		return EGJHU2hrvh3ZDlpJuh7n;
	}

	internal static object KG22hDhruneBH8lvPMfx(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void uvZarnhrIcMDRyHFEdMS()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static TimeSpan ix1d8QhrVwhBofT4Apuo(double P_0)
	{
		return TimeSpan.FromHours(P_0);
	}

	internal static TimeSpan mVGmRyhrSh05JeABNbQx(double P_0)
	{
		return TimeSpan.FromMilliseconds(P_0);
	}
}
public abstract class LockService<TSettings> : LockService where TSettings : LockServiceSettingsBase
{
	private static object RG0EONhrNO0BSsJ2owBe;

	protected TSettings Settings { get; private set; }

	protected virtual string SettingSection => typeof(TSettings).Name;

	public override Task<ILock> AcquireLockAsync(string name, TimeSpan? maxValidFor, TimeSpan? timeout, CancellationToken token = default(CancellationToken))
	{
		return AcquireLockAsync(name, token, maxValidFor ?? SecondsToTimeSpan(Settings.DefaultLockValidFor), timeout ?? SecondsToTimeSpan(Settings.DefaultLockTimeout), TimeSpan.FromMilliseconds(Settings.DefaultLockRepeat));
	}

	public override Task<ILock> TryAcquireLockAsync(string name, TimeSpan? maxValidFor, TimeSpan? timeout, CancellationToken token = default(CancellationToken))
	{
		return TryAcquireLockAsync(name, token, maxValidFor ?? SecondsToTimeSpan(Settings.DefaultLockValidFor), timeout ?? SecondsToTimeSpan(Settings.DefaultLockTimeout), TimeSpan.FromMilliseconds(Settings.DefaultLockRepeat));
	}

	public override ILock AcquireLock(string name, TimeSpan? maxValidFor, TimeSpan? timeout)
	{
		return AcquireLock(name, maxValidFor ?? SecondsToTimeSpan(Settings.DefaultLockValidFor), timeout ?? SecondsToTimeSpan(Settings.DefaultLockTimeout), TimeSpan.FromMilliseconds(Settings.DefaultLockRepeat));
	}

	public override bool TryAcquireLock(string name, TimeSpan? maxValidFor, TimeSpan? timeout, out ILock @lock)
	{
		return TryAcquireLock(name, maxValidFor ?? SecondsToTimeSpan(Settings.DefaultLockValidFor), timeout ?? SecondsToTimeSpan(Settings.DefaultLockTimeout), TimeSpan.FromMilliseconds(Settings.DefaultLockRepeat), out @lock);
	}

	public override void Configure(ProviderSettingsSection settings, RuntimeConfiguration configuration)
	{
		//Discarded unreachable code: IL_005f, IL_017f, IL_018e
		int num = 9;
		int num2 = num;
		TSettings val = default(TSettings);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 6:
				if (IsRequireSettings())
				{
					num2 = 3;
					break;
				}
				goto case 5;
			case 5:
				Settings = CreateSettings();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (val != null)
				{
					num2 = 2;
					break;
				}
				goto case 6;
			case 1:
				return;
			case 3:
				throw new ConfigurationErrorsException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234142126), SettingSection));
			case 2:
				Settings = val;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				Contract.ArgumentNotNull(configuration.Config, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576126948));
				num2 = 7;
				break;
			case 9:
				Contract.ArgumentNotNull(configuration, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103E2A77));
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 4;
				}
				break;
			case 7:
				val = configuration.Config.GetSection(SettingSection) as TSettings;
				num2 = 4;
				break;
			}
		}
	}

	private bool IsRequireSettings()
	{
		return typeof(TSettings).GetProperties().SelectMany((PropertyInfo p) => p.GetCustomAttributes(typeof(ConfigurationPropertyAttribute), inherit: false)).Any((object a) => ((ConfigurationPropertyAttribute)a).IsRequired);
	}

	private TSettings CreateSettings()
	{
		object obj = Activator.CreateInstance(typeof(TSettings));
		foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(obj))
		{
			if (property.Attributes[typeof(ConfigurationPropertyAttribute)] is ConfigurationPropertyAttribute configurationPropertyAttribute && configurationPropertyAttribute.DefaultValue != null)
			{
				try
				{
					property.SetValue(obj, configurationPropertyAttribute.DefaultValue);
				}
				catch (Exception)
				{
				}
			}
		}
		return (TSettings)obj;
	}

	private TimeSpan SecondsToTimeSpan(int secs)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return TimeSpan.FromSeconds(secs);
			case 1:
				if (secs < 0)
				{
					return LockService.InfiniteTimeSpan;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected LockService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
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
	}

	internal static bool VXem4Mhr3noyg7WDWuai()
	{
		return RG0EONhrNO0BSsJ2owBe == null;
	}

	internal static object NjagAhhrpjNVRci447Aw()
	{
		return RG0EONhrNO0BSsJ2owBe;
	}
}
