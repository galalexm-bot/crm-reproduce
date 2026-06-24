using System;
using System.Collections.Generic;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Services;

[Service]
internal sealed class NotValidElementStorage : INotValidElementStorage
{
	private readonly Dictionary<Guid, ReactiveCollection<Guid>> storage = new Dictionary<Guid, ReactiveCollection<Guid>>();

	public void Init(Guid ownerUid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (!storage.ContainsKey(ownerUid))
		{
			storage.set_Item(ownerUid, new ReactiveCollection<Guid>());
		}
	}

	public void Add(Guid ownerUid, Guid elementUid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		ReactiveCollection<Guid> reactiveCollection = default(ReactiveCollection<Guid>);
		if (!storage.TryGetValue(ownerUid, ref reactiveCollection))
		{
			reactiveCollection = new ReactiveCollection<Guid>();
			storage.set_Item(ownerUid, reactiveCollection);
		}
		reactiveCollection.Add(elementUid);
	}

	public void AddRange(Guid ownerUid, System.Collections.Generic.IEnumerable<Guid> elementUids)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		ReactiveCollection<Guid> reactiveCollection = default(ReactiveCollection<Guid>);
		if (!storage.TryGetValue(ownerUid, ref reactiveCollection))
		{
			reactiveCollection = new ReactiveCollection<Guid>();
			storage.set_Item(ownerUid, reactiveCollection);
		}
		reactiveCollection.AddRange(elementUids);
	}

	public bool Contains(Guid ownerUid, Guid elementUid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		ReactiveCollection<Guid> reactiveCollection = default(ReactiveCollection<Guid>);
		if (storage.TryGetValue(ownerUid, ref reactiveCollection))
		{
			return reactiveCollection.Contains(elementUid);
		}
		return false;
	}

	public void Clear(Guid ownerUid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		ReactiveCollection<Guid> reactiveCollection = default(ReactiveCollection<Guid>);
		if (storage.TryGetValue(ownerUid, ref reactiveCollection))
		{
			reactiveCollection.Clear();
		}
	}
}
