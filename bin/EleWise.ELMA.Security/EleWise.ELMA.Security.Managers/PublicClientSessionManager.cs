using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Models.API;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Managers;

public class PublicClientSessionManager : EntityManager<IPublicClientSession, long>
{
	private static readonly string SessionTokenPropName;

	private static readonly string AuthTokenPropName;

	private static readonly string AuthUserPropName;

	private static PublicClientSessionManager awKdmkYYwaEIKCwTBNE;

	public new static PublicClientSessionManager Instance => Locator.GetServiceNotNull<PublicClientSessionManager>();

	protected override void SetupAutoFilter(ICriteria criteria, IEntityFilter filter, EntityMetadata metadata, string alias = null)
	{
		int num = 5;
		int num2 = num;
		IPublicClientSessionFilter publicClientSessionFilter = default(IPublicClientSessionFilter);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 6:
				if (!string.IsNullOrWhiteSpace((string)XLZHnrYVQnIRwLEfhFn(publicClientSessionFilter)))
				{
					num2 = 3;
					break;
				}
				goto case 1;
			case 5:
				publicClientSessionFilter = filter as IPublicClientSessionFilter;
				num2 = 4;
				break;
			case 1:
				Rkyoq2Y3n7GZfRp1Nug(this, criteria, filter, metadata, alias);
				num2 = 2;
				break;
			case 4:
				if (publicClientSessionFilter != null)
				{
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 1;
			default:
				jCJpcWYrTnA3KjhIFUW((IPublicClientSessionFilter)filter, null);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				v5QsXKY8QJg3TLo0I6S(criteria, dxKcahYg6tykDjErANA(XvKsSjYQ3vbtuhIrHF5(alias) ? SessionTokenPropName : oT5DkOYTYIx8QaRMQWv(OxW3QMYddMk1oDnTbiQ(0x4E6718AE ^ 0x4E67ABA0), alias, SessionTokenPropName), XLZHnrYVQnIRwLEfhFn(publicClientSessionFilter)));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IPublicClientSession FindByToken(string sessionToken)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return ((IQuery)rngssEY1RVT1ZhkJZgs(hH0cGwYfy28BPNQ0UTq(((ISession)pt0PRvYSh29KJH7LHpg(this)).CreateSQLQuery(text), OxW3QMYddMk1oDnTbiQ(0x2C648300 ^ 0x2C6430C2), rEZYfRY9xTIwRjHo3WW(this, null)), OxW3QMYddMk1oDnTbiQ(-1195916818 ^ -1195937244), sessionToken)).CleanUpCache(cleanUpCache: false).UniqueResult<IPublicClientSession>();
			case 2:
				text = (string)oT5DkOYTYIx8QaRMQWv(OxW3QMYddMk1oDnTbiQ(0x7A093321 ^ 0x7A098001), QlF1oBYyLuHrgFbdpfh(serviceNotNull, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-208231202 ^ -208266812), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x38328F00 ^ 0x38323CB6)), pMjJkIYbWTNghdRKA7q(serviceNotNull.Dialect, SessionTokenPropName));
				num2 = 3;
				break;
			default:
				return null;
			case 1:
				if (!string.IsNullOrWhiteSpace(sessionToken))
				{
					serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 == 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	public IPublicClientSession FindByAuthToken(Guid authToken)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return ((IQuery)pJWwnjI5VU3uCf7pUn5(i3YUm4IpOw88nOwBRio(((ISQLQuery)eLOSjSIkCfSKZL01Luo(pt0PRvYSh29KJH7LHpg(this), text)).AddEntity(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1329706983 ^ -1329660965), rEZYfRY9xTIwRjHo3WW(this, null)), OxW3QMYddMk1oDnTbiQ(0x11C59687 ^ 0x11C5254D), authToken), false)).UniqueResult<IPublicClientSession>();
			case 1:
				if (authToken == Guid.Empty)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
					num2 = 3;
				}
				break;
			default:
				return null;
			case 3:
				text = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2121ECF9 ^ 0x21215FD9), QlF1oBYyLuHrgFbdpfh(serviceNotNull, OxW3QMYddMk1oDnTbiQ(-730071140 ^ -730119546), OxW3QMYddMk1oDnTbiQ(0x45F3B9A1 ^ 0x45F30A17)), pMjJkIYbWTNghdRKA7q(VBgTreYzlyvX06pRerk(serviceNotNull), AuthTokenPropName));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public IPublicClientSession FindByTokenUser(string sessionToken, EleWise.ELMA.Security.Models.IUser currentUser)
	{
		//Discarded unreachable code: IL_00f7, IL_0131, IL_0140
		int num = 12;
		IQuery val = default(IQuery);
		string text = default(string);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (currentUser != null)
					{
						goto end_IL_0012;
					}
					goto case 8;
				case 8:
					val = (IQuery)rngssEY1RVT1ZhkJZgs(hH0cGwYfy28BPNQ0UTq(eLOSjSIkCfSKZL01Luo(pt0PRvYSh29KJH7LHpg(this), text), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-426925384 ^ -426962566), rEZYfRY9xTIwRjHo3WW(this, null)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6547C338 ^ 0x654770F2), sessionToken);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 == 0)
					{
						num2 = 3;
					}
					break;
				case 4:
					serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
					num2 = 7;
					break;
				case 10:
					return null;
				case 11:
					if (currentUser == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				case 1:
					currentUser = ((IAuthenticationService)LEFpEJIWSrUHjRPOkqZ(this)).GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
					num2 = 4;
					break;
				case 3:
					if (currentUser == null)
					{
						num2 = 6;
						break;
					}
					goto default;
				default:
					mTYBLWIiI5C4Kri0PJy(val, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7CAA49C6 ^ 0x7CAA442C), currentUser);
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 != 0)
					{
						num2 = 9;
					}
					break;
				case 7:
					text = string.Format((string)OxW3QMYddMk1oDnTbiQ(0x46347DA6 ^ 0x4634CE86), QlF1oBYyLuHrgFbdpfh(serviceNotNull, OxW3QMYddMk1oDnTbiQ(-236222459 ^ -236243681), OxW3QMYddMk1oDnTbiQ(0x1869C442 ^ 0x186977F4)), serviceNotNull.Dialect.QuoteIfNeeded(SessionTokenPropName));
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b != 0)
					{
						num2 = 2;
					}
					break;
				case 6:
				case 9:
					return ((IQuery)pJWwnjI5VU3uCf7pUn5(val, false)).UniqueResult<IPublicClientSession>();
				case 12:
					if (!UQBJPZIAxCRRi6r6emA(sessionToken))
					{
						num2 = 11;
						break;
					}
					goto case 10;
				case 5:
					text = (string)BGFREhInyXUiy0PicdC(text, UZey3yIXkNANXx2Cvja(OxW3QMYddMk1oDnTbiQ(-1858473711 ^ -1858515883), pMjJkIYbWTNghdRKA7q(VBgTreYzlyvX06pRerk(serviceNotNull), AuthUserPropName)));
					num2 = 8;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	[Transaction]
	public virtual long DeleteExpired(DateTime expireDateTime)
	{
		//Discarded unreachable code: IL_005c, IL_006b
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (T8fRDOI6enP1m4BHytD(F0QMKbI7DH1cSSq0SDJ(this), PermissionProvider.APIAdminPermission))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return 0L;
			default:
				return ((ISession)pt0PRvYSh29KJH7LHpg(this)).Delete((string)UZey3yIXkNANXx2Cvja(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x40096392 ^ 0x4009D86C), rEZYfRY9xTIwRjHo3WW(this, null).FullName), (object)expireDateTime, (IType)(object)NHibernateUtil.DateTime);
			}
		}
	}

	[Transaction]
	internal virtual void DeleteByAuthUser(long authUser)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				text = string.Format((string)OxW3QMYddMk1oDnTbiQ(0x48E9668D ^ 0x48E9DBFB), pMjJkIYbWTNghdRKA7q(VBgTreYzlyvX06pRerk(NEeub5IlLhvNZp37fg6(this)), OxW3QMYddMk1oDnTbiQ(-1858473711 ^ -1858515957)), pMjJkIYbWTNghdRKA7q(VBgTreYzlyvX06pRerk(base.Transformation), AuthUserPropName));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				((ISession)pt0PRvYSh29KJH7LHpg(this)).Delete(text, (object)authUser, (IType)(object)NHibernateUtil.Int64);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public PublicClientSessionManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		CIW33pINCGZisLjcOGY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PublicClientSessionManager()
	{
		int num = 3;
		int num2 = num;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			case 4:
				SessionTokenPropName = LinqUtils.NameOf(Expression.Lambda<Func<IPublicClientSession, object>>((Expression)P9qVOsIB0XuWBqI3dT9(parameterExpression, (MethodInfo)vftMr2IxgZR93YUm7Yh((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 7;
				break;
			case 3:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
				num2 = 2;
				break;
			case 2:
				parameterExpression = Expression.Parameter(lEonx9IZmdaQsYOYX7x(typeof(IPublicClientSession).TypeHandle), (string)OxW3QMYddMk1oDnTbiQ(0x71BC7C31 ^ 0x71BC5783));
				num2 = 4;
				break;
			case 7:
				parameterExpression = (ParameterExpression)txPRBlIuufqsCNUBdD8(lEonx9IZmdaQsYOYX7x(typeof(IPublicClientSession).TypeHandle), OxW3QMYddMk1oDnTbiQ(0x32A45635 ^ 0x32A47D87));
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 != 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				AuthTokenPropName = LinqUtils.NameOf(Expression.Lambda<Func<IPublicClientSession, object>>((Expression)WwNg8EImfS9me7lmhON(Expression.Property(parameterExpression, (MethodInfo)vftMr2IxgZR93YUm7Yh((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), lEonx9IZmdaQsYOYX7x(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				parameterExpression = Expression.Parameter(lEonx9IZmdaQsYOYX7x(typeof(IPublicClientSession).TypeHandle), (string)OxW3QMYddMk1oDnTbiQ(0x4D3A45F ^ 0x4D38FED));
				num2 = 6;
				break;
			case 1:
				return;
			case 6:
				AuthUserPropName = LinqUtils.NameOf(Expression.Lambda<Func<IPublicClientSession, object>>(Expression.Property(parameterExpression, (MethodInfo)vftMr2IxgZR93YUm7Yh((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object XLZHnrYVQnIRwLEfhFn(object P_0)
	{
		return ((IPublicClientSessionFilter)P_0).SessionToken;
	}

	internal static bool XvKsSjYQ3vbtuhIrHF5(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object OxW3QMYddMk1oDnTbiQ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object oT5DkOYTYIx8QaRMQWv(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object dxKcahYg6tykDjErANA(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object v5QsXKY8QJg3TLo0I6S(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static void jCJpcWYrTnA3KjhIFUW(object P_0, object P_1)
	{
		((IPublicClientSessionFilter)P_0).SessionToken = (string)P_1;
	}

	internal static void Rkyoq2Y3n7GZfRp1Nug(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		((EntityManager<IPublicClientSession, long>)P_0).SetupAutoFilter((ICriteria)P_1, (IEntityFilter)P_2, (EntityMetadata)P_3, (string)P_4);
	}

	internal static bool s9DBQZYIlZindABQqLb()
	{
		return awKdmkYYwaEIKCwTBNE == null;
	}

	internal static PublicClientSessionManager rD70AUY40VWcCNRYISl()
	{
		return awKdmkYYwaEIKCwTBNE;
	}

	internal static object QlF1oBYyLuHrgFbdpfh(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).NoLockTableExpression((string)P_1, (string)P_2);
	}

	internal static object pMjJkIYbWTNghdRKA7q(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object pt0PRvYSh29KJH7LHpg(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static Type rEZYfRY9xTIwRjHo3WW(object P_0, object P_1)
	{
		return ((EntityManager<IPublicClientSession, long>)P_0).GetFetchType((IEntityFilter)P_1);
	}

	internal static object hH0cGwYfy28BPNQ0UTq(object P_0, object P_1, Type P_2)
	{
		return ((ISQLQuery)P_0).AddEntity((string)P_1, P_2);
	}

	internal static object rngssEY1RVT1ZhkJZgs(object P_0, object P_1, object P_2)
	{
		return ((IQuery)P_0).SetString((string)P_1, (string)P_2);
	}

	internal static object VBgTreYzlyvX06pRerk(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object eLOSjSIkCfSKZL01Luo(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static object i3YUm4IpOw88nOwBRio(object P_0, object P_1, Guid P_2)
	{
		return ((IQuery)P_0).SetGuid((string)P_1, P_2);
	}

	internal static object pJWwnjI5VU3uCf7pUn5(object P_0, bool P_1)
	{
		return ((IQuery)P_0).CleanUpCache(P_1);
	}

	internal static bool UQBJPZIAxCRRi6r6emA(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object LEFpEJIWSrUHjRPOkqZ(object P_0)
	{
		return ((EntityManager<IPublicClientSession, long>)P_0).AuthenticationService;
	}

	internal static object UZey3yIXkNANXx2Cvja(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object BGFREhInyXUiy0PicdC(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object mTYBLWIiI5C4Kri0PJy(object P_0, object P_1, object P_2)
	{
		return ((IQuery)P_0).SetEntity((string)P_1, P_2);
	}

	internal static object F0QMKbI7DH1cSSq0SDJ(object P_0)
	{
		return ((EntityManager<IPublicClientSession, long>)P_0).SecurityService;
	}

	internal static bool T8fRDOI6enP1m4BHytD(object P_0, object P_1)
	{
		return ((ISecurityService)P_0).HasPermission((Permission)P_1);
	}

	internal static object NEeub5IlLhvNZp37fg6(object P_0)
	{
		return ((EntityManager<IPublicClientSession, long>)P_0).Transformation;
	}

	internal static void CIW33pINCGZisLjcOGY()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static Type lEonx9IZmdaQsYOYX7x(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object vftMr2IxgZR93YUm7Yh(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object P9qVOsIB0XuWBqI3dT9(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object txPRBlIuufqsCNUBdD8(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object WwNg8EImfS9me7lmhON(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}
}
