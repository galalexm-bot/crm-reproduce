using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Context;

namespace EleWise.ELMA.Web.Mvc.Models.Context;

[Service]
public class ContextObjects : IContextObjects
{
	private readonly SessionObject<Dictionary<Type, object>> tableHolder = new SessionObject<Dictionary<Type, object>>("EleWise.ELMA.SDK.Web.ContextObjects.tableHolder.KEY");

	public virtual T Get<T>() where T : class
	{
		tableHolder.Value.TryGetValue(typeof(T), out var value);
		return (T)value;
	}

	public virtual void Set<T>(T obj) where T : class
	{
		tableHolder.UpdateValue(delegate(Dictionary<Type, object> objects)
		{
			objects[typeof(T)] = obj;
		});
	}
}
