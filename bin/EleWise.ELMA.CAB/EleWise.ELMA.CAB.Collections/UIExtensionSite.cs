using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using EleWise.ELMA.CAB.UIElements;

namespace EleWise.ELMA.CAB.Collections;

public class UIExtensionSite : IEnumerable<object>, IEnumerable
{
	private readonly IUIElementAdapter adapter;

	private readonly List<object> items = new List<object>();

	public int Count => items.Count;

	public UIExtensionSite(IUIElementAdapter adapter)
	{
		this.adapter = adapter;
	}

	IEnumerator<object> IEnumerable<object>.GetEnumerator()
	{
		IEnumerator<object> enumerator = items.GetEnumerator();
		IEnumerator<object> enumerator2 = enumerator;
		__ContractsRuntime.Ensures(enumerator2 != null, null, "Contract.Result<IEnumerator<T>>() != null");
		return enumerator2;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		IEnumerator enumerator = items.GetEnumerator();
		IEnumerator enumerator2 = enumerator;
		__ContractsRuntime.Ensures(enumerator2 != null, null, "Contract.Result<IEnumerator>() != null");
		return enumerator2;
	}

	public TElement Add<TElement>(TElement uiElement)
	{
		TElement val = (TElement)adapter.Add(uiElement);
		items.Add(val);
		return val;
	}

	public void Clear()
	{
		foreach (object item in items)
		{
			adapter.Remove(item);
		}
		items.Clear();
	}

	public bool Contains(object uiElement)
	{
		return items.Contains(uiElement);
	}

	public void Remove(object uiElement)
	{
		if (items.Contains(uiElement))
		{
			adapter.Remove(uiElement);
			items.Remove(uiElement);
		}
	}

	internal UIExtensionSite Duplicate()
	{
		return new UIExtensionSite(adapter);
	}
}
