using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models.API;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Managers;

public class PublicApplicationTokenManager : EntityManager<IPublicApplicationToken, long>
{
	private static readonly string TokenPropName;

	private static PublicApplicationTokenManager YkACuusUZpfba1Zhs6Z;

	public new static PublicApplicationTokenManager Instance => Locator.GetServiceNotNull<PublicApplicationTokenManager>();

	protected override void SetupAutoFilter(ICriteria criteria, IEntityFilter filter, EntityMetadata metadata, string alias = null)
	{
		int num = 1;
		int num2 = num;
		IPublicApplicationTokenFilter publicApplicationTokenFilter = default(IPublicApplicationTokenFilter);
		while (true)
		{
			switch (num2)
			{
			case 6:
				YVGNQFsF6ghVuDkkevC(this, criteria, filter, metadata, alias);
				num2 = 5;
				break;
			case 5:
				return;
			case 2:
				if (!DqVYhmsK96NWBM3HiBG(publicApplicationTokenFilter.Token))
				{
					num2 = 4;
					break;
				}
				goto case 6;
			case 1:
				publicApplicationTokenFilter = filter as IPublicApplicationTokenFilter;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (publicApplicationTokenFilter != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 6;
			case 3:
				S6S7W3sG9Ghkp8m9AyT((IPublicApplicationTokenFilter)filter, null);
				num2 = 6;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
				{
					num2 = 6;
				}
				break;
			case 4:
				PelqZbscmLYKOOVBpqF(criteria, joJZU2sqC19KG4rEvQc(string.IsNullOrEmpty(alias) ? TokenPropName : YnbB66shnSg0iX1Wrnh(vrFuNDstPPKtA7SgrJf(0x3B1D6430 ^ 0x3B1DD73E), alias, TokenPropName), tOdrfZsOyfaI9y878f5(publicApplicationTokenFilter)));
				num2 = 3;
				break;
			}
		}
	}

	public IPublicApplicationToken FindByToken(string applicationToken)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				if (DqVYhmsK96NWBM3HiBG(applicationToken))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 != 0)
					{
						num2 = 0;
					}
					break;
				}
				object obj = ysKDldsE41MX3SWkAOt(this, new FetchOptions(0, 1), STv33js090ChwIpcGKf(this, null), null, null);
				PelqZbscmLYKOOVBpqF(obj, joJZU2sqC19KG4rEvQc(TokenPropName, applicationToken));
				uoIKq3sMTUjXdKNj7u6(Bc87cHsDS8JZv0nTgfn(obj, true), vrFuNDstPPKtA7SgrJf(-1329706983 ^ -1329663503));
				return ((ICriteria)obj).UniqueResult<IPublicApplicationToken>();
			}
			default:
				return null;
			}
		}
	}

	[PublicApiMember]
	public override void Delete(IPublicApplicationToken obj)
	{
		//Discarded unreachable code: IL_0083
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (mrO3ftsYCvxJ8P5wFDM(c50K5Zssq024UM3jKF3(this), PermissionProvider.APIAdminPermission))
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 == 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 0:
				return;
			case 3:
				return;
			case 1:
				base.Delete(obj);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void Delete(string query)
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
				if (!mrO3ftsYCvxJ8P5wFDM(c50K5Zssq024UM3jKF3(this), PermissionProvider.APIAdminPermission))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
					{
						num2 = 0;
					}
					break;
				}
				base.Delete(query);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad != 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			case 2:
				return;
			}
		}
	}

	public override void DeleteAll()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 0:
				return;
			case 2:
				if (mrO3ftsYCvxJ8P5wFDM(c50K5Zssq024UM3jKF3(this), PermissionProvider.APIAdminPermission))
				{
					x59d3XsI7x4P2eqLx7W(this);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
					{
						num2 = 1;
					}
				}
				break;
			}
		}
	}

	public PublicApplicationTokenManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PublicApplicationTokenManager()
	{
		int num = 2;
		int num2 = num;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			case 1:
				parameterExpression = (ParameterExpression)AupqaJsQlmFnlsJKrs7(JCP007sVh4UN15sy59I(typeof(IPublicApplicationToken).TypeHandle), vrFuNDstPPKtA7SgrJf(0x6A336151 ^ 0x6A334AE3));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			default:
				TokenPropName = LinqUtils.NameOf(Expression.Lambda<Func<IPublicApplicationToken, object>>((Expression)AV9fpVsTLrIIRrxJlkd(parameterExpression, (MethodInfo)rmhKD7sdwvqlFtf522J((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 3;
				break;
			case 2:
				VkbFZMs4TBrOtKtubh8();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool DqVYhmsK96NWBM3HiBG(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object vrFuNDstPPKtA7SgrJf(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object YnbB66shnSg0iX1Wrnh(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object tOdrfZsOyfaI9y878f5(object P_0)
	{
		return ((IPublicApplicationTokenFilter)P_0).Token;
	}

	internal static object joJZU2sqC19KG4rEvQc(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object PelqZbscmLYKOOVBpqF(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static void S6S7W3sG9Ghkp8m9AyT(object P_0, object P_1)
	{
		((IPublicApplicationTokenFilter)P_0).Token = (string)P_1;
	}

	internal static void YVGNQFsF6ghVuDkkevC(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		((EntityManager<IPublicApplicationToken, long>)P_0).SetupAutoFilter((ICriteria)P_1, (IEntityFilter)P_2, (EntityMetadata)P_3, (string)P_4);
	}

	internal static bool aMMpMrsoiI9MPuyHWsg()
	{
		return YkACuusUZpfba1Zhs6Z == null;
	}

	internal static PublicApplicationTokenManager aGYcwlsJriOasU2GmF6()
	{
		return YkACuusUZpfba1Zhs6Z;
	}

	internal static Type STv33js090ChwIpcGKf(object P_0, object P_1)
	{
		return ((EntityManager<IPublicApplicationToken, long>)P_0).GetFetchType((IEntityFilter)P_1);
	}

	internal static object ysKDldsE41MX3SWkAOt(object P_0, object P_1, Type P_2, object P_3, object P_4)
	{
		return ((EntityManager<IPublicApplicationToken, long>)P_0).CreateCriteria((FetchOptions)P_1, P_2, (string)P_3, (IEntityFilter)P_4);
	}

	internal static object Bc87cHsDS8JZv0nTgfn(object P_0, bool P_1)
	{
		return ((ICriteria)P_0).SetCacheable(P_1);
	}

	internal static object uoIKq3sMTUjXdKNj7u6(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetCacheRegion((string)P_1);
	}

	internal static object c50K5Zssq024UM3jKF3(object P_0)
	{
		return ((EntityManager<IPublicApplicationToken, long>)P_0).SecurityService;
	}

	internal static bool mrO3ftsYCvxJ8P5wFDM(object P_0, object P_1)
	{
		return ((ISecurityService)P_0).HasPermission((Permission)P_1);
	}

	internal static void x59d3XsI7x4P2eqLx7W(object P_0)
	{
		((EntityManager<IPublicApplicationToken, long>)P_0).DeleteAll();
	}

	internal static void VkbFZMs4TBrOtKtubh8()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static Type JCP007sVh4UN15sy59I(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object AupqaJsQlmFnlsJKrs7(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object rmhKD7sdwvqlFtf522J(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object AV9fpVsTLrIIRrxJlkd(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}
}
