using System;
using System.Runtime.Caching;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Locking;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Cache;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

public abstract class NHCacheBase : CacheBase
{
	public class LockInfo
	{
		internal static LockInfo DwsvGGQJoEhykYSt5kfv;

		public TimeSpan? Ttl { get; set; }

		public TimeSpan? Timeout { get; set; }

		public string Key
		{
			[CompilerGenerated]
			get
			{
				return _003CKey_003Ek__BackingField;
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
						_003CKey_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public LockInfo()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool n39Ia5QJb4ROSagMW5PG()
		{
			return DwsvGGQJoEhykYSt5kfv == null;
		}

		internal static LockInfo PEckbYQJhi50e3EKRSgk()
		{
			return DwsvGGQJoEhykYSt5kfv;
		}
	}

	private ILockService lockService;

	private readonly MemoryCache locks;

	private static NHCacheBase Cd45adWpiHd5arcgOfuP;

	protected ILockService LockService
	{
		get
		{
			int num = 1;
			int num2 = num;
			ILockService lockService = default(ILockService);
			ILockService obj;
			while (true)
			{
				switch (num2)
				{
				default:
					lockService = (this.lockService = Locator.GetService<ILockService>());
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					obj = this.lockService;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = lockService;
					break;
				}
				break;
			}
			return obj;
		}
	}

	protected virtual LockInfo GetLockInfo(object key)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				MEJnUcWpXqfdKUWBYkUe(key, BZpZBKWpK0lTfZQWYHoa(-1858887263 ^ -1858939391));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				LockInfo lockInfo = new LockInfo();
				cZKEXFWpT4IKAbweprji(lockInfo, key.ToString());
				return lockInfo;
			}
			}
		}
	}

	public override object Lock(object key)
	{
		int num = 3;
		int num2 = num;
		LockInfo lockInfo = default(LockInfo);
		ILock @lock = default(ILock);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return lockInfo;
			case 2:
				@lock = LockService.AcquireLock(lockInfo.Key, lockInfo.Ttl, lockInfo.Timeout);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				lockInfo = GetLockInfo(key);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 2;
				}
				break;
			default:
				gVWPWTWpnSeBLxvrlfPC(locks, tnujM9Wpk7yBV398w1CV(lockInfo), @lock);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override void Unlock(object key, object lockValue)
	{
		int num = 4;
		ILock @lock = default(ILock);
		LockInfo lockInfo = default(LockInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					return;
				case 4:
					break;
				case 0:
					return;
				case 2:
					if (@lock != null)
					{
						@lock.Dispose();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num2 = 0;
						}
					}
					continue;
				case 3:
					@lock = lJC6HXWpO0FhBYcDb0Yy(locks, tnujM9Wpk7yBV398w1CV(lockInfo), null) as ILock;
					num2 = 2;
					continue;
				}
				break;
			}
			lockInfo = lockValue as LockInfo;
			num = 3;
		}
	}

	public virtual void Unlock(object key)
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
				Unlock(key, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected virtual void Unlock(object key, Action<LockInfo> lockNotFound)
	{
		LockInfo lockInfo = GetLockInfo(key);
		if (!(locks.Remove(lockInfo.Key) is ILock @lock))
		{
			lockNotFound?.Invoke(lockInfo);
		}
		else
		{
			@lock.Dispose();
		}
	}

	protected NHCacheBase()
	{
		//Discarded unreachable code: IL_0051, IL_0056
		BV4lAxWp2UvaUs5OyF64();
		locks = new MemoryCache((string)BZpZBKWpK0lTfZQWYHoa(-234299632 ^ -234174542));
		((CacheBase)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool jHW8pWWpR9CopjNIkhlA()
	{
		return Cd45adWpiHd5arcgOfuP == null;
	}

	internal static NHCacheBase vd1fiaWpqn1r8O1dy1Ys()
	{
		return Cd45adWpiHd5arcgOfuP;
	}

	internal static object BZpZBKWpK0lTfZQWYHoa(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void MEJnUcWpXqfdKUWBYkUe(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void cZKEXFWpT4IKAbweprji(object P_0, object P_1)
	{
		((LockInfo)P_0).Key = (string)P_1;
	}

	internal static object tnujM9Wpk7yBV398w1CV(object P_0)
	{
		return ((LockInfo)P_0).Key;
	}

	internal static void gVWPWTWpnSeBLxvrlfPC(object P_0, object P_1, object P_2)
	{
		((ObjectCache)P_0)[(string)P_1] = P_2;
	}

	internal static object lJC6HXWpO0FhBYcDb0Yy(object P_0, object P_1, object P_2)
	{
		return ((ObjectCache)P_0).Remove((string)P_1, (string)P_2);
	}

	internal static void BV4lAxWp2UvaUs5OyF64()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
