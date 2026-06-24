using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Nemerle.Builtins;

[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027r>
{
	private sealed class _N_closureOf_op_RightShift_14256<B>
	{
		internal Function<_0027p1, B> _N_fab_14263;

		internal Function<B, _0027r> _N_fbc_14261;

		internal _N_closureOf_op_RightShift_14256()
		{
		}
	}

	private sealed class _N__N_lambda__14250__14265<B> : Function<_0027p1, _0027r>
	{
		[SpecialName]
		private _N_closureOf_op_RightShift_14256<B> _N_op_RightShift_closure_14269;

		public _N__N_lambda__14250__14265(_N_closureOf_op_RightShift_14256<B> _N_op_RightShift_closure_14269)
		{
			this._N_op_RightShift_closure_14269 = _N_op_RightShift_closure_14269;
		}

		[SpecialName]
		public sealed override _0027r apply(_0027p1 a)
		{
			return _N_op_RightShift_closure_14269._N_fbc_14261.apply(_N_op_RightShift_closure_14269._N_fab_14263.apply(a));
		}
	}

	private sealed class _N_closureOf_op_RightShift_14282<B>
	{
		internal Function<B> _N_fab_14289;

		internal Function<B, _0027r> _N_fbc_14287;

		internal _N_closureOf_op_RightShift_14282()
		{
		}
	}

	private sealed class _N__N_lambda__14277__14291<B> : Function<_0027r>
	{
		[SpecialName]
		private Function<_0027p1, _0027r>._N_closureOf_op_RightShift_14282<B> _N_op_RightShift_closure_14295;

		public _N__N_lambda__14277__14291(Function<_0027p1, _0027r>._N_closureOf_op_RightShift_14282<B> _N_op_RightShift_closure_14295)
		{
			this._N_op_RightShift_closure_14295 = _N_op_RightShift_closure_14295;
		}

		[SpecialName]
		public sealed override _0027r apply()
		{
			return _N_op_RightShift_closure_14295._N_fbc_14287.apply(_N_op_RightShift_closure_14295._N_fab_14289.apply());
		}
	}

	private sealed class _N_closureOf_op_RightShift_14309<B>
	{
		internal Function<_0027p1, B> _N_fab_14316;

		internal FunctionVoid<B> _N_fbc_14314;

		internal _N_closureOf_op_RightShift_14309()
		{
		}
	}

	private sealed class _N__N_lambda__14303__14318<B> : FunctionVoid<_0027p1>
	{
		[SpecialName]
		private Function<_0027p1, _0027r>._N_closureOf_op_RightShift_14309<B> _N_op_RightShift_closure_14322;

		public _N__N_lambda__14303__14318(Function<_0027p1, _0027r>._N_closureOf_op_RightShift_14309<B> _N_op_RightShift_closure_14322)
		{
			this._N_op_RightShift_closure_14322 = _N_op_RightShift_closure_14322;
		}

		[SpecialName]
		public sealed override void apply_void(_0027p1 a)
		{
			_N_op_RightShift_closure_14322._N_fbc_14314.apply_void(_N_op_RightShift_closure_14322._N_fab_14316.apply(a));
		}
	}

	private sealed class _N_closureOf_op_RightShift_14335<B>
	{
		internal Function<B> _N_fab_14342;

		internal FunctionVoid<B> _N_fbc_14340;

		internal _N_closureOf_op_RightShift_14335()
		{
		}
	}

	private sealed class _N__N_lambda__14330__14344<B> : FunctionVoid
	{
		[SpecialName]
		private Function<_0027p1, _0027r>._N_closureOf_op_RightShift_14335<B> _N_op_RightShift_closure_14348;

		public _N__N_lambda__14330__14344(Function<_0027p1, _0027r>._N_closureOf_op_RightShift_14335<B> _N_op_RightShift_closure_14348)
		{
			this._N_op_RightShift_closure_14348 = _N_op_RightShift_closure_14348;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_op_RightShift_closure_14348._N_fbc_14340.apply_void(_N_op_RightShift_closure_14348._N_fab_14342.apply());
		}
	}

	private sealed class _N_closureOf_op_LeftShift_14362<B>
	{
		internal Function<B, _0027r> _N_fbc_14369;

		internal Function<_0027p1, B> _N_fab_14367;

		internal _N_closureOf_op_LeftShift_14362()
		{
		}
	}

	private sealed class _N__N_lambda__14356__14371<B> : Function<_0027p1, _0027r>
	{
		[SpecialName]
		private _N_closureOf_op_LeftShift_14362<B> _N_op_LeftShift_closure_14375;

		public _N__N_lambda__14356__14371(_N_closureOf_op_LeftShift_14362<B> _N_op_LeftShift_closure_14375)
		{
			this._N_op_LeftShift_closure_14375 = _N_op_LeftShift_closure_14375;
		}

		[SpecialName]
		public sealed override _0027r apply(_0027p1 a)
		{
			return _N_op_LeftShift_closure_14375._N_fbc_14369.apply(_N_op_LeftShift_closure_14375._N_fab_14367.apply(a));
		}
	}

	private sealed class _N_closureOf_op_LeftShift_14388<B>
	{
		internal Function<B, _0027r> _N_fbc_14395;

		internal Function<B> _N_fab_14393;

		internal _N_closureOf_op_LeftShift_14388()
		{
		}
	}

	private sealed class _N__N_lambda__14383__14397<B> : Function<_0027r>
	{
		[SpecialName]
		private Function<_0027p1, _0027r>._N_closureOf_op_LeftShift_14388<B> _N_op_LeftShift_closure_14401;

		public _N__N_lambda__14383__14397(Function<_0027p1, _0027r>._N_closureOf_op_LeftShift_14388<B> _N_op_LeftShift_closure_14401)
		{
			this._N_op_LeftShift_closure_14401 = _N_op_LeftShift_closure_14401;
		}

		[SpecialName]
		public sealed override _0027r apply()
		{
			return _N_op_LeftShift_closure_14401._N_fbc_14395.apply(_N_op_LeftShift_closure_14401._N_fab_14393.apply());
		}
	}

	private sealed class _N_closureOf_op_LeftShift_14415<B>
	{
		internal FunctionVoid<B> _N_fbc_14422;

		internal Function<_0027p1, B> _N_fab_14420;

		internal _N_closureOf_op_LeftShift_14415()
		{
		}
	}

	private sealed class _N__N_lambda__14409__14424<B> : FunctionVoid<_0027p1>
	{
		[SpecialName]
		private Function<_0027p1, _0027r>._N_closureOf_op_LeftShift_14415<B> _N_op_LeftShift_closure_14428;

		public _N__N_lambda__14409__14424(Function<_0027p1, _0027r>._N_closureOf_op_LeftShift_14415<B> _N_op_LeftShift_closure_14428)
		{
			this._N_op_LeftShift_closure_14428 = _N_op_LeftShift_closure_14428;
		}

		[SpecialName]
		public sealed override void apply_void(_0027p1 a)
		{
			_N_op_LeftShift_closure_14428._N_fbc_14422.apply_void(_N_op_LeftShift_closure_14428._N_fab_14420.apply(a));
		}
	}

	private sealed class _N_closureOf_op_LeftShift_14441<B>
	{
		internal FunctionVoid<B> _N_fbc_14448;

		internal Function<B> _N_fab_14446;

		internal _N_closureOf_op_LeftShift_14441()
		{
		}
	}

	private sealed class _N__N_lambda__14436__14450<B> : FunctionVoid
	{
		[SpecialName]
		private Function<_0027p1, _0027r>._N_closureOf_op_LeftShift_14441<B> _N_op_LeftShift_closure_14454;

		public _N__N_lambda__14436__14450(Function<_0027p1, _0027r>._N_closureOf_op_LeftShift_14441<B> _N_op_LeftShift_closure_14454)
		{
			this._N_op_LeftShift_closure_14454 = _N_op_LeftShift_closure_14454;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_op_LeftShift_closure_14454._N_fbc_14448.apply_void(_N_op_LeftShift_closure_14454._N_fab_14446.apply());
		}
	}

	[SpecialName]
	public static Function<_0027p1, _0027r> op_RightShift<B>(Function<_0027p1, B> fab, Function<B, _0027r> fbc)
	{
		_N_closureOf_op_RightShift_14256<B> n_closureOf_op_RightShift_ = new _N_closureOf_op_RightShift_14256<B>();
		n_closureOf_op_RightShift_._N_fab_14263 = fab;
		n_closureOf_op_RightShift_._N_fbc_14261 = fbc;
		return new _N__N_lambda__14250__14265<B>(n_closureOf_op_RightShift_);
	}

	[SpecialName]
	public static Function<_0027r> op_RightShift<B>(Function<B> fab, Function<B, _0027r> fbc)
	{
		_N_closureOf_op_RightShift_14282<B> n_closureOf_op_RightShift_ = new _N_closureOf_op_RightShift_14282<B>();
		n_closureOf_op_RightShift_._N_fab_14289 = fab;
		n_closureOf_op_RightShift_._N_fbc_14287 = fbc;
		return new _N__N_lambda__14277__14291<B>(n_closureOf_op_RightShift_);
	}

	[SpecialName]
	public static FunctionVoid<_0027p1> op_RightShift<B>(Function<_0027p1, B> fab, FunctionVoid<B> fbc)
	{
		_N_closureOf_op_RightShift_14309<B> n_closureOf_op_RightShift_ = new _N_closureOf_op_RightShift_14309<B>();
		n_closureOf_op_RightShift_._N_fab_14316 = fab;
		n_closureOf_op_RightShift_._N_fbc_14314 = fbc;
		return new _N__N_lambda__14303__14318<B>(n_closureOf_op_RightShift_);
	}

	[SpecialName]
	public static FunctionVoid op_RightShift<B>(Function<B> fab, FunctionVoid<B> fbc)
	{
		_N_closureOf_op_RightShift_14335<B> n_closureOf_op_RightShift_ = new _N_closureOf_op_RightShift_14335<B>();
		n_closureOf_op_RightShift_._N_fab_14342 = fab;
		n_closureOf_op_RightShift_._N_fbc_14340 = fbc;
		return new _N__N_lambda__14330__14344<B>(n_closureOf_op_RightShift_);
	}

	[SpecialName]
	public static Function<_0027p1, _0027r> op_LeftShift<B>(Function<B, _0027r> fbc, Function<_0027p1, B> fab)
	{
		_N_closureOf_op_LeftShift_14362<B> n_closureOf_op_LeftShift_ = new _N_closureOf_op_LeftShift_14362<B>();
		n_closureOf_op_LeftShift_._N_fbc_14369 = fbc;
		n_closureOf_op_LeftShift_._N_fab_14367 = fab;
		return new _N__N_lambda__14356__14371<B>(n_closureOf_op_LeftShift_);
	}

	[SpecialName]
	public static Function<_0027r> op_LeftShift<B>(Function<B, _0027r> fbc, Function<B> fab)
	{
		_N_closureOf_op_LeftShift_14388<B> n_closureOf_op_LeftShift_ = new _N_closureOf_op_LeftShift_14388<B>();
		n_closureOf_op_LeftShift_._N_fbc_14395 = fbc;
		n_closureOf_op_LeftShift_._N_fab_14393 = fab;
		return new _N__N_lambda__14383__14397<B>(n_closureOf_op_LeftShift_);
	}

	[SpecialName]
	public static FunctionVoid<_0027p1> op_LeftShift<B>(FunctionVoid<B> fbc, Function<_0027p1, B> fab)
	{
		_N_closureOf_op_LeftShift_14415<B> n_closureOf_op_LeftShift_ = new _N_closureOf_op_LeftShift_14415<B>();
		n_closureOf_op_LeftShift_._N_fbc_14422 = fbc;
		n_closureOf_op_LeftShift_._N_fab_14420 = fab;
		return new _N__N_lambda__14409__14424<B>(n_closureOf_op_LeftShift_);
	}

	[SpecialName]
	public static FunctionVoid op_LeftShift<B>(FunctionVoid<B> fbc, Function<B> fab)
	{
		_N_closureOf_op_LeftShift_14441<B> n_closureOf_op_LeftShift_ = new _N_closureOf_op_LeftShift_14441<B>();
		n_closureOf_op_LeftShift_._N_fbc_14448 = fbc;
		n_closureOf_op_LeftShift_._N_fab_14446 = fab;
		return new _N__N_lambda__14436__14450<B>(n_closureOf_op_LeftShift_);
	}

	public static _0027r _007C_003E(_0027p1 a, Function<_0027p1, _0027r> fac)
	{
		return fac.apply(a);
	}

	public static void _007C_003E(_0027p1 a, FunctionVoid<_0027p1> fac)
	{
		fac.apply_void(a);
	}

	public static _0027r _003C_007C(Function<_0027p1, _0027r> fac, _0027p1 a)
	{
		return fac.apply(a);
	}

	public static void _003C_007C(FunctionVoid<_0027p1> fac, _0027p1 a)
	{
		fac.apply_void(a);
	}

	public abstract override _0027r apply(_0027p1 _N_wildcard_2421);
}
[DebuggerNonUserCode]
public abstract class Function<_0027r> : Function<object, _0027r>
{
	public abstract override _0027r apply();

	public override _0027r apply(object _N_wildcard_2420)
	{
		return apply();
	}
}
[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027p2, _0027r> : Function<Tuple<_0027p1, _0027p2>, _0027r>
{
	public abstract override _0027r apply(_0027p1 _N_wildcard_2423, _0027p2 _N_wildcard_2424);

	public override _0027r apply(Tuple<_0027p1, _0027p2> o)
	{
		return apply(o.Field0, o.Field1);
	}
}
[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027p2, _0027p3, _0027r> : Function<Tuple<_0027p1, _0027p2, _0027p3>, _0027r>
{
	public abstract override _0027r apply(_0027p1 _N_wildcard_2427, _0027p2 _N_wildcard_2428, _0027p3 _N_wildcard_2429);

	public override _0027r apply(Tuple<_0027p1, _0027p2, _0027p3> o)
	{
		return apply(o.Field0, o.Field1, o.Field2);
	}
}
[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027r> : Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4>, _0027r>
{
	public abstract override _0027r apply(_0027p1 _N_wildcard_2433, _0027p2 _N_wildcard_2434, _0027p3 _N_wildcard_2435, _0027p4 _N_wildcard_2436);

	public override _0027r apply(Tuple<_0027p1, _0027p2, _0027p3, _0027p4> o)
	{
		return apply(o.Field0, o.Field1, o.Field2, o.Field3);
	}
}
[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027r> : Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5>, _0027r>
{
	public abstract override _0027r apply(_0027p1 _N_wildcard_2441, _0027p2 _N_wildcard_2442, _0027p3 _N_wildcard_2443, _0027p4 _N_wildcard_2444, _0027p5 _N_wildcard_2445);

	public override _0027r apply(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5> o)
	{
		return apply(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4);
	}
}
[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027r> : Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6>, _0027r>
{
	public abstract override _0027r apply(_0027p1 _N_wildcard_2451, _0027p2 _N_wildcard_2452, _0027p3 _N_wildcard_2453, _0027p4 _N_wildcard_2454, _0027p5 _N_wildcard_2455, _0027p6 _N_wildcard_2456);

	public override _0027r apply(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6> o)
	{
		return apply(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5);
	}
}
[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027r> : Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7>, _0027r>
{
	public abstract override _0027r apply(_0027p1 _N_wildcard_2463, _0027p2 _N_wildcard_2464, _0027p3 _N_wildcard_2465, _0027p4 _N_wildcard_2466, _0027p5 _N_wildcard_2467, _0027p6 _N_wildcard_2468, _0027p7 _N_wildcard_2469);

	public override _0027r apply(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7> o)
	{
		return apply(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6);
	}
}
[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027r> : Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8>, _0027r>
{
	public abstract override _0027r apply(_0027p1 _N_wildcard_2477, _0027p2 _N_wildcard_2478, _0027p3 _N_wildcard_2479, _0027p4 _N_wildcard_2480, _0027p5 _N_wildcard_2481, _0027p6 _N_wildcard_2482, _0027p7 _N_wildcard_2483, _0027p8 _N_wildcard_2484);

	public override _0027r apply(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8> o)
	{
		return apply(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7);
	}
}
[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027r> : Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9>, _0027r>
{
	public abstract override _0027r apply(_0027p1 _N_wildcard_2493, _0027p2 _N_wildcard_2494, _0027p3 _N_wildcard_2495, _0027p4 _N_wildcard_2496, _0027p5 _N_wildcard_2497, _0027p6 _N_wildcard_2498, _0027p7 _N_wildcard_2499, _0027p8 _N_wildcard_2500, _0027p9 _N_wildcard_2501);

	public override _0027r apply(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9> o)
	{
		return apply(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8);
	}
}
[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027r> : Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10>, _0027r>
{
	public abstract override _0027r apply(_0027p1 _N_wildcard_2511, _0027p2 _N_wildcard_2512, _0027p3 _N_wildcard_2513, _0027p4 _N_wildcard_2514, _0027p5 _N_wildcard_2515, _0027p6 _N_wildcard_2516, _0027p7 _N_wildcard_2517, _0027p8 _N_wildcard_2518, _0027p9 _N_wildcard_2519, _0027p10 _N_wildcard_2520);

	public override _0027r apply(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10> o)
	{
		return apply(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9);
	}
}
[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027r> : Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11>, _0027r>
{
	public abstract override _0027r apply(_0027p1 _N_wildcard_2531, _0027p2 _N_wildcard_2532, _0027p3 _N_wildcard_2533, _0027p4 _N_wildcard_2534, _0027p5 _N_wildcard_2535, _0027p6 _N_wildcard_2536, _0027p7 _N_wildcard_2537, _0027p8 _N_wildcard_2538, _0027p9 _N_wildcard_2539, _0027p10 _N_wildcard_2540, _0027p11 _N_wildcard_2541);

	public override _0027r apply(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11> o)
	{
		return apply(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10);
	}
}
[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027r> : Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12>, _0027r>
{
	public abstract override _0027r apply(_0027p1 _N_wildcard_2553, _0027p2 _N_wildcard_2554, _0027p3 _N_wildcard_2555, _0027p4 _N_wildcard_2556, _0027p5 _N_wildcard_2557, _0027p6 _N_wildcard_2558, _0027p7 _N_wildcard_2559, _0027p8 _N_wildcard_2560, _0027p9 _N_wildcard_2561, _0027p10 _N_wildcard_2562, _0027p11 _N_wildcard_2563, _0027p12 _N_wildcard_2564);

	public override _0027r apply(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12> o)
	{
		return apply(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10, o.Field11);
	}
}
[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027r> : Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13>, _0027r>
{
	public abstract override _0027r apply(_0027p1 _N_wildcard_2577, _0027p2 _N_wildcard_2578, _0027p3 _N_wildcard_2579, _0027p4 _N_wildcard_2580, _0027p5 _N_wildcard_2581, _0027p6 _N_wildcard_2582, _0027p7 _N_wildcard_2583, _0027p8 _N_wildcard_2584, _0027p9 _N_wildcard_2585, _0027p10 _N_wildcard_2586, _0027p11 _N_wildcard_2587, _0027p12 _N_wildcard_2588, _0027p13 _N_wildcard_2589);

	public override _0027r apply(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13> o)
	{
		return apply(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10, o.Field11, o.Field12);
	}
}
[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027r> : Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14>, _0027r>
{
	public abstract override _0027r apply(_0027p1 _N_wildcard_2603, _0027p2 _N_wildcard_2604, _0027p3 _N_wildcard_2605, _0027p4 _N_wildcard_2606, _0027p5 _N_wildcard_2607, _0027p6 _N_wildcard_2608, _0027p7 _N_wildcard_2609, _0027p8 _N_wildcard_2610, _0027p9 _N_wildcard_2611, _0027p10 _N_wildcard_2612, _0027p11 _N_wildcard_2613, _0027p12 _N_wildcard_2614, _0027p13 _N_wildcard_2615, _0027p14 _N_wildcard_2616);

	public override _0027r apply(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14> o)
	{
		return apply(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10, o.Field11, o.Field12, o.Field13);
	}
}
[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027r> : Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15>, _0027r>
{
	public abstract override _0027r apply(_0027p1 _N_wildcard_2631, _0027p2 _N_wildcard_2632, _0027p3 _N_wildcard_2633, _0027p4 _N_wildcard_2634, _0027p5 _N_wildcard_2635, _0027p6 _N_wildcard_2636, _0027p7 _N_wildcard_2637, _0027p8 _N_wildcard_2638, _0027p9 _N_wildcard_2639, _0027p10 _N_wildcard_2640, _0027p11 _N_wildcard_2641, _0027p12 _N_wildcard_2642, _0027p13 _N_wildcard_2643, _0027p14 _N_wildcard_2644, _0027p15 _N_wildcard_2645);

	public override _0027r apply(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15> o)
	{
		return apply(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10, o.Field11, o.Field12, o.Field13, o.Field14);
	}
}
[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027r> : Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16>, _0027r>
{
	public abstract override _0027r apply(_0027p1 _N_wildcard_2661, _0027p2 _N_wildcard_2662, _0027p3 _N_wildcard_2663, _0027p4 _N_wildcard_2664, _0027p5 _N_wildcard_2665, _0027p6 _N_wildcard_2666, _0027p7 _N_wildcard_2667, _0027p8 _N_wildcard_2668, _0027p9 _N_wildcard_2669, _0027p10 _N_wildcard_2670, _0027p11 _N_wildcard_2671, _0027p12 _N_wildcard_2672, _0027p13 _N_wildcard_2673, _0027p14 _N_wildcard_2674, _0027p15 _N_wildcard_2675, _0027p16 _N_wildcard_2676);

	public override _0027r apply(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16> o)
	{
		return apply(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10, o.Field11, o.Field12, o.Field13, o.Field14, o.Field15);
	}
}
[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027r> : Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17>, _0027r>
{
	public abstract override _0027r apply(_0027p1 _N_wildcard_2693, _0027p2 _N_wildcard_2694, _0027p3 _N_wildcard_2695, _0027p4 _N_wildcard_2696, _0027p5 _N_wildcard_2697, _0027p6 _N_wildcard_2698, _0027p7 _N_wildcard_2699, _0027p8 _N_wildcard_2700, _0027p9 _N_wildcard_2701, _0027p10 _N_wildcard_2702, _0027p11 _N_wildcard_2703, _0027p12 _N_wildcard_2704, _0027p13 _N_wildcard_2705, _0027p14 _N_wildcard_2706, _0027p15 _N_wildcard_2707, _0027p16 _N_wildcard_2708, _0027p17 _N_wildcard_2709);

	public override _0027r apply(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17> o)
	{
		return apply(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10, o.Field11, o.Field12, o.Field13, o.Field14, o.Field15, o.Field16);
	}
}
[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027r> : Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18>, _0027r>
{
	public abstract override _0027r apply(_0027p1 _N_wildcard_2727, _0027p2 _N_wildcard_2728, _0027p3 _N_wildcard_2729, _0027p4 _N_wildcard_2730, _0027p5 _N_wildcard_2731, _0027p6 _N_wildcard_2732, _0027p7 _N_wildcard_2733, _0027p8 _N_wildcard_2734, _0027p9 _N_wildcard_2735, _0027p10 _N_wildcard_2736, _0027p11 _N_wildcard_2737, _0027p12 _N_wildcard_2738, _0027p13 _N_wildcard_2739, _0027p14 _N_wildcard_2740, _0027p15 _N_wildcard_2741, _0027p16 _N_wildcard_2742, _0027p17 _N_wildcard_2743, _0027p18 _N_wildcard_2744);

	public override _0027r apply(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18> o)
	{
		return apply(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10, o.Field11, o.Field12, o.Field13, o.Field14, o.Field15, o.Field16, o.Field17);
	}
}
[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19, _0027r> : Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19>, _0027r>
{
	public abstract override _0027r apply(_0027p1 _N_wildcard_2763, _0027p2 _N_wildcard_2764, _0027p3 _N_wildcard_2765, _0027p4 _N_wildcard_2766, _0027p5 _N_wildcard_2767, _0027p6 _N_wildcard_2768, _0027p7 _N_wildcard_2769, _0027p8 _N_wildcard_2770, _0027p9 _N_wildcard_2771, _0027p10 _N_wildcard_2772, _0027p11 _N_wildcard_2773, _0027p12 _N_wildcard_2774, _0027p13 _N_wildcard_2775, _0027p14 _N_wildcard_2776, _0027p15 _N_wildcard_2777, _0027p16 _N_wildcard_2778, _0027p17 _N_wildcard_2779, _0027p18 _N_wildcard_2780, _0027p19 _N_wildcard_2781);

	public override _0027r apply(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19> o)
	{
		return apply(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10, o.Field11, o.Field12, o.Field13, o.Field14, o.Field15, o.Field16, o.Field17, o.Field18);
	}
}
[DebuggerNonUserCode]
public abstract class Function<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19, _0027p20, _0027r> : Function<Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19, _0027p20>, _0027r>
{
	public abstract override _0027r apply(_0027p1 _N_wildcard_2801, _0027p2 _N_wildcard_2802, _0027p3 _N_wildcard_2803, _0027p4 _N_wildcard_2804, _0027p5 _N_wildcard_2805, _0027p6 _N_wildcard_2806, _0027p7 _N_wildcard_2807, _0027p8 _N_wildcard_2808, _0027p9 _N_wildcard_2809, _0027p10 _N_wildcard_2810, _0027p11 _N_wildcard_2811, _0027p12 _N_wildcard_2812, _0027p13 _N_wildcard_2813, _0027p14 _N_wildcard_2814, _0027p15 _N_wildcard_2815, _0027p16 _N_wildcard_2816, _0027p17 _N_wildcard_2817, _0027p18 _N_wildcard_2818, _0027p19 _N_wildcard_2819, _0027p20 _N_wildcard_2820);

	public override _0027r apply(Tuple<_0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19, _0027p20> o)
	{
		return apply(o.Field0, o.Field1, o.Field2, o.Field3, o.Field4, o.Field5, o.Field6, o.Field7, o.Field8, o.Field9, o.Field10, o.Field11, o.Field12, o.Field13, o.Field14, o.Field15, o.Field16, o.Field17, o.Field18, o.Field19);
	}
}
