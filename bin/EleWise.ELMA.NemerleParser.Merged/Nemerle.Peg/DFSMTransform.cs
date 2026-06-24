using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;

namespace Nemerle.Peg;

public static class DFSMTransform
{
	private sealed class _N__N_lambda__11692__11740 : Function<Transition, Hashtable<Nemerle.Builtins.Tuple<int, int>, Nemerle.Builtins.Tuple<RangeSet, bool>>, Hashtable<Nemerle.Builtins.Tuple<int, int>, Nemerle.Builtins.Tuple<RangeSet, bool>>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__11692__11740 Instance = new _N__N_lambda__11692__11740();

		[SpecialName]
		public sealed override Hashtable<Nemerle.Builtins.Tuple<int, int>, Nemerle.Builtins.Tuple<RangeSet, bool>> apply(Transition transition, Hashtable<Nemerle.Builtins.Tuple<int, int>, Nemerle.Builtins.Tuple<RangeSet, bool>> transitions)
		{
			_N_closureOf__N_lambda__11692_11750 n_closureOf__N_lambda__11692_ = new _N_closureOf__N_lambda__11692_11750();
			n_closureOf__N_lambda__11692_._N_transition_11755 = transition;
			Nemerle.Builtins.Tuple<int, int> key = new Nemerle.Builtins.Tuple<int, int>(n_closureOf__N_lambda__11692_._N_transition_11755.From, n_closureOf__N_lambda__11692_._N_transition_11755.To);
			Nemerle.Builtins.Tuple<RangeSet, bool> defaultValue = new Nemerle.Builtins.Tuple<RangeSet, bool>(new RangeSet(), field1: false);
			Function<RangeSet, bool, Nemerle.Builtins.Tuple<RangeSet, bool>> updateFn = new _N__N_lambda__11698__11757(n_closureOf__N_lambda__11692_);
			return transitions.Update(key, defaultValue, updateFn);
		}
	}

	private sealed class _N_closureOf__N_lambda__11692_11750
	{
		internal Transition _N_transition_11755;

		internal _N_closureOf__N_lambda__11692_11750()
		{
		}
	}

	private sealed class _N__N_lambda__11698__11757 : Function<RangeSet, bool, Nemerle.Builtins.Tuple<RangeSet, bool>>
	{
		[SpecialName]
		private _N_closureOf__N_lambda__11692_11750 _N__N_lambda__11692_closure_11761;

		public _N__N_lambda__11698__11757(_N_closureOf__N_lambda__11692_11750 _N__N_lambda__11692_closure_11761)
		{
			this._N__N_lambda__11692_closure_11761 = _N__N_lambda__11692_closure_11761;
		}

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<RangeSet, bool> apply(RangeSet chars, bool epsilon)
		{
			Nemerle.Builtins.Tuple<RangeSet, bool> result;
			if (_N__N_lambda__11692_closure_11761._N_transition_11755 is Transition.Symbol)
			{
				RangeSet chars2 = ((Transition.Symbol)_N__N_lambda__11692_closure_11761._N_transition_11755).Chars;
				result = new Nemerle.Builtins.Tuple<RangeSet, bool>(chars2.Sum(chars), epsilon);
			}
			else
			{
				if (!(_N__N_lambda__11692_closure_11761._N_transition_11755 is Transition.Epsilon))
				{
					throw new MatchFailureException();
				}
				result = new Nemerle.Builtins.Tuple<RangeSet, bool>(chars, field1: true);
			}
			return result;
		}
	}

	private sealed class _N__N_lambda__11708__11792 : Function<Nemerle.Builtins.Tuple<int, int>, Nemerle.Builtins.Tuple<RangeSet, bool>, list<Transition>, list<Transition>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__11708__11792 Instance = new _N__N_lambda__11708__11792();

		[SpecialName]
		public sealed override list<Transition> apply(Nemerle.Builtins.Tuple<int, int> _N__11789, Nemerle.Builtins.Tuple<RangeSet, bool> _N__11790, list<Transition> _N__11791)
		{
			RangeSet field = _N__11790.Field0;
			bool field2 = _N__11790.Field1;
			int field3 = _N__11789.Field0;
			int field4 = _N__11789.Field1;
			list<Transition> list = (field.Ranges.IsEmpty() ? _N__11791 : new list<Transition>.Cons(new Transition.Symbol(field3, field4, field), _N__11791));
			return (!field2) ? list : new list<Transition>.Cons(new Transition.Epsilon(field3, field4), list);
		}
	}

	private sealed class _N_closureOf_Do_12103
	{
		internal FSM _N_fsm_12114;

		internal Hashtable<Set<int>, int> _N_stateMap_12112;

		internal Nemerle.Collections.Stack<Nemerle.Builtins.Tuple<Set<int>, int>> _N_states_12110;

		internal FSM _N_result_12108;

		internal _N_closureOf_Do_12103()
		{
		}
	}

	private sealed class _N_closureOf_symbolTransitions_12123
	{
		internal int _N_state_12128;

		internal _N_closureOf_symbolTransitions_12123()
		{
		}
	}

	private sealed class _N__N_lambda__11820__12130 : Function<Transition, Transition.Symbol>
	{
		[SpecialName]
		public static readonly _N__N_lambda__11820__12130 Instance = new _N__N_lambda__11820__12130();

		[SpecialName]
		public sealed override Transition.Symbol apply(Transition _N__11819)
		{
			return (Transition.Symbol)_N__11819;
		}
	}

	private sealed class _N__N_lambda__11825__12140 : Function<Transition, bool>
	{
		[SpecialName]
		private _N_closureOf_symbolTransitions_12123 _N_symbolTransitions_closure_12144;

		public _N__N_lambda__11825__12140(_N_closureOf_symbolTransitions_12123 _N_symbolTransitions_closure_12144)
		{
			this._N_symbolTransitions_closure_12144 = _N_symbolTransitions_closure_12144;
		}

		[SpecialName]
		public sealed override bool apply(Transition t)
		{
			return t.From == _N_symbolTransitions_closure_12144._N_state_12128 && t is Transition.Symbol;
		}
	}

	private sealed class _N_closureOf_epsilonTransitions_12162
	{
		internal int _N_state_12167;

		internal _N_closureOf_epsilonTransitions_12162()
		{
		}
	}

	private sealed class _N__N_lambda__11835__12169 : Function<Transition, Transition.Epsilon>
	{
		[SpecialName]
		public static readonly _N__N_lambda__11835__12169 Instance = new _N__N_lambda__11835__12169();

		[SpecialName]
		public sealed override Transition.Epsilon apply(Transition _N__11834)
		{
			return (Transition.Epsilon)_N__11834;
		}
	}

	private sealed class _N__N_lambda__11840__12179 : Function<Transition, bool>
	{
		[SpecialName]
		private _N_closureOf_epsilonTransitions_12162 _N_epsilonTransitions_closure_12183;

		public _N__N_lambda__11840__12179(_N_closureOf_epsilonTransitions_12162 _N_epsilonTransitions_closure_12183)
		{
			this._N_epsilonTransitions_closure_12183 = _N_epsilonTransitions_closure_12183;
		}

		[SpecialName]
		public sealed override bool apply(Transition t)
		{
			return t.From == _N_epsilonTransitions_closure_12183._N_state_12167 && t is Transition.Epsilon;
		}
	}

	private sealed class _N_closureOf_epsilonMove_12201
	{
		internal Function<int, Set<int>, Set<int>> _N_rec_12206;

		internal _N_closureOf_epsilonMove_12201()
		{
		}
	}

	private sealed class _N_rec__12208 : Function<int, Set<int>, Set<int>>
	{
		[SpecialName]
		private _N_closureOf_Do_12103 _N_Do_closure_12214;

		[SpecialName]
		private _N_closureOf_epsilonMove_12201 _N_epsilonMove_closure_12212;

		public _N_rec__12208(_N_closureOf_epsilonMove_12201 _N_epsilonMove_closure_12212, _N_closureOf_Do_12103 _N_Do_closure_12214)
		{
			this._N_epsilonMove_closure_12212 = _N_epsilonMove_closure_12212;
			this._N_Do_closure_12214 = _N_Do_closure_12214;
		}

		[SpecialName]
		public sealed override Set<int> apply(int state, Set<int> set)
		{
			_N_closureOf_rec_12219 n_closureOf_rec_ = new _N_closureOf_rec_12219();
			n_closureOf_rec_._N_set_12224 = set;
			list<Transition.Epsilon> list = _N_epsilonTransitions_12156(_N_Do_closure_12214, state);
			Function<Transition.Epsilon, int> instance = _N__N_lambda__11860__12235.Instance;
			list<int> list2 = list.Map(instance);
			Function<int, bool> f = new _N__N_lambda__11854__12226(n_closureOf_rec_);
			list<int> list3 = list2.Filter(f);
			return list3.Fold(n_closureOf_rec_._N_set_12224.AddList(list3), _N_epsilonMove_closure_12212._N_rec_12206);
		}
	}

	private sealed class _N_closureOf_rec_12219
	{
		internal Set<int> _N_set_12224;

		internal _N_closureOf_rec_12219()
		{
		}
	}

	private sealed class _N__N_lambda__11854__12226 : Function<int, bool>
	{
		[SpecialName]
		private _N_closureOf_rec_12219 _N_rec_closure_12230;

		public _N__N_lambda__11854__12226(_N_closureOf_rec_12219 _N_rec_closure_12230)
		{
			this._N_rec_closure_12230 = _N_rec_closure_12230;
		}

		[SpecialName]
		public sealed override bool apply(int state)
		{
			return !_N_rec_closure_12230._N_set_12224.Contains(state);
		}
	}

	private sealed class _N__N_lambda__11860__12235 : Function<Transition.Epsilon, int>
	{
		[SpecialName]
		public static readonly _N__N_lambda__11860__12235 Instance = new _N__N_lambda__11860__12235();

		[SpecialName]
		public sealed override int apply(Transition.Epsilon _N__11859)
		{
			return _N__11859.To;
		}
	}

	private sealed class _N_closureOf_loop_12258
	{
		internal int _N_fromState_12263;

		internal _N_closureOf_loop_12258()
		{
		}
	}

	private sealed class _N_closureOf_foreach_loop_12290
	{
		internal Transition.Symbol _N_transition_12295;

		internal _N_closureOf_foreach_loop_12290()
		{
		}
	}

	private sealed class _N__N_lambda__12013__12308 : Function<list<int>, list<int>>
	{
		[SpecialName]
		private _N_closureOf_foreach_loop_12290 _N_foreach_loop_closure_12312;

		public _N__N_lambda__12013__12308(_N_closureOf_foreach_loop_12290 _N_foreach_loop_closure_12312)
		{
			this._N_foreach_loop_closure_12312 = _N_foreach_loop_closure_12312;
		}

		[SpecialName]
		public sealed override list<int> apply(list<int> states)
		{
			return new list<int>.Cons(_N_foreach_loop_closure_12312._N_transition_12295.To, states);
		}
	}

	private sealed class _N__N_lambda__12019__12317 : Function<list<int>, list<int>>
	{
		[SpecialName]
		private _N_closureOf_foreach_loop_12290 _N_foreach_loop_closure_12321;

		public _N__N_lambda__12019__12317(_N_closureOf_foreach_loop_12290 _N_foreach_loop_closure_12321)
		{
			this._N_foreach_loop_closure_12321 = _N_foreach_loop_closure_12321;
		}

		[SpecialName]
		public sealed override list<int> apply(list<int> states)
		{
			return new list<int>.Cons(_N_foreach_loop_closure_12321._N_transition_12295.To, states);
		}
	}

	private sealed class _N__N_lambda__12025__12326 : Function<KeyValuePair<Nemerle.Builtins.Tuple<int, bool>, list<int>>, Nemerle.Builtins.Tuple<int, bool, list<int>>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__12025__12326 Instance = new _N__N_lambda__12025__12326();

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<int, bool, list<int>> apply(KeyValuePair<Nemerle.Builtins.Tuple<int, bool>, list<int>> pair)
		{
			return new Nemerle.Builtins.Tuple<int, bool, list<int>>(pair.Key.Field0, pair.Key.Field1, pair.Value);
		}
	}

	private sealed class _N__N_lambda__12033__12340 : Function<Nemerle.Builtins.Tuple<int, bool, list<int>>, Nemerle.Builtins.Tuple<int, bool, list<int>>, int>
	{
		[SpecialName]
		public static readonly _N__N_lambda__12033__12340 Instance = new _N__N_lambda__12033__12340();

		[SpecialName]
		public sealed override int apply(Nemerle.Builtins.Tuple<int, bool, list<int>> _N__12338, Nemerle.Builtins.Tuple<int, bool, list<int>> _N__12339)
		{
			int field = _N__12339.Field0;
			bool field2 = _N__12339.Field1;
			int field3 = _N__12338.Field0;
			bool field4 = _N__12338.Field1;
			field = field3.CompareTo(field);
			return (field != 0) ? field : checked(field4.CompareTo(field2) * -1);
		}
	}

	private sealed class _N__N_lambda__12097__12388 : Function<int, bool>
	{
		[SpecialName]
		private _N_closureOf_Do_12103 _N_Do_closure_12392;

		public _N__N_lambda__12097__12388(_N_closureOf_Do_12103 _N_Do_closure_12392)
		{
			this._N_Do_closure_12392 = _N_Do_closure_12392;
		}

		[SpecialName]
		public sealed override bool apply(int s)
		{
			return _N_Do_closure_12392._N_fsm_12114.OkStates.Contains(s);
		}
	}

	private sealed class _N_closureOf_Minimize_12560
	{
		internal int[] _N_stateMap_12573;

		internal List<list<int>> _N_stateSets_12571;

		internal list<Transition.Symbol>[] _N_stateTransitions_12569;

		internal RangeSet[] _N_stateChars_12567;

		internal int[] _N_transitionMap_12565;

		internal _N_closureOf_Minimize_12560()
		{
		}
	}

	private sealed class _N__N_lambda__12422__12598 : Function<list<Transition.Symbol>, RangeSet>
	{
		[SpecialName]
		public static readonly _N__N_lambda__12422__12598 Instance = new _N__N_lambda__12422__12598();

		[SpecialName]
		public sealed override RangeSet apply(list<Transition.Symbol> t)
		{
			RangeSet ini = new RangeSet();
			Function<Transition.Symbol, RangeSet, RangeSet> instance = _N__N_lambda__12427__12608.Instance;
			return t.Fold(ini, instance);
		}
	}

	private sealed class _N__N_lambda__12427__12608 : Function<Transition.Symbol, RangeSet, RangeSet>
	{
		[SpecialName]
		public static readonly _N__N_lambda__12427__12608 Instance = new _N__N_lambda__12427__12608();

		[SpecialName]
		public sealed override RangeSet apply(Transition.Symbol t, RangeSet r)
		{
			return r.Sum(t.Chars);
		}
	}

	private sealed class _N_closureOf_loop_12626
	{
		internal int _N_state_12631;

		internal _N_closureOf_loop_12626()
		{
		}
	}

	private sealed class _N__N_lambda__12543__12640 : Function<list<int>, list<int>>
	{
		[SpecialName]
		private _N_closureOf_loop_12626 _N_loop_closure_12644;

		public _N__N_lambda__12543__12640(_N_closureOf_loop_12626 _N_loop_closure_12644)
		{
			this._N_loop_closure_12644 = _N_loop_closure_12644;
		}

		[SpecialName]
		public sealed override list<int> apply(list<int> _N__12542)
		{
			return new list<int>.Cons(_N_loop_closure_12644._N_state_12631, _N__12542);
		}
	}

	private sealed class _N_isMatch__12689 : Function<int, bool>
	{
		[SpecialName]
		private _N_closureOf_Minimize_12560 _N_Minimize_closure_12693;

		public _N_isMatch__12689(_N_closureOf_Minimize_12560 _N_Minimize_closure_12693)
		{
			this._N_Minimize_closure_12693 = _N_Minimize_closure_12693;
		}

		[SpecialName]
		public sealed override bool apply(int state)
		{
			int num = 0;
			bool flag = false;
			int num2 = 0;
			list<Transition.Symbol> list = _N_Minimize_closure_12693._N_stateTransitions_12569[state];
			while (list is list<Transition.Symbol>.Cons)
			{
				Transition.Symbol hd = ((list<Transition.Symbol>.Cons)list).hd;
				list = ((list<Transition.Symbol>.Cons)list).tl;
				hd = hd;
				list<RangeSet.Range> list2 = hd.Chars.Ranges;
				while (list2 is list<RangeSet.Range>.Cons)
				{
					RangeSet.Range hd2 = ((list<RangeSet.Range>.Cons)list2).hd;
					list2 = ((list<RangeSet.Range>.Cons)list2).tl;
					hd2 = hd2;
					num = hd2.from;
					int to = hd2.to;
					flag = num <= to;
					num2 = to - 1;
					bool flag2 = num2 > to;
					while (flag)
					{
						to = num;
						flag = ((!flag2) ? (num <= num2) : (num >= num2));
						num++;
						if (_N_Minimize_closure_12693._N_transitionMap_12565[to] != _N_Minimize_closure_12693._N_stateMap_12573[hd.To])
						{
							return false;
						}
					}
					list2 = list2;
				}
				list = list;
			}
			return true;
		}
	}

	public static FSM Normalize(FSM fsm)
	{
		list<Transition> transitions = fsm.Transitions;
		Hashtable<Nemerle.Builtins.Tuple<int, int>, Nemerle.Builtins.Tuple<RangeSet, bool>> ini = new Hashtable<Nemerle.Builtins.Tuple<int, int>, Nemerle.Builtins.Tuple<RangeSet, bool>>();
		Function<Transition, Hashtable<Nemerle.Builtins.Tuple<int, int>, Nemerle.Builtins.Tuple<RangeSet, bool>>, Hashtable<Nemerle.Builtins.Tuple<int, int>, Nemerle.Builtins.Tuple<RangeSet, bool>>> instance = _N__N_lambda__11692__11740.Instance;
		Hashtable<Nemerle.Builtins.Tuple<int, int>, Nemerle.Builtins.Tuple<RangeSet, bool>> hashtable = transitions.Fold(ini, instance);
		list<Transition>.Nil n_constant_object = list<Transition>.Nil._N_constant_object;
		Function<Nemerle.Builtins.Tuple<int, int>, Nemerle.Builtins.Tuple<RangeSet, bool>, list<Transition>, list<Transition>> instance2 = _N__N_lambda__11708__11792.Instance;
		list<Transition> transitions2 = hashtable.Fold(n_constant_object, instance2);
		return fsm.SetTransitions(transitions2);
	}

	public static FSM Do(FSM fsm)
	{
		_N_closureOf_Do_12103 n_closureOf_Do_ = new _N_closureOf_Do_12103();
		n_closureOf_Do_._N_fsm_12114 = Normalize(fsm);
		n_closureOf_Do_._N_stateMap_12112 = new Hashtable<Set<int>, int>();
		n_closureOf_Do_._N_states_12110 = new Nemerle.Collections.Stack<Nemerle.Builtins.Tuple<Set<int>, int>>();
		n_closureOf_Do_._N_result_12108 = new FSM();
		_N_addStateSet_12246(n_closureOf_Do_, new Set<int>().Add(n_closureOf_Do_._N_fsm_12114.StartState));
		checked
		{
			while (true)
			{
				_N_closureOf_loop_12258 n_closureOf_loop_ = new _N_closureOf_loop_12258();
				if (n_closureOf_Do_._N_states_12110.Count <= 0)
				{
					break;
				}
				Nemerle.Builtins.Tuple<Set<int>, int> tuple = n_closureOf_Do_._N_states_12110.Pop();
				Set<int> field = tuple.Field0;
				n_closureOf_loop_._N_fromState_12263 = tuple.Field1;
				Hashtable<Nemerle.Builtins.Tuple<int, bool>, list<int>> hashtable = new Hashtable<Nemerle.Builtins.Tuple<int, bool>, list<int>>();
				IEnumerator<int> enumerator = field.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						int current = enumerator.Current;
						int state = current;
						list<Transition.Symbol> list = _N_symbolTransitions_12117(n_closureOf_Do_, state);
						while (true)
						{
							_N_closureOf_foreach_loop_12290 n_closureOf_foreach_loop_ = new _N_closureOf_foreach_loop_12290();
							if (list is list<Transition.Symbol>.Cons)
							{
								Transition.Symbol hd = ((list<Transition.Symbol>.Cons)list).hd;
								list<Transition.Symbol> list2 = ((list<Transition.Symbol>.Cons)list).tl;
								n_closureOf_foreach_loop_._N_transition_12295 = hd;
								list<RangeSet.Range> list3 = n_closureOf_foreach_loop_._N_transition_12295.Chars.Ranges;
								while (list3 is list<RangeSet.Range>.Cons)
								{
									RangeSet.Range hd2 = ((list<RangeSet.Range>.Cons)list3).hd;
									list<RangeSet.Range> list4 = ((list<RangeSet.Range>.Cons)list3).tl;
									RangeSet.Range range = hd2;
									Nemerle.Builtins.Tuple<int, bool> key = new Nemerle.Builtins.Tuple<int, bool>(range.from, field1: true);
									list<int>.Nil n_constant_object = list<int>.Nil._N_constant_object;
									Function<list<int>, list<int>> updateFn = new _N__N_lambda__12013__12308(n_closureOf_foreach_loop_);
									hashtable.Update(key, n_constant_object, updateFn);
									Nemerle.Builtins.Tuple<int, bool> key2 = new Nemerle.Builtins.Tuple<int, bool>(range.to, field1: false);
									list<int>.Nil n_constant_object2 = list<int>.Nil._N_constant_object;
									Function<list<int>, list<int>> updateFn2 = new _N__N_lambda__12019__12317(n_closureOf_foreach_loop_);
									hashtable.Update(key2, n_constant_object2, updateFn2);
									list3 = list4;
								}
								list = list2;
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
				Function<KeyValuePair<Nemerle.Builtins.Tuple<int, bool>, list<int>>, Nemerle.Builtins.Tuple<int, bool, list<int>>> instance = _N__N_lambda__12025__12326.Instance;
				Nemerle.Builtins.Tuple<int, bool, list<int>>[] source = hashtable.MapToArray(instance);
				Function<Nemerle.Builtins.Tuple<int, bool, list<int>>, Nemerle.Builtins.Tuple<int, bool, list<int>>, int> instance2 = _N__N_lambda__12033__12340.Instance;
				Nemerle.Builtins.Tuple<int, bool, list<int>>[] array = source.SortInplace(instance2.apply);
				int num = 0;
				Set<int> set = new Set<int>();
				Nemerle.Builtins.Tuple<int, bool, list<int>>[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					Nemerle.Builtins.Tuple<int, bool, list<int>> tuple2 = array2[i];
					int field2 = tuple2.Field0;
					bool field3 = tuple2.Field1;
					list<int> field4 = tuple2.Field2;
					if (set.Count != 0)
					{
						if (field3)
						{
							if (field2 > num)
							{
								_N_addSymbolTransition_12274(n_closureOf_loop_, n_closureOf_Do_, num, field2 - 1, _N_addStateSet_12246(n_closureOf_Do_, set));
								num = field2;
							}
						}
						else
						{
							_N_addSymbolTransition_12274(n_closureOf_loop_, n_closureOf_Do_, num, field2, _N_addStateSet_12246(n_closureOf_Do_, set));
							num = field2 + 1;
						}
					}
					else
					{
						num = field2;
					}
					set = ((!field3) ? set.RemoveList(field4) : set.AddList(field4));
				}
			}
			foreach (KeyValuePair<Set<int>, int> item in n_closureOf_Do_._N_stateMap_12112)
			{
				KeyValuePair<Set<int>, int> keyValuePair = item;
				Set<int> key3 = keyValuePair.Key;
				Function<int, bool> fn = new _N__N_lambda__12097__12388(n_closureOf_Do_);
				if (key3.Exists(fn))
				{
					n_closureOf_Do_._N_result_12108 = n_closureOf_Do_._N_result_12108.AddOkState(keyValuePair.Value);
				}
			}
			return Minimize(n_closureOf_Do_._N_result_12108);
		}
	}

	public static FSM Minimize(FSM fsm)
	{
		_N_closureOf_Minimize_12560 n_closureOf_Minimize_ = new _N_closureOf_Minimize_12560();
		FSM fSM = Normalize(fsm);
		n_closureOf_Minimize_._N_stateMap_12573 = new int[fSM.StateCount];
		n_closureOf_Minimize_._N_stateSets_12571 = new List<list<int>>();
		n_closureOf_Minimize_._N_stateTransitions_12569 = new list<Transition.Symbol>[fSM.StateCount];
		checked
		{
			for (int i = 0; i < fSM.StateCount; i++)
			{
				n_closureOf_Minimize_._N_stateTransitions_12569[i] = list<Transition.Symbol>.Nil._N_constant_object;
			}
			list<Transition> list = fSM.Transitions;
			while (list is list<Transition>.Cons)
			{
				Transition hd = ((list<Transition>.Cons)list).hd;
				list<Transition> list2 = ((list<Transition>.Cons)list).tl;
				Transition transition = hd;
				n_closureOf_Minimize_._N_stateTransitions_12569[transition.From] = new list<Transition.Symbol>.Cons((Transition.Symbol)transition, n_closureOf_Minimize_._N_stateTransitions_12569[transition.From]);
				list = list2;
			}
			list<Transition.Symbol>[] n_stateTransitions_ = n_closureOf_Minimize_._N_stateTransitions_12569;
			Function<list<Transition.Symbol>, RangeSet> instance = _N__N_lambda__12422__12598.Instance;
			n_closureOf_Minimize_._N_stateChars_12567 = n_stateTransitions_.MapToArray(instance);
			_N_initalSplit_12619(n_closureOf_Minimize_, fSM.FailStates);
			_N_initalSplit_12619(n_closureOf_Minimize_, fSM.OkStates);
			n_closureOf_Minimize_._N_transitionMap_12565 = new int[65536];
			bool flag = true;
			while (flag)
			{
				flag = false;
				for (int j = 0; j < n_closureOf_Minimize_._N_stateSets_12571.Count; j++)
				{
					list<int> list3 = n_closureOf_Minimize_._N_stateSets_12571[j];
					if (list3.Length <= 1)
					{
						continue;
					}
					int head = list3.Head;
					list<Transition.Symbol> list4 = n_closureOf_Minimize_._N_stateTransitions_12569[head];
					list<int> field;
					list<int> field2;
					unchecked
					{
						while (list4 is list<Transition.Symbol>.Cons)
						{
							Transition.Symbol hd2 = ((list<Transition.Symbol>.Cons)list4).hd;
							list<Transition.Symbol> list5 = ((list<Transition.Symbol>.Cons)list4).tl;
							Transition.Symbol symbol = hd2;
							list<RangeSet.Range> list6 = symbol.Chars.Ranges;
							while (list6 is list<RangeSet.Range>.Cons)
							{
								RangeSet.Range hd3 = ((list<RangeSet.Range>.Cons)list6).hd;
								list<RangeSet.Range> list7 = ((list<RangeSet.Range>.Cons)list6).tl;
								RangeSet.Range range = hd3;
								int num = range.from;
								int to = range.to;
								bool flag2 = num <= to;
								int num2 = to;
								num2--;
								bool flag3 = num2 > to;
								while (flag2)
								{
									int num3 = num;
									flag2 = ((!flag3) ? (num <= num2) : (num >= num2));
									num++;
									n_closureOf_Minimize_._N_transitionMap_12565[num3] = n_closureOf_Minimize_._N_stateMap_12573[symbol.To];
								}
								list6 = list7;
							}
							list4 = list5;
						}
						Function<int, bool> pred = new _N_isMatch__12689(n_closureOf_Minimize_);
						Nemerle.Builtins.Tuple<list<int>, list<int>> tuple = list3.Partition(pred);
						field = tuple.Field0;
						field2 = tuple.Field1;
					}
					if (!field2.IsEmpty())
					{
						n_closureOf_Minimize_._N_stateSets_12571[j] = field;
						_N_addStateSet_12576(n_closureOf_Minimize_, field2);
						flag = true;
						j--;
					}
				}
			}
			FSM fSM2 = new FSM();
			fSM2 = fSM2.NewState(n_closureOf_Minimize_._N_stateSets_12571.Count - 1);
			fSM2 = fSM2.SetStartState(n_closureOf_Minimize_._N_stateMap_12573[fSM.StartState]);
			list<Transition> list8 = fSM.Transitions;
			while (list8 is list<Transition>.Cons)
			{
				Transition hd4 = ((list<Transition>.Cons)list8).hd;
				list<Transition> list9 = ((list<Transition>.Cons)list8).tl;
				Transition transition2 = hd4;
				Transition.Symbol symbol2 = (Transition.Symbol)transition2;
				int from = n_closureOf_Minimize_._N_stateMap_12573[symbol2.From];
				int to2 = n_closureOf_Minimize_._N_stateMap_12573[symbol2.To];
				fSM2 = fSM2.AddTransition(new Transition.Symbol(from, to2, symbol2.Chars));
				list8 = list9;
			}
			IEnumerator<int> enumerator = fSM.OkStates.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int current = enumerator.Current;
					int num4 = current;
					fSM2 = fSM2.AddOkState(n_closureOf_Minimize_._N_stateMap_12573[num4]);
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			return Normalize(fSM2);
		}
	}

	private static list<Transition.Symbol> _N_symbolTransitions_12117(_N_closureOf_Do_12103 _N_Do_cp_12116, int state)
	{
		_N_closureOf_symbolTransitions_12123 n_closureOf_symbolTransitions_ = new _N_closureOf_symbolTransitions_12123();
		n_closureOf_symbolTransitions_._N_state_12128 = state;
		list<Transition> transitions = _N_Do_cp_12116._N_fsm_12114.Transitions;
		Function<Transition, bool> f = new _N__N_lambda__11825__12140(n_closureOf_symbolTransitions_);
		list<Transition> list = transitions.Filter(f);
		Function<Transition, Transition.Symbol> instance = _N__N_lambda__11820__12130.Instance;
		return list.Map(instance);
	}

	private static list<Transition.Epsilon> _N_epsilonTransitions_12156(_N_closureOf_Do_12103 _N_Do_cp_12155, int state)
	{
		_N_closureOf_epsilonTransitions_12162 n_closureOf_epsilonTransitions_ = new _N_closureOf_epsilonTransitions_12162();
		n_closureOf_epsilonTransitions_._N_state_12167 = state;
		list<Transition> transitions = _N_Do_cp_12155._N_fsm_12114.Transitions;
		Function<Transition, bool> f = new _N__N_lambda__11840__12179(n_closureOf_epsilonTransitions_);
		list<Transition> list = transitions.Filter(f);
		Function<Transition, Transition.Epsilon> instance = _N__N_lambda__11835__12169.Instance;
		return list.Map(instance);
	}

	private static Set<int> _N_epsilonMove_12195(_N_closureOf_Do_12103 _N_Do_cp_12194, Set<int> set)
	{
		_N_closureOf_epsilonMove_12201 n_closureOf_epsilonMove_ = new _N_closureOf_epsilonMove_12201();
		n_closureOf_epsilonMove_._N_rec_12206 = new _N_rec__12208(n_closureOf_epsilonMove_, _N_Do_cp_12194);
		return set.Fold(set, n_closureOf_epsilonMove_._N_rec_12206);
	}

	private static int _N_addStateSet_12246(_N_closureOf_Do_12103 _N_Do_cp_12245, Set<int> stateSet)
	{
		Set<int> set = _N_epsilonMove_12195(_N_Do_cp_12245, stateSet);
		option<int> option = _N_Do_cp_12245._N_stateMap_12112.Get(set);
		int result;
		if (option is option<int>.Some)
		{
			int val = ((option<int>.Some)option).val;
			result = val;
		}
		else
		{
			if (option != option<int>.None._N_constant_object)
			{
				throw new MatchFailureException();
			}
			int val = _N_Do_cp_12245._N_stateMap_12112.Count;
			_N_Do_cp_12245._N_stateMap_12112.Add(set, val);
			_N_Do_cp_12245._N_states_12110.Push(new Nemerle.Builtins.Tuple<Set<int>, int>(set, val));
			_N_Do_cp_12245._N_result_12108 = _N_Do_cp_12245._N_result_12108.NewState(val);
			result = val;
		}
		return result;
	}

	private static void _N_addSymbolTransition_12274(_N_closureOf_loop_12258 _N_loop_cp_12272, _N_closureOf_Do_12103 _N_Do_cp_12273, int fromCh, int toCh, int toState)
	{
		Transition.Symbol t = new Transition.Symbol(_N_loop_cp_12272._N_fromState_12263, toState, new RangeSet().AddRange((char)checked((ushort)fromCh), (char)checked((ushort)toCh)));
		_N_Do_cp_12273._N_result_12108 = _N_Do_cp_12273._N_result_12108.AddTransition(t);
	}

	private static void _N_addStateSet_12576(_N_closureOf_Minimize_12560 _N_Minimize_cp_12575, list<int> set)
	{
		list<int> list = set;
		while (list is list<int>.Cons)
		{
			int hd = ((list<int>.Cons)list).hd;
			list = ((list<int>.Cons)list).tl;
			_N_Minimize_cp_12575._N_stateMap_12573[hd] = _N_Minimize_cp_12575._N_stateSets_12571.Count;
			list = list;
		}
		_N_Minimize_cp_12575._N_stateSets_12571.Add(set);
	}

	private static void _N_initalSplit_12619(_N_closureOf_Minimize_12560 _N_Minimize_cp_12618, Set<int> states)
	{
		Hashtable<RangeSet, list<int>> hashtable = new Hashtable<RangeSet, list<int>>();
		IEnumerator<int> enumerator = states.GetEnumerator();
		try
		{
			while (true)
			{
				_N_closureOf_loop_12626 n_closureOf_loop_ = new _N_closureOf_loop_12626();
				if (!enumerator.MoveNext())
				{
					break;
				}
				int num = (n_closureOf_loop_._N_state_12631 = enumerator.Current);
				RangeSet key = _N_Minimize_cp_12618._N_stateChars_12567[n_closureOf_loop_._N_state_12631];
				list<int>.Nil n_constant_object = list<int>.Nil._N_constant_object;
				Function<list<int>, list<int>> updateFn = new _N__N_lambda__12543__12640(n_closureOf_loop_);
				hashtable.Update(key, n_constant_object, updateFn);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		foreach (KeyValuePair<RangeSet, list<int>> item in hashtable)
		{
			KeyValuePair<RangeSet, list<int>> keyValuePair = item;
			_N_addStateSet_12576(_N_Minimize_cp_12618, keyValuePair.Value);
		}
	}
}
