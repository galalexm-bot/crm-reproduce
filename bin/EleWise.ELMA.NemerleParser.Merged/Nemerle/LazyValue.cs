using System;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;

namespace Nemerle;

public class LazyValue<_0027a>
{
	private sealed class _N_closureOf_get_Value_17666
	{
		internal Exception _N_e_17671;

		internal _N_closureOf_get_Value_17666()
		{
		}
	}

	private sealed class _N__N_lambda__17660__17676 : Function<_0027a>
	{
		[SpecialName]
		private _N_closureOf_get_Value_17666 _N_get_Value_closure_17680;

		public _N__N_lambda__17660__17676(_N_closureOf_get_Value_17666 _N_get_Value_closure_17680)
		{
			this._N_get_Value_closure_17680 = _N_get_Value_closure_17680;
		}

		[SpecialName]
		public sealed override _0027a apply()
		{
			//Discarded unreachable code: IL_000c
			throw _N_get_Value_closure_17680._N_e_17671;
		}
	}

	private _0027a val;

	private Function<_0027a> computation;

	public _0027a Value
	{
		get
		{
			//Discarded unreachable code: IL_0062
			_N_closureOf_get_Value_17666 n_closureOf_get_Value_ = new _N_closureOf_get_Value_17666();
			lock (this)
			{
				try
				{
					if (computation != null)
					{
						val = computation.apply();
						computation = null;
					}
					return val;
				}
				catch (Exception n_e_)
				{
					Exception ex = (n_closureOf_get_Value_._N_e_17671 = n_e_);
					Function<_0027a> function = (computation = new _N__N_lambda__17660__17676(n_closureOf_get_Value_));
					throw;
				}
			}
		}
	}

	public LazyValue(Function<_0027a> f)
	{
		computation = f;
	}

	public static LazyValue<_0027a> FromValue(_0027a val)
	{
		return new LazyValue<_0027a>(val, null);
	}

	private LazyValue(_0027a val, Function<_0027a> fn)
	{
		this.val = val;
		computation = fn;
	}

	public static implicit operator _0027a(LazyValue<_0027a> x)
	{
		return x.Value;
	}

	public static implicit operator LazyValue<_0027a>(_0027a x)
	{
		return FromValue(x);
	}

	public override string ToString()
	{
		return Convert.ToString(Value);
	}

	public override bool Equals(object x)
	{
		return Value.Equals(x);
	}

	public override int GetHashCode()
	{
		return Value.GetHashCode();
	}
}
