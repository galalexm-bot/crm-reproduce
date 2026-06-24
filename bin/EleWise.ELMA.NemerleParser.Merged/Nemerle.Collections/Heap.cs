using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;

namespace Nemerle.Collections;

public class Heap<T> : IEnumerable, IEnumerable<T>, System.Collections.Generic.ICollection<T>
{
	private class _N_Enumerator_13899 : IEnumerator, IDisposable, IEnumerator<T>
	{
		internal int _N_i_13921;

		internal T _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_13917;

		internal Heap<T> _N__N_closurised_this_ptr_13915;

		internal Function<bool> _N__N_wildcard_3438_13913;

		public T Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
		}

		public void Reset()
		{
			//Discarded unreachable code: IL_0006
			throw new NotSupportedException();
		}

		public bool MoveNext()
		{
			checked
			{
				try
				{
					bool flag = false;
					if (_N_state != 1)
					{
						if (_N_state != 0)
						{
							return false;
						}
						_N_i_13921 = 1;
					}
					else
					{
						_N_i_13921++;
					}
					if (_N_i_13921 <= _N__N_closurised_this_ptr_13915.m_elements_count)
					{
						_N_current = _N__N_closurised_this_ptr_13915.m_heap[_N_i_13921];
						_N_state = 1;
						return true;
					}
					return false;
				}
				catch
				{
					//try-fault
					Dispose();
					throw;
				}
			}
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	private readonly Function<T, T, int> m_comparison;

	private T[] m_heap;

	private int m_elements_count;

	public bool IsEmpty => m_elements_count == 0;

	public int Count => m_elements_count;

	public int CurrentCapacity => checked(m_heap.Length - 1);

	public bool IsReadOnly => false;

	public int Capacity => checked(m_heap.Length - 1);

	public Heap(T[] a)
		: this(a, NemerleCollectionsComparer.Comparer<T>.Default)
	{
	}

	public Heap(T[] a, Function<T, T, int> comparison)
	{
		m_comparison = comparison;
		m_elements_count = a.Length;
		m_heap = new T[checked(a.Length + 1)];
		a.CopyTo(m_heap, 1);
		build_heap();
	}

	public Heap(IEnumerable<T> coll)
		: this(coll, NemerleCollectionsComparer.Comparer<T>.Default)
	{
	}

	public Heap(IEnumerable<T> coll, Function<T, T, int> comparison)
	{
		m_comparison = comparison;
		m_elements_count = 0;
		m_heap = new T[10];
		IEnumerator<T> enumerator = coll.GetEnumerator();
		checked
		{
			try
			{
				while (enumerator.MoveNext())
				{
					T val = default(T);
					T current = enumerator.Current;
					val = current;
					if (m_elements_count >= m_heap.Length - 1)
					{
						grow();
					}
					m_elements_count++;
					m_heap[m_elements_count] = val;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			build_heap();
		}
	}

	public Heap(int capacity)
		: this(capacity, NemerleCollectionsComparer.Comparer<T>.Default)
	{
	}

	public Heap(int capacity, Function<T, T, int> comparison)
	{
		m_comparison = comparison;
		int num = ((capacity < 10) ? 10 : capacity);
		m_heap = new T[checked(num + 1)];
		m_elements_count = 0;
	}

	private Heap(T[] heap, int count, Function<T, T, int> comparison)
	{
		m_comparison = comparison;
		m_heap = heap;
		m_elements_count = count;
		build_heap();
	}

	public void Insert(T x)
	{
		int num = 0;
		checked
		{
			if (m_elements_count >= m_heap.Length - 1)
			{
				grow();
			}
			m_elements_count++;
			num = m_elements_count;
			while (num > 1 && m_comparison.apply(x, m_heap[parent(num)]) > 0)
			{
				m_heap[num] = m_heap[parent(num)];
				num = parent(num);
			}
			m_heap[num] = x;
		}
	}

	public void Add(T x)
	{
		Insert(x);
	}

	public void Clear()
	{
		Array.Clear(m_heap, 1, m_elements_count);
		m_elements_count = 0;
	}

	public T Top()
	{
		if (m_elements_count == 0)
		{
			throw new EmptyHeap();
		}
		return m_heap[1];
	}

	public T ExtractFirst()
	{
		T val = default(T);
		if (m_elements_count < 1)
		{
			throw new EmptyHeap();
		}
		val = m_heap[1];
		m_heap[1] = m_heap[m_elements_count];
		checked
		{
			m_elements_count--;
			heapify(1);
			return val;
		}
	}

	public void CopyTo(T[] to, int startIdx)
	{
		int num = 0;
		checked
		{
			startIdx--;
			for (num = 1; num <= m_elements_count; num++)
			{
				to[startIdx + num] = m_heap[num];
			}
		}
	}

	public bool Contains(T x)
	{
		return Array.IndexOf(m_heap, x, 1) != -1;
	}

	public Heap<B> Map<B>(Function<T, B> f)
	{
		return Map(f, NemerleCollectionsComparer.Comparer<B>.Default);
	}

	public Heap<B> Map<B>(Function<T, B> f, Function<B, B, int> comparison)
	{
		int num = 0;
		checked
		{
			B[] array = new B[m_heap.Length + 1];
			for (num = 1; num <= m_elements_count; num++)
			{
				array[num] = f.apply(m_heap[num]);
			}
			return new Heap<B>(array, m_elements_count, comparison);
		}
	}

	public void Iter(FunctionVoid<T> f)
	{
		int num = 0;
		for (num = 1; num <= m_elements_count; num = checked(num + 1))
		{
			f.apply_void(m_heap[num]);
		}
	}

	public _0027b Fold<_0027b>(Function<_0027b, T, _0027b> f, _0027b x)
	{
		int num = 0;
		_0027b val = default(_0027b);
		val = x;
		for (num = 1; num <= m_elements_count; num = checked(num + 1))
		{
			val = f.apply(val, m_heap[num]);
		}
		return val;
	}

	public IEnumerator<T> GetEnumerator()
	{
		_N_Enumerator_13899 n_Enumerator_ = new _N_Enumerator_13899();
		n_Enumerator_._N__N_closurised_this_ptr_13915 = this;
		return n_Enumerator_;
	}

	private bool Remove(T _N_wildcard_2419)
	{
		//Discarded unreachable code: IL_000b
		throw new NotSupportedException("remove operation is not supported by heap class");
	}

	bool System.Collections.Generic.ICollection<T>.Remove(T _N_wildcard_2419)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Remove
		return this.Remove(_N_wildcard_2419);
	}

	private void grow()
	{
		checked
		{
			int num = 2 * m_heap.Length;
			T[] array = new T[num + 1];
			m_heap.CopyTo(array, 0);
			m_heap = array;
		}
	}

	private bool is_greater(int k, int l)
	{
		return m_comparison.apply(m_heap[k], m_heap[l]) > 0;
	}

	private static int parent(int i)
	{
		return i >> 1;
	}

	private static int left(int i)
	{
		return i << 1;
	}

	private static int right(int i)
	{
		return checked(2 * i + 1);
	}

	private void heapify(int i)
	{
		int num = 0;
		T val = default(T);
		while (true)
		{
			num = left(i);
			int num2 = right(i);
			num = ((num > m_elements_count || !is_greater(num, i)) ? i : num);
			if (num2 <= m_elements_count && is_greater(num2, num))
			{
				num = num2;
			}
			if (num != i)
			{
				T[] heap = m_heap;
				T[] heap2 = m_heap;
				val = heap[i];
				heap[i] = heap2[num];
				heap2[num] = val;
				i = num;
				continue;
			}
			break;
		}
	}

	private void build_heap()
	{
		int num = 0;
		for (num = m_elements_count / 2; num >= 1; num = checked(num - 1))
		{
			heapify(num);
		}
	}

	public void RebuildHeap()
	{
		build_heap();
	}

	[SpecialName]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
