using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Internal;

namespace Nemerle.Collections;

public class Pair<_0027a> : IEnumerable, IEnumerable<_0027a>, IEquatable<Pair<_0027a>>
{
	private class _N_Enumerator_26173 : IEnumerator, IDisposable, IEnumerator<_0027a>
	{
		internal _0027a _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_26191;

		internal Pair<_0027a> _N__N_closurised_this_ptr_26189;

		internal Function<bool> _N__N_wildcard_3438_26187;

		public _0027a Current => _N_current;

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
			try
			{
				bool flag = false;
				if (_N_state != 0)
				{
					if (_N_state != 1)
					{
						if (_N_state != 2)
						{
							return false;
						}
						return false;
					}
					_N_current = _N__N_closurised_this_ptr_26189.snd;
					_N_state = 2;
					return true;
				}
				_N_current = _N__N_closurised_this_ptr_26189.fst;
				_N_state = 1;
				return true;
			}
			catch
			{
				//try-fault
				Dispose();
				throw;
			}
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	public readonly _0027a fst;

	public readonly _0027a snd;

	public bool Equals(Pair<_0027a> p)
	{
		_0027a val = fst;
		int result;
		if (val.Equals(p.fst))
		{
			_0027a val2 = snd;
			result = (val2.Equals(p.snd) ? 1 : 0);
		}
		else
		{
			result = 0;
		}
		return (byte)result != 0;
	}

	public override string ToString()
	{
		return "(" + Convert.ToString(fst) + ", " + Convert.ToString(snd) + ")";
	}

	public IEnumerator<_0027a> GetEnumerator()
	{
		_N_Enumerator_26173 n_Enumerator_ = new _N_Enumerator_26173();
		n_Enumerator_._N__N_closurised_this_ptr_26189 = this;
		return n_Enumerator_;
	}

	public override bool Equals(object other)
	{
		return other == this || (other is Pair<_0027a> && Equals((Pair<_0027a>)other));
	}

	[RecordCtor]
	public Pair([MappedMember("fst")] _0027a fst, [MappedMember("snd")] _0027a snd)
	{
		this.fst = fst;
		this.snd = snd;
	}

	[SpecialName]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
