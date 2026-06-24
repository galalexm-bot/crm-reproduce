using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using EleWise.ELMA.CAB.Properties;
using EleWise.ELMA.CAB.Services;
using EleWise.ELMA.CAB.Utility;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB.Collections;

public class ServiceCollection : ICollection, IEnumerable<KeyValuePair<Type, object>>, IEnumerable
{
	private class DemandAddPlaceholder
	{
		private readonly Type typeToCreate;

		public Type TypeToCreate => typeToCreate;

		public DemandAddPlaceholder(Type typeToCreate)
		{
			this.typeToCreate = typeToCreate;
		}
	}

	private readonly IBuilder<BuilderStage> builder;

	private readonly ILifetimeContainer container;

	private readonly IReadWriteLocator locator;

	private readonly ServiceCollection parent;

	int ICollection.Count
	{
		get
		{
			//Discarded unreachable code: IL_0007
			throw new NotImplementedException();
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

	public event EventHandler<DataEventArgs<object>> Added;

	public event EventHandler<DataEventArgs<object>> Removed;

	public ServiceCollection(ILifetimeContainer container, IReadWriteLocator locator, IBuilder<BuilderStage> builder, ServiceCollection parent)
	{
		this.builder = builder;
		this.container = container;
		this.locator = locator;
		this.parent = parent;
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

	public IEnumerator<KeyValuePair<Type, object>> GetEnumerator()
	{
		_003CGetEnumerator_003Ed__0 _003CGetEnumerator_003Ed__ = new _003CGetEnumerator_003Ed__0(0);
		_003CGetEnumerator_003Ed__._003C_003E4__this = this;
		IEnumerator<KeyValuePair<Type, object>> enumerator = _003CGetEnumerator_003Ed__;
		IEnumerator<KeyValuePair<Type, object>> enumerator2 = enumerator;
		__ContractsRuntime.Ensures(enumerator2 != null, null, "Contract.Result<IEnumerator<T>>() != null");
		return enumerator2;
	}

	public void Add<TService>(TService serviceInstance)
	{
		Add(typeof(TService), serviceInstance);
	}

	public void Add(Type serviceType, object serviceInstance)
	{
		Guard.ArgumentNotNull(serviceType, "serviceType");
		Guard.ArgumentNotNull(serviceInstance, "serviceInstance");
		Build(serviceInstance.GetType(), serviceType, serviceInstance);
	}

	public void AddOnDemand<TService>()
	{
		AddOnDemand(typeof(TService), null);
	}

	public void AddOnDemand<TService, TRegisterAs>()
	{
		AddOnDemand(typeof(TService), typeof(TRegisterAs));
	}

	public void AddOnDemand(Type serviceType)
	{
		AddOnDemand(serviceType, null);
	}

	public void AddOnDemand(Type serviceType, Type registerAs)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		Guard.ArgumentNotNull(serviceType, "serviceType");
		if (registerAs == null)
		{
			registerAs = serviceType;
		}
		DependencyResolutionLocatorKey val = new DependencyResolutionLocatorKey(registerAs, (string)null);
		if (((IReadableLocator)locator).Contains((object)val, (SearchMode)1))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.DuplicateService, new object[1] { registerAs.FullName }));
		}
		DemandAddPlaceholder demandAddPlaceholder = new DemandAddPlaceholder(serviceType);
		locator.Add((object)val, (object)demandAddPlaceholder);
		container.Add((object)demandAddPlaceholder);
	}

	public TService AddNew<TService>()
	{
		return AddNew<TService, TService>();
	}

	public TService AddNew<TService, TRegisterAs>() where TService : TRegisterAs
	{
		return (TService)AddNew(typeof(TService), typeof(TRegisterAs));
	}

	public object AddNew(Type serviceType)
	{
		return AddNew(serviceType, serviceType);
	}

	public object AddNew(Type serviceType, Type registerAs)
	{
		Guard.ArgumentNotNull(serviceType, "serviceType");
		Guard.ArgumentNotNull(registerAs, "registerAs");
		return Build(serviceType, registerAs, null);
	}

	public bool Contains<TService>()
	{
		return Contains(typeof(TService));
	}

	public bool Contains(Type serviceType)
	{
		return Contains(serviceType, (SearchMode)0);
	}

	private bool Contains(Type serviceType, SearchMode searchMode)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		Guard.ArgumentNotNull(serviceType, "serviceType");
		return ((IReadableLocator)locator).Contains((object)new DependencyResolutionLocatorKey(serviceType, (string)null), searchMode);
	}

	public bool ContainsLocal(Type serviceType)
	{
		return Contains(serviceType, (SearchMode)1);
	}

	public TService Get<TService>()
	{
		return (TService)Get(typeof(TService), ensureExists: false);
	}

	public TService Get<TService>(bool ensureExists)
	{
		return (TService)Get(typeof(TService), ensureExists);
	}

	public object Get(Type serviceType)
	{
		return Get(serviceType, ensureExists: false);
	}

	public object Get(Type serviceType, bool ensureExists)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		Guard.ArgumentNotNull(serviceType, "serviceType");
		if (Contains(serviceType, (SearchMode)1))
		{
			object obj = ((IReadableLocator)locator).Get((object)new DependencyResolutionLocatorKey(serviceType, (string)null));
			if (obj is DemandAddPlaceholder demandAddPlaceholder)
			{
				Remove(serviceType);
				obj = Build(demandAddPlaceholder.TypeToCreate, serviceType, null);
			}
			return obj;
		}
		if (parent != null)
		{
			return parent.Get(serviceType, ensureExists);
		}
		if (ensureExists)
		{
			throw new ServiceMissingException(serviceType);
		}
		return null;
	}

	public void Remove<TService>()
	{
		Remove(typeof(TService));
	}

	public void Remove(Type serviceType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		Guard.ArgumentNotNull(serviceType, "serviceType");
		DependencyResolutionLocatorKey val = new DependencyResolutionLocatorKey(serviceType, (string)null);
		if (!((IReadableLocator)locator).Contains((object)val, (SearchMode)1))
		{
			return;
		}
		object obj = ((IReadableLocator)locator).Get((object)val, (SearchMode)1);
		bool flag = true;
		locator.Remove((object)new DependencyResolutionLocatorKey(serviceType, (string)null));
		foreach (KeyValuePair<object, object> item in (IEnumerable<KeyValuePair<object, object>>)locator)
		{
			if (object.ReferenceEquals(item.Value, obj))
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			builder.TearDown<object>(locator, obj);
			container.Remove(obj);
			if (!(obj is DemandAddPlaceholder))
			{
				OnRemoved(obj);
			}
		}
	}

	protected virtual void OnAdded(object service)
	{
		if (this.Added != null)
		{
			this.Added(this, new DataEventArgs<object>(service));
		}
	}

	protected virtual void OnRemoved(object service)
	{
		if (this.Removed != null)
		{
			this.Removed(this, new DataEventArgs<object>(service));
		}
	}

	private object Build(Type typeToBuild, Type typeToRegisterAs, object serviceInstance)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Guard.TypeIsAssignableFromType(typeToBuild, typeToRegisterAs, "typeToBuild");
		if (((IReadableLocator)locator).Contains((object)new DependencyResolutionLocatorKey(typeToRegisterAs, (string)null), (SearchMode)1))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.DuplicateService, new object[1] { typeToRegisterAs.FullName }));
		}
		if (serviceInstance == null)
		{
			serviceInstance = BuildFirstTimeItem(typeToBuild, typeToRegisterAs, null);
		}
		else if (!container.Contains(serviceInstance))
		{
			serviceInstance = BuildFirstTimeItem(typeToBuild, typeToRegisterAs, serviceInstance);
		}
		else
		{
			BuildRepeatedItem(typeToRegisterAs, serviceInstance);
		}
		return serviceInstance;
	}

	private object BuildFirstTimeItem(Type typeToBuild, Type typeToRegisterAs, object item)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		item = builder.BuildUp(locator, typeToBuild, (string)null, item, (PolicyList[])(object)new PolicyList[0]);
		if (typeToRegisterAs != typeToBuild)
		{
			locator.Add((object)new DependencyResolutionLocatorKey(typeToRegisterAs, (string)null), item);
			locator.Remove((object)new DependencyResolutionLocatorKey(typeToBuild, (string)null));
		}
		OnAdded(item);
		return item;
	}

	private void BuildRepeatedItem(Type typeToRegisterAs, object item)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		locator.Add((object)new DependencyResolutionLocatorKey(typeToRegisterAs, (string)null), item);
	}
}
