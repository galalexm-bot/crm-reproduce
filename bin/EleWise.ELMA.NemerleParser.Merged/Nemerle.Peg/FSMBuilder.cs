using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;

namespace Nemerle.Peg;

public static class FSMBuilder
{
	private sealed class _N_static_proxy_14250 : Function<RangeSet, FSM>
	{
		[SpecialName]
		public static readonly _N_static_proxy_14250 single_instance = new _N_static_proxy_14250();

		[SpecialName]
		public sealed override FSM apply(RangeSet _N_sp_parm_14257)
		{
			return Symbol(_N_sp_parm_14257);
		}

		private _N_static_proxy_14250()
		{
		}
	}

	private sealed class _N_append__14285 : Function<FSM, FSM, FSM>
	{
		[SpecialName]
		public static readonly _N_append__14285 Instance = new _N_append__14285();

		[SpecialName]
		public sealed override FSM apply(FSM fsm2, FSM fsm1)
		{
			_N_closureOf_append_14295 n_closureOf_append_ = new _N_closureOf_append_14295();
			Tuple<FSM, int, Set<int>> tuple = fsm1.IncludeFSM(fsm2);
			FSM field = tuple.Field0;
			n_closureOf_append_._N_start_14300 = tuple.Field1;
			Set<int> field2 = tuple.Field2;
			Set<int> okStates = field.OkStates;
			FSM acc = field;
			Function<int, FSM, FSM> fn = new _N__N_lambda__14273__14306(n_closureOf_append_);
			field = okStates.Fold(acc, fn);
			return field.SetOkStates(field2);
		}
	}

	private sealed class _N_closureOf_append_14295
	{
		internal int _N_start_14300;

		internal _N_closureOf_append_14295()
		{
		}
	}

	private sealed class _N__N_lambda__14273__14306 : Function<int, FSM, FSM>
	{
		[SpecialName]
		private _N_closureOf_append_14295 _N_append_closure_14310;

		public _N__N_lambda__14273__14306(_N_closureOf_append_14295 _N_append_closure_14310)
		{
			this._N_append_closure_14310 = _N_append_closure_14310;
		}

		[SpecialName]
		public sealed override FSM apply(int state, FSM fsm1)
		{
			return fsm1.AddTransition(new Transition.Epsilon(state, _N_append_closure_14310._N_start_14300));
		}
	}

	private sealed class _N_static_proxy_14318 : Function<char, FSM>
	{
		[SpecialName]
		public static readonly _N_static_proxy_14318 single_instance = new _N_static_proxy_14318();

		[SpecialName]
		public sealed override FSM apply(char _N_sp_parm_14325)
		{
			return Symbol(_N_sp_parm_14325);
		}

		private _N_static_proxy_14318()
		{
		}
	}

	private sealed class _N_static_proxy_14331 : Function<char, FSM>
	{
		[SpecialName]
		public static readonly _N_static_proxy_14331 single_instance = new _N_static_proxy_14331();

		[SpecialName]
		public sealed override FSM apply(char _N_sp_parm_14338)
		{
			return ISymbol(_N_sp_parm_14338);
		}

		private _N_static_proxy_14331()
		{
		}
	}

	private sealed class _N__N_lambda__14343__14350 : Function<int, FSM, FSM>
	{
		[SpecialName]
		public static readonly _N__N_lambda__14343__14350 Instance = new _N__N_lambda__14343__14350();

		[SpecialName]
		public sealed override FSM apply(int state, FSM fsm)
		{
			return fsm.AddTransition(new Transition.Epsilon(fsm.StartState, state));
		}
	}

	private sealed class _N_closureOf_RepeatMin_14390
	{
		internal FSM _N_fsm_14395;

		internal _N_closureOf_RepeatMin_14390()
		{
		}
	}

	private sealed class _N__N_lambda__14363__14397 : Function<int, FSM, FSM>
	{
		[SpecialName]
		public static readonly _N__N_lambda__14363__14397 Instance = new _N__N_lambda__14363__14397();

		[SpecialName]
		public sealed override FSM apply(int state, FSM fsm)
		{
			return fsm.AddTransition(new Transition.Epsilon(fsm.StartState, state)).AddTransition(new Transition.Epsilon(state, fsm.StartState));
		}
	}

	private sealed class _N__N_lambda__14371__14407 : Function<int, FSM>
	{
		[SpecialName]
		private _N_closureOf_RepeatMin_14390 _N_RepeatMin_closure_14411;

		public _N__N_lambda__14371__14407(_N_closureOf_RepeatMin_14390 _N_RepeatMin_closure_14411)
		{
			this._N_RepeatMin_closure_14411 = _N_RepeatMin_closure_14411;
		}

		[SpecialName]
		public sealed override FSM apply(int _N_wildcard_14370)
		{
			return _N_RepeatMin_closure_14411._N_fsm_14395;
		}
	}

	private sealed class _N_closureOf_RepeatMinMax_14472
	{
		internal FSM _N_fsm_14477;

		internal _N_closureOf_RepeatMinMax_14472()
		{
		}
	}

	private sealed class _N__N_lambda__14434__14479 : Function<int, FSM>
	{
		[SpecialName]
		private _N_closureOf_RepeatMinMax_14472 _N_RepeatMinMax_closure_14483;

		public _N__N_lambda__14434__14479(_N_closureOf_RepeatMinMax_14472 _N_RepeatMinMax_closure_14483)
		{
			this._N_RepeatMinMax_closure_14483 = _N_RepeatMinMax_closure_14483;
		}

		[SpecialName]
		public sealed override FSM apply(int _N_wildcard_14433)
		{
			return Option(_N_RepeatMinMax_closure_14483._N_fsm_14477);
		}
	}

	private sealed class _N__N_lambda__14453__14501 : Function<int, FSM>
	{
		[SpecialName]
		private _N_closureOf_RepeatMinMax_14472 _N_RepeatMinMax_closure_14505;

		public _N__N_lambda__14453__14501(_N_closureOf_RepeatMinMax_14472 _N_RepeatMinMax_closure_14505)
		{
			this._N_RepeatMinMax_closure_14505 = _N_RepeatMinMax_closure_14505;
		}

		[SpecialName]
		public sealed override FSM apply(int _N_wildcard_14452)
		{
			return _N_RepeatMinMax_closure_14505._N_fsm_14477;
		}
	}

	private sealed class _N_append__14537 : Function<FSM, FSM, FSM>
	{
		[SpecialName]
		public static readonly _N_append__14537 Instance = new _N_append__14537();

		[SpecialName]
		public sealed override FSM apply(FSM fsm2, FSM fsm1)
		{
			Tuple<FSM, int, Set<int>> tuple = fsm1.IncludeFSM(fsm2);
			FSM field = tuple.Field0;
			int field2 = tuple.Field1;
			Set<int> field3 = tuple.Field2;
			field = field.AddTransition(new Transition.Epsilon(field.StartState, field2));
			return field.AddOkStates(field3);
		}
	}

	public static FSM Symbol(char c)
	{
		return Symbol(new RangeSet().AddRange(c, c));
	}

	public static FSM Symbol(char l, char h)
	{
		return Symbol(new RangeSet().AddRange(l, h));
	}

	public static FSM ISymbol(char c)
	{
		char c2 = char.ToLowerInvariant(c);
		char c3 = char.ToUpperInvariant(c);
		return Symbol(new RangeSet().AddRange(c2, c2).AddRange(c3, c3));
	}

	public static FSM Symbol(RangeSet chars)
	{
		Tuple<FSM, int> tuple = new FSM().NewOkState();
		FSM field = tuple.Field0;
		int field2 = tuple.Field1;
		return field.AddTransition(new Transition.Symbol(field.StartState, field2, chars));
	}

	public static FSM Seq(list<RangeSet> seq)
	{
		return Seq(seq.Map(_N_static_proxy_14250.single_instance));
	}

	public static FSM Seq(list<FSM> fsms)
	{
		FSM result;
		if ((object)fsms == list<FSM>.Nil._N_constant_object)
		{
			FSM fSM = new FSM();
			result = fSM.AddOkState(fSM.StartState);
		}
		else
		{
			if (!(fsms is list<FSM>.Cons))
			{
				throw new MatchFailureException();
			}
			FSM fSM = ((list<FSM>.Cons)fsms).hd;
			list<FSM> list = ((list<FSM>.Cons)fsms).tl;
			Function<FSM, FSM, FSM> instance = _N_append__14285.Instance;
			result = list.FoldLeft(fSM, instance);
		}
		return result;
	}

	public static FSM String(string str)
	{
		return Seq(str.Map(_N_static_proxy_14318.single_instance));
	}

	public static FSM IString(string str)
	{
		return Seq(str.Map(_N_static_proxy_14331.single_instance));
	}

	public static FSM Option(FSM fsm)
	{
		Set<int> okStates = fsm.OkStates;
		Function<int, FSM, FSM> instance = _N__N_lambda__14343__14350.Instance;
		return okStates.Fold(fsm, instance);
	}

	public static FSM RepeatMin(int min, FSM fsm)
	{
		int num = 0;
		list<int>.Cons cons = null;
		list<int>.Cons cons2 = null;
		bool flag = false;
		int num2 = 0;
		_N_closureOf_RepeatMin_14390 n_closureOf_RepeatMin_ = new _N_closureOf_RepeatMin_14390();
		n_closureOf_RepeatMin_._N_fsm_14395 = fsm;
		Set<int> okStates = n_closureOf_RepeatMin_._N_fsm_14395.OkStates;
		FSM n_fsm_ = n_closureOf_RepeatMin_._N_fsm_14395;
		Function<int, FSM, FSM> instance = _N__N_lambda__14363__14397.Instance;
		FSM hd = okStates.Fold(n_fsm_, instance);
		cons = null;
		cons2 = null;
		num = 0;
		int num3 = checked(min - 1);
		flag = num <= num3;
		num2 = num3 - 1;
		bool flag2 = num2 > num3;
		while (flag)
		{
			num3 = num;
			flag = ((!flag2) ? (num <= num2) : (num >= num2));
			num++;
			list<int>.Cons cons3 = new list<int>.Cons(num3, list<int>.Nil._N_constant_object);
			if (cons == null)
			{
				cons = cons3;
				cons2 = cons3;
			}
			else
			{
				cons2.tl = cons3;
				cons2 = cons3;
			}
		}
		list<int> obj = ((!(cons == null)) ? ((list<int>)cons) : ((list<int>)list<int>.Nil._N_constant_object));
		Function<int, FSM> convert = new _N__N_lambda__14371__14407(n_closureOf_RepeatMin_);
		list<FSM> fsms = obj.Map(convert).Append(new list<FSM>.Cons(hd, list<FSM>.Nil._N_constant_object));
		return Seq(fsms);
	}

	public static FSM RepeatMinMax(int min, int max, FSM fsm)
	{
		int num = 0;
		list<int>.Cons cons = null;
		int num2 = 0;
		bool flag = false;
		list<int>.Cons cons2 = null;
		list<int>.Cons cons3 = null;
		_N_closureOf_RepeatMinMax_14472 n_closureOf_RepeatMinMax_ = new _N_closureOf_RepeatMinMax_14472();
		n_closureOf_RepeatMinMax_._N_fsm_14477 = fsm;
		cons3 = null;
		cons = null;
		num = 0;
		int num3 = checked(max - min - 1);
		flag = num <= num3;
		num2 = num3 - 1;
		bool flag2 = num2 > num3;
		while (flag)
		{
			num3 = num;
			flag = ((!flag2) ? (num <= num2) : (num >= num2));
			num++;
			list<int>.Cons cons4 = new list<int>.Cons(num3, list<int>.Nil._N_constant_object);
			if (cons3 == null)
			{
				cons3 = cons4;
				cons = cons4;
			}
			else
			{
				cons.tl = cons4;
				cons = cons4;
			}
		}
		list<int> obj = ((!(cons3 == null)) ? ((list<int>)cons3) : ((list<int>)list<int>.Nil._N_constant_object));
		Function<int, FSM> convert = new _N__N_lambda__14434__14479(n_closureOf_RepeatMinMax_);
		list<FSM> y = obj.Map(convert);
		cons2 = null;
		cons = null;
		num = 0;
		num3 = checked(min - 1);
		flag = num <= num3;
		num2 = num3 - 1;
		flag2 = num2 > num3;
		while (flag)
		{
			num3 = num;
			flag = ((!flag2) ? (num <= num2) : (num >= num2));
			num++;
			list<int>.Cons cons4 = new list<int>.Cons(num3, list<int>.Nil._N_constant_object);
			if (cons2 == null)
			{
				cons2 = cons4;
				cons = cons4;
			}
			else
			{
				cons.tl = cons4;
				cons = cons4;
			}
		}
		list<int> obj2 = ((!(cons2 == null)) ? ((list<int>)cons2) : ((list<int>)list<int>.Nil._N_constant_object));
		convert = new _N__N_lambda__14453__14501(n_closureOf_RepeatMinMax_);
		list<FSM> fsms = obj2.Map(convert).Append(y);
		return Seq(fsms);
	}

	public static FSM Choice(list<FSM> fsms)
	{
		FSM acc = new FSM();
		Function<FSM, FSM, FSM> instance = _N_append__14537.Instance;
		return fsms.FoldLeft(acc, instance);
	}
}
