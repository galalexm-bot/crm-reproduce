using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core.Serialization;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Model.Entities;

public sealed class TablePartChangesModel
{
	private readonly IIdGenerator idGenerator;

	private List<Entity> originalItems;

	private readonly List<Entity> addedEntities = new List<Entity>();

	private readonly List<Entity> changedEntities = new List<Entity>();

	private readonly List<Entity> deletedEntities = new List<Entity>();

	private int? _003CTotalCount_003Ek__BackingField;

	private readonly List<object> _003CAdded_003Ek__BackingField;

	private readonly List<object> _003CChanged_003Ek__BackingField;

	private readonly List<string> _003CDeleted_003Ek__BackingField;

	public int? TotalCount
	{
		get
		{
			return _003CTotalCount_003Ek__BackingField;
		}
		set
		{
			_003CTotalCount_003Ek__BackingField = value;
		}
	}

	public List<object> Added => _003CAdded_003Ek__BackingField;

	public List<object> Changed => _003CChanged_003Ek__BackingField;

	public List<string> Deleted => _003CDeleted_003Ek__BackingField;

	public TablePartChangesModel(IIdGenerator idGenerator)
	{
		this.idGenerator = idGenerator;
		_003CAdded_003Ek__BackingField = new List<object>();
		_003CChanged_003Ek__BackingField = new List<object>();
		_003CDeleted_003Ek__BackingField = new List<string>();
	}

	public void Init(System.Collections.Generic.ICollection<Entity> initItems)
	{
		System.Collections.Generic.ICollection<Entity> collection = (System.Collections.Generic.ICollection<Entity>)(((object)initItems) ?? ((object)new List<Entity>()));
		originalItems = Enumerable.ToList<Entity>((System.Collections.Generic.IEnumerable<Entity>)collection);
		TotalCount = collection.get_Count();
	}

	public string Serialize()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		Deleted.Clear();
		Added.Clear();
		Changed.Clear();
		Enumerator<Entity> enumerator = deletedEntities.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Entity current = enumerator.get_Current();
				Deleted.Add(((object)current.Id).ToString());
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		enumerator = addedEntities.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Entity current2 = enumerator.get_Current();
				Added.Add(ConvertHelper.Serialize(current2, new SerializationSettings
				{
					WriteReferences = true
				}));
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		enumerator = changedEntities.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Entity current3 = enumerator.get_Current();
				Changed.Add(ConvertHelper.Serialize(current3, new SerializationSettings
				{
					WriteReferences = true
				}));
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		return SerializationHelper.SerializeObjectByJson(this);
	}

	public void Update(System.Collections.Generic.ICollection<Entity> initItems)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		List<Entity> val = Enumerable.ToList<Entity>((System.Collections.Generic.IEnumerable<Entity>)(((object)initItems) ?? ((object)new List<Entity>())));
		changedEntities.Clear();
		deletedEntities.Clear();
		addedEntities.Clear();
		if (originalItems.get_Count() > 0)
		{
			List<Entity> val2 = Enumerable.ToList<Entity>((System.Collections.Generic.IEnumerable<Entity>)val);
			Enumerator<Entity> enumerator = originalItems.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Entity current = enumerator.get_Current();
					int num = val.IndexOf(current);
					if (num != -1)
					{
						Entity entity = val.get_Item(num);
						changedEntities.Add(entity);
						val2.Remove(entity);
					}
					else
					{
						deletedEntities.Add(current);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
			enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Entity current2 = enumerator.get_Current();
					current2.Id = idGenerator.GenerateNewId(current2.TypeUid);
					addedEntities.Add(current2);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		else
		{
			Enumerator<Entity> enumerator = val.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Entity current3 = enumerator.get_Current();
					current3.Id = idGenerator.GenerateNewId(current3.TypeUid);
					addedEntities.Add(current3);
				}
			}
			finally
			{
				((System.IDisposable)enumerator).Dispose();
			}
		}
		TotalCount = val.get_Count();
	}
}
