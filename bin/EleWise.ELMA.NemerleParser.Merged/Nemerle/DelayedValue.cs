using System.Runtime.CompilerServices;
using System.Threading;
using Nemerle.Builtins;

namespace Nemerle;

public class DelayedValue<_0027a> : LazyValue<_0027a>
{
	private sealed class _N_closureOf__ctor_18130
	{
		internal Function<_0027a> _N_f_18137;

		internal DelayedValue<_0027a> _N__N_closurised_this_ptr_18135;

		internal _N_closureOf__ctor_18130()
		{
		}
	}

	private sealed class _N__N_lambda__17690__18139 : Function<_0027a>
	{
		[SpecialName]
		private _N_closureOf__ctor_18130 _N__ctor_closure_18143;

		public _N__N_lambda__17690__18139(_N_closureOf__ctor_18130 _N__ctor_closure_18143)
		{
			this._N__ctor_closure_18143 = _N__ctor_closure_18143;
		}

		[SpecialName]
		public sealed override _0027a apply()
		{
			_N__ctor_closure_18143._N__N_closurised_this_ptr_18135.thread.Join();
			return _N__ctor_closure_18143._N__N_closurised_this_ptr_18135.val;
		}
	}

	private sealed class _N__N_lambda__18081__18148 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf__ctor_18130 _N__ctor_closure_18152;

		public _N__N_lambda__18081__18148(_N_closureOf__ctor_18130 _N__ctor_closure_18152)
		{
			this._N__ctor_closure_18152 = _N__ctor_closure_18152;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N__ctor_closure_18152._N__N_closurised_this_ptr_18135.val = _N__ctor_closure_18152._N_f_18137.apply();
		}
	}

	private sealed class _N_closureOf__ctor_18170
	{
		internal Function<_0027a> _N_f_18177;

		internal DelayedValue<_0027a> _N__N_closurised_this_ptr_18175;

		internal _N_closureOf__ctor_18170()
		{
		}
	}

	private sealed class _N__N_lambda__18160__18179 : Function<_0027a>
	{
		[SpecialName]
		private _N_closureOf__ctor_18170 _N__ctor_closure_18183;

		public _N__N_lambda__18160__18179(_N_closureOf__ctor_18170 _N__ctor_closure_18183)
		{
			this._N__ctor_closure_18183 = _N__ctor_closure_18183;
		}

		[SpecialName]
		public sealed override _0027a apply()
		{
			_N__ctor_closure_18183._N__N_closurised_this_ptr_18175.thread.Join();
			return _N__ctor_closure_18183._N__N_closurised_this_ptr_18175.val;
		}
	}

	private sealed class _N__N_lambda__18164__18188 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf__ctor_18170 _N__ctor_closure_18192;

		public _N__N_lambda__18164__18188(_N_closureOf__ctor_18170 _N__ctor_closure_18192)
		{
			this._N__ctor_closure_18192 = _N__ctor_closure_18192;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N__ctor_closure_18192._N__N_closurised_this_ptr_18175.val = _N__ctor_closure_18192._N_f_18177.apply();
		}
	}

	private readonly Thread thread;

	private _0027a val;

	public bool HasValue => !thread.IsAlive;

	public DelayedValue(Function<_0027a> f)
	{
		_N_closureOf__ctor_18130 n_closureOf__ctor_ = new _N_closureOf__ctor_18130
		{
			_N_f_18137 = f
		};
		base._002Ector((Function<_0027a>)new _N__N_lambda__17690__18139(n_closureOf__ctor_));
		n_closureOf__ctor_._N__N_closurised_this_ptr_18135 = this;
		FunctionVoid functionVoid = new _N__N_lambda__18081__18148(n_closureOf__ctor_);
		thread = new Thread(functionVoid.apply_void);
		thread.Start();
	}

	public DelayedValue(string threadName, Function<_0027a> f)
	{
		_N_closureOf__ctor_18170 n_closureOf__ctor_ = new _N_closureOf__ctor_18170
		{
			_N_f_18177 = f
		};
		base._002Ector((Function<_0027a>)new _N__N_lambda__18160__18179(n_closureOf__ctor_));
		n_closureOf__ctor_._N__N_closurised_this_ptr_18175 = this;
		FunctionVoid functionVoid = new _N__N_lambda__18164__18188(n_closureOf__ctor_);
		thread = new Thread(functionVoid.apply_void);
		thread.Name = threadName;
		thread.Start();
	}

	public static implicit operator _0027a(DelayedValue<_0027a> dv)
	{
		return dv.Value;
	}

	public void Join()
	{
		thread.Join();
	}

	public bool Join(int timeout)
	{
		return thread.Join(timeout);
	}
}
