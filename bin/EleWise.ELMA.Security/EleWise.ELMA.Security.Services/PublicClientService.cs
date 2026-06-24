using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using EleWise.ELMA.API;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security.Cryptography;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Models.API;
using EleWise.ELMA.Services;
using EleWise.ELMA.Text;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Services.API;

[Service(Type = ComponentType.Server, InjectProperties = false, EnableInterceptors = false)]
internal sealed class PublicClientService : IPublicClientService
{
	[Component(Type = ComponentType.WebServer, EnableInterceptiors = false)]
	private class PublicClientSessionSweepHandler : ISweepHandler, IThreadPoolContainer
	{
		private readonly object _sweepPool;

		private static object U70FwVpLjBIJNlspMDkN;

		IThreadPool IThreadPoolContainer.Pool => (IThreadPool)_sweepPool;

		public PublicClientSessionSweepHandler()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			JLWLQgpLRQbsITsAL16F();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 != 0)
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
					_sweepPool = new ThreadSubPool(1);
					num = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 != 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		void ISweepHandler.Execute()
		{
			Locator.GetServiceNotNull<PublicClientService>().FlushUpdatedSessions();
		}

		internal static void JLWLQgpLRQbsITsAL16F()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}

		internal static bool CE234mpLHGalJLGfo1ge()
		{
			return U70FwVpLjBIJNlspMDkN == null;
		}

		internal static PublicClientSessionSweepHandler NAw0empLa8wleRhaj3Fq()
		{
			return (PublicClientSessionSweepHandler)U70FwVpLjBIJNlspMDkN;
		}
	}

	internal const int TokenLength = 128;

	private readonly PublicClientSessionManager clientSessionManager;

	private readonly IEntityManager<EleWise.ELMA.Security.Models.API.IPublicApplication, long> applicationManager;

	private readonly PublicApplicationTokenManager applicationTokenManager;

	private readonly IPublicApplicationService applicationService;

	private readonly ILockManager lockManager;

	private readonly IPublicSignatureService publicSignatureService;

	private readonly SessionCache cache;

	private ConcurrentDictionary<long, bool> promotedSessions;

	private ReaderWriterLock _updateSessionsLock;

	private DateTime? _lastUpdateTime;

	internal static PublicClientService hbgJSOom7fSHK4sjeQo;

	public IEnumerable<EleWise.ELMA.API.Models.IPublicClientSession> Sessions => clientSessionManager.FindAll();

	public PublicClientService(IPublicApplicationService applicationService, PublicClientSessionManager clientSessionManager, IEntityManager<EleWise.ELMA.Security.Models.API.IPublicApplication, long> applicationManager, PublicApplicationTokenManager applicationTokenManager, ILockManager lockManager, IPublicSignatureService publicSignatureService, ICacheService cacheService)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		promotedSessions = new ConcurrentDictionary<long, bool>();
		_updateSessionsLock = new ReaderWriterLock();
		base._002Ector();
		this.clientSessionManager = clientSessionManager;
		this.applicationService = applicationService;
		this.applicationManager = applicationManager;
		this.applicationTokenManager = applicationTokenManager;
		this.lockManager = lockManager;
		this.publicSignatureService = publicSignatureService;
		cache = new SessionCache(clientSessionManager, cacheService);
	}

	private EleWise.ELMA.Security.Models.API.IPublicClientSession GetSessionInternal(string sessionToken)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass9_._003C_003E4__this = this;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a == 0)
				{
					num2 = 2;
				}
				break;
			default:
				return cache.GetOrAdd(_003C_003Ec__DisplayClass9_.sessionToken, _003C_003Ec__DisplayClass9_._003CGetSessionInternal_003Eb__0);
			case 1:
				_003C_003Ec__DisplayClass9_.sessionToken = sessionToken;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private EleWise.ELMA.Security.Models.API.IPublicClientSession GetSessionInternal(Guid authToken)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass10_.authToken = authToken;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass10_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
				num2 = 2;
				break;
			case 1:
				return cache.GetOrAdd(_003C_003Ec__DisplayClass10_.authToken, _003C_003Ec__DisplayClass10_._003CGetSessionInternal_003Eb__0);
			}
		}
	}

	internal static string GenerateSessionToken(Guid authToken, string applicationToken)
	{
		return (string)kHveomoROfOnhOp09ZQ(CqK8UJoaehhT8AIcnMl(applicationToken, authToken.ToString((string)wnXDTMojcRhnVuaKt40(0x4177C82C ^ 0x4177F448)), GFCuenoHHfbi1GER4hY().Ticks));
	}

	internal static string Generate128ByteToken(string tokenKey)
	{
		//Discarded unreachable code: IL_006b, IL_00f7, IL_012f, IL_013e
		int num = 2;
		int num2 = num;
		SHA512 sHA = default(SHA512);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				sHA = (SHA512)P95jSbowYBcEk8ViysG();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				try
				{
					Encoding encoding = (Encoding)cjo50qo2D0lc5hRvcwo();
					int num3 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							result = (string)NRVlB5oUDBlVelHTAJw(r4lu2QoCsZvhVDxN3Nf(nFdYxHovWwEReHIVAmT(sHA, pSIcXloPrdJ39O66Q9l(encoding, tokenKey))), wnXDTMojcRhnVuaKt40(0x23D92C6F ^ 0x23D925F7), "");
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 == 0)
							{
								num3 = 0;
							}
							break;
						default:
							return result;
						case 0:
							return result;
						}
					}
				}
				finally
				{
					if (sHA != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								((IDisposable)sHA).Dispose();
								num4 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a == 0)
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
			default:
				return result;
			}
		}
	}

	public EleWise.ELMA.API.Models.IPublicClientSession CreateSession(Guid authToken, string applicationToken)
	{
		//Discarded unreachable code: IL_006a
		int num = 3;
		int num2 = num;
		IEcdhKey ecdhKey = default(IEcdhKey);
		byte[] secret = default(byte[]);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				if (ecdhKey == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b != 0)
					{
						num2 = 1;
					}
					continue;
				}
				obj = JeHDtFoJfy6FmbhARJd(ecdhKey);
				break;
			case 3:
				ecdhKey = (IEcdhKey)CaLVCqooJ2egKAhc8Hp(publicSignatureService);
				num2 = 2;
				continue;
			case 1:
				obj = null;
				break;
			default:
				return CreateSession(authToken, applicationToken, secret);
			}
			secret = (byte[])obj;
			num2 = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d != 0)
			{
				num2 = 0;
			}
		}
	}

	private EleWise.ELMA.API.Models.IPublicClientSession CreateSession(Guid authToken, string applicationToken, byte[] secret)
	{
		//Discarded unreachable code: IL_00ff, IL_010e, IL_011d, IL_0309, IL_0318
		int num = 16;
		EleWise.ELMA.API.Models.IPublicClientSession session = default(EleWise.ELMA.API.Models.IPublicClientSession);
		EleWise.ELMA.Security.Models.API.IPublicClientSession publicClientSession = default(EleWise.ELMA.Security.Models.API.IPublicClientSession);
		EleWise.ELMA.API.Models.IPublicApplicationToken token = default(EleWise.ELMA.API.Models.IPublicApplicationToken);
		IUser user = default(IUser);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					if (session == null)
					{
						num2 = 22;
						continue;
					}
					goto case 8;
				case 2:
					clientSessionManager.Save(publicClientSession);
					num2 = 23;
					continue;
				case 6:
					jpW4FvoFdo2ymxrNZ4S(publicClientSession, applicationManager.Load(uLNA8moGFJXFQMKo63B(d7tc36ocfn3DDU139qA(token))));
					num2 = 21;
					continue;
				case 8:
					if (session.ClientToken != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 18;
				case 12:
					if (token == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
						{
							num2 = 7;
						}
						continue;
					}
					break;
				case 23:
					cache.Add(publicClientSession);
					num2 = 25;
					continue;
				case 16:
					if (e28V8ZoKm2WCcTyGfM1(authToken, Guid.Empty))
					{
						num2 = 15;
						continue;
					}
					goto case 20;
				case 24:
					t01UfToEmUPYawy201A(publicClientSession, (EleWise.ELMA.Security.Models.IUser)user);
					num2 = 3;
					continue;
				case 13:
					return session;
				case 18:
					return null;
				case 22:
					if (applicationService.IsTokenValid(applicationToken, out token))
					{
						num2 = 12;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 7;
				case 11:
					cLBmZeoMAvf8gLsjw3N(publicClientSession, secret);
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d != 0)
					{
						num2 = 4;
					}
					continue;
				case 10:
					if (gFCWq2ot4ndIKtjYo1Z(applicationToken) != 128)
					{
						num2 = 17;
						continue;
					}
					user = (IUser)jtxQNwohEeKHfTI5KGE(Locator.GetServiceNotNull<IAuthenticationTokenService>(), authToken);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 == 0)
					{
						num2 = 0;
					}
					continue;
				case 25:
					return publicClientSession;
				case 7:
					return null;
				case 20:
					if (applicationToken != null)
					{
						num2 = 5;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 15;
				case 1:
					return null;
				case 4:
					CsOgVSoqDyfoIFrxKDs(publicClientSession, authToken);
					num2 = 6;
					continue;
				case 15:
				case 17:
					return null;
				case 3:
					ckgQVDoD5aHqNBDm094(publicClientSession, GenerateSessionToken(authToken, applicationToken));
					num2 = 11;
					continue;
				case 5:
					s6p8S7osmfR6rnOUp30(publicClientSession, GFCuenoHHfbi1GER4hY());
					num2 = 2;
					continue;
				case 14:
					if (!(((EleWise.ELMA.API.Models.IPublicApplicationToken)oTBWPxoOSwBMUpHr9Or(session)).Token == applicationToken))
					{
						goto end_IL_0012;
					}
					goto case 13;
				case 21:
					CQMW0oo0v4dRpOEBKR4(publicClientSession, applicationTokenManager.FindByToken(applicationToken));
					num2 = 24;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e != 0)
					{
						num2 = 5;
					}
					continue;
				default:
					if (user != null)
					{
						session = GetSession(authToken);
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 == 0)
						{
							num2 = 9;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
						{
							num2 = 1;
						}
					}
					continue;
				case 19:
					break;
				}
				publicClientSession = clientSessionManager.Create();
				num2 = 4;
				continue;
				end_IL_0012:
				break;
			}
			num = 18;
		}
	}

	public bool UpdateAuthToken(string sessionToken, Guid newToken)
	{
		//Discarded unreachable code: IL_0084, IL_00d6, IL_0116, IL_0125
		int num = 12;
		EleWise.ELMA.Security.Models.API.IPublicClientSession sessionInternal = default(EleWise.ELMA.Security.Models.API.IPublicClientSession);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					CsOgVSoqDyfoIFrxKDs(sessionInternal, newToken);
					num2 = 7;
					continue;
				default:
					cache.Add(sessionInternal);
					num2 = 3;
					continue;
				case 3:
					return true;
				case 9:
					if (sessionInternal != null)
					{
						num = 8;
						break;
					}
					goto case 5;
				case 1:
					if (e28V8ZoKm2WCcTyGfM1(newToken, Guid.Empty))
					{
						num2 = 5;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a == 0)
						{
							num2 = 6;
						}
						continue;
					}
					if (GetSession(newToken) == null)
					{
						num2 = 10;
						continue;
					}
					goto case 4;
				case 6:
				case 11:
					return false;
				case 4:
					return false;
				case 10:
					sessionInternal = GetSessionInternal(sessionToken);
					num = 9;
					break;
				case 12:
					if (sessionToken == null)
					{
						num2 = 11;
						continue;
					}
					goto case 2;
				case 7:
					clientSessionManager.Save(sessionInternal);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					return false;
				case 8:
					acXBLfoIoZsbaRhB7Xu(cache, Ui2uLIoY8kPDQcLBdFb(sessionInternal));
					num2 = 10;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 != 0)
					{
						num2 = 13;
					}
					continue;
				case 2:
					if (gFCWq2ot4ndIKtjYo1Z(sessionToken) == 128)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 6;
				}
				break;
			}
		}
	}

	public bool IsSessionValid(string sessionToken, out EleWise.ELMA.API.Models.IPublicClientSession session)
	{
		//Discarded unreachable code: IL_00a8, IL_00b7, IL_0169, IL_017a
		int num = 3;
		int num2 = num;
		EleWise.ELMA.Security.Models.API.IPublicClientSession sessionInternal = default(EleWise.ELMA.Security.Models.API.IPublicClientSession);
		while (true)
		{
			switch (num2)
			{
			case 9:
				if (zqbiAfo44V4b34Gybt5(sessionInternal) == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc != 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 1;
			case 3:
				session = null;
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				if (sessionToken == null)
				{
					num2 = 10;
					break;
				}
				goto case 4;
			case 8:
				session = sessionInternal;
				num2 = 7;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				if (sessionInternal != null)
				{
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 12;
			case 7:
				return true;
			case 5:
			case 11:
				RemoveSession(sessionToken);
				num2 = 12;
				break;
			default:
				return false;
			case 4:
				if (gFCWq2ot4ndIKtjYo1Z(sessionToken) == 128)
				{
					sessionInternal = GetSessionInternal(sessionToken);
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
					{
						num2 = 6;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f != 0)
					{
						num2 = 0;
					}
				}
				break;
			case 12:
				return false;
			case 1:
			{
				if (!applicationService.IsTokenValid((string)TYAZe7oVZWppiTWgAsF(zqbiAfo44V4b34Gybt5(sessionInternal)), out var _))
				{
					num2 = 11;
					break;
				}
				goto case 8;
			}
			}
		}
	}

	public bool PromoteSession(string sessionToken)
	{
		//Discarded unreachable code: IL_0060, IL_006f, IL_007f, IL_00ef, IL_012b, IL_013e
		int num = 4;
		int num2 = num;
		EleWise.ELMA.Security.Models.API.IPublicClientSession sessionInternal = default(EleWise.ELMA.Security.Models.API.IPublicClientSession);
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 1:
			case 3:
				return false;
			case 4:
				if (sessionToken == null)
				{
					num2 = 3;
					break;
				}
				goto case 6;
			case 8:
				try
				{
					promotedSessions.AddOrUpdate(sessionInternal.Id, addValue: false, (long l, bool b) => false);
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				finally
				{
					X2vqXgoQmgfKyXuHE2G(_updateSessionsLock);
					int num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 9;
			case 9:
				return true;
			case 7:
				if (sessionInternal == null)
				{
					num2 = 2;
					break;
				}
				goto case 10;
			default:
				return false;
			case 10:
				if (!(sessionInternal.LastAccess > dateTime.AddMinutes(-1.0)))
				{
					_updateSessionsLock.AcquireReaderLock(10);
					num2 = 8;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				if (gFCWq2ot4ndIKtjYo1Z(sessionToken) == 128)
				{
					dateTime = GFCuenoHHfbi1GER4hY();
					num2 = 5;
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				sessionInternal = GetSessionInternal(sessionToken);
				num2 = 7;
				break;
			}
		}
	}

	public bool RemoveSession(string sessionToken)
	{
		//Discarded unreachable code: IL_0053, IL_0062
		int num = 3;
		EleWise.ELMA.Security.Models.API.IPublicClientSession publicClientSession = default(EleWise.ELMA.Security.Models.API.IPublicClientSession);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (sessionToken == null)
					{
						num2 = 2;
						continue;
					}
					goto case 1;
				case 6:
					return true;
				case 2:
				case 7:
					return false;
				default:
					publicClientSession = clientSessionManager.FindByToken(sessionToken);
					num2 = 5;
					continue;
				case 1:
					if (sessionToken.Length == 128)
					{
						E5MnmdodERCETBZrCjY(cache, sessionToken);
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd != 0)
						{
							num2 = 7;
						}
					}
					continue;
				case 5:
					if (publicClientSession != null)
					{
						clientSessionManager.Delete(publicClientSession);
						num2 = 6;
						continue;
					}
					break;
				case 4:
					return false;
				}
				break;
			}
			num = 4;
		}
	}

	public EleWise.ELMA.API.Models.IPublicClientSession GetSession(Guid authToken)
	{
		return GetSessionInternal(authToken);
	}

	public bool UpdateLastChangesPackage(Guid authToken, string changesPackage)
	{
		//Discarded unreachable code: IL_00d2, IL_0139, IL_014c, IL_015b
		int num = 3;
		int num2 = num;
		EleWise.ELMA.Security.Models.API.IPublicClientSession sessionInternal = default(EleWise.ELMA.Security.Models.API.IPublicClientSession);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return true;
			case 3:
				sessionInternal = GetSessionInternal(authToken);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc != 0)
				{
					num2 = 2;
				}
				break;
			default:
				return false;
			case 2:
				if (sessionInternal != null)
				{
					qlYUJVoT0HmZbC0Ck7j(_updateSessionsLock, 10);
					num2 = 4;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				try
				{
					NYKYqdo8TbNWCvHlEdE(sessionInternal, WlkRYAogO0FcywR8VPx(changesPackage) ? new byte[0] : pSIcXloPrdJ39O66Q9l(EncodingCache.UTF8WithoutEmitIdentifier, changesPackage));
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							clientSessionManager.Save(sessionInternal);
							num3 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 == 0)
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
				finally
				{
					X2vqXgoQmgfKyXuHE2G(_updateSessionsLock);
					int num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 1;
			}
		}
	}

	public long RemoveExpired(TimeSpan expireInterval)
	{
		int num = 1;
		int num2 = num;
		DateTime expireDateTime = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 1:
				expireDateTime = XE9lqQorrsY9p1uWTqr(GFCuenoHHfbi1GER4hY(), expireInterval);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return clientSessionManager.DeleteExpired(expireDateTime);
			}
		}
	}

	protected void FlushUpdatedSessions()
	{
		//Discarded unreachable code: IL_00c2, IL_0139, IL_0185, IL_0194, IL_01bf, IL_01e2, IL_0270, IL_0283, IL_0292, IL_02e5, IL_031d, IL_033d, IL_034c, IL_03dd
		int num = 6;
		int num2 = num;
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = default(_003C_003Ec__DisplayClass28_0);
		CallContextSessionOwner callContextSessionOwner = default(CallContextSessionOwner);
		_003C_003Ec__DisplayClass28_1 CS_0024_003C_003E8__locals0;
		while (true)
		{
			switch (num2)
			{
			case 4:
			case 8:
				_lastUpdateTime = _003C_003Ec__DisplayClass28_.now;
				num2 = 7;
				break;
			case 7:
				callContextSessionOwner = CallContextSessionOwner.Create();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				if (!_lastUpdateTime.HasValue)
				{
					num2 = 4;
					break;
				}
				goto case 2;
			case 3:
				return;
			case 10:
				return;
			case 1:
				try
				{
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass28_1();
					int num3 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 6:
							return;
						case 8:
							return;
						case 4:
							CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass28_;
							num3 = 3;
							break;
						case 5:
						case 7:
							ExecuteWithLock(delegate
							{
								//Discarded unreachable code: IL_0055, IL_0064, IL_00f7, IL_0106, IL_01a6, IL_01b9, IL_01c8
								int num7 = 2;
								int num8 = num7;
								List<long>.Enumerator enumerator = default(List<long>.Enumerator);
								EleWise.ELMA.Security.Models.API.IPublicClientSession publicClientSession = default(EleWise.ELMA.Security.Models.API.IPublicClientSession);
								long current = default(long);
								while (true)
								{
									switch (num8)
									{
									default:
										return;
									case 2:
										enumerator = CS_0024_003C_003E8__locals0.sessionsToUpdate.GetEnumerator();
										num8 = 1;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 == 0)
										{
											num8 = 1;
										}
										break;
									case 1:
										try
										{
											while (true)
											{
												IL_0111:
												int num10;
												if (!enumerator.MoveNext())
												{
													int num9 = 4;
													num10 = num9;
													goto IL_0073;
												}
												goto IL_00ce;
												IL_0073:
												while (true)
												{
													switch (num10)
													{
													case 5:
														CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.clientSessionManager.Save(publicClientSession);
														num10 = 1;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c != 0)
														{
															num10 = 1;
														}
														continue;
													case 3:
														break;
													default:
														if (publicClientSession == null)
														{
															num10 = 6;
															continue;
														}
														goto case 7;
													case 1:
													case 6:
														goto IL_0111;
													case 7:
														publicClientSession.LastAccess = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.now;
														num10 = 5;
														continue;
													case 2:
														publicClientSession = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.clientSessionManager.LoadOrNull(current);
														num10 = 0;
														if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd != 0)
														{
															num10 = 0;
														}
														continue;
													case 4:
														return;
													}
													break;
												}
												goto IL_00ce;
												IL_00ce:
												current = enumerator.Current;
												num10 = 2;
												goto IL_0073;
											}
										}
										finally
										{
											((IDisposable)enumerator).Dispose();
											int num11 = 0;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 != 0)
											{
												num11 = 0;
											}
											switch (num11)
											{
											case 0:
												break;
											}
										}
									case 0:
										return;
									}
								}
							});
							num3 = 8;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 == 0)
							{
								num3 = 0;
							}
							break;
						default:
							if (CS_0024_003C_003E8__locals0.sessionsToUpdate == null)
							{
								return;
							}
							num3 = 7;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
							{
								num3 = 1;
							}
							break;
						case 1:
							Wyj7FQobnBdpFED8is8(_updateSessionsLock, 100);
							num3 = 2;
							break;
						case 2:
							try
							{
								int num4;
								if (xw5ObHoSRGqMQqR8xaZ(promotedSessions.Keys) == 0)
								{
									num4 = 3;
									goto IL_01c3;
								}
								goto IL_01f0;
								IL_01c3:
								while (true)
								{
									switch (num4)
									{
									case 3:
										return;
									default:
										goto end_IL_01c3;
									case 2:
										break;
									case 1:
										promotedSessions.Clear();
										num4 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 == 0)
										{
											num4 = 0;
										}
										continue;
									case 0:
										goto end_IL_01c3;
									}
									goto IL_01f0;
									continue;
									end_IL_01c3:
									break;
								}
								goto end_IL_01a0;
								IL_01f0:
								CS_0024_003C_003E8__locals0.sessionsToUpdate = new List<long>(promotedSessions.Keys);
								num4 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d == 0)
								{
									num4 = 1;
								}
								goto IL_01c3;
								end_IL_01a0:;
							}
							finally
							{
								D42orVo9ZspSi9LqtyS(_updateSessionsLock);
								int num5 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 == 0)
								{
									num5 = 0;
								}
								switch (num5)
								{
								case 0:
									break;
								}
							}
							goto default;
						case 3:
							CS_0024_003C_003E8__locals0.sessionsToUpdate = null;
							num3 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc == 0)
							{
								num3 = 1;
							}
							break;
						}
					}
				}
				finally
				{
					if (callContextSessionOwner != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad != 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								iaJlNiofXaF4Dv1v9Oh(callContextSessionOwner);
								num6 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
								{
									num6 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 6:
				_003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
				num2 = 5;
				break;
			case 2:
				if (!FHpYlioyP2CENOe5m6L(onSxlDo3rMOvv97dJiU(_003C_003Ec__DisplayClass28_.now, _lastUpdateTime.Value), TimeSpan.FromMinutes(5.0)))
				{
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 == 0)
					{
						num2 = 10;
					}
					break;
				}
				goto case 4;
			case 5:
				_003C_003Ec__DisplayClass28_._003C_003E4__this = this;
				num2 = 9;
				break;
			case 9:
				_003C_003Ec__DisplayClass28_.now = DateTime.Now;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6ebd2dabc54f4311bbbe57be8fcccc48 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void ExecuteWithLock(Action action)
	{
		//Discarded unreachable code: IL_0074, IL_00ed, IL_014b, IL_0196, IL_01cd, IL_0205, IL_0224, IL_0250, IL_025f, IL_028a, IL_0308, IL_0361, IL_03ba, IL_03f2
		int num = 1;
		int num2 = num;
		IUnitOfWorkManager serviceNotNull = default(IUnitOfWorkManager);
		PublicClientService publicClientService = default(PublicClientService);
		bool lockTaken = default(bool);
		IUnitOfWork unitOfWork = default(IUnitOfWork);
		while (true)
		{
			switch (num2)
			{
			case 6:
				throw new ArgumentNullException((string)wnXDTMojcRhnVuaKt40(-698589567 ^ -698592261));
			default:
				serviceNotNull = Locator.GetServiceNotNull<IUnitOfWorkManager>();
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				publicClientService = this;
				num2 = 5;
				break;
			case 1:
				if (action != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c270ab2f5854923a44daf526a7f59af != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			case 3:
				return;
			case 5:
				lockTaken = false;
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 != 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				try
				{
					Monitor.Enter(publicClientService, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							unitOfWork = (IUnitOfWork)kvUWEmo1WQwFhyGmVUr(serviceNotNull, string.Empty, true, IsolationLevel.Unspecified);
							num3 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
							{
								num3 = 0;
							}
							break;
						case 1:
							try
							{
								bool flag = false;
								int num4 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 != 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								}
								try
								{
									IDisposable disposable = (IDisposable)e2KyrMozvd4ssbmakdi(lockManager, wnXDTMojcRhnVuaKt40(-1084772212 ^ -1084767246));
									int num5 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 != 0)
									{
										num5 = 1;
									}
									switch (num5)
									{
									case 0:
										break;
									case 1:
										try
										{
											ywiYFmJkTYqi2cKRc8u(action);
											int num6 = 0;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
											{
												num6 = 0;
											}
											switch (num6)
											{
											case 0:
												break;
											}
											break;
										}
										finally
										{
											int num7;
											if (disposable == null)
											{
												num7 = 1;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad == 0)
												{
													num7 = 1;
												}
												goto IL_0209;
											}
											goto IL_022e;
											IL_022e:
											iaJlNiofXaF4Dv1v9Oh(disposable);
											num7 = 0;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 != 0)
											{
												num7 = 0;
											}
											goto IL_0209;
											IL_0209:
											switch (num7)
											{
											default:
												goto end_IL_01e4;
											case 1:
												goto end_IL_01e4;
											case 2:
												break;
											case 0:
												goto end_IL_01e4;
											}
											goto IL_022e;
											end_IL_01e4:;
										}
									}
									return;
								}
								catch (Exception)
								{
									int num8 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 == 0)
									{
										num8 = 1;
									}
									while (true)
									{
										switch (num8)
										{
										default:
											return;
										case 0:
											return;
										case 1:
											flag = true;
											num8 = 2;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc == 0)
											{
												num8 = 0;
											}
											break;
										case 2:
											xLvyYpJplnGJ1Pc9C6w(unitOfWork);
											num8 = 0;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b == 0)
											{
												num8 = 0;
											}
											break;
										}
									}
								}
								finally
								{
									if (!flag)
									{
										int num9 = 1;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc == 0)
										{
											num9 = 1;
										}
										while (true)
										{
											switch (num9)
											{
											case 1:
												unitOfWork.Commit();
												num9 = 0;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be == 0)
												{
													num9 = 0;
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
							finally
							{
								if (unitOfWork != null)
								{
									int num10 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
									{
										num10 = 0;
									}
									while (true)
									{
										switch (num10)
										{
										default:
											unitOfWork.Dispose();
											num10 = 1;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 != 0)
											{
												num10 = 0;
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
				}
				finally
				{
					if (lockTaken)
					{
						int num11 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 == 0)
						{
							num11 = 0;
						}
						while (true)
						{
							switch (num11)
							{
							default:
								pVSR1aJ5g1IYCs5YKVK(publicClientService);
								num11 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df != 0)
								{
									num11 = 1;
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
	}

	internal static bool LkhQDGoeyb7Ql6fXFya()
	{
		return hbgJSOom7fSHK4sjeQo == null;
	}

	internal static PublicClientService LwV8cCoLwE2EKuO9mgd()
	{
		return hbgJSOom7fSHK4sjeQo;
	}

	internal static object wnXDTMojcRhnVuaKt40(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static DateTime GFCuenoHHfbi1GER4hY()
	{
		return DateTime.Now;
	}

	internal static object CqK8UJoaehhT8AIcnMl(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}

	internal static object kHveomoROfOnhOp09ZQ(object P_0)
	{
		return Generate128ByteToken((string)P_0);
	}

	internal static object P95jSbowYBcEk8ViysG()
	{
		return SHA512.Create();
	}

	internal static object cjo50qo2D0lc5hRvcwo()
	{
		return Encoding.UTF8;
	}

	internal static object pSIcXloPrdJ39O66Q9l(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static object nFdYxHovWwEReHIVAmT(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((byte[])P_1);
	}

	internal static object r4lu2QoCsZvhVDxN3Nf(object P_0)
	{
		return BitConverter.ToString((byte[])P_0);
	}

	internal static object NRVlB5oUDBlVelHTAJw(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object CaLVCqooJ2egKAhc8Hp(object P_0)
	{
		return ((IPublicSignatureService)P_0).ProcessAuthInfo();
	}

	internal static object JeHDtFoJfy6FmbhARJd(object P_0)
	{
		return ((IEcdhKey)P_0).SharedSecret;
	}

	internal static bool e28V8ZoKm2WCcTyGfM1(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static int gFCWq2ot4ndIKtjYo1Z(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object jtxQNwohEeKHfTI5KGE(object P_0, Guid P_1)
	{
		return ((IAuthenticationTokenService)P_0).GetUser(P_1);
	}

	internal static object oTBWPxoOSwBMUpHr9Or(object P_0)
	{
		return ((EleWise.ELMA.API.Models.IPublicClientSession)P_0).ClientToken;
	}

	internal static void CsOgVSoqDyfoIFrxKDs(object P_0, Guid value)
	{
		((EleWise.ELMA.Security.Models.API.IPublicClientSession)P_0).AuthToken = value;
	}

	internal static object d7tc36ocfn3DDU139qA(object P_0)
	{
		return ((EleWise.ELMA.API.Models.IPublicApplicationToken)P_0).Application;
	}

	internal static Guid uLNA8moGFJXFQMKo63B(object P_0)
	{
		return ((EleWise.ELMA.API.Models.IPublicApplication)P_0).Uid;
	}

	internal static void jpW4FvoFdo2ymxrNZ4S(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.API.IPublicClientSession)P_0).Application = (EleWise.ELMA.Security.Models.API.IPublicApplication)P_1;
	}

	internal static void CQMW0oo0v4dRpOEBKR4(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.API.IPublicClientSession)P_0).ClientToken = (EleWise.ELMA.Security.Models.API.IPublicApplicationToken)P_1;
	}

	internal static void t01UfToEmUPYawy201A(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.API.IPublicClientSession)P_0).AuthUser = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static void ckgQVDoD5aHqNBDm094(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.API.IPublicClientSession)P_0).SessionToken = (string)P_1;
	}

	internal static void cLBmZeoMAvf8gLsjw3N(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.API.IPublicClientSession)P_0).Secret = (byte[])P_1;
	}

	internal static void s6p8S7osmfR6rnOUp30(object P_0, DateTime value)
	{
		((EleWise.ELMA.Security.Models.API.IPublicClientSession)P_0).LastAccess = value;
	}

	internal static Guid Ui2uLIoY8kPDQcLBdFb(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.API.IPublicClientSession)P_0).AuthToken;
	}

	internal static bool acXBLfoIoZsbaRhB7Xu(object P_0, Guid authToken)
	{
		return ((SessionCache)P_0).Remove(authToken);
	}

	internal static object zqbiAfo44V4b34Gybt5(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.API.IPublicClientSession)P_0).ClientToken;
	}

	internal static object TYAZe7oVZWppiTWgAsF(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.API.IPublicApplicationToken)P_0).Token;
	}

	internal static void X2vqXgoQmgfKyXuHE2G(object P_0)
	{
		((ReaderWriterLock)P_0).ReleaseReaderLock();
	}

	internal static bool E5MnmdodERCETBZrCjY(object P_0, object P_1)
	{
		return ((SessionCache)P_0).Remove((string)P_1);
	}

	internal static void qlYUJVoT0HmZbC0Ck7j(object P_0, int P_1)
	{
		((ReaderWriterLock)P_0).AcquireReaderLock(P_1);
	}

	internal static bool WlkRYAogO0FcywR8VPx(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static void NYKYqdo8TbNWCvHlEdE(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.API.IPublicClientSession)P_0).LastChangesPackage = (byte[])P_1;
	}

	internal static DateTime XE9lqQorrsY9p1uWTqr(DateTime P_0, TimeSpan P_1)
	{
		return P_0 - P_1;
	}

	internal static TimeSpan onSxlDo3rMOvv97dJiU(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static bool FHpYlioyP2CENOe5m6L(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 >= P_1;
	}

	internal static void Wyj7FQobnBdpFED8is8(object P_0, int P_1)
	{
		((ReaderWriterLock)P_0).AcquireWriterLock(P_1);
	}

	internal static int xw5ObHoSRGqMQqR8xaZ(object P_0)
	{
		return ((ICollection<long>)P_0).Count;
	}

	internal static void D42orVo9ZspSi9LqtyS(object P_0)
	{
		((ReaderWriterLock)P_0).ReleaseWriterLock();
	}

	internal static void iaJlNiofXaF4Dv1v9Oh(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object kvUWEmo1WQwFhyGmVUr(object P_0, object P_1, bool P_2, IsolationLevel P_3)
	{
		return ((IUnitOfWorkManager)P_0).Create((string)P_1, P_2, P_3);
	}

	internal static object e2KyrMozvd4ssbmakdi(object P_0, object P_1)
	{
		return ((ILockManager)P_0).Lock((string)P_1);
	}

	internal static void ywiYFmJkTYqi2cKRc8u(object P_0)
	{
		P_0();
	}

	internal static void xLvyYpJplnGJ1Pc9C6w(object P_0)
	{
		((IUnitOfWork)P_0).Rollback();
	}

	internal static void pVSR1aJ5g1IYCs5YKVK(object P_0)
	{
		Monitor.Exit(P_0);
	}
}
