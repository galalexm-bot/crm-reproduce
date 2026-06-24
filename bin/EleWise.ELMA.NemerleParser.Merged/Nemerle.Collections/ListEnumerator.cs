using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nemerle.Core;

namespace Nemerle.Collections;

public class ListEnumerator<T> : IEnumerator, IDisposable, IEnumerator<T>, ICovariantEnumerator<T>
{
	private sealed class _N_closureOf_MoveNext_21117
	{
		internal ListEnumerator<T> _N__N_closurised_this_ptr_21122;

		internal _N_closureOf_MoveNext_21117()
		{
		}
	}

	private list<T> m_list;

	private T m_current;

	private list<T> m_rest;

	private ListEnumState m_state;

	public T Current
	{
		get
		{
			switch (m_state)
			{
			case ListEnumState.Correct:
				return m_current;
			case ListEnumState.BeforeFirst:
			case ListEnumState.AfterLast:
				throw new InvalidOperationException();
			default:
				throw new MatchFailureException();
			}
		}
	}

	public ListEnumerator(list<T> l)
	{
		m_list = l;
		Reset();
	}

	private void Dispose()
	{
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}

	public bool MoveNext()
	{
		_N_closureOf_MoveNext_21117 n_closureOf_MoveNext_ = new _N_closureOf_MoveNext_21117();
		n_closureOf_MoveNext_._N__N_closurised_this_ptr_21122 = this;
		int result;
		switch (m_state)
		{
		case ListEnumState.BeforeFirst:
			m_state = ListEnumState.Correct;
			result = (_N_doMove_21125(n_closureOf_MoveNext_) ? 1 : 0);
			break;
		case ListEnumState.Correct:
			result = (_N_doMove_21125(n_closureOf_MoveNext_) ? 1 : 0);
			break;
		case ListEnumState.AfterLast:
			result = 0;
			break;
		default:
			throw new MatchFailureException();
		}
		return (byte)result != 0;
	}

	public void Reset()
	{
		m_rest = m_list;
		m_state = ListEnumState.BeforeFirst;
	}

	private bool _N_doMove_21125(_N_closureOf_MoveNext_21117 _N_MoveNext_cp_21124)
	{
		T val = default(T);
		list<T> rest = m_rest;
		int result;
		if (rest is list<T>.Cons)
		{
			val = ((list<T>.Cons)rest).hd;
			rest = ((list<T>.Cons)rest).tl;
			m_current = val;
			m_rest = rest;
			result = 1;
		}
		else
		{
			m_state = ListEnumState.AfterLast;
			result = 0;
		}
		return (byte)result != 0;
	}

	[SpecialName]
	object IEnumerator.get_Current()
	{
		return Current;
	}
}
