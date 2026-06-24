using System.Collections.Generic;
using System.Text;
using Nemerle.Builtins;
using Nemerle.Core;

namespace Nemerle.Collections;

public class Stack<_0027a> : System.Collections.Generic.Stack<_0027a>
{
	public bool IsEmpty => Count == 0;

	public int Length => Count;

	public int Height => Count;

	public _0027a Top
	{
		get
		{
			return Peek();
		}
		set
		{
			_0027a val = default(_0027a);
			val = Pop();
			Push(value);
		}
	}

	public void RemoveLast()
	{
		_0027a val = default(_0027a);
		val = Pop();
	}

	public void Add(_0027a x)
	{
		Push(x);
	}

	public Stack()
	{
	}

	public Stack(int capacity)
		: base(capacity)
	{
	}

	public Stack(IEnumerable<_0027a> enu)
		: base(enu)
	{
	}

	public option<_0027a> First()
	{
		return (Count <= 0) ? ((option<_0027a>)option<_0027a>.None._N_constant_object) : ((option<_0027a>)new option<_0027a>.Some(Peek()));
	}

	public Stack<_0027a> Clone()
	{
		return new Stack<_0027a>(this);
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

	public Stack<_0027b> Map<_0027b>(Function<_0027a, _0027b> f)
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
			Stack<_0027b> stack = new Stack<_0027b>(array.Length);
			for (num = array.Length - 1; num >= 0; num--)
			{
				stack.Push(array[num]);
			}
			return stack;
		}
	}

	public void Filter(Function<_0027a, bool> f)
	{
		int num = 0;
		_0027a[] array = ToArray();
		Clear();
		checked
		{
			for (num = array.Length - 1; num >= 0; num--)
			{
				if (f.apply(array[num]))
				{
					Push(array[num]);
				}
			}
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

	public Tuple<Stack<_0027a>, Stack<_0027a>> Partition(Function<_0027a, bool> f)
	{
		int num = 0;
		_0027a val = default(_0027a);
		_0027a[] array = ToArray();
		Stack<_0027a> stack = new Stack<_0027a>();
		Stack<_0027a> stack2 = new Stack<_0027a>();
		checked
		{
			for (num = array.Length - 1; num >= 0; num--)
			{
				val = array[num];
				if (f.apply(val))
				{
					stack.Push(val);
				}
				else
				{
					stack2.Push(val);
				}
			}
			return new Tuple<Stack<_0027a>, Stack<_0027a>>(stack, stack2);
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
}
