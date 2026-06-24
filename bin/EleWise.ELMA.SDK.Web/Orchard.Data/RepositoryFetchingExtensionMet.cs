using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NHibernate.Linq;

namespace Orchard.Data;

public static class RepositoryFetchingExtensionMethods
{
	public static IFetchRequest<TOriginating, TRelated> Fetch<TOriginating, TRelated>(this IQueryable<TOriginating> query, Expression<Func<TOriginating, TRelated>> relatedObjectSelector)
	{
		return new FetchRequest<TOriginating, TRelated>(EagerFetchingExtensionMethods.Fetch<TOriginating, TRelated>(query, relatedObjectSelector));
	}

	public static IFetchRequest<TOriginating, TRelated> FetchMany<TOriginating, TRelated>(this IQueryable<TOriginating> query, Expression<Func<TOriginating, IEnumerable<TRelated>>> relatedObjectSelector)
	{
		return new FetchRequest<TOriginating, TRelated>(EagerFetchingExtensionMethods.FetchMany<TOriginating, TRelated>(query, relatedObjectSelector));
	}

	public static IFetchRequest<TQueried, TRelated> ThenFetch<TQueried, TFetch, TRelated>(this IFetchRequest<TQueried, TFetch> query, Expression<Func<TFetch, TRelated>> relatedObjectSelector)
	{
		return new FetchRequest<TQueried, TRelated>(EagerFetchingExtensionMethods.ThenFetch<TQueried, TFetch, TRelated>((query as FetchRequest<TQueried, TFetch>).NhFetchRequest, relatedObjectSelector));
	}

	public static IFetchRequest<TQueried, TRelated> ThenFetchMany<TQueried, TFetch, TRelated>(this IFetchRequest<TQueried, TFetch> query, Expression<Func<TFetch, IEnumerable<TRelated>>> relatedObjectSelector)
	{
		return new FetchRequest<TQueried, TRelated>(EagerFetchingExtensionMethods.ThenFetchMany<TQueried, TFetch, TRelated>((query as FetchRequest<TQueried, TFetch>).NhFetchRequest, relatedObjectSelector));
	}
}
