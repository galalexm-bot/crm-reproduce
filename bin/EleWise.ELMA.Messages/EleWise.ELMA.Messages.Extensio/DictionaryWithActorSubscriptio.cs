using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;

namespace EleWise.ELMA.Messages.Extensions;

internal static class DictionaryWithActorSubscriptionsExtensions
{
	public static async Task Add<TKey>(this IDictionary<TKey, ICollection<ISubscription>> dict, TKey key, params Task<ISubscription>[] subscription)
	{
		dict.Add(key, await Task.WhenAll(subscription));
	}

	public static async Task ClearSubscriptions<TKey>(this IDictionary<TKey, ICollection<ISubscription>> dict)
	{
		await dict.ForEachAsync((KeyValuePair<TKey, ICollection<ISubscription>> c) => c.Value.ForEachAsync((ISubscription s) => s.Unsubscribe()));
		dict.Clear();
	}

	public static async Task ClearSubscriptions<TKey>(this IDictionary<TKey, ISubscription> dict)
	{
		await dict.ForEachAsync((KeyValuePair<TKey, ISubscription> c) => c.Value.Unsubscribe());
		dict.Clear();
	}

	public static async Task ForEachAsync<T>(this IEnumerable<T> enumeration, Func<T, Task> action)
	{
		if (enumeration != null && action != null)
		{
			await Task.WhenAll(enumeration.Select((Func<T, Task>)async delegate(T item)
			{
				await action(item);
			}));
		}
	}
}
