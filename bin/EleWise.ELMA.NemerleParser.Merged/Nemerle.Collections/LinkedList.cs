using System;
using System.Collections.Generic;
using System.Text;
using Nemerle.Builtins;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Collections;

public class LinkedList<_0027a> : System.Collections.Generic.LinkedList<_0027a>, ICollection<_0027a>, IEquatable<LinkedList<_0027a>>
{
	public bool IsEmpty => Count == 0;

	public LinkedList()
	{
	}

	public LinkedList(list<_0027a> some_list)
	{
		_0027a val = default(_0027a);
		base._002Ector();
		if (!(some_list == null))
		{
			list<_0027a> list = some_list;
			while (list is list<_0027a>.Cons)
			{
				val = ((list<_0027a>.Cons)list).hd;
				list = ((list<_0027a>.Cons)list).tl;
				LinkedListNode<_0027a> linkedListNode = AddLast(val);
				list = list;
			}
		}
	}

	private void concat_helper(string separator, StringBuilder sb)
	{
		if (!IsEmpty)
		{
			Enumerator enumerator = GetEnumerator();
			bool flag = enumerator.MoveNext();
			StringBuilder stringBuilder = sb.Append(enumerator.Current);
			while (enumerator.MoveNext())
			{
				stringBuilder = sb.Append(separator);
				stringBuilder = sb.Append(enumerator.Current);
			}
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("[");
		concat_helper(", ", stringBuilder);
		return stringBuilder.Append("]").ToString();
	}

	public string ToString(string separator)
	{
		StringBuilder stringBuilder = new StringBuilder();
		concat_helper(separator, stringBuilder);
		return stringBuilder.ToString();
	}

	public bool Equals(LinkedList<_0027a> another_list)
	{
		Enumerator enumerator = GetEnumerator();
		Enumerator enumerator2 = another_list.GetEnumerator();
		int result;
		while (true)
		{
			bool flag = enumerator.MoveNext();
			bool flag2 = enumerator2.MoveNext();
			if (flag != flag2)
			{
				result = 0;
				break;
			}
			if (flag)
			{
				if (enumerator.Current.Equals(enumerator2.Current))
				{
					continue;
				}
				result = 0;
				break;
			}
			result = 1;
			break;
		}
		return (byte)result != 0;
	}

	public void Reverse()
	{
		LinkedListNode<_0027a> linkedListNode = null;
		if (!IsEmpty)
		{
			linkedListNode = Last.Previous;
			while (linkedListNode != null)
			{
				LinkedListNode<_0027a> linkedListNode2 = AddLast(linkedListNode.Value);
				linkedListNode2 = linkedListNode.Previous;
				Remove(linkedListNode);
				linkedListNode = linkedListNode2;
			}
		}
	}

	public void Prepend(_0027a item)
	{
		LinkedListNode<_0027a> linkedListNode = AddFirst(item);
	}

	public void Prepend([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] LinkedList<_0027a> l)
	{
		LinkedListNode<_0027a> linkedListNode = null;
		if (l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\linkedlist.n:133:31:133:32: .");
		}
		if (!l.IsEmpty)
		{
			Enumerator enumerator = l.GetEnumerator();
			if (!enumerator.MoveNext())
			{
				throw new AssertionException("lib\\linkedlist.n", 137, "enu.MoveNext()", "");
			}
			linkedListNode = AddFirst(enumerator.Current);
			while (enumerator.MoveNext())
			{
				linkedListNode = AddAfter(linkedListNode, enumerator.Current);
			}
		}
	}

	public void Append(_0027a item)
	{
		LinkedListNode<_0027a> linkedListNode = AddLast(item);
	}

	public void Append([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] LinkedList<_0027a> l)
	{
		if (l == null)
		{
			throw new ArgumentNullException("l", "The ``NotNull'' contract of parameter ``l'' has been violated. See lib\\linkedlist.n:153:30:153:31: .");
		}
		using Enumerator enumerator = l.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_0027a val = default(_0027a);
			_0027a current = enumerator.Current;
			val = current;
			AddLast(val);
		}
	}

	public void Add(_0027a item)
	{
		LinkedListNode<_0027a> linkedListNode = AddFirst(item);
	}

	public new option<_0027a> First()
	{
		LinkedListNode<_0027a> first = base.First;
		return ((object)first != null) ? ((option<_0027a>)new option<_0027a>.Some(first.Value)) : ((option<_0027a>)option<_0027a>.None._N_constant_object);
	}

	public ICollection<_0027a> Clone()
	{
		LinkedList<_0027a> linkedList = new LinkedList<_0027a>();
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			_0027a val = default(_0027a);
			_0027a current = enumerator.Current;
			val = current;
			linkedList.Append(val);
		}
		return linkedList;
	}

	public _0027b Fold<_0027b>(Function<_0027a, _0027b, _0027b> f, _0027b x)
	{
		_0027b val = x;
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			_0027a val2 = default(_0027a);
			_0027a current = enumerator.Current;
			val2 = current;
			val = f.apply(val2, val);
		}
		return val;
	}

	public ICollection<_0027b> Map<_0027b>(Function<_0027a, _0027b> f)
	{
		LinkedList<_0027b> linkedList = new LinkedList<_0027b>();
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			_0027a val = default(_0027a);
			_0027a current = enumerator.Current;
			val = current;
			linkedList.Append(f.apply(val));
		}
		return linkedList;
	}

	public void Iter(FunctionVoid<_0027a> f)
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			_0027a val = default(_0027a);
			_0027a current = enumerator.Current;
			val = current;
			f.apply_void(val);
		}
	}

	public bool ForAll(Function<_0027a, bool> f)
	{
		Enumerator enumerator = GetEnumerator();
		int result;
		while (true)
		{
			if (enumerator.MoveNext())
			{
				if (f.apply(enumerator.Current))
				{
					continue;
				}
				result = 0;
				break;
			}
			result = 1;
			break;
		}
		return (byte)result != 0;
	}

	public bool Exists(Function<_0027a, bool> f)
	{
		Enumerator enumerator = GetEnumerator();
		int result;
		while (true)
		{
			if (enumerator.MoveNext())
			{
				if (f.apply(enumerator.Current))
				{
					result = 1;
					break;
				}
				continue;
			}
			result = 0;
			break;
		}
		return (byte)result != 0;
	}

	public void Filter(Function<_0027a, bool> f)
	{
		LinkedListNode<_0027a> linkedListNode = null;
		if (IsEmpty)
		{
			return;
		}
		linkedListNode = base.First;
		while (linkedListNode != null)
		{
			LinkedListNode<_0027a> next = linkedListNode.Next;
			if (!f.apply(linkedListNode.Value))
			{
				Remove(linkedListNode);
			}
			linkedListNode = next;
		}
	}

	public Nemerle.Builtins.Tuple<ICollection<_0027a>, ICollection<_0027a>> Partition(Function<_0027a, bool> f)
	{
		LinkedList<_0027a> linkedList = new LinkedList<_0027a>();
		LinkedList<_0027a> linkedList2 = new LinkedList<_0027a>();
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_0027a val = default(_0027a);
				_0027a current = enumerator.Current;
				val = current;
				if (f.apply(val))
				{
					linkedList.Append(val);
				}
				else
				{
					linkedList2.Append(val);
				}
			}
		}
		return new Nemerle.Builtins.Tuple<ICollection<_0027a>, ICollection<_0027a>>(linkedList, linkedList2);
	}

	public new void Remove(_0027a item)
	{
		while (base.Remove(item))
		{
		}
	}

	public override bool Equals(object other)
	{
		return other == this || (other is LinkedList<_0027a> && Equals((LinkedList<_0027a>)other));
	}
}
