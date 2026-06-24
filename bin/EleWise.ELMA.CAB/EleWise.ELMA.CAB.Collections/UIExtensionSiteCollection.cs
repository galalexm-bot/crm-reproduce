using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using EleWise.ELMA.CAB.Properties;
using EleWise.ELMA.CAB.UIElements;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.Collections;

public class UIExtensionSiteCollection : ICollection, IEnumerable<string>, IEnumerable, IDisposable
{
	private readonly List<IUIElementAdapter> createdAdapters = new List<IUIElementAdapter>();

	private readonly UIExtensionSiteCollection parent;

	private readonly WorkItem rootWorkItem;

	private readonly Dictionary<string, UIExtensionSite> sites = new Dictionary<string, UIExtensionSite>();

	public UIExtensionSite this[string siteName]
	{
		get
		{
			if (sites.ContainsKey(siteName))
			{
				return sites[siteName];
			}
			if (parent != null)
			{
				UIExtensionSite uIExtensionSite = parent[siteName].Duplicate();
				sites.Add(siteName, uIExtensionSite);
				return uIExtensionSite;
			}
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.ExtensionSiteDoesNotExist, new object[1] { siteName }), "siteName");
		}
	}

	public int Count
	{
		get
		{
			int num = 0;
			foreach (string item in (IEnumerable<string>)this)
			{
				num++;
			}
			return num;
		}
	}

	private IUIElementAdapterFactoryCatalog FactoryCatalog => rootWorkItem.Services.Get<IUIElementAdapterFactoryCatalog>();

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

	public UIExtensionSiteCollection()
		: this(null, null)
	{
	}

	public UIExtensionSiteCollection(WorkItem rootWorkItem)
		: this(rootWorkItem, null)
	{
	}

	public UIExtensionSiteCollection(UIExtensionSiteCollection parent)
		: this(parent.rootWorkItem, parent)
	{
	}

	private UIExtensionSiteCollection(WorkItem rootWorkItem, UIExtensionSiteCollection parent)
	{
		this.parent = parent;
		this.rootWorkItem = rootWorkItem;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		IEnumerator enumerator = ((IEnumerable<string>)this).GetEnumerator();
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

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	IEnumerator<string> IEnumerable<string>.GetEnumerator()
	{
		GetEnumerator_003Ed__0 getEnumerator_003Ed__ = new GetEnumerator_003Ed__0(0);
		getEnumerator_003Ed__._003C_003E4__this = this;
		IEnumerator<string> enumerator = getEnumerator_003Ed__;
		IEnumerator<string> enumerator2 = enumerator;
		__ContractsRuntime.Ensures(enumerator2 != null, null, "Contract.Result<IEnumerator<T>>() != null");
		return enumerator2;
	}

	public bool Contains(string siteName)
	{
		if (sites.ContainsKey(siteName))
		{
			return true;
		}
		if (parent != null)
		{
			return parent.Contains(siteName);
		}
		return false;
	}

	public void RegisterSite(string siteName, object uiElement)
	{
		Guard.ArgumentNotNullOrEmptyString(siteName, "siteName");
		Guard.ArgumentNotNull(uiElement, "uiElement");
		IUIElementAdapterFactory factory = FactoryCatalog.GetFactory(uiElement);
		IUIElementAdapter adapter = factory.GetAdapter(uiElement);
		createdAdapters.Add(adapter);
		RegisterSite(siteName, adapter);
	}

	public void RegisterSite(string siteName, IUIElementAdapter adapter)
	{
		Guard.ArgumentNotNullOrEmptyString(siteName, "siteName");
		Guard.ArgumentNotNull(adapter, "adapter");
		if (Contains(siteName))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.DuplicateUIExtensionSite, new object[1] { siteName }), "siteName");
		}
		sites.Add(siteName, new UIExtensionSite(adapter));
	}

	public void UnregisterSite(string siteName)
	{
		Guard.ArgumentNotNullOrEmptyString(siteName, "siteName");
		if (parent != null && parent.Contains(siteName))
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Resources.CannotUnregisterSiteRegisteredWithParent, new object[1] { siteName }), "siteName");
		}
		sites.Remove(siteName);
	}

	protected virtual void Dispose(bool disposing)
	{
		foreach (UIExtensionSite value in sites.Values)
		{
			value.Clear();
		}
		foreach (IUIElementAdapter createdAdapter in createdAdapters)
		{
			if (createdAdapter is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
		sites.Clear();
		createdAdapters.Clear();
	}
}
