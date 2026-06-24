using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Models.API;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Managers;

public class ClientSessionDataSetsManager : EntityManager<IClientSessionDataSets, long>
{
	private static readonly string SessionTokenPropName;

	private static ClientSessionDataSetsManager K7Wb6wDKb8aKrM15TdY;

	public new ClientSessionDataSetsManager Instance => Locator.GetServiceNotNull<ClientSessionDataSetsManager>();

	protected override void SetupAutoFilter(ICriteria criteria, IEntityFilter filter, EntityMetadata metadata, string alias = null)
	{
		int num = 2;
		int num2 = num;
		IPublicClientSessionFilter publicClientSessionFilter = default(IPublicClientSessionFilter);
		while (true)
		{
			switch (num2)
			{
			default:
				if (!b7oFN9DqduEDRD61VZe(dkOEYaDOxFKb2vhKAVj(publicClientSessionFilter)))
				{
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 2:
				publicClientSessionFilter = filter as IPublicClientSessionFilter;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (publicClientSessionFilter != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				XZTB5sDEiwDGyi6UM8d(this, criteria, filter, metadata, alias);
				num2 = 6;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d == 0)
				{
					num2 = 6;
				}
				break;
			case 4:
				((IPublicClientSessionFilter)filter).SessionToken = null;
				num2 = 3;
				break;
			case 6:
				return;
			case 5:
				nMhGLKD0qIylyap6B4L(criteria, Restrictions.Eq((string)(vUXvOmDc8o3Vdwd9wqK(alias) ? SessionTokenPropName : TGlgdxDFZDWOqiX1gDC(YnE4oBDGASBisQVQBui(-1757426405 ^ -1757446635), alias, SessionTokenPropName)), dkOEYaDOxFKb2vhKAVj(publicClientSessionFilter)));
				num2 = 4;
				break;
			}
		}
	}

	public IClientSessionDataSets FindByToken(string sessionToken)
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			default:
				text = (string)TGlgdxDFZDWOqiX1gDC(YnE4oBDGASBisQVQBui(-1757426405 ^ -1757446597), serviceNotNull.NoLockTableExpression((string)YnE4oBDGASBisQVQBui(0x46347DA6 ^ 0x4634CE2E), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-959661060 ^ -959707062)), oAaKXSDD2tqwVJi8jL8(serviceNotNull.Dialect, SessionTokenPropName));
				num2 = 3;
				break;
			case 3:
				return ((IQuery)gINIsxDIgj0n9nEIPiu(TvSiBlDYWcCnV0T5fV5(((ISession)tLtWKADM4ih3FETLFuZ(this)).CreateSQLQuery(text).AddEntity((string)YnE4oBDGASBisQVQBui(0x4CD4C8A0 ^ 0x4CD47B62), pLYLyKDsmG9lcipdp9n(this, null)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4E6718AE ^ 0x4E67AB64), sessionToken), false)).UniqueResult<IClientSessionDataSets>();
			case 2:
				if (b7oFN9DqduEDRD61VZe(sessionToken))
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
					{
						num2 = 1;
					}
					break;
				}
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return null;
			}
		}
	}

	public ClientSessionDataSetsManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BDsesLD4ladUmjCUsgp();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ClientSessionDataSetsManager()
	{
		int num = 3;
		int num2 = num;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				parameterExpression = (ParameterExpression)ojNs5fDQsNQ465LhAxp(aR1kNpDV0UciJjYj89S(typeof(IClientSessionDataSets).TypeHandle), YnE4oBDGASBisQVQBui(0x7A093321 ^ 0x7A091893));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2c264a158ded4d26bea0177e79c88bc4 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				SessionTokenPropName = LinqUtils.NameOf(Expression.Lambda<Func<IClientSessionDataSets, object>>(Expression.Property(parameterExpression, (MethodInfo)OGW8JZDdyaWfaj3hC6S((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				BDsesLD4ladUmjCUsgp();
				num2 = 2;
				break;
			}
		}
	}

	internal static object dkOEYaDOxFKb2vhKAVj(object P_0)
	{
		return ((IPublicClientSessionFilter)P_0).SessionToken;
	}

	internal static bool b7oFN9DqduEDRD61VZe(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static bool vUXvOmDc8o3Vdwd9wqK(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object YnE4oBDGASBisQVQBui(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object TGlgdxDFZDWOqiX1gDC(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object nMhGLKD0qIylyap6B4L(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static void XZTB5sDEiwDGyi6UM8d(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		((EntityManager<IClientSessionDataSets, long>)P_0).SetupAutoFilter((ICriteria)P_1, (IEntityFilter)P_2, (EntityMetadata)P_3, (string)P_4);
	}

	internal static bool xogXBWDtCMq5O2UDeNC()
	{
		return K7Wb6wDKb8aKrM15TdY == null;
	}

	internal static ClientSessionDataSetsManager DhslaGDh29BQN4f82ey()
	{
		return K7Wb6wDKb8aKrM15TdY;
	}

	internal static object oAaKXSDD2tqwVJi8jL8(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object tLtWKADM4ih3FETLFuZ(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static Type pLYLyKDsmG9lcipdp9n(object P_0, object P_1)
	{
		return ((EntityManager<IClientSessionDataSets, long>)P_0).GetFetchType((IEntityFilter)P_1);
	}

	internal static object TvSiBlDYWcCnV0T5fV5(object P_0, object P_1, object P_2)
	{
		return ((IQuery)P_0).SetString((string)P_1, (string)P_2);
	}

	internal static object gINIsxDIgj0n9nEIPiu(object P_0, bool P_1)
	{
		return ((IQuery)P_0).CleanUpCache(P_1);
	}

	internal static void BDsesLD4ladUmjCUsgp()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static Type aR1kNpDV0UciJjYj89S(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object ojNs5fDQsNQ465LhAxp(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object OGW8JZDdyaWfaj3hC6S(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}
}
