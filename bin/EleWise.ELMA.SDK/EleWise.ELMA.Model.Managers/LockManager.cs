using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Locking;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Managers;

[Service(Type = ComponentType.Server)]
public class LockManager : NHManager, ILockManager
{
	private ILockService DistributedLockServicePrivate;

	private IAsyncLockService distributedAsyncLockServicePrivate;

	internal static LockManager SJRSsNhQvnYCEoOyYiuX;

	public IUnitOfWorkManager UnitOfWorkManager
	{
		[CompilerGenerated]
		get
		{
			return _003CUnitOfWorkManager_003Ek__BackingField;
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
					_003CUnitOfWorkManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
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

	[Obsolete]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ILockService DistributedLockService
	{
		get
		{
			int num = 1;
			int num2 = num;
			ILockService lockService2;
			ILockService lockService = default(ILockService);
			while (true)
			{
				switch (num2)
				{
				case 1:
					lockService2 = DistributedLockServicePrivate;
					if (lockService2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					lockService = (DistributedLockServicePrivate = Locator.GetServiceNotNull<ILockService>());
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					lockService2 = lockService;
					break;
				}
				break;
			}
			return lockService2;
		}
	}

	public IAsyncLockService DistributedAsyncLockService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IAsyncLockService asyncLockService = default(IAsyncLockService);
			IAsyncLockService asyncLockService2;
			while (true)
			{
				switch (num2)
				{
				default:
					asyncLockService = (distributedAsyncLockServicePrivate = Locator.GetServiceNotNull<IAsyncLockService>());
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					asyncLockService2 = distributedAsyncLockServicePrivate;
					if (asyncLockService2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					asyncLockService2 = asyncLockService;
					break;
				}
				break;
			}
			return asyncLockService2;
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
				case 0:
					return;
				case 1:
					_003CLogger_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Obsolete("Устарел, используйте метод Lock")]
	public void ObtainLock(string lockName, int timeout)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ObtainLockException(lockName);
			case 1:
			{
				if (DistributedLockService.TryAcquireLock(lockName, null, TimeSpan.FromSeconds(timeout), out var _))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	[Obsolete("Устарел, используйте метод Lock")]
	public void ObtainLock(string lockName)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			default:
				throw new ObtainLockException(lockName);
			case 2:
			{
				if (DistributedLockService.TryAcquireLock(lockName, null, null, out var _))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
			}
		}
	}

	[Obsolete("Устарел, используйте метод TryLock")]
	public bool TryObtainLock(string lockName, int timeout)
	{
		ILock @lock;
		return DistributedLockService.TryAcquireLock(lockName, null, INBbUXhQuIAlgBjgEWom(timeout), out @lock);
	}

	[Obsolete("Устарел, используйте метод TryLock")]
	public bool TryObtainLock(string lockName)
	{
		ILock @lock;
		return DistributedLockService.TryAcquireLock(lockName, null, null, out @lock);
	}

	public IDisposable Lock(string lockName)
	{
		return (IDisposable)X1ytPShQISAc0cB2C7nA(DistributedLockService, lockName);
	}

	public IDisposable Lock(string lockName, int timeout)
	{
		return DistributedLockService.AcquireLock(lockName, null, INBbUXhQuIAlgBjgEWom(timeout));
	}

	public bool TryLock(string lockName, int timeout, out IDisposable @lock)
	{
		ILock lock2;
		bool result = DistributedLockService.TryAcquireLock(lockName, null, INBbUXhQuIAlgBjgEWom(timeout), out lock2);
		@lock = lock2;
		return result;
	}

	public bool TryLock(string lockName, out IDisposable @lock)
	{
		ILock lock2;
		bool result = DistributedLockService.TryAcquireLock(lockName, null, null, out lock2);
		@lock = lock2;
		return result;
	}

	[Obsolete("Используйте Lock. Будет удален в будущих версиях.")]
	public IDisposable HardLock(string lockName)
	{
		return (IDisposable)X1ytPShQISAc0cB2C7nA(DistributedLockService, lockName);
	}

	[Obsolete("Используйте Lock. Будет удален в будущих версиях.")]
	public IDisposable HardLock(string lockName, int timeout)
	{
		return (IDisposable)X1ytPShQISAc0cB2C7nA(DistributedLockService, lockName);
	}

	[Obsolete("Устарел, не используется")]
	public void ReleaseLock(string lockName)
	{
		//Discarded unreachable code: IL_0062, IL_009a, IL_00d2, IL_010a, IL_0119, IL_0145, IL_01a3, IL_01b2
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				ILock @lock = DistributedLockService.AcquireLock(lockName, null, TimeSpan.Zero);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					break;
				default:
					try
					{
						wi2eshhQVyxlaZawteJO(@lock);
						int num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
						{
							num2 = 0;
						}
						switch (num2)
						{
						case 0:
							break;
						}
						break;
					}
					finally
					{
						if (@lock != null)
						{
							int num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
							{
								num3 = 0;
							}
							while (true)
							{
								switch (num3)
								{
								default:
									@lock.Dispose();
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
									{
										num3 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				}
				break;
			}
			catch (TimeoutException ex)
			{
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num4 = 0;
				}
				while (true)
				{
					switch (num4)
					{
					case 1:
						return;
					}
					z4xltBhQiXCVgw6LLAiS(Logger, ncwbh9hQS1IXoNBOV1XN(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6D6CB7), lockName), ex);
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num4 = 1;
					}
				}
			}
		}
	}

	[Obsolete("Don't use this method. Always returns null.")]
	public bool? HasLock(string lockName)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CLockAsync_003Ed__26))]
	public Task<IDisposable> LockAsync(string lockName, CancellationToken token = default(CancellationToken))
	{
		_003CLockAsync_003Ed__26 stateMachine = default(_003CLockAsync_003Ed__26);
		stateMachine._003C_003E4__this = this;
		stateMachine.lockName = lockName;
		stateMachine.token = token;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IDisposable>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IDisposable> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CLockAsync_003Ed__27))]
	public Task<IDisposable> LockAsync(string lockName, int timeout, CancellationToken token = default(CancellationToken))
	{
		_003CLockAsync_003Ed__27 stateMachine = default(_003CLockAsync_003Ed__27);
		stateMachine._003C_003E4__this = this;
		stateMachine.lockName = lockName;
		stateMachine.timeout = timeout;
		stateMachine.token = token;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IDisposable>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IDisposable> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CTryLockAsync_003Ed__28))]
	public Task<IDisposable> TryLockAsync(string lockName, CancellationToken token = default(CancellationToken))
	{
		_003CTryLockAsync_003Ed__28 stateMachine = default(_003CTryLockAsync_003Ed__28);
		stateMachine._003C_003E4__this = this;
		stateMachine.lockName = lockName;
		stateMachine.token = token;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IDisposable>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IDisposable> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CTryLockAsync_003Ed__29))]
	public Task<IDisposable> TryLockAsync(string lockName, int timeout, CancellationToken token = default(CancellationToken))
	{
		_003CTryLockAsync_003Ed__29 stateMachine = default(_003CTryLockAsync_003Ed__29);
		stateMachine._003C_003E4__this = this;
		stateMachine.lockName = lockName;
		stateMachine.timeout = timeout;
		stateMachine.token = token;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IDisposable>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IDisposable> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public LockManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JeDlSGhQRI8nqHDr2a6S();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool SfmnQPhQ8fLKRLT2am31()
	{
		return SJRSsNhQvnYCEoOyYiuX == null;
	}

	internal static LockManager XFa4I5hQZMetWsqnr90o()
	{
		return SJRSsNhQvnYCEoOyYiuX;
	}

	internal static TimeSpan INBbUXhQuIAlgBjgEWom(double P_0)
	{
		return TimeSpan.FromSeconds(P_0);
	}

	internal static object X1ytPShQISAc0cB2C7nA(object P_0, object P_1)
	{
		return ((ILockService)P_0).AcquireLock((string)P_1);
	}

	internal static void wi2eshhQVyxlaZawteJO(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object ncwbh9hQS1IXoNBOV1XN(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void z4xltBhQiXCVgw6LLAiS(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static void JeDlSGhQRI8nqHDr2a6S()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
