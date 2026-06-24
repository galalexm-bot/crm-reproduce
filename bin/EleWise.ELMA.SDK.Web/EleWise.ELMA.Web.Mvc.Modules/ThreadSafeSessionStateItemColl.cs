using System;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading;
using System.Web.SessionState;
using EleWise.ELMA.Collections;

namespace EleWise.ELMA.Web.Mvc.Modules;

[Serializable]
internal class ThreadSafeSessionStateItemCollection : ISessionStateItemCollection, ICollection, IEnumerable, IDeserializationCallback
{
	private readonly NameValueCollection dataKeys = new NameValueCollection();

	private readonly Hashtable dataValues = new Hashtable();

	[NonSerialized]
	private ReaderWriterLockSlim dataLock = new ReaderWriterLockSlim();

	private bool dirty;

	public bool Dirty
	{
		get
		{
			return dirty;
		}
		set
		{
			dirty = true;
		}
	}

	public NameObjectCollectionBase.KeysCollection Keys
	{
		get
		{
			try
			{
				dataLock.EnterReadLock();
				return dataKeys.Keys;
			}
			finally
			{
				dataLock.ExitReadLock();
			}
		}
	}

	public object this[int index]
	{
		get
		{
			try
			{
				dataLock.EnterReadLock();
				return dataValues[dataKeys.GetKey(index)];
			}
			finally
			{
				dataLock.ExitReadLock();
			}
		}
		set
		{
			try
			{
				dataLock.EnterWriteLock();
				dataValues[dataKeys.GetKey(index)] = value;
			}
			finally
			{
				dataLock.ExitWriteLock();
			}
		}
	}

	public object this[string name]
	{
		get
		{
			try
			{
				dataLock.EnterReadLock();
				return dataValues[name];
			}
			finally
			{
				dataLock.ExitReadLock();
			}
		}
		set
		{
			try
			{
				dataLock.EnterWriteLock();
				dataKeys.Set(name, null);
				dataValues[name] = value;
			}
			finally
			{
				dataLock.ExitWriteLock();
			}
		}
	}

	public int Count
	{
		get
		{
			try
			{
				dataLock.EnterReadLock();
				return dataKeys.Count;
			}
			finally
			{
				dataLock.ExitReadLock();
			}
		}
	}

	public bool IsSynchronized => true;

	public object SyncRoot
	{
		get
		{
			throw new InvalidOperationException();
		}
	}

	public void Clear()
	{
		try
		{
			dataLock.EnterWriteLock();
			dataKeys.Clear();
			dataValues.Clear();
		}
		finally
		{
			dataLock.ExitWriteLock();
		}
	}

	public void Remove(string name)
	{
		try
		{
			dataLock.EnterWriteLock();
			dataKeys.Remove(name);
			dataValues.Remove(name);
		}
		finally
		{
			dataLock.ExitWriteLock();
		}
	}

	public void RemoveAt(int index)
	{
		try
		{
			dataLock.EnterWriteLock();
			string key = dataKeys.GetKey(index);
			dataKeys.Remove(key);
			dataValues.Remove(key);
		}
		finally
		{
			dataLock.ExitWriteLock();
		}
	}

	public void CopyTo(Array array, int index)
	{
		try
		{
			dataLock.EnterReadLock();
			dataKeys.Keys.Cast<string>().ToArray().CopyTo(array, index);
		}
		finally
		{
			dataLock.ExitReadLock();
		}
	}

	public IEnumerator GetEnumerator()
	{
		return new SafeEnumerator(dataKeys.GetEnumerator(), dataLock);
	}

	public void OnDeserialization(object sender)
	{
		dataLock = new ReaderWriterLockSlim();
	}
}
