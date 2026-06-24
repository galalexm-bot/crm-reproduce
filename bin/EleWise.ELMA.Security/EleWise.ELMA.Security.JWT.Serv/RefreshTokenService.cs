using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.JWT.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Linq;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.JWT.Services;

[Service]
internal class RefreshTokenService : IRefreshTokenService
{
	private readonly ICacheService cacheService;

	private readonly ISessionProvider sessionProvider;

	private readonly IJwtTokenService jwtTokenService;

	private readonly byte[] secret;

	internal static RefreshTokenService pduuZNgx6QcD8V5CDm9;

	private TimeSpan TokenDuration => crWPwrgMxhfIyMX133k(SR.GetSetting((string)zhXWe9gwJBpA8FGm5ai(-1943394692 ^ -1943351626), 240.0));

	private ISession Session => sessionProvider.GetSession(string.Empty);

	public RefreshTokenService(ICacheService cacheService, ISessionProvider sessionProvider, IJwtTokenService jwtTokenService)
	{
		//Discarded unreachable code: IL_0037, IL_003c
		el2vCBgmAMQ2moLpmM1();
		secret = new byte[32]
		{
			75, 52, 72, 57, 113, 119, 66, 75, 108, 90,
			121, 83, 55, 119, 102, 112, 112, 106, 70, 106,
			113, 119, 65, 75, 89, 78, 79, 65, 69, 116,
			53, 56
		};
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 2:
				this.cacheService = cacheService;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				this.jwtTokenService = jwtTokenService;
				num = 3;
				break;
			default:
				this.sessionProvider = sessionProvider;
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual string CreateToken(AuthInfoContainer authInfo)
	{
		int num = 2;
		IDictionary<string, string> dictionary = default(IDictionary<string, string>);
		RefreshToken refreshToken2 = default(RefreshToken);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					dictionary = authInfo.ToDictionary();
					num2 = 4;
					continue;
				case 4:
					break;
				case 6:
					NL6VmkgREa3fhy5Ux45(Session, refreshToken2);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					TokenToCache(refreshToken2, TokenDuration);
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					Contract.ArgumentNotNull(authInfo, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x23D92C6F ^ 0x23D9CB17));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					return jwtTokenService.CreateToken(dictionary, secret, TokenDuration).ToString();
				case 1:
				{
					RefreshToken refreshToken = new RefreshToken();
					M6WDdDgLdwx92J5HCnW(refreshToken, WDV9m1getiHZwC7jKN4(authInfo));
					S7YkitgHENNVlqAawJP(refreshToken, yp3fOFgjSweeQWVfxJT(authInfo));
					refreshToken.ExpireDate = guqdhFgaYff1Nyt8vSI().Add(TokenDuration);
					refreshToken2 = refreshToken;
					num2 = 6;
					continue;
				}
				}
				break;
			}
			dictionary.Add((string)zhXWe9gwJBpA8FGm5ai(-698589567 ^ -698566973), i2yF6Hg2slBajvD43ie(refreshToken2).ToString());
			num = 5;
		}
	}

	[Transaction]
	public virtual AuthInfoContainer GetAuthInfo(string refreshToken)
	{
		//Discarded unreachable code: IL_0055, IL_0064
		int num = 10;
		Guid guid = default(Guid);
		IDictionary<string, string> validatedPayload = default(IDictionary<string, string>);
		string tokenCacheKey = default(string);
		RefreshToken refreshToken2 = default(RefreshToken);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					guid = ehdflGgvONJOWPQLZK5(validatedPayload[(string)zhXWe9gwJBpA8FGm5ai(0xA5DAE86 ^ 0xA5D46C4)]);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					return validatedPayload.ToAuthInfo();
				case 3:
					RemoveToken(guid);
					num2 = 12;
					continue;
				case 11:
					tokenCacheKey = GetTokenCacheKey(guid);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 != 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					return validatedPayload.ToAuthInfo();
				case 6:
					refreshToken2 = Session.Get<RefreshToken>((object)guid);
					num2 = 7;
					continue;
				default:
					validatedPayload.Remove(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA4E904F ^ 0xA4E780D));
					num2 = 11;
					continue;
				case 4:
					return null;
				case 9:
					validatedPayload = jwtTokenService.GetValidatedPayload(refreshToken, secret);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b != 0)
					{
						num2 = 2;
					}
					continue;
				case 10:
					SObyI9gP6ZwJsnMk5mw(refreshToken, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1195916818 ^ -1195956714));
					num2 = 9;
					continue;
				case 2:
					break;
				case 1:
				{
					if (!cacheService.TryGetValue<object>(tokenCacheKey, (string)zhXWe9gwJBpA8FGm5ai(-236222459 ^ -236232537), out var _))
					{
						num2 = 6;
						continue;
					}
					goto case 3;
				}
				case 7:
					if (refreshToken2 != null)
					{
						RemoveToken(refreshToken2);
						num2 = 8;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 == 0)
						{
							num2 = 5;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd == 0)
						{
							num2 = 4;
						}
					}
					continue;
				}
				break;
			}
			Contract.CheckWithMessage<ArgumentException>(validatedPayload.ContainsKey((string)zhXWe9gwJBpA8FGm5ai(0x4177C82C ^ 0x4177206E)), SR.T((string)zhXWe9gwJBpA8FGm5ai(0x3B1D6430 ^ 0x3B1D8C60), zhXWe9gwJBpA8FGm5ai(0x8875F5C ^ 0x887B8A4)));
			num = 5;
		}
	}

	[Transaction]
	public virtual void Revoke(AuthInfoContainer authInfo)
	{
		//Discarded unreachable code: IL_01ad, IL_01bc, IL_01c7, IL_0296, IL_02a9, IL_02b8
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		List<Guid>.Enumerator enumerator = default(List<Guid>.Enumerator);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
			{
				IQueryable<RefreshToken> source2 = Session.Query<RefreshToken>();
				ParameterExpression parameterExpression = (ParameterExpression)Wv6v3QgUgDZg5lkBFZq(typeof(RefreshToken), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4BBFF2C6 ^ 0x4BBFD974));
				IQueryable<RefreshToken> source3 = source2.Where(Expression.Lambda<Func<RefreshToken, bool>>(Expression.AndAlso((Expression)A5byOpgq2gXMnGR0rSx(Expression.Property(parameterExpression, (MethodInfo)d9IxiygovKpnwrSSWbs((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), oba7cegO2fDwtpFlBWO(VysU6UghUKgcVCFhDuE(QYqx13gKJHBfRORNur7(_003C_003Ec__DisplayClass10_, y5IhhugJXxNR2fBteTi(typeof(_003C_003Ec__DisplayClass10_0).TypeHandle)), gOUeGAgtuxYUqihx4hw((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)d9IxiygovKpnwrSSWbs((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)A5byOpgq2gXMnGR0rSx(oba7cegO2fDwtpFlBWO(parameterExpression, (MethodInfo)d9IxiygovKpnwrSSWbs((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), oba7cegO2fDwtpFlBWO(VysU6UghUKgcVCFhDuE(QYqx13gKJHBfRORNur7(_003C_003Ec__DisplayClass10_, y5IhhugJXxNR2fBteTi(typeof(_003C_003Ec__DisplayClass10_0).TypeHandle)), gOUeGAgtuxYUqihx4hw((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)))), new ParameterExpression[1] { parameterExpression }));
				parameterExpression = (ParameterExpression)Wv6v3QgUgDZg5lkBFZq(y5IhhugJXxNR2fBteTi(typeof(RefreshToken).TypeHandle), zhXWe9gwJBpA8FGm5ai(-848444002 ^ -848433620));
				enumerator = source3.Select(Expression.Lambda<Func<RefreshToken, Guid>>((Expression)oba7cegO2fDwtpFlBWO(parameterExpression, (MethodInfo)d9IxiygovKpnwrSSWbs((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).ToList().GetEnumerator();
				num2 = 6;
				break;
			}
			case 1:
				return;
			case 2:
				_003C_003Ec__DisplayClass10_.authInfo = authInfo;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 == 0)
				{
					num2 = 5;
				}
				break;
			case 6:
				try
				{
					while (true)
					{
						IL_020d:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 == 0)
							{
								num3 = 3;
							}
							goto IL_01cb;
						}
						goto IL_01e5;
						IL_01e5:
						text = (string)T5tgVogcfVrvoTCtPn9(enumerator.Current);
						num3 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d == 0)
						{
							num3 = 0;
						}
						goto IL_01cb;
						IL_01cb:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto IL_020d;
							case 2:
								SnlnoIgG3hJLufE5DOe(cacheService, text, zhXWe9gwJBpA8FGm5ai(-730071140 ^ -730130626));
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 != 0)
								{
									num3 = 0;
								}
								continue;
							case 3:
								goto end_IL_020d;
							}
							break;
						}
						goto IL_01e5;
						continue;
						end_IL_020d:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto default;
			default:
			{
				IQueryable<RefreshToken> source = Session.Query<RefreshToken>();
				ParameterExpression parameterExpression = (ParameterExpression)Wv6v3QgUgDZg5lkBFZq(typeof(RefreshToken), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x50A2A0A3 ^ 0x50A28B11));
				DmlExtensionMethods.Delete<RefreshToken>(source.Where(Expression.Lambda<Func<RefreshToken, bool>>((Expression)xTbmRYgFFpmSc11wEni(A5byOpgq2gXMnGR0rSx(oba7cegO2fDwtpFlBWO(parameterExpression, (MethodInfo)d9IxiygovKpnwrSSWbs((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), oba7cegO2fDwtpFlBWO(VysU6UghUKgcVCFhDuE(QYqx13gKJHBfRORNur7(_003C_003Ec__DisplayClass10_, y5IhhugJXxNR2fBteTi(typeof(_003C_003Ec__DisplayClass10_0).TypeHandle)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), A5byOpgq2gXMnGR0rSx(oba7cegO2fDwtpFlBWO(parameterExpression, (MethodInfo)d9IxiygovKpnwrSSWbs((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), oba7cegO2fDwtpFlBWO(Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass10_, y5IhhugJXxNR2fBteTi(typeof(_003C_003Ec__DisplayClass10_0).TypeHandle)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)d9IxiygovKpnwrSSWbs((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)))), new ParameterExpression[1] { parameterExpression })));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 3:
				_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
				num2 = 2;
				break;
			case 5:
				AlfxnNgCGKBDXYI0NcV(_003C_003Ec__DisplayClass10_.authInfo, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2121ECF9 ^ 0x21210B81));
				num2 = 4;
				break;
			}
		}
	}

	[Transaction]
	public virtual void RemoveExpired()
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
				_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				_003C_003Ec__DisplayClass11_.now = guqdhFgaYff1Nyt8vSI();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			IQueryable<RefreshToken> source = Session.Query<RefreshToken>();
			ParameterExpression parameterExpression = (ParameterExpression)Wv6v3QgUgDZg5lkBFZq(y5IhhugJXxNR2fBteTi(typeof(RefreshToken).TypeHandle), zhXWe9gwJBpA8FGm5ai(0x8875F5C ^ 0x88774EE));
			DmlExtensionMethods.Delete<RefreshToken>(source.Where(Expression.Lambda<Func<RefreshToken, bool>>((Expression)s6Iojrg0P8eyGmAEk2A(oba7cegO2fDwtpFlBWO(parameterExpression, (MethodInfo)d9IxiygovKpnwrSSWbs((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field((Expression)QYqx13gKJHBfRORNur7(_003C_003Ec__DisplayClass11_, y5IhhugJXxNR2fBteTi(typeof(_003C_003Ec__DisplayClass11_0).TypeHandle)), (FieldInfo)gOUeGAgtuxYUqihx4hw((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), false, (MethodInfo)d9IxiygovKpnwrSSWbs((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
			num2 = 3;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 == 0)
			{
				num2 = 2;
			}
		}
	}

	private void TokenToCache(RefreshToken token, TimeSpan duration)
	{
		int num = 1;
		int num2 = num;
		string tokenCacheKey = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				tokenCacheKey = GetTokenCacheKey(token.Uid);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				cacheService.Insert(tokenCacheKey, token, (string)zhXWe9gwJBpA8FGm5ai(-192929954 ^ -192874500), duration);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void RemoveToken(Guid tokenUid)
	{
		int num = 2;
		int num2 = num;
		string tokenCacheKey = default(string);
		RefreshToken refreshToken = default(RefreshToken);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				tokenCacheKey = GetTokenCacheKey(tokenUid);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				p9V7bigEwl1Lp0lIUqm(Session, refreshToken);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				cacheService.Remove(tokenCacheKey, (string)zhXWe9gwJBpA8FGm5ai(-1076846736 ^ -1076856878));
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				refreshToken = Session.Get<RefreshToken>((object)tokenUid);
				num2 = 5;
				break;
			case 0:
				return;
			case 5:
				if (refreshToken == null)
				{
					return;
				}
				num2 = 4;
				break;
			}
		}
	}

	private void RemoveToken(RefreshToken token)
	{
		int num = 3;
		int num2 = num;
		string tokenCacheKey = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				SnlnoIgG3hJLufE5DOe(cacheService, tokenCacheKey, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x71CDF2F ^ 0x71C378D));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				tokenCacheKey = GetTokenCacheKey(i2yF6Hg2slBajvD43ie(token));
				num2 = 2;
				break;
			case 1:
				Session.Delete((object)token);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private static string GetTokenCacheKey(Guid token)
	{
		return (string)EaXnEXgDEQqF1HmWgMk(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31C71464 ^ 0x31C7FCA4), token);
	}

	internal static void el2vCBgmAMQ2moLpmM1()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool mqhuc4gBRAMFp507Owl()
	{
		return pduuZNgx6QcD8V5CDm9 == null;
	}

	internal static RefreshTokenService kjmLoHguDvQj8AFi6tX()
	{
		return pduuZNgx6QcD8V5CDm9;
	}

	internal static long WDV9m1getiHZwC7jKN4(object P_0)
	{
		return ((AuthInfoContainer)P_0).UserId;
	}

	internal static void M6WDdDgLdwx92J5HCnW(object P_0, long value)
	{
		((RefreshToken)P_0).UserId = value;
	}

	internal static object yp3fOFgjSweeQWVfxJT(object P_0)
	{
		return ((AuthInfoContainer)P_0).ApplicationToken;
	}

	internal static void S7YkitgHENNVlqAawJP(object P_0, object P_1)
	{
		((RefreshToken)P_0).ApplicationToken = (string)P_1;
	}

	internal static DateTime guqdhFgaYff1Nyt8vSI()
	{
		return DateTime.Now;
	}

	internal static object NL6VmkgREa3fhy5Ux45(object P_0, object P_1)
	{
		return ((ISession)P_0).Save(P_1);
	}

	internal static object zhXWe9gwJBpA8FGm5ai(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Guid i2yF6Hg2slBajvD43ie(object P_0)
	{
		return ((RefreshToken)P_0).Uid;
	}

	internal static void SObyI9gP6ZwJsnMk5mw(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static Guid ehdflGgvONJOWPQLZK5(object P_0)
	{
		return Guid.Parse((string)P_0);
	}

	internal static void AlfxnNgCGKBDXYI0NcV(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object Wv6v3QgUgDZg5lkBFZq(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object d9IxiygovKpnwrSSWbs(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static Type y5IhhugJXxNR2fBteTi(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object QYqx13gKJHBfRORNur7(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object gOUeGAgtuxYUqihx4hw(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object VysU6UghUKgcVCFhDuE(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object oba7cegO2fDwtpFlBWO(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object A5byOpgq2gXMnGR0rSx(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static object T5tgVogcfVrvoTCtPn9(Guid token)
	{
		return GetTokenCacheKey(token);
	}

	internal static void SnlnoIgG3hJLufE5DOe(object P_0, object P_1, object P_2)
	{
		((ICacheService)P_0).Remove((string)P_1, (string)P_2);
	}

	internal static object xTbmRYgFFpmSc11wEni(object P_0, object P_1)
	{
		return Expression.AndAlso((Expression)P_0, (Expression)P_1);
	}

	internal static object s6Iojrg0P8eyGmAEk2A(object P_0, object P_1, bool P_2, object P_3)
	{
		return Expression.LessThan((Expression)P_0, (Expression)P_1, P_2, (MethodInfo)P_3);
	}

	internal static void p9V7bigEwl1Lp0lIUqm(object P_0, object P_1)
	{
		((ISession)P_0).Delete(P_1);
	}

	internal static object EaXnEXgDEQqF1HmWgMk(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static TimeSpan crWPwrgMxhfIyMX133k(double P_0)
	{
		return TimeSpan.FromHours(P_0);
	}
}
