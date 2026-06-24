using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NHibernate.Linq;

namespace Orchard.Data;

public class FetchRequest<TQueried, TFetch> : IFetchRequest<TQueried, TFetch>, IOrderedQueryable<TQueried>, IQueryable<TQueried>, IEnumerable<TQueried>, IEnumerable, IQueryable, IOrderedQueryable
{
	public Type ElementType => ((IQueryable)NhFetchRequest).ElementType;

	public Expression Expression => ((IQueryable)NhFetchRequest).Expression;

	public IQueryProvider Provider => ((IQueryable)NhFetchRequest).Provider;

	public INhFetchRequest<TQueried, TFetch> NhFetchRequest { get; private set; }

	public IEnumerator<TQueried> GetEnumerator()
	{
		return ((IEnumerable<TQueried>)NhFetchRequest).GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<TQueried>)NhFetchRequest).GetEnumerator();
	}

	public FetchRequest(INhFetchRequest<TQueried, TFetch> nhFetchRequest)
	{
		NhFetchRequest = nhFetchRequest;
	}
}
