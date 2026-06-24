using System.Collections.Generic;
using System.Text;
using Nemerle.Builtins;
using Nemerle.Core;

namespace Nemerle.Collections;

public class Queue<_0027a> : System.Collections.Generic.Queue<_0027a>
{
	public bool IsEmpty => Count == 0;

	public int Length => Count;

	public Queue()
	{
	}

	public Queue(int size)
		: base(size)
	{
	}

	public Queue(IEnumerable<_0027a> enu)
		: base(enu)
	{
	}

	public void Push(_0027a x)
	{
		Enqueue(x);
	}

	public void Add(_0027a x)
	{
		Enqueue(x);
	}

	public _0027a Take()
	{
		return Dequeue();
	}

	public _0027a Pop()
	{
		return Dequeue();
	}

	public _0027a Top()
	{
		return Peek();
	}

	public option<_0027a> First()
	{
		return (Count <= 0) ? ((option<_0027a>)option<_0027a>.None._N_constant_object) : ((option<_0027a>)new option<_0027a>.Some(Peek()));
	}

	public Queue<_0027a> Clone()
	{
		return new Queue<_0027a>(this);
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

	public _0027b Fold<_0027b>(Function<_0027a, _0027b, _0027b> f, _0027b x)
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			_0027a val = default(_0027a);
			_0027a current = enumerator.Current;
			val = current;
			x = f.apply(val, x);
		}
		return x;
	}

	public void Transfer(Queue<_0027a> q)
	{
		Clear();
		using Enumerator enumerator = q.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_0027a val = default(_0027a);
			_0027a current = enumerator.Current;
			val = current;
			Push(val);
		}
	}

	public bool ForAll(Function<_0027a, bool> f)
	{
		bool flag = false;
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_0027a val = default(_0027a);
				_0027a current = enumerator.Current;
				val = current;
				if (!f.apply(val))
				{
					return false;
				}
			}
		}
		return true;
	}

	public bool Exists(Function<_0027a, bool> f)
	{
		bool flag = false;
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_0027a val = default(_0027a);
				_0027a current = enumerator.Current;
				val = current;
				if (f.apply(val))
				{
					return true;
				}
			}
		}
		return false;
	}

	public void Filter(Function<_0027a, bool> f)
	{
		int num = 0;
		_0027a[] array = ToArray();
		Clear();
		for (num = 0; num < array.Length; num = checked(num + 1))
		{
			if (f.apply(array[num]))
			{
				Push(array[num]);
			}
		}
	}

	public Queue<_0027b> Map<_0027b>(Function<_0027a, _0027b> f)
	{
		_0027b[] array = new _0027b[Count];
		int num = 0;
		checked
		{
			using (Enumerator enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					_0027a val = default(_0027a);
					_0027a current = enumerator.Current;
					val = current;
					array[num] = f.apply(val);
					num++;
				}
			}
			Queue<_0027b> queue = new Queue<_0027b>(array.Length);
			for (num = 0; num < array.Length; num++)
			{
				queue.Push(array[num]);
			}
			return queue;
		}
	}

	public Tuple<Queue<_0027a>, Queue<_0027a>> Partition(Function<_0027a, bool> f)
	{
		Queue<_0027a> queue = new Queue<_0027a>();
		Queue<_0027a> queue2 = new Queue<_0027a>();
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_0027a val = default(_0027a);
				_0027a current = enumerator.Current;
				val = current;
				if (f.apply(val))
				{
					queue.Push(val);
				}
				else
				{
					queue2.Push(val);
				}
			}
		}
		return new Tuple<Queue<_0027a>, Queue<_0027a>>(queue, queue2);
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
}
