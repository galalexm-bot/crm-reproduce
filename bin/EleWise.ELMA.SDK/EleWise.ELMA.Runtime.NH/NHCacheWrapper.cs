using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.NHCacheWrapper;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Cache;
using NHibernate.Cache.Entry;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

public class NHCacheWrapper : CacheBase
{
	private static readonly ILogger logger;

	private static readonly ILogger OrgItemLog;

	private int disableCount;

	private readonly CacheBase cache;

	private readonly bool needDiagnostics;

	private static IServerPlacementPublishService serverPlacementPublishService;

	internal static NHCacheWrapper rUGIXnWaONKiSUfMXija;

	public override string RegionName => (string)TRtOleWaacjeHBr4q500(cache);

	public override int Timeout => yUR1aOWamwJii09Tq0j4(cache);

	private string GetCacheItem(object cachedValue)
	{
		//Discarded unreachable code: IL_011b
		int num = 7;
		int num2 = num;
		CachedItem val2 = default(CachedItem);
		CacheEntry val = default(CacheEntry);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (cachedValue == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return (string)JxtJjXWa19n1d705ZwyV(xLCCJNWaPD3orWppXOiO(0x638095EB ^ 0x63828FC3), cachedValue.GetType(), cachedValue);
			case 7:
				val2 = (CachedItem)((cachedValue is CachedItem) ? cachedValue : null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				if (val2 != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 4;
			case 5:
				if (val == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 3;
					}
					break;
				}
				if (val.get_DisassembledState() != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)xLCCJNWaPD3orWppXOiO(0x7C1EE318 ^ 0x7C1CF94E);
			case 1:
				return (string)xLCCJNWaPD3orWppXOiO(-1317790512 ^ -1317794762);
			case 2:
			{
				object obj = FukoLiWaNdq5Vw2qj7b9(val2);
				val = (CacheEntry)((obj is CacheEntry) ? obj : null);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 5;
				}
				break;
			}
			case 3:
				return string.Format((string)xLCCJNWaPD3orWppXOiO(0x638095EB ^ 0x63828FD5), (val2.get_Value() != null) ? JxtJjXWa19n1d705ZwyV(xLCCJNWaPD3orWppXOiO(-1459557599 ^ -1459425015), FukoLiWaNdq5Vw2qj7b9(val2).GetType(), val2.get_Value()) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17ADDC3E));
			default:
				return string.Join((string)xLCCJNWaPD3orWppXOiO(0x4D1C1EE4 ^ 0x4D1C0140), val.get_DisassembledState().Select((object o, int i) => (string)_003C_003Ec.m1nceoQJ0PpeIxGhwMTs(_003C_003Ec.vr1LPQQJxkvwDG9ijuik(-672123589 ^ -672120703), i, o)));
			}
		}
	}

	public NHCacheWrapper(CacheBase cache)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YVwhQaWa3fMmAgwUjwBX();
		((CacheBase)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				if (cache == null)
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num = 2;
					}
				}
				else
				{
					this.cache = cache;
					num = 3;
				}
				break;
			case 3:
				needDiagnostics = !(cache is IHandleDiagnostics);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 2:
				throw new ArgumentNullException((string)xLCCJNWaPD3orWppXOiO(-1633514411 ^ -1633642815));
			}
		}
	}

	public override void Clear()
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
				DiagnosticsManager.StartCall(delegate
				{
					//Discarded unreachable code: IL_0057, IL_0066
					int num5 = 2;
					int num6 = num5;
					while (true)
					{
						switch (num6)
						{
						default:
							return null;
						case 1:
						{
							CacheWriteInfo cacheWriteInfo = new CacheWriteInfo();
							tOKHPuWaJd6L27P48xCG(cacheWriteInfo, TRtOleWaacjeHBr4q500(this));
							pcgXT2Wa9QOpoBuEYmwP(cacheWriteInfo, xLCCJNWaPD3orWppXOiO(0x57A5235E ^ 0x57A73D54));
							return cacheWriteInfo;
						}
						case 2:
							if (needDiagnostics)
							{
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
								{
									num6 = 1;
								}
								break;
							}
							goto default;
						}
					}
				}, delegate
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							cache.Clear();
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void Destroy()
	{
	}

	public override object Get(object key)
	{
		//Discarded unreachable code: IL_0124, IL_0133, IL_0143, IL_0152, IL_01ce, IL_01dd, IL_0236, IL_0245, IL_0254, IL_0301, IL_0310, IL_0373, IL_0382, IL_045f, IL_0497, IL_04a6
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		CacheReadInfo cacheReadInfo = default(CacheReadInfo);
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		object result = default(object);
		while (true)
		{
			switch (num2)
			{
			case 4:
				cacheReadInfo = DiagnosticsManager.StartCall(_003C_003Ec__DisplayClass6_._003CGet_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				_003C_003Ec__DisplayClass6_.key = key;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 4;
				}
				continue;
			case 1:
				_003C_003Ec__DisplayClass6_._003C_003E4__this = this;
				num2 = 3;
				continue;
			case 2:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 1;
				}
				continue;
			case 5:
				return result;
			}
			try
			{
				object obj = lMUEv0WapIAViYEgcSTb(cache, _003C_003Ec__DisplayClass6_.key);
				int num3 = 11;
				while (true)
				{
					int num4;
					switch (num3)
					{
					case 5:
					case 22:
						if (!(_003C_003Ec__DisplayClass6_.key is CacheKey))
						{
							num3 = 17;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
							{
								num3 = 3;
							}
							break;
						}
						goto case 7;
					case 13:
					case 15:
						if (!OrgItemLog.IsEnabled(LogLevel.Debug))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
							{
								num3 = 0;
							}
							break;
						}
						goto case 14;
					case 11:
						if (IsDisabled(obj))
						{
							num3 = 9;
							break;
						}
						goto case 8;
					case 9:
						logger.DebugFormat((string)xLCCJNWaPD3orWppXOiO(-957824448 ^ -957687582), ((CacheBase)this).get_RegionName());
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
						{
							num3 = 10;
						}
						break;
					case 7:
						if (MTd7ALWaDRLljt0F5ZAx(CHauGdWatiuokvvUZHVX((object)(CacheKey)_003C_003Ec__DisplayClass6_.key), xLCCJNWaPD3orWppXOiO(-1939377524 ^ -1939510822)))
						{
							num3 = 4;
							break;
						}
						goto default;
					case 6:
						logger.DebugFormat((string)xLCCJNWaPD3orWppXOiO(0x49E27B8A ^ 0x49E06160), TRtOleWaacjeHBr4q500(this));
						num4 = 21;
						goto IL_00b5;
					case 14:
						if (!(_003C_003Ec__DisplayClass6_.key is string))
						{
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
							{
								num3 = 0;
							}
							break;
						}
						goto case 18;
					case 4:
					case 20:
						XdWaFaWawAFFu3woS0SH(OrgItemLog, JxtJjXWa19n1d705ZwyV(xLCCJNWaPD3orWppXOiO(0x8317432 ^ 0x8336F86), _003C_003Ec__DisplayClass6_.key, GetCacheItem(obj)));
						num3 = 19;
						break;
					case 16:
						if (obj != null)
						{
							num4 = 6;
							goto IL_00b5;
						}
						goto case 1;
					case 18:
						if (MTd7ALWaDRLljt0F5ZAx((string)_003C_003Ec__DisplayClass6_.key, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2139092790)))
						{
							num3 = 20;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
							{
								num3 = 8;
							}
							break;
						}
						goto case 5;
					case 10:
						obj = null;
						num3 = 12;
						break;
					case 8:
						if (disableCount <= 0)
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
							{
								num3 = 1;
							}
							break;
						}
						goto case 16;
					case 3:
						cacheReadInfo.Success = obj != null;
						num3 = 15;
						break;
					default:
						result = obj;
						num3 = 2;
						break;
					case 1:
					case 12:
					case 21:
						if (cacheReadInfo == null)
						{
							num4 = 13;
							goto IL_00b5;
						}
						goto case 3;
					case 2:
						{
							return result;
						}
						IL_00b5:
						num3 = num4;
						break;
					}
				}
			}
			finally
			{
				if (cacheReadInfo != null)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							zdpqyRWa4MDDbEINswAx(cacheReadInfo);
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
							{
								num5 = 1;
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
	}

	public override object Lock(object key)
	{
		//Discarded unreachable code: IL_0061, IL_0070, IL_00c4, IL_00fc, IL_011b, IL_012a, IL_0157, IL_0252
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		CacheLockInfo cacheLockInfo = default(CacheLockInfo);
		object result = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 14:
					if (disableCount <= 0)
					{
						num = 13;
						break;
					}
					goto case 15;
				case 5:
					try
					{
						result = H4NftQWaAk9TegcWOE1l(cache, _003C_003Ec__DisplayClass7_.key);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
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
						if (cacheLockInfo == null)
						{
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
							{
								num4 = 1;
							}
							goto IL_0100;
						}
						goto IL_0135;
						IL_0135:
						((IDisposable)cacheLockInfo).Dispose();
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num4 = 0;
						}
						goto IL_0100;
						IL_0100:
						switch (num4)
						{
						default:
							goto end_IL_00db;
						case 1:
							goto end_IL_00db;
						case 2:
							break;
						case 0:
							goto end_IL_00db;
						}
						goto IL_0135;
						end_IL_00db:;
					}
				case 8:
				case 11:
					if (_003C_003Ec__DisplayClass7_.key is CacheKey)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 14;
				case 1:
					_003C_003Ec__DisplayClass7_._003C_003E4__this = this;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
				case 13:
					cacheLockInfo = DiagnosticsManager.StartCall(_003C_003Ec__DisplayClass7_._003CLock_003Eb__0);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 5;
					}
					continue;
				case 15:
					logger.DebugFormat((string)xLCCJNWaPD3orWppXOiO(0x63ABA4E8 ^ 0x63A9BF0A), TRtOleWaacjeHBr4q500(this));
					num = 9;
					break;
				case 4:
					XdWaFaWawAFFu3woS0SH(OrgItemLog, W2c4UfWaHW7548EPHbPN(xLCCJNWaPD3orWppXOiO(-218496594 ^ -218621344), _003C_003Ec__DisplayClass7_.key));
					num2 = 14;
					continue;
				default:
					_003C_003Ec__DisplayClass7_.key = key;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 7;
					}
					continue;
				case 6:
					if (!((string)_003C_003Ec__DisplayClass7_.key == (string)xLCCJNWaPD3orWppXOiO(0x3B36AB09 ^ 0x3B34B03B)))
					{
						num2 = 11;
						continue;
					}
					goto case 4;
				case 2:
					_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					if (((CacheKey)_003C_003Ec__DisplayClass7_.key).get_EntityOrRoleName() == (string)xLCCJNWaPD3orWppXOiO(--1333735954 ^ 0x4F7D2944))
					{
						num2 = 4;
						continue;
					}
					goto case 14;
				case 7:
					if (yuNeO9Wa6NkbOq6d4lfN(OrgItemLog, LogLevel.Debug))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 14;
				case 12:
					return result;
				case 10:
					if (!(_003C_003Ec__DisplayClass7_.key is string))
					{
						num2 = 8;
						continue;
					}
					goto case 6;
				}
				break;
			}
		}
	}

	public override long NextTimestamp()
	{
		return Di5936Wa7HKOxRLo0hDV(cache);
	}

	public override void Put(object key, object value)
	{
		//Discarded unreachable code: IL_0137, IL_0209, IL_0218, IL_02bc, IL_033b
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		int num = 7;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 14:
					OrgItemLog.Debug(yIG8KLWa0ft6loXOW2LH(xLCCJNWaPD3orWppXOiO(0x1C9495B4 ^ 0x1C968926), _003C_003Ec__DisplayClass9_.key, GetCacheItem(_003C_003Ec__DisplayClass9_.value), NEQNEfWaxHTn5NigC11C()));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					return;
				case 3:
					if (disableCount > 0)
					{
						num2 = 8;
						continue;
					}
					goto case 16;
				case 6:
					_003C_003Ec__DisplayClass9_._003C_003E4__this = this;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 11;
					}
					continue;
				case 18:
					if (!((string)_003C_003Ec__DisplayClass9_.key == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281970806)))
					{
						num2 = 19;
						continue;
					}
					goto case 14;
				default:
					_003C_003Ec__DisplayClass9_.value = value;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 17;
					}
					continue;
				case 17:
					if (!IsDisabled(_003C_003Ec__DisplayClass9_.value))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 20;
				case 15:
					((CacheBase)this).Remove(_003C_003Ec__DisplayClass9_.key);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					logger.DebugFormat((string)xLCCJNWaPD3orWppXOiO(-16752921 ^ -16629079), TRtOleWaacjeHBr4q500(this));
					num2 = 16;
					continue;
				case 16:
					if (!yuNeO9Wa6NkbOq6d4lfN(OrgItemLog, LogLevel.Debug))
					{
						num2 = 12;
						continue;
					}
					goto case 9;
				case 11:
					_003C_003Ec__DisplayClass9_.key = key;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (!MTd7ALWaDRLljt0F5ZAx(CHauGdWatiuokvvUZHVX((object)(CacheKey)_003C_003Ec__DisplayClass9_.key), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852970670)))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 14;
				case 4:
				case 10:
				case 12:
					break;
				case 2:
				case 19:
					if (_003C_003Ec__DisplayClass9_.key is CacheKey)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
						{
							num2 = 5;
						}
						continue;
					}
					break;
				case 13:
					return;
				case 7:
					_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
					num2 = 6;
					continue;
				case 20:
					logger.DebugFormat((string)xLCCJNWaPD3orWppXOiO(0x7EC153F ^ 0x7EE0935), ((CacheBase)this).get_RegionName());
					num2 = 15;
					continue;
				case 9:
					if (!(_003C_003Ec__DisplayClass9_.key is string))
					{
						num2 = 2;
						continue;
					}
					goto case 18;
				}
				break;
			}
			DiagnosticsManager.StartCall(_003C_003Ec__DisplayClass9_._003CPut_003Eb__0, _003C_003Ec__DisplayClass9_._003CPut_003Eb__1);
			num = 13;
		}
	}

	public override void Remove(object key)
	{
		//Discarded unreachable code: IL_00c9, IL_00d8, IL_0147, IL_0156, IL_0167, IL_0176
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		int num = 9;
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					_003C_003Ec__DisplayClass12_.key = key;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 3;
					}
					break;
				case 5:
					if (MTd7ALWaDRLljt0F5ZAx((string)_003C_003Ec__DisplayClass12_.key, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571CB8AB)))
					{
						num2 = 12;
						break;
					}
					goto case 11;
				case 3:
					if (yuNeO9Wa6NkbOq6d4lfN(OrgItemLog, LogLevel.Debug))
					{
						goto end_IL_0012;
					}
					goto default;
				case 1:
					if (!MTd7ALWaDRLljt0F5ZAx(CHauGdWatiuokvvUZHVX((object)(CacheKey)_003C_003Ec__DisplayClass12_.key), xLCCJNWaPD3orWppXOiO(-488881205 ^ -488744803)))
					{
						num2 = 2;
						break;
					}
					goto case 6;
				default:
					DiagnosticsManager.StartCall(_003C_003Ec__DisplayClass12_._003CRemove_003Eb__0, _003C_003Ec__DisplayClass12_._003CRemove_003Eb__1);
					num2 = 7;
					break;
				case 7:
					return;
				case 9:
					_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 5;
					}
					break;
				case 13:
					if (_003C_003Ec__DisplayClass12_.key is string)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 11;
				case 8:
					_003C_003Ec__DisplayClass12_._003C_003E4__this = this;
					num2 = 4;
					break;
				case 6:
				case 12:
					OrgItemLog.DebugFormat((string)W2c4UfWaHW7548EPHbPN(xLCCJNWaPD3orWppXOiO(0x1637C429 ^ 0x1635D89D), _003C_003Ec__DisplayClass12_.key));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					break;
				case 11:
					if (!(_003C_003Ec__DisplayClass12_.key is CacheKey))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 10;
						}
						break;
					}
					goto case 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 13;
		}
	}

	public override void Unlock(object key, object lockValue)
	{
		//Discarded unreachable code: IL_00e1, IL_00f0, IL_01cb
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		int num = 8;
		int num2 = num;
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		while (true)
		{
			switch (num2)
			{
			case 13:
				if (MTd7ALWaDRLljt0F5ZAx((string)_003C_003Ec__DisplayClass15_.key, xLCCJNWaPD3orWppXOiO(-1998538950 ^ -1998410744)))
				{
					num2 = 10;
					break;
				}
				goto case 3;
			case 2:
				logger.DebugFormat((string)xLCCJNWaPD3orWppXOiO(-629844702 ^ -629716538), TRtOleWaacjeHBr4q500(this));
				num2 = 5;
				break;
			case 15:
				if (disableCount <= 0)
				{
					num2 = 4;
					break;
				}
				goto case 2;
			case 12:
				_003C_003Ec__DisplayClass15_.key = key;
				num2 = 9;
				break;
			case 1:
				return;
			default:
				OrgItemLog.Debug(string.Format((string)xLCCJNWaPD3orWppXOiO(-210725949 ^ -210596081), _003C_003Ec__DisplayClass15_.key));
				num2 = 15;
				break;
			case 6:
				if (yuNeO9Wa6NkbOq6d4lfN(OrgItemLog, LogLevel.Debug))
				{
					num2 = 14;
					break;
				}
				goto case 15;
			case 4:
			case 5:
				DiagnosticsManager.StartCall(_003C_003Ec__DisplayClass15_._003CUnlock_003Eb__0, _003C_003Ec__DisplayClass15_._003CUnlock_003Eb__1);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				_003C_003Ec__DisplayClass15_.lockValue = lockValue;
				num2 = 6;
				break;
			case 7:
				_003C_003Ec__DisplayClass15_._003C_003E4__this = this;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 12;
				}
				break;
			case 11:
				if ((string)CHauGdWatiuokvvUZHVX((object)(CacheKey)_003C_003Ec__DisplayClass15_.key) == (string)xLCCJNWaPD3orWppXOiO(0x3C5338FF ^ 0x3C5123A9))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 15;
			case 14:
				if (_003C_003Ec__DisplayClass15_.key is string)
				{
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			case 3:
				if (_003C_003Ec__DisplayClass15_.key is CacheKey)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 15;
			case 8:
				_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
				num2 = 7;
				break;
			}
		}
	}

	internal static Task DisableCache(IList<string> regions)
	{
		_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_0();
		CS_0024_003C_003E8__locals0.regions = regions;
		if (CS_0024_003C_003E8__locals0.regions.Count != 0)
		{
			return serverPlacementPublishService.For<INHCacheWrapperSynchronizer>().Publish((INHCacheWrapperSynchronizer a) => a.DisableCache(CS_0024_003C_003E8__locals0.regions));
		}
		return Task.CompletedTask;
	}

	internal static Task EnableCache(IList<string> regions)
	{
		_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_0();
		CS_0024_003C_003E8__locals0.regions = regions;
		if (CS_0024_003C_003E8__locals0.regions.Count != 0)
		{
			return serverPlacementPublishService.For<INHCacheWrapperSynchronizer>().Publish((INHCacheWrapperSynchronizer a) => a.EnableCache(CS_0024_003C_003E8__locals0.regions));
		}
		return Task.CompletedTask;
	}

	private string GetCacheKey(object identifier)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return string.Empty;
			case 1:
				if (identifier != null)
				{
					return identifier.ToString();
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private bool IsDisabled(object value)
	{
		//Discarded unreachable code: IL_006a, IL_0079, IL_0089, IL_0098
		int num = 4;
		int num2 = num;
		ILockable val = default(ILockable);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return !FhwkBoWayivketCKB2Xb(val);
			case 2:
				return true;
			case 3:
				return false;
			case 4:
				if (disableCount <= 0)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				if ((val = (ILockable)((value is ILockable) ? value : null)) == null)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			}
		}
	}

	internal void Disable()
	{
		//Discarded unreachable code: IL_003d
		int num = 6;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				logger.InfoFormat((string)xLCCJNWaPD3orWppXOiO(0x53CB464B ^ 0x53C95B5B), TRtOleWaacjeHBr4q500(this));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				if (num3 != 0)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 2;
			case 6:
				num3 = disableCount++;
				num2 = 5;
				break;
			case 2:
				((CacheBase)this).Clear();
				num2 = 4;
				break;
			case 1:
				return;
			case 3:
				logger.DebugFormat((string)xLCCJNWaPD3orWppXOiO(-1317790512 ^ -1317666402), TRtOleWaacjeHBr4q500(this), disableCount);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal void Enable()
	{
		//Discarded unreachable code: IL_00ad, IL_00bc
		int num = 4;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return;
				case 1:
					return;
				case 2:
					logger.DebugFormat((string)xLCCJNWaPD3orWppXOiO(-951514650 ^ -951380954), TRtOleWaacjeHBr4q500(this), disableCount);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 5;
					}
					continue;
				case 3:
					if (num3 != 0)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				case 4:
					goto end_IL_0012;
				}
				logger.InfoFormat((string)xLCCJNWaPD3orWppXOiO(-398663332 ^ -398525244), TRtOleWaacjeHBr4q500(this));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num3 = --disableCount;
			num = 3;
		}
	}

	static NHCacheWrapper()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				OrgItemLog = Logger.GetLogger((string)xLCCJNWaPD3orWppXOiO(0x48A7E34A ^ 0x48A5F110));
				num2 = 3;
				break;
			case 1:
				logger = (ILogger)b7AlHtWaMiOCT6bQXE0u(typeof(NHCacheWrapper));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				serverPlacementPublishService = Locator.GetServiceNotNull<IServerPlacementPublishService>();
				num2 = 4;
				break;
			}
		}
	}

	internal static object xLCCJNWaPD3orWppXOiO(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object JxtJjXWa19n1d705ZwyV(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object FukoLiWaNdq5Vw2qj7b9(object P_0)
	{
		return ((CachedItem)P_0).get_Value();
	}

	internal static bool uND9Q1Wa28HnELKjQddK()
	{
		return rUGIXnWaONKiSUfMXija == null;
	}

	internal static NHCacheWrapper hDRFl4WaekUT9US6JL99()
	{
		return rUGIXnWaONKiSUfMXija;
	}

	internal static void YVwhQaWa3fMmAgwUjwBX()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object lMUEv0WapIAViYEgcSTb(object P_0, object P_1)
	{
		return ((CacheBase)P_0).Get(P_1);
	}

	internal static object TRtOleWaacjeHBr4q500(object P_0)
	{
		return ((CacheBase)P_0).get_RegionName();
	}

	internal static bool MTd7ALWaDRLljt0F5ZAx(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object CHauGdWatiuokvvUZHVX(object P_0)
	{
		return ((CacheKey)P_0).get_EntityOrRoleName();
	}

	internal static void XdWaFaWawAFFu3woS0SH(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static void zdpqyRWa4MDDbEINswAx(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool yuNeO9Wa6NkbOq6d4lfN(object P_0, LogLevel level)
	{
		return ((ILogger)P_0).IsEnabled(level);
	}

	internal static object W2c4UfWaHW7548EPHbPN(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object H4NftQWaAk9TegcWOE1l(object P_0, object P_1)
	{
		return ((CacheBase)P_0).Lock(P_1);
	}

	internal static long Di5936Wa7HKOxRLo0hDV(object P_0)
	{
		return ((CacheBase)P_0).NextTimestamp();
	}

	internal static object NEQNEfWaxHTn5NigC11C()
	{
		return Environment.StackTrace;
	}

	internal static object yIG8KLWa0ft6loXOW2LH(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static int yUR1aOWamwJii09Tq0j4(object P_0)
	{
		return ((CacheBase)P_0).get_Timeout();
	}

	internal static bool FhwkBoWayivketCKB2Xb(object P_0)
	{
		return ((ILockable)P_0).get_IsLock();
	}

	internal static object b7AlHtWaMiOCT6bQXE0u(Type componentType)
	{
		return Logger.GetLogger(componentType);
	}

	internal static void tOKHPuWaJd6L27P48xCG(object P_0, object P_1)
	{
		((CacheQueryInfo)P_0).Region = (string)P_1;
	}

	internal static void pcgXT2Wa9QOpoBuEYmwP(object P_0, object P_1)
	{
		((CacheQueryInfo)P_0).Operation = (string)P_1;
	}
}
