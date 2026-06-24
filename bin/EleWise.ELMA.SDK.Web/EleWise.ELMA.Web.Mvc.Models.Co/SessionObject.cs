using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Models.Context;

public class SessionObject<T> where T : class, new()
{
	private readonly string key;

	public virtual T Value => SessionVars.GetOrAdd(key, () => new T());

	public SessionObject(string key)
	{
		if (string.IsNullOrEmpty(key))
		{
			throw new ArgumentException("key");
		}
		this.key = key;
	}

	public T UpdateValue([NotNull] Action<T> updateAction)
	{
		if (updateAction == null)
		{
			throw new ArgumentNullException("updateAction");
		}
		T value = Value;
		updateAction(value);
		SessionVars.Set(key, value);
		return value;
	}
}
