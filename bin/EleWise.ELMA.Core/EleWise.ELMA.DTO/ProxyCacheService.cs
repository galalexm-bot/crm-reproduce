using System;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Types.Storage;

namespace EleWise.ELMA.DTO;

[Service]
internal sealed class ProxyCacheService : IProxyCacheService
{
	private readonly TypedMap<string, ReactiveProxy> proxies = new TypedMap<string, ReactiveProxy>();

	public void Add(string key, ReactiveProxy proxy)
	{
		proxies.Set(key, ObjectExtensions.As<ReactiveProxy>(proxy.Clone()));
	}

	public ReactiveProxy Get(string key)
	{
		ReactiveProxy reactiveProxy = proxies.Get(key);
		if (reactiveProxy == null)
		{
			return null;
		}
		return ObjectExtensions.As<ReactiveProxy>(reactiveProxy.Clone());
	}

	public void Update(string key)
	{
		proxies.Delete(key);
	}

	public ValueTuple<string, ReactiveProxy>[] GetValues()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		ValueTuple<string, ReactiveProxy>[] array = new ValueTuple<string, ReactiveProxy>[0];
		int size = proxies.get_Size();
		string[] keys = proxies.get_Keys();
		ReactiveProxy[] values = proxies.get_Values();
		for (int i = 0; i < size - 1; i++)
		{
			ArrayExtensions.Push<ValueTuple<string, ReactiveProxy>>(array, new ValueTuple<string, ReactiveProxy>[1]
			{
				new ValueTuple<string, ReactiveProxy>(keys[i], values[i])
			});
		}
		return array;
	}
}
