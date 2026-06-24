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

public class DisjunctionCriteria : ICriteria, ICloneable
{
	private readonly ICriteria criteria;

	private Disjunction disjunction;

	private Conjunction conjunction;

	private static DisjunctionCriteria DjY5NiWNxXZhc25VkGXk;

	public string Alias => criteria.get_Alias();

	public bool IsReadOnly
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public bool IsReadOnlyInitialized
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public Task<IList> ListAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return criteria.ListAsync(cancellationToken);
	}

	public Task<object> UniqueResultAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return criteria.UniqueResultAsync(cancellationToken);
	}

	public Task ListAsync(IList results, CancellationToken cancellationToken = default(CancellationToken))
	{
		return (Task)IE0sltWNyKkbOZsNjWgb(criteria, results, cancellationToken);
	}

	public Task<IList<T>> ListAsync<T>(CancellationToken cancellationToken = default(CancellationToken))
	{
		return criteria.ListAsync<T>(cancellationToken);
	}

	public Task<T> UniqueResultAsync<T>(CancellationToken cancellationToken = default(CancellationToken))
	{
		return criteria.UniqueResultAsync<T>(cancellationToken);
	}

	public DisjunctionCriteria(ICriteria criteria)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
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
				this.criteria = criteria;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void NewDisjunctionCriteria()
	{
		//Discarded unreachable code: IL_0077, IL_0086
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
			case 5:
				conjunction = new Conjunction();
				num2 = 3;
				break;
			case 1:
				disjunction = new Disjunction();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				KixwlJWNM2EPHOuU1r8c(criteria, disjunction);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				if (disjunction != null)
				{
					num2 = 5;
					break;
				}
				goto case 1;
			case 3:
				((Junction)disjunction).Add((ICriterion)(object)conjunction);
				num2 = 2;
				break;
			case 2:
				return;
			}
		}
	}

	public ICriteria Add(ICriterion expression)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				jH0y5wWNJsAXMrtw7y4u(conjunction, expression);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (ICriteria)(object)this;
			}
		}
	}

	public ICriteria CreateAlias(string associationPath, string alias)
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
				uOxdo4WN9boTt74M8fsJ(criteria, associationPath, alias);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ICriteria CreateAlias(string associationPath, string alias, JoinType joinType)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (ICriteria)(object)this;
			case 1:
				L4yB0bWNdTxlWqtR98Ot(criteria, associationPath, alias, joinType);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
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
				zS8SCRWNlksS2bNaMYrV(criteria, value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public object Clone()
	{
		throw new NotImplementedException();
	}

	public ICriteria SetProjection(params IProjection[] projection)
	{
		throw new NotImplementedException();
	}

	public ICriteria AddOrder(Order order)
	{
		throw new NotImplementedException();
	}

	public ICriteria SetFetchMode(string associationPath, FetchMode mode)
	{
		throw new NotImplementedException();
	}

	public ICriteria SetLockMode(LockMode lockMode)
	{
		throw new NotImplementedException();
	}

	public ICriteria SetLockMode(string alias, LockMode lockMode)
	{
		throw new NotImplementedException();
	}

	public ICriteria CreateCriteria(string associationPath)
	{
		throw new NotImplementedException();
	}

	public ICriteria CreateCriteria(string associationPath, JoinType joinType)
	{
		throw new NotImplementedException();
	}

	public ICriteria CreateCriteria(string associationPath, string alias)
	{
		throw new NotImplementedException();
	}

	public ICriteria CreateCriteria(string associationPath, string alias, JoinType joinType)
	{
		throw new NotImplementedException();
	}

	public ICriteria SetResultTransformer(IResultTransformer resultTransformer)
	{
		throw new NotImplementedException();
	}

	public ICriteria SetMaxResults(int maxResults)
	{
		throw new NotImplementedException();
	}

	public ICriteria SetFirstResult(int firstResult)
	{
		throw new NotImplementedException();
	}

	public ICriteria SetFetchSize(int fetchSize)
	{
		throw new NotImplementedException();
	}

	public ICriteria SetTimeout(int timeout)
	{
		throw new NotImplementedException();
	}

	public ICriteria SetCacheable(bool cacheable)
	{
		throw new NotImplementedException();
	}

	public ICriteria SetCacheRegion(string cacheRegion)
	{
		throw new NotImplementedException();
	}

	public ICriteria SetComment(string comment)
	{
		throw new NotImplementedException();
	}

	public ICriteria SetFlushMode(FlushMode flushMode)
	{
		throw new NotImplementedException();
	}

	public ICriteria SetCacheMode(CacheMode cacheMode)
	{
		throw new NotImplementedException();
	}

	public IList List()
	{
		throw new NotImplementedException();
	}

	public object UniqueResult()
	{
		throw new NotImplementedException();
	}

	public IEnumerable<T> Future<T>()
	{
		throw new NotImplementedException();
	}

	IFutureEnumerable<T> ICriteria.Future<T>()
	{
		return criteria.Future<T>();
	}

	public IFutureValue<T> FutureValue<T>()
	{
		throw new NotImplementedException();
	}

	public void List(IList results)
	{
		throw new NotImplementedException();
	}

	public IList<T> List<T>()
	{
		throw new NotImplementedException();
	}

	public T UniqueResult<T>()
	{
		throw new NotImplementedException();
	}

	public void ClearOrders()
	{
		throw new NotImplementedException();
	}

	public ICriteria GetCriteriaByPath(string path)
	{
		throw new NotImplementedException();
	}

	public ICriteria GetCriteriaByAlias(string alias)
	{
		throw new NotImplementedException();
	}

	public Type GetRootEntityTypeIfAvailable()
	{
		throw new NotImplementedException();
	}

	public ICriteria CreateAlias(string associationPath, string alias, JoinType joinType, ICriterion withClause)
	{
		throw new NotImplementedException();
	}

	public ICriteria CreateCriteria(string associationPath, string alias, JoinType joinType, ICriterion withClause)
	{
		throw new NotImplementedException();
	}

	public ICriteria SetReadOnly(bool readOnly)
	{
		throw new NotImplementedException();
	}

	internal static object IE0sltWNyKkbOZsNjWgb(object P_0, object P_1, CancellationToken P_2)
	{
		return ((ICriteria)P_0).ListAsync((IList)P_1, P_2);
	}

	internal static bool RClhelWN0xk9E532LeY2()
	{
		return DjY5NiWNxXZhc25VkGXk == null;
	}

	internal static DisjunctionCriteria EFABsHWNm6EitVrG5Vyf()
	{
		return DjY5NiWNxXZhc25VkGXk;
	}

	internal static object KixwlJWNM2EPHOuU1r8c(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object jH0y5wWNJsAXMrtw7y4u(object P_0, object P_1)
	{
		return ((Junction)P_0).Add((ICriterion)P_1);
	}

	internal static object uOxdo4WN9boTt74M8fsJ(object P_0, object P_1, object P_2)
	{
		return ((ICriteria)P_0).CreateAlias((string)P_1, (string)P_2);
	}

	internal static object L4yB0bWNdTxlWqtR98Ot(object P_0, object P_1, object P_2, JoinType P_3)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return ((ICriteria)P_0).CreateAlias((string)P_1, (string)P_2, P_3);
	}

	internal static object zS8SCRWNlksS2bNaMYrV(object P_0, bool P_1)
	{
		return ((ICriteria)P_0).FetchModeForProjections(P_1);
	}
}
