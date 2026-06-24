using System;
using System.Collections.Concurrent;
using EleWise.ELMA.API;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models.API;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Services.API;

[Service(Type = ComponentType.Server)]
internal class PublicCacheService : IPublicCacheService
{
	private readonly IPublicClientService clientService;

	private readonly PublicClientCacheTokenManager cacheTokenManager;

	private readonly PublicClientSessionManager clientSessionManager;

	private static readonly ConcurrentDictionary<string, Guid> TokenCache;

	internal static PublicCacheService YoA0SUUSyKNnNGyBHxP;

	public PublicCacheService(IPublicClientService clientService, PublicClientCacheTokenManager cacheTokenManager, PublicClientSessionManager clientSessionManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		lKxxhZU1CIYWpVUcBSK();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.cacheTokenManager = cacheTokenManager;
				num = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f == 0)
				{
					num = 3;
				}
				break;
			case 3:
				this.clientSessionManager = clientSessionManager;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
				{
					num = 0;
				}
				break;
			case 2:
				this.clientService = clientService;
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static Guid GenerateTokenKey(Guid authToken, string tokenValue)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return TokenCache.GetOrAdd(tokenValue, SBKknUokKTykdwHvoEw(tokenValue));
			case 1:
				if (icp3vaUzAnMl5PpWJRh(tokenValue))
				{
					return Guid.Empty;
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public string GetTokenValue(Guid typeUid, string eqlQuery)
	{
		return (string)p750yio51d0uCcIRITt(typeUid.ToString((string)gfsYCqopX36uoT8WFZW(--561310391 ^ 0x2174D6D3)), gfsYCqopX36uoT8WFZW(0x4A799728 ^ 0x4A79E450), eqlQuery);
	}

	public bool IsCacheValid(Guid authToken, string tokenValue, out EleWise.ELMA.API.Models.IPublicClientCacheToken cacheToken)
	{
		int num = 5;
		EleWise.ELMA.API.Models.IPublicClientSession session = default(EleWise.ELMA.API.Models.IPublicClientSession);
		EleWise.ELMA.Security.Models.API.IPublicClientCacheToken publicClientCacheToken = default(EleWise.ELMA.Security.Models.API.IPublicClientCacheToken);
		EleWise.ELMA.Security.Models.API.IPublicClientSession publicClientSession = default(EleWise.ELMA.Security.Models.API.IPublicClientSession);
		Guid tokenKey = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					cacheToken = null;
					num2 = 4;
					continue;
				case 2:
					if (icp3vaUzAnMl5PpWJRh(tokenValue))
					{
						num2 = 3;
						continue;
					}
					session = (EleWise.ELMA.API.Models.IPublicClientSession)ePXaeaoWOpCMbDeDNai(clientService, authToken);
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
					{
						num2 = 11;
					}
					continue;
				case 11:
					if (session != null)
					{
						num2 = 6;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 9;
				case 1:
					if (publicClientCacheToken != null)
					{
						num2 = 7;
						continue;
					}
					goto case 8;
				case 6:
					if (!clientService.IsSessionValid((string)bCDtjQoXjN94KNSkc3W(session), out session))
					{
						num2 = 9;
						continue;
					}
					publicClientSession = (EleWise.ELMA.Security.Models.API.IPublicClientSession)oiO5HconY9vVQaYt0Q9(clientSessionManager, bCDtjQoXjN94KNSkc3W(session));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					if (!ad0ILToAeAFXd71h1b8(authToken, Guid.Empty))
					{
						num2 = 2;
						continue;
					}
					goto case 3;
				case 7:
					cacheToken = publicClientCacheToken;
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b081c717aa3147caa220888eaef123d9 == 0)
					{
						num2 = 8;
					}
					continue;
				case 10:
					publicClientCacheToken = (EleWise.ELMA.Security.Models.API.IPublicClientCacheToken)BjChcqo7Ct3miEpVfUZ(cacheTokenManager, tokenKey, publicClientSession);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					return false;
				case 8:
					return publicClientCacheToken != null;
				case 9:
					return false;
				}
				break;
			}
			tokenKey = bWMRALoir02Bc6gwZwH(authToken, tokenValue);
			num = 10;
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
			default:
				return q3v9bdoNmilcpNec5yb(cacheTokenManager, expireDateTime);
			case 1:
				expireDateTime = qeZmKGolTrOcoQtcOO7(vnQUBao63aiUDN2FIgB(), expireInterval);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public EleWise.ELMA.API.Models.IPublicClientCacheToken CreateCacheToken(Guid authToken, string tokenValue)
	{
		//Discarded unreachable code: IL_00ae, IL_00bd, IL_00cc, IL_016d
		int num = 15;
		EleWise.ELMA.Security.Models.API.IPublicClientCacheToken publicClientCacheToken = default(EleWise.ELMA.Security.Models.API.IPublicClientCacheToken);
		EleWise.ELMA.API.Models.IPublicClientCacheToken cacheToken = default(EleWise.ELMA.API.Models.IPublicClientCacheToken);
		EleWise.ELMA.API.Models.IPublicClientSession session = default(EleWise.ELMA.API.Models.IPublicClientSession);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
					if (!ad0ILToAeAFXd71h1b8(authToken, Guid.Empty))
					{
						num2 = 14;
						continue;
					}
					goto case 3;
				case 7:
					CNJ8kpoxeqTndcq9gKs(publicClientCacheToken, bWMRALoir02Bc6gwZwH(authToken, tokenValue));
					num2 = 6;
					continue;
				case 3:
					return null;
				default:
					if (!IsCacheValid(authToken, tokenValue, out cacheToken))
					{
						num2 = 8;
						continue;
					}
					goto case 10;
				case 1:
					publicClientCacheToken = cacheTokenManager.Create();
					num2 = 11;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
					{
						num2 = 4;
					}
					continue;
				case 14:
					if (!icp3vaUzAnMl5PpWJRh(tokenValue))
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 12:
					gkNkk2oZFlfa2Jf2FEs(publicClientCacheToken, tokenValue);
					num2 = 7;
					continue;
				case 9:
					if (clientService.IsSessionValid(session.SessionToken, out session))
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 5;
				case 10:
					return cacheToken;
				case 8:
					session = (EleWise.ELMA.API.Models.IPublicClientSession)ePXaeaoWOpCMbDeDNai(clientService, authToken);
					num2 = 13;
					continue;
				case 2:
					cacheTokenManager.Save(publicClientCacheToken);
					num = 4;
					break;
				case 4:
					return publicClientCacheToken;
				case 5:
					return null;
				case 13:
					if (session == null)
					{
						num = 5;
						break;
					}
					goto case 9;
				case 6:
					kkHt5LoBSOf17xDAWwF(publicClientCacheToken, vnQUBao63aiUDN2FIgB());
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 == 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					publicClientCacheToken.Session = (EleWise.ELMA.Security.Models.API.IPublicClientSession)oiO5HconY9vVQaYt0Q9(clientSessionManager, session.SessionToken);
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e == 0)
					{
						num2 = 12;
					}
					continue;
				}
				break;
			}
		}
	}

	public Guid GetTokenKey(Guid authToken, string tokenValue)
	{
		//Discarded unreachable code: IL_0078, IL_0087, IL_00fd, IL_010c, IL_011c
		int num = 5;
		int num2 = num;
		EleWise.ELMA.API.Models.IPublicClientSession session = default(EleWise.ELMA.API.Models.IPublicClientSession);
		while (true)
		{
			switch (num2)
			{
			case 8:
				if (!clientService.IsSessionValid((string)bCDtjQoXjN94KNSkc3W(session), out session))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 4:
			case 7:
				return Guid.Empty;
			case 2:
				session = (EleWise.ELMA.API.Models.IPublicClientSession)ePXaeaoWOpCMbDeDNai(clientService, authToken);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
				{
					num2 = 3;
				}
				break;
			default:
				return GenerateTokenKey(authToken, tokenValue);
			case 1:
				return Guid.Empty;
			case 5:
				if (ad0ILToAeAFXd71h1b8(authToken, Guid.Empty))
				{
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 6;
			case 6:
				if (!icp3vaUzAnMl5PpWJRh(tokenValue))
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 3:
				if (session != null)
				{
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public bool PromoteCacheToken(Guid authToken, string tokenValue)
	{
		//Discarded unreachable code: IL_00a5, IL_00b4
		int num = 6;
		int num2 = num;
		EleWise.ELMA.API.Models.IPublicClientSession session = default(EleWise.ELMA.API.Models.IPublicClientSession);
		Guid tokenKey = default(Guid);
		EleWise.ELMA.Security.Models.API.IPublicClientSession publicClientSession = default(EleWise.ELMA.Security.Models.API.IPublicClientSession);
		while (true)
		{
			switch (num2)
			{
			case 6:
				session = (EleWise.ELMA.API.Models.IPublicClientSession)ePXaeaoWOpCMbDeDNai(clientService, authToken);
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				return l1bngdou2Nhsvy6HFe5(cacheTokenManager, tokenKey, publicClientSession);
			case 4:
				return false;
			case 1:
				publicClientSession = (EleWise.ELMA.Security.Models.API.IPublicClientSession)oiO5HconY9vVQaYt0Q9(clientSessionManager, bCDtjQoXjN94KNSkc3W(session));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (session != null)
				{
					num2 = 2;
					break;
				}
				goto case 4;
			case 2:
				if (clientService.IsSessionValid(session.SessionToken, out session))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			default:
				tokenKey = bWMRALoir02Bc6gwZwH(authToken, tokenValue);
				num2 = 3;
				break;
			}
		}
	}

	public bool SyncCache(Guid authToken, Guid typeUid, DateTime? fromDate, long[] data, string eqlQuery)
	{
		if (authToken == Guid.Empty || typeUid == Guid.Empty || data == null)
		{
			return false;
		}
		string tokenValue = GetTokenValue(typeUid, eqlQuery);
		EleWise.ELMA.API.Models.IPublicClientSession session = clientService.GetSession(authToken);
		if (session != null && clientService.IsSessionValid(session.SessionToken, out session))
		{
			EleWise.ELMA.API.Models.IPublicClientCacheToken publicClientCacheToken = CreateCacheToken(authToken, tokenValue);
			if (publicClientCacheToken != null)
			{
				return cacheTokenManager.SetData(publicClientCacheToken.Id, data);
			}
		}
		return false;
	}

	public bool UpdateCache(Guid authToken, Guid typeUid, DateTime? fromDate, long[] updated, long[] deleted, string eqlQuery)
	{
		if (authToken == Guid.Empty || typeUid == Guid.Empty || (updated == null && deleted == null))
		{
			return false;
		}
		string tokenValue = GetTokenValue(typeUid, eqlQuery);
		EleWise.ELMA.API.Models.IPublicClientSession session = clientService.GetSession(authToken);
		if (session != null && clientService.IsSessionValid(session.SessionToken, out session))
		{
			EleWise.ELMA.API.Models.IPublicClientCacheToken publicClientCacheToken = CreateCacheToken(authToken, tokenValue);
			if (publicClientCacheToken != null)
			{
				return cacheTokenManager.UpdateData(publicClientCacheToken.Id, updated, deleted);
			}
		}
		return false;
	}

	static PublicCacheService()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				lKxxhZU1CIYWpVUcBSK();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c == 0)
				{
					num2 = 0;
				}
				break;
			default:
				TokenCache = new ConcurrentDictionary<string, Guid>();
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void lKxxhZU1CIYWpVUcBSK()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool uVgeMmU9wH2hLRNniLV()
	{
		return YoA0SUUSyKNnNGyBHxP == null;
	}

	internal static PublicCacheService RdpSIpUfX0UebiQhdAS()
	{
		return YoA0SUUSyKNnNGyBHxP;
	}

	internal static bool icp3vaUzAnMl5PpWJRh(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static Guid SBKknUokKTykdwHvoEw(object P_0)
	{
		return ((string)P_0).GetDeterministicGuid();
	}

	internal static object gfsYCqopX36uoT8WFZW(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object p750yio51d0uCcIRITt(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool ad0ILToAeAFXd71h1b8(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object ePXaeaoWOpCMbDeDNai(object P_0, Guid P_1)
	{
		return ((IPublicClientService)P_0).GetSession(P_1);
	}

	internal static object bCDtjQoXjN94KNSkc3W(object P_0)
	{
		return ((EleWise.ELMA.API.Models.IPublicClientSession)P_0).SessionToken;
	}

	internal static object oiO5HconY9vVQaYt0Q9(object P_0, object P_1)
	{
		return ((PublicClientSessionManager)P_0).FindByToken((string)P_1);
	}

	internal static Guid bWMRALoir02Bc6gwZwH(Guid authToken, object P_1)
	{
		return GenerateTokenKey(authToken, (string)P_1);
	}

	internal static object BjChcqo7Ct3miEpVfUZ(object P_0, Guid tokenKey, object P_2)
	{
		return ((PublicClientCacheTokenManager)P_0).FindByTokenSession(tokenKey, (EleWise.ELMA.Security.Models.API.IPublicClientSession)P_2);
	}

	internal static DateTime vnQUBao63aiUDN2FIgB()
	{
		return DateTime.Now;
	}

	internal static DateTime qeZmKGolTrOcoQtcOO7(DateTime P_0, TimeSpan P_1)
	{
		return P_0 - P_1;
	}

	internal static long q3v9bdoNmilcpNec5yb(object P_0, DateTime expireDateTime)
	{
		return ((PublicClientCacheTokenManager)P_0).DeleteExpired(expireDateTime);
	}

	internal static void gkNkk2oZFlfa2Jf2FEs(object P_0, object P_1)
	{
		((EleWise.ELMA.Security.Models.API.IPublicClientCacheToken)P_0).TokenValue = (string)P_1;
	}

	internal static void CNJ8kpoxeqTndcq9gKs(object P_0, Guid value)
	{
		((EleWise.ELMA.Security.Models.API.IPublicClientCacheToken)P_0).TokenKey = value;
	}

	internal static void kkHt5LoBSOf17xDAWwF(object P_0, DateTime value)
	{
		((EleWise.ELMA.Security.Models.API.IPublicClientCacheToken)P_0).LastAccess = value;
	}

	internal static bool l1bngdou2Nhsvy6HFe5(object P_0, Guid tokenKey, object P_2)
	{
		return ((PublicClientCacheTokenManager)P_0).Promote(tokenKey, (EleWise.ELMA.Security.Models.API.IPublicClientSession)P_2);
	}
}
