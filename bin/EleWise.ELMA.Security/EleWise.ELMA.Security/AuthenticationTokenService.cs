using System;
using System.Threading;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Service(Type = ComponentType.WebServer, InjectProperties = true, Scope = ServiceScope.Application)]
internal class AuthenticationTokenService : IAuthenticationTokenService
{
	private readonly IAuthenticationServiceEventHandler authenticationServiceEventHandler;

	private readonly UserManager userManager;

	private volatile ICacheService cacheService;

	private readonly ISessionProvider sessionProvider;

	internal static AuthenticationTokenService VntEBqWHKehDJXD6yjx;

	private TimeSpan TokenDuration => ftJpkOWEmq7wmTLDfHa(SR.GetSetting((string)SKldKuWwbLiqeSK5lMj(-1858473711 ^ -1858474095), 60.0));

	private ICacheService CacheService
	{
		get
		{
			//Discarded unreachable code: IL_0039, IL_00cd, IL_0142, IL_0151, IL_01a6, IL_01de
			int num = 2;
			int num2 = num;
			bool lockTaken = default(bool);
			AuthenticationTokenService obj = default(AuthenticationTokenService);
			ICacheService result = default(ICacheService);
			while (true)
			{
				switch (num2)
				{
				case 5:
					lockTaken = false;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					return cacheService;
				case 2:
					if (cacheService == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 4;
				case 4:
					return cacheService;
				case 1:
					obj = this;
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
					{
						num2 = 5;
					}
					break;
				default:
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						int num3 = 4;
						while (true)
						{
							switch (num3)
							{
							case 3:
								return result;
							case 4:
								if (cacheService != null)
								{
									num3 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d == 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto case 2;
							case 2:
								cacheService = Locator.GetServiceNotNull<ICacheService>();
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 == 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
								result = cacheService;
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc != 0)
								{
									num3 = 3;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						if (lockTaken)
						{
							int num4 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									Monitor.Exit(obj);
									num4 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d != 0)
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
					goto case 3;
				}
			}
		}
	}

	private ISession Session => sessionProvider.GetSession(string.Empty);

	public AuthenticationTokenService([NotNull] UserManager userManager, ISessionProvider sessionProvider, IAuthenticationServiceEventHandler authenticationServiceEventHandler)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 4:
				this.authenticationServiceEventHandler = authenticationServiceEventHandler;
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_488725796a2e487f95c022f5056d8a88 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				this.sessionProvider = sessionProvider;
				num = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc != 0)
				{
					num = 0;
				}
				break;
			case 3:
				EEGM8gW2hQn8U7Eiwhi(userManager, SKldKuWwbLiqeSK5lMj(0x37FE8EDE ^ 0x37FE9348));
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
				this.userManager = userManager;
				num = 2;
				break;
			}
		}
	}

	[Transaction]
	public virtual Guid CreateToken(IUser user)
	{
		int num = 1;
		int num2 = num;
		AuthToken authToken = default(AuthToken);
		while (true)
		{
			switch (num2)
			{
			case 3:
				TokenToCache(authToken, TokenDuration);
				num2 = 5;
				break;
			case 4:
				authenticationServiceEventHandler.SignedIn(user);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				authToken = new AuthToken
				{
					Uid = default(Guid),
					UserId = (long)hRb3BRWPX82Fh51fZRK(user),
					ExpireDate = iYU5gjWvmq0srfLEraq().Add(TokenDuration)
				};
				num2 = 3;
				break;
			case 1:
				EEGM8gW2hQn8U7Eiwhi(user, SKldKuWwbLiqeSK5lMj(-1429357207 ^ -1429360509));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return r7r4beWUu4QFdgMvKmq(authToken);
			case 5:
				mTQLA0WCAg38dqcDoSn(Session, authToken);
				num2 = 4;
				break;
			}
		}
	}

	[Transaction]
	public virtual IUser GetUser(Guid token)
	{
		//Discarded unreachable code: IL_0110, IL_0153, IL_0175
		int num = 1;
		int num2 = num;
		long? value = default(long?);
		AuthToken authToken = default(AuthToken);
		string tokenCacheKey = default(string);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return null;
			case 2:
				return userManager.LoadOrNull(value.Value);
			case 4:
				authToken = Session.Get<AuthToken>((object)token);
				num2 = 10;
				break;
			case 3:
				if (value.HasValue)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			case 9:
				return null;
			case 11:
				return null;
			case 8:
				if (!RiBNKNWJ1UFChDyjZZt(bK1bwGWo1K4mHSubo56(authToken), iYU5gjWvmq0srfLEraq()))
				{
					TokenToCache(authToken);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 != 0)
					{
						num2 = 6;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 != 0)
					{
						num2 = 7;
					}
				}
				break;
			case 10:
				if (authToken != null)
				{
					num2 = 8;
					break;
				}
				goto case 11;
			default:
				if (!CacheService.TryGetValue<long?>(tokenCacheKey, (string)SKldKuWwbLiqeSK5lMj(-731479136 ^ -731472368), out value))
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 6:
				return userManager.LoadOrNull(Q5kiugWKaTRtjVkxwvG(authToken));
			case 7:
				RemoveToken(authToken);
				num2 = 6;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
				{
					num2 = 9;
				}
				break;
			case 1:
				tokenCacheKey = GetTokenCacheKey(token);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual void RemoveToken(Guid token)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 1;
		int num2 = num;
		AuthToken authToken = default(AuthToken);
		while (true)
		{
			switch (num2)
			{
			case 1:
				authToken = Session.Load<AuthToken>((object)token);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				return;
			case 3:
				RemoveToken(authToken);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 != 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				return;
			}
			if (authToken == null)
			{
				return;
			}
			num2 = 3;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 != 0)
			{
				num2 = 1;
			}
		}
	}

	private void RemoveToken(AuthToken authToken)
	{
		//Discarded unreachable code: IL_0045, IL_0054
		int num = 4;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		string tokenCacheKey = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					gM469hWh1rnnCHRiHbT(authenticationServiceEventHandler, user);
					num2 = 8;
					continue;
				case 3:
					if (user == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto default;
				case 2:
					GU3qwPWcXEYrIIitm2Z(CacheService, tokenCacheKey, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--553267277 ^ 0x20FA2DFD));
					num2 = 5;
					continue;
				case 5:
					return;
				case 6:
					EYgNt9Wq8ELNxXpypkk(Session.CreateQuery((string)SKldKuWwbLiqeSK5lMj(-1378061210 ^ -1378063942)).SetParameter<DateTime>((string)SKldKuWwbLiqeSK5lMj(0x7A093321 ^ 0x7A092D7B), iYU5gjWvmq0srfLEraq().AddHours(-1.0)).SetParameter<Guid>((string)SKldKuWwbLiqeSK5lMj(0xCDF201B ^ 0xCDF3E7B), r7r4beWUu4QFdgMvKmq(authToken)), false);
					num2 = 2;
					continue;
				case 1:
				case 8:
					break;
				case 7:
					G7Ey1UWO3yu3dQ1xAZ4(Session, authToken);
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 == 0)
					{
						num2 = 5;
					}
					continue;
				case 4:
					user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>)RkJna2WtM56XuF99fv8()).LoadOrNull(Q5kiugWKaTRtjVkxwvG(authToken));
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			}
			tokenCacheKey = GetTokenCacheKey(authToken.Uid);
			num = 7;
		}
	}

	private void TokenToCache(AuthToken authToken)
	{
		int num = 3;
		int num2 = num;
		TimeSpan timeSpan = default(TimeSpan);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (OiZmjFW0GZgp3EeP9sJ(timeSpan, TimeSpan.Zero))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 3:
				AvJP8iWGloXihZnNBcC(authToken, SKldKuWwbLiqeSK5lMj(0x43ED0455 ^ 0x43ED1A3F));
				num2 = 2;
				break;
			case 2:
				timeSpan = srLqGrWFg19qXvfAOJ8(bK1bwGWo1K4mHSubo56(authToken), iYU5gjWvmq0srfLEraq());
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				TokenToCache(authToken, timeSpan);
				num2 = 4;
				break;
			case 4:
				return;
			}
		}
	}

	private void TokenToCache(AuthToken authToken, TimeSpan duration)
	{
		int num = 1;
		int num2 = num;
		string tokenCacheKey = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				Contract.NotNull(authToken, (string)SKldKuWwbLiqeSK5lMj(-2119527672 ^ -2119529118));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				tokenCacheKey = GetTokenCacheKey(r7r4beWUu4QFdgMvKmq(authToken));
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				CacheService.Insert(tokenCacheKey, Q5kiugWKaTRtjVkxwvG(authToken), (string)SKldKuWwbLiqeSK5lMj(0x74C28149 ^ 0x74C29CF9), duration);
				num2 = 3;
				break;
			}
		}
	}

	private static string GetTokenCacheKey(Guid token)
	{
		return (string)epy2FDWDfARnJ0gQrqo(SKldKuWwbLiqeSK5lMj(-930147978 ^ -930148386), token);
	}

	internal static object SKldKuWwbLiqeSK5lMj(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void EEGM8gW2hQn8U7Eiwhi(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool N9wGI7WauCQNy3hosy7()
	{
		return VntEBqWHKehDJXD6yjx == null;
	}

	internal static AuthenticationTokenService dOeJODWRs7JfxKvfTpT()
	{
		return VntEBqWHKehDJXD6yjx;
	}

	internal static object hRb3BRWPX82Fh51fZRK(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static DateTime iYU5gjWvmq0srfLEraq()
	{
		return DateTime.Now;
	}

	internal static object mTQLA0WCAg38dqcDoSn(object P_0, object P_1)
	{
		return ((ISession)P_0).Save(P_1);
	}

	internal static Guid r7r4beWUu4QFdgMvKmq(object P_0)
	{
		return ((AuthToken)P_0).Uid;
	}

	internal static DateTime bK1bwGWo1K4mHSubo56(object P_0)
	{
		return ((AuthToken)P_0).ExpireDate;
	}

	internal static bool RiBNKNWJ1UFChDyjZZt(DateTime P_0, DateTime P_1)
	{
		return P_0 < P_1;
	}

	internal static long Q5kiugWKaTRtjVkxwvG(object P_0)
	{
		return ((AuthToken)P_0).UserId;
	}

	internal static object RkJna2WtM56XuF99fv8()
	{
		return UserManager.Instance;
	}

	internal static void gM469hWh1rnnCHRiHbT(object P_0, object P_1)
	{
		((IAuthenticationServiceEventHandler)P_0).SignedOut((IUser)P_1);
	}

	internal static void G7Ey1UWO3yu3dQ1xAZ4(object P_0, object P_1)
	{
		((ISession)P_0).Delete(P_1);
	}

	internal static int EYgNt9Wq8ELNxXpypkk(object P_0, bool P_1)
	{
		return ((IQuery)P_0).ExecuteUpdate(P_1);
	}

	internal static void GU3qwPWcXEYrIIitm2Z(object P_0, object P_1, object P_2)
	{
		((ICacheService)P_0).Remove((string)P_1, (string)P_2);
	}

	internal static void AvJP8iWGloXihZnNBcC(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static TimeSpan srLqGrWFg19qXvfAOJ8(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static bool OiZmjFW0GZgp3EeP9sJ(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 > P_1;
	}

	internal static TimeSpan ftJpkOWEmq7wmTLDfHa(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}

	internal static object epy2FDWDfARnJ0gQrqo(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}
}
