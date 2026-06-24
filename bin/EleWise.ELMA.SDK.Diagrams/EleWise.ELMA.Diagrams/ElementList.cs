using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Diagrams;

[Serializable]
public class ElementList : IList<Element>, ICollection<Element>, IEnumerable<Element>, IEnumerable, IList, ICollection, ISerializable
{
	private List<Element> elements = new List<Element>();

	private Dictionary<Guid, Element> elementsByUid = new Dictionary<Guid, Element>();

	private const string ELEMENT_ALREADY_EXISTS = "Element with uid=[{0}] already exists";

	public Element this[int index]
	{
		get
		{
			return elements[index];
		}
		set
		{
			Element element = this[index];
			if (element != value)
			{
				elementsByUid.Remove(element.Uid);
			}
			if (elementsByUid.ContainsKey(value.Uid))
			{
				throw new ArgumentException($"Element with uid=[{value.Uid}] already exists");
			}
			elements[index] = value;
			elementsByUid.Add(value.Uid, value);
		}
	}

	public Element this[Guid uid]
	{
		get
		{
			elementsByUid.TryGetValue(uid, out var value);
			return value;
		}
	}

	public int Count => elements.Count;

	public bool IsReadOnly => false;

	bool IList.IsFixedSize => ((IList)elements).IsFixedSize;

	object IList.this[int index]
	{
		get
		{
			return this[index];
		}
		set
		{
			Contract.CheckArgument(value is Element, "value is Element");
			Element element2 = (this[index] = (Element)value);
		}
	}

	bool ICollection.IsSynchronized => ((ICollection)elements).IsSynchronized;

	object ICollection.SyncRoot => ((ICollection)elements).SyncRoot;

	public ElementList()
	{
	}

	public ElementList(SerializationInfo info, StreamingContext context)
	{
		SerializationInfoEnumerator enumerator = info.GetEnumerator();
		enumerator.Reset();
		while (enumerator.MoveNext())
		{
			Add((Element)info.GetValue(enumerator.Name, enumerator.ObjectType));
		}
	}

	public int IndexOf(Element item)
	{
		return elements.IndexOf(item);
	}

	private bool CheckNewItem(Element item)
	{
		if (elements.Contains(item))
		{
			return false;
		}
		if (elementsByUid.ContainsKey(item.Uid))
		{
			item.Uid = Guid.NewGuid();
		}
		return true;
	}

	public void Insert(int index, Element item)
	{
		Contract.ArgumentNotNull(item, "item");
		if (CheckNewItem(item))
		{
			elements.Insert(index, item);
			elementsByUid.Add(item.Uid, item);
		}
	}

	public void InsertOrAdd(int index, Element item)
	{
		Contract.ArgumentNotNull(item, "item");
		if (elements.Count - 1 <= index)
		{
			elements.Add(item);
		}
		else
		{
			elements.Insert(index, item);
		}
		elementsByUid.Add(item.Uid, item);
	}

	public void RemoveAt(int index)
	{
		Element item = elements[index];
		Remove(item);
	}

	public void Add(Element item)
	{
		Contract.ArgumentNotNull(item, "item");
		if (CheckNewItem(item))
		{
			elements.Add(item);
			elementsByUid.Add(item.Uid, item);
		}
	}

	public void Clear()
	{
		elements.Clear();
		elementsByUid.Clear();
	}

	public bool Contains(Element item)
	{
		return elements.Contains(item);
	}

	public void CopyTo(Element[] array, int arrayIndex)
	{
		elements.CopyTo(array, arrayIndex);
	}

	public bool Remove(Element item)
	{
		Contract.ArgumentNotNull(item, "item");
		elementsByUid.Remove(item.Uid);
		return elements.Remove(item);
	}

	public IEnumerator<Element> GetEnumerator()
	{
		return elements.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return elements.GetEnumerator();
	}

	int IList.Add(object value)
	{
		Contract.CheckArgument(value is Element, "value is Element");
		Element item = (Element)value;
		Add(item);
		return IndexOf(item);
	}

	bool IList.Contains(object value)
	{
		Contract.CheckArgument(value is Element, "value is Element");
		Element item = (Element)value;
		return Contains(item);
	}

	int IList.IndexOf(object value)
	{
		Contract.CheckArgument(value is Element, "value is Element");
		Element item = (Element)value;
		return IndexOf(item);
	}

	void IList.Insert(int index, object value)
	{
		Contract.CheckArgument(value is Element, "value is Element");
		Element item = (Element)value;
		Insert(index, item);
	}

	void IList.Remove(object value)
	{
		Contract.CheckArgument(value is Element, "value is Element");
		Element item = (Element)value;
		Remove(item);
	}

	void ICollection.CopyTo(Array array, int index)
	{
		((ICollection)elements).CopyTo(array, index);
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		for (int i = 0; i < elements.Count; i++)
		{
			info.AddValue("V" + i, elements[i]);
		}
	}
}
