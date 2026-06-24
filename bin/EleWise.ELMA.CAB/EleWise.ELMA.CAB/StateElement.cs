using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Threading;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB;

[Serializable]
public class StateElement : NameObjectCollectionBase, IChangeNotification, IDisposable
{
	private readonly object changedKey = new object();

	private readonly EventHandlerList handlers = new EventHandlerList();

	private readonly IDictionary<object, string> valueIndexed = new Dictionary<object, string>();

	internal ReaderWriterLock syncRoot = new ReaderWriterLock();

	protected object this[string key]
	{
		get
		{
			Guard.ArgumentNotNull(key, "key");
			using (new ReaderLock(syncRoot))
			{
				return BaseGet(key);
			}
		}
		set
		{
			Guard.ArgumentNotNull(key, "key");
			using (new WriterLock(syncRoot))
			{
				object obj = BaseGet(key);
				if (obj != null)
				{
					Remove(key);
				}
				BaseSet(key, value);
				if (value != null)
				{
					valueIndexed[value] = key;
				}
				RaiseStateChanged(key, value, obj);
				if (value != null)
				{
					HookChangeNotification(value as IChangeNotification);
				}
			}
		}
	}

	event EventHandler IChangeNotification.Changed
	{
		add
		{
			handlers.AddHandler(changedKey, value);
		}
		remove
		{
			handlers.RemoveHandler(changedKey, value);
		}
	}

	public event EventHandler<StateChangedEventArgs> StateChanged;

	public StateElement()
	{
	}

	protected StateElement(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void HookChangeNotification(IChangeNotification element)
	{
		if (element != null)
		{
			element.Changed -= ChildChanged;
			element.Changed += ChildChanged;
		}
	}

	private void UnHookChangeNotification(IChangeNotification element)
	{
		if (element != null)
		{
			element.Changed -= ChildChanged;
		}
	}

	private void ChildChanged(object sender, EventArgs e)
	{
		if (valueIndexed.ContainsKey(sender))
		{
			RaiseStateChanged(valueIndexed[sender], sender);
		}
	}

	public void Remove(string key)
	{
		Guard.ArgumentNotNull(key, "key");
		using (new WriterLock(syncRoot))
		{
			object obj = BaseGet(key);
			UnHookChangeNotification(obj as IChangeNotification);
			BaseRemove(key);
			if (obj != null)
			{
				valueIndexed.Remove(obj);
			}
		}
	}

	public void RaiseStateChanged(string key, object newValue, object oldValue)
	{
		OnStateChanged(new StateChangedEventArgs(key, newValue, oldValue));
	}

	public void RaiseStateChanged(string key, object newValue)
	{
		RaiseStateChanged(key, newValue, null);
	}

	protected virtual void OnStateChanged(StateChangedEventArgs e)
	{
		this.StateChanged?.Invoke(this, e);
		((EventHandler)handlers[changedKey])?.Invoke(this, EventArgs.Empty);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			handlers.Dispose();
		}
	}
}
