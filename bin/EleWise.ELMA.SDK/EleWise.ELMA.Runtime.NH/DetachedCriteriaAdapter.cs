using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;

namespace EleWise.ELMA.Runtime.NH;

public class DetachedCriteriaAdapter : ICriteria, ICloneable
{
	private readonly DetachedCriteria detachedCriteria;

	private readonly ISession session;

	private readonly Type rootType;

	private bool enableFetchJoinForProjection;

	private bool _readOnly;

	private bool _readOnlyInitialized;

	internal static DetachedCriteriaAdapter yU1slvWNXYxWeBPE2neg;

	public DetachedCriteria DetachedCriteria => detachedCriteria;

	public ISession Session => session;

	public IProjection Projection => null;

	public string Alias => (string)EOaqZPWNP1f1TTsUjT0V(detachedCriteria);

	public bool IsReadOnly => _readOnly;

	public bool IsReadOnlyInitialized => _readOnlyInitialized;

	public Task<IList> ListAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		throw new NotImplementedException();
	}

	public Task<object> UniqueResultAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		throw new NotImplementedException();
	}

	public Task ListAsync(IList results, CancellationToken cancellationToken = default(CancellationToken))
	{
		throw new NotImplementedException();
	}

	public Task<IList<T>> ListAsync<T>(CancellationToken cancellationToken = default(CancellationToken))
	{
		throw new NotImplementedException();
	}

	public Task<T> UniqueResultAsync<T>(CancellationToken cancellationToken = default(CancellationToken))
	{
		throw new NotImplementedException();
	}

	public DetachedCriteriaAdapter(DetachedCriteria detachedCriteria, ISession session)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zXI6dDWNnFx1ksbN4Aor();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			default:
				this.detachedCriteria = detachedCriteria;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				this.session = session;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public DetachedCriteriaAdapter(DetachedCriteria detachedCriteria, ISession session, Type rootType)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(detachedCriteria, session);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.rootType = rootType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public ICriteria Add(ICriterion expression)
	{
		return (ICriteria)ixyS1iWN2lHX3aNHNR3S(HfjQgYWNOwIkhqtZrwjf(detachedCriteria, expression), session);
	}

	public ICriteria AddOrder(Order order)
	{
		return (ICriteria)ixyS1iWN2lHX3aNHNR3S(ErVeVaWNefOwAQXEiYEK(detachedCriteria, order), session);
	}

	public void ClearOrderds()
	{
		throw new NotSupportedException();
	}

	public ICriteria CreateAlias(string associationPath, string alias, JoinType joinType)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return (ICriteria)ixyS1iWN2lHX3aNHNR3S(n1Isw5WN1EIRsGehYmXe(detachedCriteria, associationPath, alias, joinType), session);
	}

	public ICriteria CreateAlias(string associationPath, string alias)
	{
		return (ICriteria)ixyS1iWN2lHX3aNHNR3S(bf4sXMWNNGEtRxPxYJbD(detachedCriteria, associationPath, alias), session);
	}

	public ICriteria CreateAlias(string associationPath, string alias, JoinType joinType, ICriterion withClause)
	{
		throw new NotImplementedException();
	}

	public ICriteria CreateCriteria(string associationPath, string alias, JoinType joinType)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return (ICriteria)ixyS1iWN2lHX3aNHNR3S(x30ZK2WN3Ya0QjksrqDk(detachedCriteria, associationPath, alias, joinType), session);
	}

	public ICriteria CreateCriteria(string associationPath, string alias)
	{
		return (ICriteria)ixyS1iWN2lHX3aNHNR3S(VJywNCWNpiG3kuXMu92H(detachedCriteria, associationPath, alias), session);
	}

	public ICriteria CreateCriteria(string associationPath, JoinType joinType)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return (ICriteria)ixyS1iWN2lHX3aNHNR3S(MPOkjUWNaRN1BSFJpiwC(detachedCriteria, associationPath, joinType), session);
	}

	public ICriteria CreateCriteria(string associationPath, string alias, JoinType joinType, ICriterion withClause)
	{
		throw new NotImplementedException();
	}

	public ICriteria CreateCriteria(string associationPath)
	{
		return (ICriteria)ixyS1iWN2lHX3aNHNR3S(WcTmySWNDUE7klsSCjZy(detachedCriteria, associationPath), session);
	}

	public ICriteria GetCriteriaByAlias(string alias)
	{
		return detachedCriteria.GetCriteriaByAlias(alias).Adapt(session);
	}

	public ICriteria GetCriteriaByPath(string path)
	{
		return (ICriteria)ixyS1iWN2lHX3aNHNR3S(UdAodAWNtVa7b4dCYahc(detachedCriteria, path), session);
	}

	public IList<T> List<T>()
	{
		throw new NotSupportedException();
	}

	public void List(IList results)
	{
		throw new NotSupportedException();
	}

	public IList List()
	{
		throw new NotSupportedException();
	}

	public ICriteria SetCacheMode(CacheMode cacheMode)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return (ICriteria)ixyS1iWN2lHX3aNHNR3S(zF6GAHWNwMlKnEpx42oX(detachedCriteria, cacheMode), session);
	}

	public ICriteria SetCacheRegion(string cacheRegion)
	{
		throw new NotSupportedException();
	}

	public ICriteria SetCacheable(bool cacheable)
	{
		throw new NotSupportedException();
	}

	public ICriteria SetComment(string comment)
	{
		throw new NotSupportedException();
	}

	public ICriteria SetFetchMode(string associationPath, FetchMode mode)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return (ICriteria)ixyS1iWN2lHX3aNHNR3S(detachedCriteria.SetFetchMode(associationPath, mode), session);
	}

	public ICriteria SetFetchSize(int fetchSize)
	{
		throw new NotSupportedException();
	}

	public ICriteria SetFirstResult(int firstResult)
	{
		return (ICriteria)ixyS1iWN2lHX3aNHNR3S(LjN5GpWN4pZN6TdpnnWq(detachedCriteria, firstResult), session);
	}

	public ICriteria SetFlushMode(FlushMode flushMode)
	{
		throw new NotSupportedException();
	}

	public ICriteria SetLockMode(string alias, LockMode lockMode)
	{
		throw new NotSupportedException();
	}

	public ICriteria SetLockMode(LockMode lockMode)
	{
		throw new NotSupportedException();
	}

	public ICriteria SetMaxResults(int maxResults)
	{
		return ((DetachedCriteria)jZ7NtuWN6rwmSQHR9mX2(detachedCriteria, maxResults)).Adapt(session);
	}

	public ICriteria SetProjection(IProjection projection)
	{
		return (ICriteria)ixyS1iWN2lHX3aNHNR3S(AgxRG1WNHXiv7WDa0LGn(detachedCriteria, projection), session);
	}

	public ICriteria SetProjection(params IProjection[] projections)
	{
		//Discarded unreachable code: IL_0049, IL_00f4, IL_0103
		int num = 9;
		int num2 = num;
		ProjectionList val2 = default(ProjectionList);
		int num3 = default(int);
		IProjection val = default(IProjection);
		IProjection[] array = default(IProjection[]);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return (ICriteria)ixyS1iWN2lHX3aNHNR3S(AgxRG1WNHXiv7WDa0LGn(detachedCriteria, val2), session);
			case 6:
				num3 = 0;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 7;
				}
				break;
			case 4:
				VNINeVWN7da6T2NZhwGH(val2, val);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				num3++;
				num2 = 3;
				break;
			case 3:
			case 7:
				if (num3 < array.Length)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 5;
			case 8:
				array = projections;
				num2 = 6;
				break;
			case 9:
				val2 = (ProjectionList)lHDxMxWNArU1Il8m8Ab5();
				num2 = 8;
				break;
			default:
				val = array[num3];
				num2 = 4;
				break;
			}
		}
	}

	public ICriteria SetResultTransformer(IResultTransformer resultTransformer)
	{
		return (ICriteria)ixyS1iWN2lHX3aNHNR3S(detachedCriteria.SetResultTransformer(resultTransformer), session);
	}

	public ICriteria SetTimeout(int timeout)
	{
		throw new NotSupportedException();
	}

	public T UniqueResult<T>()
	{
		throw new NotSupportedException();
	}

	public object UniqueResult()
	{
		throw new NotSupportedException();
	}

	public Type GetRootEntityTypeIfAvailable()
	{
		int num = 1;
		int num2 = num;
		Type rootEntityTypeIfAvailable;
		while (true)
		{
			switch (num2)
			{
			case 1:
				rootEntityTypeIfAvailable = rootType;
				if ((object)rootEntityTypeIfAvailable == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				rootEntityTypeIfAvailable = detachedCriteria.GetRootEntityTypeIfAvailable();
				break;
			}
			break;
		}
		return rootEntityTypeIfAvailable;
	}

	public void ClearOrders()
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
				detachedCriteria.ClearOrders();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public IEnumerable<T> Future<T>()
	{
		throw new NotSupportedException();
	}

	public IFutureValue<T> FutureValue<T>()
	{
		throw new NotSupportedException();
	}

	IFutureEnumerable<T> ICriteria.Future<T>()
	{
		throw new NotImplementedException();
	}

	public object Clone()
	{
		throw new NotSupportedException();
	}

	public ICriteria SetReadOnly(bool readOnly)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				_readOnlyInitialized = true;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return (ICriteria)(object)this;
			case 1:
				_readOnly = readOnly;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ICriteria FetchModeForProjections(bool value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (ICriteria)(object)this;
			case 1:
				enableFetchJoinForProjection = value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void zXI6dDWNnFx1ksbN4Aor()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool N1WNu2WNTWJSsqSiSojx()
	{
		return yU1slvWNXYxWeBPE2neg == null;
	}

	internal static DetachedCriteriaAdapter GUB3pIWNkV9cp2tBkGmm()
	{
		return yU1slvWNXYxWeBPE2neg;
	}

	internal static object HfjQgYWNOwIkhqtZrwjf(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object ixyS1iWN2lHX3aNHNR3S(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).Adapt((ISession)P_1);
	}

	internal static object ErVeVaWNefOwAQXEiYEK(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).AddOrder((Order)P_1);
	}

	internal static object EOaqZPWNP1f1TTsUjT0V(object P_0)
	{
		return ((DetachedCriteria)P_0).get_Alias();
	}

	internal static object n1Isw5WN1EIRsGehYmXe(object P_0, object P_1, object P_2, JoinType P_3)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return ((DetachedCriteria)P_0).CreateAlias((string)P_1, (string)P_2, P_3);
	}

	internal static object bf4sXMWNNGEtRxPxYJbD(object P_0, object P_1, object P_2)
	{
		return ((DetachedCriteria)P_0).CreateAlias((string)P_1, (string)P_2);
	}

	internal static object x30ZK2WN3Ya0QjksrqDk(object P_0, object P_1, object P_2, JoinType P_3)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return ((DetachedCriteria)P_0).CreateCriteria((string)P_1, (string)P_2, P_3);
	}

	internal static object VJywNCWNpiG3kuXMu92H(object P_0, object P_1, object P_2)
	{
		return ((DetachedCriteria)P_0).CreateCriteria((string)P_1, (string)P_2);
	}

	internal static object MPOkjUWNaRN1BSFJpiwC(object P_0, object P_1, JoinType P_2)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return ((DetachedCriteria)P_0).CreateCriteria((string)P_1, P_2);
	}

	internal static object WcTmySWNDUE7klsSCjZy(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).CreateCriteria((string)P_1);
	}

	internal static object UdAodAWNtVa7b4dCYahc(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).GetCriteriaByPath((string)P_1);
	}

	internal static object zF6GAHWNwMlKnEpx42oX(object P_0, CacheMode P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((DetachedCriteria)P_0).SetCacheMode(P_1);
	}

	internal static object LjN5GpWN4pZN6TdpnnWq(object P_0, int P_1)
	{
		return ((DetachedCriteria)P_0).SetFirstResult(P_1);
	}

	internal static object jZ7NtuWN6rwmSQHR9mX2(object P_0, int P_1)
	{
		return ((DetachedCriteria)P_0).SetMaxResults(P_1);
	}

	internal static object AgxRG1WNHXiv7WDa0LGn(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).SetProjection((IProjection)P_1);
	}

	internal static object lHDxMxWNArU1Il8m8Ab5()
	{
		return Projections.ProjectionList();
	}

	internal static object VNINeVWN7da6T2NZhwGH(object P_0, object P_1)
	{
		return ((ProjectionList)P_0).Add((IProjection)P_1);
	}
}
