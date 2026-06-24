using System;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models.API;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Services.API;

internal sealed class SessionCache
{
	private class MultiKeyCache
	{
		private readonly object cacheService;

		private readonly object region;

		private readonly Func<object, string> Keygen;

		internal static object BId7cGpLYsUX0IIgiYoV;

		public MultiKeyCache(ICacheService cacheService, string region, Func<object, string> keygen)
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
			base._002Ector();
			this.cacheService = cacheService;
			this.region = region;
			Keygen = keygen;
		}

		public bool TryGetValue(object key, out long id)
		{
			return ((ICacheService)cacheService).TryGetValue(Keygen(key), (string)region, out id);
		}

		public bool ContainsKey(object key)
		{
			return UPNLAmpLVKsdnRYaFTrC(cacheService, Keygen(key), region);
		}

		public void Add(Guid authToken, string sessionToken, long val)
		{
			int num = 5;
			int num2 = num;
			_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
			while (true)
			{
				switch (num2)
				{
				case 2:
					CreateKeyRef(authToken, sessionToken);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					((ICacheService)cacheService).GetOrAdd(Keygen(authToken), _003C_003Ec__DisplayClass6_._003CAdd_003Eb__1, (string)region);
					num2 = 2;
					break;
				case 4:
					_003C_003Ec__DisplayClass6_.val = val;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					return;
				default:
					((ICacheService)cacheService).GetOrAdd(Keygen(authToken), _003C_003Ec__DisplayClass6_._003CAdd_003Eb__0, (string)region);
					num2 = 3;
					break;
				case 5:
					_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
					{
						num2 = 4;
					}
					break;
				}
			}
		}

		public void Remove(object key)
		{
			int num = 2;
			int num2 = num;
			object value = default(object);
			string text = default(string);
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 3:
					RemoveKeyRef(key, value);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a == 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					BIamrrpLQ5fWZSRguhRm(cacheService, text, region);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 != 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					BIamrrpLQ5fWZSRguhRm(cacheService, Keygen(value), region);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 == 0)
					{
						num2 = 3;
					}
					break;
				default:
					if (!((ICacheService)cacheService).TryGetValue(GenKeyRefKey(key), (string)region, out value))
					{
						return;
					}
					num2 = 5;
					break;
				case 2:
					text = Keygen(key);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		private void CreateKeyRef(object key1, object key2)
		{
			int num = 5;
			int num2 = num;
			_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
			while (true)
			{
				switch (num2)
				{
				default:
					_003C_003Ec__DisplayClass8_.key1 = key1;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed != 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					_003C_003Ec__DisplayClass8_.key2 = key2;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					((ICacheService)cacheService).GetOrAdd(GenKeyRefKey(_003C_003Ec__DisplayClass8_.key2), _003C_003Ec__DisplayClass8_._003CCreateKeyRef_003Eb__1, (string)region);
					num2 = 3;
					break;
				case 3:
					return;
				case 1:
					((ICacheService)cacheService).GetOrAdd(GenKeyRefKey(_003C_003Ec__DisplayClass8_.key1), _003C_003Ec__DisplayClass8_._003CCreateKeyRef_003Eb__0, (string)region);
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc == 0)
					{
						num2 = 2;
					}
					break;
				case 5:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a == 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		private void RemoveKeyRef(object key1, object key2)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					((ICacheService)cacheService).Remove(GenKeyRefKey(key2), (string)region);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					((ICacheService)cacheService).Remove(GenKeyRefKey(key1), (string)region);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				}
			}
		}

		private string GenKeyRefKey(object key1)
		{
			return (string)WKTNGBpLTWnbr7RTlHHU(sDjjKUpLdW0BgX9pRYCB(0xCDF201B ^ 0xCDF3423), new object[2]
			{
				key1,
				sDjjKUpLdW0BgX9pRYCB(0x3B1D6430 ^ 0x3B1C493E)
			});
		}

		internal static bool ORl9D7pLIZGZLnxJZEhn()
		{
			return BId7cGpLYsUX0IIgiYoV == null;
		}

		internal static MultiKeyCache iBlbQbpL4GNX0748B3CO()
		{
			return (MultiKeyCache)BId7cGpLYsUX0IIgiYoV;
		}

		internal static bool UPNLAmpLVKsdnRYaFTrC(object P_0, object P_1, object P_2)
		{
			return ((ICacheService)P_0).Contains((string)P_1, (string)P_2);
		}

		internal static void BIamrrpLQ5fWZSRguhRm(object P_0, object P_1, object P_2)
		{
			((ICacheService)P_0).Remove((string)P_1, (string)P_2);
		}

		internal static object sDjjKUpLdW0BgX9pRYCB(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object WKTNGBpLTWnbr7RTlHHU(object P_0, object P_1)
		{
			return string.Join((string)P_0, (object[])P_1);
		}
	}

	private readonly PublicClientSessionManager sessionManager;

	private readonly ICacheService cacheService;

	private readonly MultiKeyCache cachedData;

	internal static SessionCache ff2qK2JAvx6lxU9YHtL;

	public SessionCache(PublicClientSessionManager sessionManager, ICacheService cacheService)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		xlCn0kJn5RRBhTdty1J();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				cachedData = new MultiKeyCache(cacheService, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7CAA49C6 ^ 0x7CAA3A78), Keygen);
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			case 3:
				this.sessionManager = sessionManager;
				num = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b == 0)
				{
					num = 2;
				}
				break;
			case 2:
				this.cacheService = cacheService;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private static long SerializeSession(object session)
	{
		return ((IEntity<long>)session).Id;
	}

	private IPublicClientSession RecreateSession(long id)
	{
		return sessionManager.LoadOrNull(id);
	}

	public IPublicClientSession GetOrAdd(Guid authToken, [NotNull] Func<IPublicClientSession> valueFunc)
	{
		if (valueFunc == null)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1429357207 ^ -1429352803));
		}
		if (!cachedData.TryGetValue(authToken, out var id))
		{
			IPublicClientSession publicClientSession = valueFunc();
			if (publicClientSession != null)
			{
				Add(publicClientSession);
			}
			return publicClientSession;
		}
		return RecreateSession(id);
	}

	public IPublicClientSession GetOrAdd(string sessionToken, Func<IPublicClientSession> valueFunc)
	{
		if (valueFunc == null)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-816887841 ^ -816892885));
		}
		if (!cachedData.TryGetValue(sessionToken, out var id))
		{
			IPublicClientSession publicClientSession = valueFunc();
			if (publicClientSession != null)
			{
				Add(publicClientSession);
			}
			return publicClientSession;
		}
		return RecreateSession(id);
	}

	public bool Remove(string sessionToken)
	{
		//Discarded unreachable code: IL_0076, IL_0085
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 2:
				HLV9VuJi1GdA8WeSO94(cachedData, sessionToken);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (cachedData.ContainsKey(sessionToken))
				{
					num2 = 2;
					break;
				}
				goto default;
			case 1:
				return true;
			}
		}
	}

	public bool Remove(Guid authToken)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return true;
			case 2:
				if (!z3UP3cJ7pqim70yVOp6(cachedData, authToken))
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e != 0)
					{
						num2 = 0;
					}
					break;
				}
				HLV9VuJi1GdA8WeSO94(cachedData, authToken);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return false;
			}
		}
	}

	public void Add([NotNull] IPublicClientSession session)
	{
		//Discarded unreachable code: IL_005d, IL_006c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 3:
				RASYnCJxtX5sB0s0rru(cachedData, OG7eSqJlavNGGVZqWJH(session), QbB9ZNJNXmjLNJML6lw(session), oO9RNGJZPuQDk1DyWMi(session));
				num2 = 4;
				break;
			case 2:
				if (session != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				throw new ArgumentNullException((string)QV1NRqJ6ejEKxxeDB5t(0x22A54A05 ^ 0x22A52C73));
			case 1:
				Remove(OG7eSqJlavNGGVZqWJH(session));
				num2 = 3;
				break;
			}
		}
	}

	public bool TryGet(Guid authToken, out IPublicClientSession session)
	{
		//Discarded unreachable code: IL_007a
		int num = 2;
		int num2 = num;
		long id = default(long);
		while (true)
		{
			switch (num2)
			{
			case 4:
				session = RecreateSession(id);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_488725796a2e487f95c022f5056d8a88 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return false;
			default:
				return true;
			case 1:
				session = null;
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				if (!cachedData.TryGetValue(authToken, out id))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public bool TryGet(string sessionToken, out IPublicClientSession session)
	{
		int num = 3;
		int num2 = num;
		long id = default(long);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (cachedData.TryGetValue(sessionToken, out id))
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d != 0)
					{
						num2 = 1;
					}
					break;
				}
				session = null;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				session = RecreateSession(id);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return true;
			case 1:
				return false;
			}
		}
	}

	private string Keygen(object key)
	{
		return (string)IFk8sEJBOnQfPebpQV8(QV1NRqJ6ejEKxxeDB5t(-2119527672 ^ -2119530704), new object[2]
		{
			QV1NRqJ6ejEKxxeDB5t(0xA4E904F ^ 0xA4EE445),
			key
		});
	}

	internal static void xlCn0kJn5RRBhTdty1J()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool SxfL2pJWnnkfQajrLCa()
	{
		return ff2qK2JAvx6lxU9YHtL == null;
	}

	internal static SessionCache AZiRHDJXxIHMXo67awc()
	{
		return ff2qK2JAvx6lxU9YHtL;
	}

	internal static void HLV9VuJi1GdA8WeSO94(object P_0, object P_1)
	{
		((MultiKeyCache)P_0).Remove(P_1);
	}

	internal static bool z3UP3cJ7pqim70yVOp6(object P_0, object P_1)
	{
		return ((MultiKeyCache)P_0).ContainsKey(P_1);
	}

	internal static object QV1NRqJ6ejEKxxeDB5t(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Guid OG7eSqJlavNGGVZqWJH(object P_0)
	{
		return ((IPublicClientSession)P_0).AuthToken;
	}

	internal static object QbB9ZNJNXmjLNJML6lw(object P_0)
	{
		return ((IPublicClientSession)P_0).SessionToken;
	}

	internal static long oO9RNGJZPuQDk1DyWMi(object P_0)
	{
		return SerializeSession(P_0);
	}

	internal static void RASYnCJxtX5sB0s0rru(object P_0, Guid authToken, object P_2, long val)
	{
		((MultiKeyCache)P_0).Add(authToken, (string)P_2, val);
	}

	internal static object IFk8sEJBOnQfPebpQV8(object P_0, object P_1)
	{
		return string.Join((string)P_0, (object[])P_1);
	}
}
