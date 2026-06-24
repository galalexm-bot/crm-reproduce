using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using EleWise.ELMA.CAB.Commands;
using EleWise.ELMA.CAB.Events;
using EleWise.ELMA.CAB.Properties;
using EleWise.ELMA.CAB.Utility;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB.Collections;

public class ManagedObjectCollection<TItem> : ICollection, IEnumerable<KeyValuePair<string, TItem>>, IEnumerable
{
	public delegate TItem IndexerCreationDelegate(Type t, string id);

	private readonly IBuilder<BuilderStage> builder;

	private readonly ILifetimeContainer container;

	private readonly Predicate<TItem> filter;

	private readonly IndexerCreationDelegate indexerCreationDelegate;

	private readonly IReadWriteLocator locator;

	private readonly ManagedObjectCollection<TItem> parentCollection;

	private readonly SearchMode searchMode;

	private readonly WorkItem workItem;

	public TItem this[string id]
	{
		get
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			TItem val = Get(id);
			if (val == null && indexerCreationDelegate != null && !Contains(id, searchMode, filtered: false))
			{
				val = indexerCreationDelegate(typeof(TItem), id);
				Add(val, id);
			}
			return val;
		}
	}

	public int Count
	{
		get
		{
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			foreach (KeyValuePair<object, object> item in (IEnumerable<KeyValuePair<object, object>>)locator)
			{
				object key = item.Key;
				DependencyResolutionLocatorKey val = (DependencyResolutionLocatorKey)((key is DependencyResolutionLocatorKey) ? key : null);
				if (val != null && val.get_ID() != null && item.Value is TItem && PassesFilter(item.Value))
				{
					num++;
				}
			}
			if ((int)searchMode == 0 && parentCollection != null)
			{
				num += parentCollection.Count;
			}
			return num;
		}
	}

	int ICollection.Count
	{
		get
		{
			int count = Count;
			int num = count;
			__ContractsRuntime.Ensures(num >= 0, null, "Contract.Result<int>() >= 0");
			return num;
		}
	}

	bool ICollection.IsSynchronized => false;

	object ICollection.SyncRoot
	{
		get
		{
			//Discarded unreachable code: IL_0007
			throw new NotImplementedException();
		}
	}

	public event EventHandler<DataEventArgs<TItem>> Added;

	public event EventHandler<DataEventArgs<TItem>> Removed;

	public ManagedObjectCollection(ILifetimeContainer container, IReadWriteLocator locator, IBuilder<BuilderStage> builder, SearchMode searchMode, IndexerCreationDelegate indexerCreationDelegate, Predicate<TItem> filter)
		: this(container, locator, builder, searchMode, indexerCreationDelegate, filter, (ManagedObjectCollection<TItem>)null)
	{
	}//IL_0004: Unknown result type (might be due to invalid IL or missing references)


	public ManagedObjectCollection(ILifetimeContainer container, IReadWriteLocator locator, IBuilder<BuilderStage> builder, SearchMode searchMode, IndexerCreationDelegate indexerCreationDelegate, Predicate<TItem> filter, ManagedObjectCollection<TItem> parentCollection)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		this.container = container;
		this.locator = locator;
		this.builder = builder;
		this.searchMode = searchMode;
		this.indexerCreationDelegate = indexerCreationDelegate;
		this.filter = filter;
		this.parentCollection = parentCollection;
		workItem = ((IReadableLocator)locator).Get<WorkItem>((object)new DependencyResolutionLocatorKey(typeof(WorkItem), (string)null));
		if (workItem != null)
		{
			workItem.ObjectAdded += WorkItem_ItemAdded;
			workItem.ObjectRemoved += WorkItem_ItemRemoved;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		IEnumerator enumerator = GetEnumerator();
		IEnumerator enumerator2 = enumerator;
		__ContractsRuntime.Ensures(enumerator2 != null, null, "Contract.Result<IEnumerator>() != null");
		return enumerator2;
	}

	void ICollection.CopyTo(Array array, int index)
	{
		//Discarded unreachable code: IL_008a
		if (__ContractsRuntime.insideContractEvaluation <= 4)
		{
			try
			{
				__ContractsRuntime.insideContractEvaluation++;
				__ContractsRuntime.Requires(array != null, null, "array != null");
				__ContractsRuntime.Requires(array.Rank == 1, null, "array.Rank == 1");
				__ContractsRuntime.Requires(index >= 0, null, "index >= 0");
				__ContractsRuntime.Requires(index <= array.Length + ((ICollection)this).Count, null, "index <= array.Length + this.Count");
			}
			finally
			{
				__ContractsRuntime.insideContractEvaluation--;
			}
		}
		throw new NotImplementedException();
	}

	public IEnumerator<KeyValuePair<string, TItem>> GetEnumerator()
	{
		_003CGetEnumerator_003Ed__0 _003CGetEnumerator_003Ed__ = new _003CGetEnumerator_003Ed__0(0);
		_003CGetEnumerator_003Ed__._003C_003E4__this = this;
		IEnumerator<KeyValuePair<string, TItem>> enumerator = _003CGetEnumerator_003Ed__;
		IEnumerator<KeyValuePair<string, TItem>> enumerator2 = enumerator;
		__ContractsRuntime.Ensures(enumerator2 != null, null, "Contract.Result<IEnumerator<T>>() != null");
		return enumerator2;
	}

	public void Add(TItem item)
	{
		Add(item, null);
	}

	public void Add(TItem item, string id)
	{
		Guard.ArgumentNotNull(item, "item");
		Build(item.GetType(), id, item);
	}

	public TItem AddNew(Type typeToBuild)
	{
		return AddNew(typeToBuild, null);
	}

	public TItem AddNew(Type typeToBuild, string id)
	{
		return Build(typeToBuild, id, null);
	}

	public TTypeToBuild AddNew<TTypeToBuild>() where TTypeToBuild : TItem
	{
		return (TTypeToBuild)(object)AddNew(typeof(TTypeToBuild), null);
	}

	public TTypeToBuild AddNew<TTypeToBuild>(string id) where TTypeToBuild : TItem
	{
		return (TTypeToBuild)(object)AddNew(typeof(TTypeToBuild), id);
	}

	public bool Contains(string id)
	{
		return Get(id) != null;
	}

	private bool Contains(string id, SearchMode searchMode, bool filtered)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return Get(id, searchMode, filtered) != null;
	}

	public bool ContainsObject(TItem item)
	{
		return container.Contains((object)item);
	}

	public ICollection<TSearchType> FindByType<TSearchType>() where TSearchType : TItem
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		List<TSearchType> list = new List<TSearchType>();
		foreach (object item in (IEnumerable<object>)container)
		{
			if (typeof(TSearchType).IsAssignableFrom(item.GetType()))
			{
				list.Add((TSearchType)item);
			}
		}
		if ((int)searchMode == 0 && parentCollection != null)
		{
			list.AddRange(parentCollection.FindByType<TSearchType>());
		}
		return list;
	}

	public ICollection<TItem> FindByType(Type searchType)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		List<TItem> list = new List<TItem>();
		foreach (object item in (IEnumerable<object>)container)
		{
			if (searchType.IsAssignableFrom(item.GetType()))
			{
				list.Add((TItem)item);
			}
		}
		if ((int)searchMode == 0 && parentCollection != null)
		{
			list.AddRange(parentCollection.FindByType(searchType));
		}
		return list;
	}

	public TItem Get(string id)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return Get(id, searchMode, filtered: true);
	}

	private TItem Get(string id, SearchMode searchMode, bool filtered)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		Guard.ArgumentNotNull(id, "id");
		foreach (KeyValuePair<object, object> item in (IEnumerable<KeyValuePair<object, object>>)locator)
		{
			if (!(item.Key is DependencyResolutionLocatorKey))
			{
				continue;
			}
			DependencyResolutionLocatorKey val = (DependencyResolutionLocatorKey)item.Key;
			if (object.Equals(val.get_ID(), id))
			{
				TItem val2 = (TItem)item.Value;
				if (!filtered || filter == null || filter(val2))
				{
					return val2;
				}
			}
		}
		if ((int)searchMode == 0 && parentCollection != null)
		{
			return parentCollection.Get(id);
		}
		return default(TItem);
	}

	public TTypeToGet Get<TTypeToGet>(string id) where TTypeToGet : TItem
	{
		return (TTypeToGet)(object)Get(id);
	}

	public void Remove(TItem item)
	{
		if (!container.Contains((object)item))
		{
			return;
		}
		ThrowIfItemRemovalIsNotPermitted(item);
		builder.TearDown<TItem>(locator, item);
		container.Remove((object)item);
		List<object> list = new List<object>();
		foreach (KeyValuePair<object, object> item2 in (IEnumerable<KeyValuePair<object, object>>)locator)
		{
			if (item2.Value.Equals(item))
			{
				list.Add(item2.Key);
			}
		}
		foreach (object item3 in list)
		{
			locator.Remove(item3);
		}
	}

	private static void ThrowIfItemRemovalIsNotPermitted(TItem item)
	{
		if (item is WorkItem)
		{
			throw new ArgumentException(Resources.NoRemoveWorkItemFromManagedObjectCollection, "item");
		}
		if (item is Command)
		{
			Command command = item as Command;
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.RemoveCommandFromWorkItemIsNotPermitted, new object[1] { command.Name }), "item");
		}
		if (item is EventTopic)
		{
			EventTopic eventTopic = item as EventTopic;
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.RemoveEventTopicFromWorkItemIsNotPermitted, new object[1] { eventTopic.Name }), "item");
		}
	}

	private TItem Build(Type typeToBuild, string idToBuild, object item)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		if (idToBuild != null && Contains(idToBuild, (SearchMode)1, filtered: true))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.DuplicateID, new object[1] { idToBuild }));
		}
		if (item != null && object.ReferenceEquals(item, ((IReadableLocator)locator).Get((object)new DependencyResolutionLocatorKey(typeof(WorkItem), (string)null))))
		{
			throw new ArgumentException(Resources.CannotAddWorkItemToItself, "item");
		}
		if (item == null)
		{
			item = BuildFirstTimeItem(typeToBuild, idToBuild, null);
		}
		else if (!container.Contains(item))
		{
			item = BuildFirstTimeItem(typeToBuild, idToBuild, item);
		}
		else
		{
			BuildRepeatedItem(typeToBuild, idToBuild, item);
		}
		return (TItem)item;
	}

	private object BuildFirstTimeItem(Type typeToBuild, string idToBuild, object item)
	{
		return builder.BuildUp(locator, typeToBuild, NormalizeID(idToBuild), item, (PolicyList[])(object)new PolicyList[0]);
	}

	private void BuildRepeatedItem(Type typeToBuild, string idToBuild, object item)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		locator.Add((object)new DependencyResolutionLocatorKey(typeToBuild, NormalizeID(idToBuild)), item);
	}

	private bool PassesFilter(object item)
	{
		if (filter != null)
		{
			return filter((TItem)item);
		}
		return true;
	}

	private string NormalizeID(string idToBuild)
	{
		return idToBuild ?? Guid.NewGuid().ToString();
	}

	private void WorkItem_ItemAdded(object sender, DataEventArgs<object> e)
	{
		if (this.Added != null && e.Data is TItem)
		{
			TItem val = (TItem)e.Data;
			DependencyResolutionLocatorKey val2 = FindObjectInLocator(val);
			if (val2 != null && val2.get_ID() != null && PassesFilter(val))
			{
				this.Added(this, new DataEventArgs<TItem>(val));
			}
		}
	}

	private void WorkItem_ItemRemoved(object sender, DataEventArgs<object> e)
	{
		if (this.Removed != null && e.Data is TItem)
		{
			TItem val = (TItem)e.Data;
			DependencyResolutionLocatorKey val2 = FindObjectInLocator(val);
			if (val2 != null && val2.get_ID() != null && PassesFilter(val))
			{
				this.Removed(this, new DataEventArgs<TItem>(val));
			}
		}
	}

	private DependencyResolutionLocatorKey FindObjectInLocator(object value)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		foreach (KeyValuePair<object, object> item in (IEnumerable<KeyValuePair<object, object>>)locator)
		{
			if (item.Key is DependencyResolutionLocatorKey && item.Value == value)
			{
				return (DependencyResolutionLocatorKey)item.Key;
			}
		}
		return null;
	}
}
