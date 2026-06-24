using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.Impl;
using NHibernate.Loader;
using NHibernate.Loader.Criteria;
using NHibernate.Persister.Entity;
using NHibernate.SqlCommand;
using NHibernate.SqlTypes;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public static class NHibernateHelper
{
	private static IMetadataRuntimeService metadataService;

	internal static NHibernateHelper bTg2L2hzNgepw7r4iW8M;

	public static AbstractCriterion And(params AbstractCriterion[] criterions)
	{
		//Discarded unreachable code: IL_0049, IL_0058, IL_007d
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		int num = 2;
		int num3 = default(int);
		AbstractCriterion[] array = default(AbstractCriterion[]);
		Conjunction val2 = default(Conjunction);
		AbstractCriterion val = default(AbstractCriterion);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num3 < array.Length)
					{
						num2 = 8;
						continue;
					}
					break;
				case 7:
					num3 = 0;
					num2 = 5;
					continue;
				case 2:
					val2 = new Conjunction();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					array = criterions;
					num2 = 7;
					continue;
				case 3:
				case 8:
					val = array[num3];
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					goto end_IL_0012;
				case 6:
					break;
				}
				return (AbstractCriterion)(object)val2;
				continue;
				end_IL_0012:
				break;
			}
			pPyKp4hzaMQtG9SCgplB(val2, val);
			num = 9;
		}
	}

	public static AbstractCriterion And(IEnumerable<AbstractCriterion> criterions)
	{
		return And(criterions.ToArray());
	}

	public static AbstractCriterion Or(params AbstractCriterion[] criterions)
	{
		//Discarded unreachable code: IL_0098, IL_00a7
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		int num = 6;
		int num2 = num;
		AbstractCriterion val2 = default(AbstractCriterion);
		AbstractCriterion[] array = default(AbstractCriterion[]);
		int num3 = default(int);
		Disjunction val = default(Disjunction);
		while (true)
		{
			switch (num2)
			{
			default:
				val2 = array[num3];
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				num3 = 0;
				num2 = 3;
				break;
			case 3:
			case 4:
				if (num3 >= array.Length)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 5:
				array = criterions;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 3;
				}
				break;
			case 8:
				return (AbstractCriterion)(object)val;
			case 1:
				((Junction)val).Add((ICriterion)(object)val2);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				val = new Disjunction();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 5;
				}
				break;
			case 2:
				num3++;
				num2 = 4;
				break;
			}
		}
	}

	public static AbstractCriterion Or(IEnumerable<AbstractCriterion> criterions)
	{
		return Or(criterions.ToArray());
	}

	public static DetachedCriteria CreateFromCriteria(ICriteria criteria)
	{
		return (DetachedCriteria)(object)new ConvertedDetachedCriteria((ICriteria)eCHoX4hzDgKGp0UhQFuo(criteria));
	}

	[Obsolete("Use Restrictions.In instead", true)]
	public static AbstractCriterion In<T>(string propertyName, params T[] objects)
	{
		return Restrictions.In(propertyName, (ICollection)objects);
	}

	public static string ConvertToSqlQuery(ICriteria criteria)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		CriteriaImpl val = default(CriteriaImpl);
		CriteriaQueryTranslator val2 = default(CriteriaQueryTranslator);
		string[] array = default(string[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				val = (CriteriaImpl)criteria;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				val2 = new CriteriaQueryTranslator(((ISessionImplementor)v8JOEchztLerDJqawpcu(val)).get_Factory(), val, (string)E1jCBshzwUvT0waQ0ODb(val), CriteriaQueryTranslator.RootSqlAlias);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return dpnMZOhzHubTp2F4k3eB((object)new CriteriaJoinWalker((IOuterJoinLoadable)((ISessionFactoryImplementor)Y63teZhz4qgG6c88Ls9t(v8JOEchztLerDJqawpcu(val))).GetEntityPersister(array[0]), val2, (ISessionFactoryImplementor)Y63teZhz4qgG6c88Ls9t(v8JOEchztLerDJqawpcu(val)), (ICriteria)(object)val, (string)E1jCBshzwUvT0waQ0ODb(val), val.get_Session().get_EnabledFilters())).ToString();
			default:
				array = (string[])YqlKQghz6qBoZVv81Es6(Y63teZhz4qgG6c88Ls9t(v8JOEchztLerDJqawpcu(val)), E1jCBshzwUvT0waQ0ODb(val));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public static string ConvertToSqlQuery(DetachedCriteria detachedCriteria, ISession session)
	{
		return ConvertToSqlQuery(detachedCriteria.GetExecutableCriteria(session));
	}

	public static string GetCriteriaTypeUidPropertyName(EntityMetadata metadata)
	{
		return (string)SHgviJhz7meXBYdMdupW(P09xVBhzAAfR5gruTwDV(metadata));
	}

	public static string GetCriteriaTypeUidPropertyName(Guid typeUid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			IMetadataRuntimeService serviceNotNull;
			switch (num2)
			{
			case 2:
				return (string)eVJqqZhzxq0VvB3ULd1L(metadataService.GetTypeByUid(typeUid));
			case 1:
				serviceNotNull = metadataService;
				if (serviceNotNull != null)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
				break;
			}
			metadataService = serviceNotNull;
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
			{
				num2 = 0;
			}
		}
	}

	public static string GetCriteriaTypeUidPropertyName(Type type)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (qSuMqbhz09eh2yc9CVU5(typeof(IInheritable).TypeHandle).IsAssignableFrom(type))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return (string)ccqAcwhzmofdnbrySy5E(-1886646897 ^ -1886629907);
			case 1:
				return (string)ccqAcwhzmofdnbrySy5E(-87337865 ^ -87492015);
			}
		}
	}

	internal static IEnumerable<object> NullSafeSet(this ISessionImplementor session, IEnumerable<IType> types, IEnumerable<object> values)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
		CS_0024_003C_003E8__locals0.session = session;
		CS_0024_003C_003E8__locals0.sessionFactory = CS_0024_003C_003E8__locals0.session.get_Factory();
		CS_0024_003C_003E8__locals0.parameterTypes = new List<SqlType>();
		CS_0024_003C_003E8__locals0.index = 0;
		CS_0024_003C_003E8__locals0.typeIndexes = types.Select(delegate(IType type)
		{
			CS_0024_003C_003E8__locals0.parameterTypes.AddRange(type.SqlTypes((IMapping)(object)CS_0024_003C_003E8__locals0.sessionFactory));
			var result = new { type, CS_0024_003C_003E8__locals0.index };
			CS_0024_003C_003E8__locals0.index += type.GetColumnSpan((IMapping)(object)CS_0024_003C_003E8__locals0.sessionFactory);
			return result;
		}).ToArray();
		CS_0024_003C_003E8__locals0.command = CS_0024_003C_003E8__locals0.sessionFactory.get_ConnectionProvider().get_Driver().GenerateCommand(CommandType.Text, new SqlString(""), CS_0024_003C_003E8__locals0.parameterTypes.ToArray());
		values.ForEach(delegate(object v, int i)
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
					_003C_003Ec__DisplayClass13_0.WpwQYPv9bKsCrcUJWasa(CS_0024_003C_003E8__locals0.typeIndexes[i].type, CS_0024_003C_003E8__locals0.command, v, CS_0024_003C_003E8__locals0.typeIndexes[i].index, CS_0024_003C_003E8__locals0.session);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		return from IDbDataParameter p in CS_0024_003C_003E8__locals0.command.Parameters
			select p.Value;
	}

	[AsyncStateMachine(typeof(_003CNullSafeSetAsync_003Ed__14))]
	internal static Task<IEnumerable<object>> NullSafeSetAsync(this ISessionImplementor session, IEnumerable<IType> types, IEnumerable<object> values, CancellationToken cancellationToken)
	{
		_003CNullSafeSetAsync_003Ed__14 stateMachine = default(_003CNullSafeSetAsync_003Ed__14);
		stateMachine.session = session;
		stateMachine.types = types;
		stateMachine.values = values;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IEnumerable<object>>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IEnumerable<object>> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	static NHibernateHelper()
	{
		t2gIEShzyFYqZaOZKkbQ();
	}

	internal static object pPyKp4hzaMQtG9SCgplB(object P_0, object P_1)
	{
		return ((Junction)P_0).Add((ICriterion)P_1);
	}

	internal static bool tDD1wjhz3Bx48uBQjX7U()
	{
		return bTg2L2hzNgepw7r4iW8M == null;
	}

	internal static NHibernateHelper nbFlcchzpyN4SbWb1qbk()
	{
		return bTg2L2hzNgepw7r4iW8M;
	}

	internal static object eCHoX4hzDgKGp0UhQFuo(object P_0)
	{
		return CriteriaTransformer.Clone((ICriteria)P_0);
	}

	internal static object v8JOEchztLerDJqawpcu(object P_0)
	{
		return ((CriteriaImpl)P_0).get_Session();
	}

	internal static object E1jCBshzwUvT0waQ0ODb(object P_0)
	{
		return ((CriteriaImpl)P_0).get_EntityOrClassName();
	}

	internal static object Y63teZhz4qgG6c88Ls9t(object P_0)
	{
		return ((ISessionImplementor)P_0).get_Factory();
	}

	internal static object YqlKQghz6qBoZVv81Es6(object P_0, object P_1)
	{
		return ((ISessionFactoryImplementor)P_0).GetImplementors((string)P_1);
	}

	internal static object dpnMZOhzHubTp2F4k3eB(object P_0)
	{
		return ((JoinWalker)P_0).get_SqlString();
	}

	internal static Guid P09xVBhzAAfR5gruTwDV(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object SHgviJhz7meXBYdMdupW(Guid typeUid)
	{
		return GetCriteriaTypeUidPropertyName(typeUid);
	}

	internal static object eVJqqZhzxq0VvB3ULd1L(Type type)
	{
		return GetCriteriaTypeUidPropertyName(type);
	}

	internal static Type qSuMqbhz09eh2yc9CVU5(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object ccqAcwhzmofdnbrySy5E(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void t2gIEShzyFYqZaOZKkbQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
