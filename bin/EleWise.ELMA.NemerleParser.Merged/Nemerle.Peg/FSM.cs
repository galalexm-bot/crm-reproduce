using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Peg;

public class FSM
{
	private sealed class _N_closureOf_IncludeFSM_14069
	{
		internal FSM _N__N_closurised_this_ptr_14074;

		internal _N_closureOf_IncludeFSM_14069()
		{
		}
	}

	private sealed class _N__N_lambda__14049__14076 : Function<Transition, list<Transition>, list<Transition>>
	{
		[SpecialName]
		private _N_closureOf_IncludeFSM_14069 _N_IncludeFSM_closure_14080;

		public _N__N_lambda__14049__14076(_N_closureOf_IncludeFSM_14069 _N_IncludeFSM_closure_14080)
		{
			this._N_IncludeFSM_closure_14080 = _N_IncludeFSM_closure_14080;
		}

		[SpecialName]
		public sealed override list<Transition> apply(Transition transition, list<Transition> transitions)
		{
			checked
			{
				int from = transition.From + _N_IncludeFSM_closure_14080._N__N_closurised_this_ptr_14074.StateCount;
				int to = transition.To + _N_IncludeFSM_closure_14080._N__N_closurised_this_ptr_14074.StateCount;
				Transition transition2 = transition;
				object obj;
				if (transition2 is Transition.Symbol)
				{
					RangeSet chars = ((Transition.Symbol)transition2).Chars;
					obj = new Transition.Symbol(from, to, chars);
				}
				else
				{
					if (!(transition2 is Transition.Epsilon))
					{
						throw new MatchFailureException();
					}
					obj = new Transition.Epsilon(from, to);
				}
				transition2 = (Transition)obj;
				return new list<Transition>.Cons(transition2, transitions);
			}
		}
	}

	private sealed class _N__N_lambda__14061__14090 : Function<int, Set<int>, Set<int>>
	{
		[SpecialName]
		private _N_closureOf_IncludeFSM_14069 _N_IncludeFSM_closure_14094;

		public _N__N_lambda__14061__14090(_N_closureOf_IncludeFSM_14069 _N_IncludeFSM_closure_14094)
		{
			this._N_IncludeFSM_closure_14094 = _N_IncludeFSM_closure_14094;
		}

		[SpecialName]
		public sealed override Set<int> apply(int state, Set<int> states)
		{
			return states.Add(checked(state + _N_IncludeFSM_closure_14094._N__N_closurised_this_ptr_14074.StateCount));
		}
	}

	private readonly int _stateCount;

	private readonly list<Transition> _transitions;

	private readonly int _startState;

	private readonly Set<int> _okStates;

	public Set<int> FailStates
	{
		get
		{
			int num = 0;
			list<int>.Cons cons = null;
			list<int>.Cons cons2 = null;
			int num2 = 0;
			bool flag = false;
			cons = null;
			cons2 = null;
			num = 0;
			int num3 = checked(StateCount - 1);
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
			list<int> elems = ((!(cons == null)) ? ((list<int>)cons) : ((list<int>)list<int>.Nil._N_constant_object));
			return new Set<int>().AddRange(elems).RemoveRange(OkStates);
		}
	}

	public int StateCount
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _stateCount;
		}
	}

	public list<Transition> Transitions
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _transitions;
		}
	}

	public int StartState
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return _startState;
		}
	}

	public Set<int> OkStates
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _okStates;
		}
	}

	public FSM()
	{
		_stateCount = 1;
		_transitions = list<Transition>.Nil._N_constant_object;
		_startState = 0;
		_okStates = new Set<int>();
	}

	private FSM(int stateCount, list<Transition> transitions, int startState, Set<int> okStates)
	{
		_stateCount = stateCount;
		_transitions = transitions;
		_startState = startState;
		_okStates = okStates;
	}

	public Tuple<FSM, int> NewState()
	{
		FSM field = new FSM(checked(StateCount + 1), Transitions, StartState, OkStates);
		return new Tuple<FSM, int>(field, StateCount);
	}

	public FSM NewState(int state)
	{
		return (state >= StateCount) ? new FSM(checked(state + 1), Transitions, StartState, OkStates) : this;
	}

	public Tuple<FSM, int> NewStartState()
	{
		FSM field = new FSM(checked(StateCount + 1), Transitions, StateCount, OkStates);
		return new Tuple<FSM, int>(field, StateCount);
	}

	public Tuple<FSM, int> NewOkState()
	{
		FSM field = new FSM(checked(StateCount + 1), Transitions, StartState, OkStates.Add(StateCount));
		return new Tuple<FSM, int>(field, StateCount);
	}

	public FSM SetStartState(int state)
	{
		return new FSM(StateCount, Transitions, state, OkStates);
	}

	public FSM SetOkStates(Set<int> states)
	{
		return new FSM(StateCount, Transitions, StartState, states);
	}

	public FSM AddOkState(int state)
	{
		return new FSM(StateCount, Transitions, StartState, OkStates.Replace(state));
	}

	public FSM AddOkStates(IEnumerable<int> states)
	{
		return new FSM(StateCount, Transitions, StartState, OkStates.ReplaceRange(states));
	}

	public FSM RemoveOkState(int state)
	{
		return new FSM(StateCount, Transitions, StartState, OkStates.Remove(state));
	}

	public FSM RemoveOkStates(IEnumerable<int> states)
	{
		return new FSM(StateCount, Transitions, StartState, OkStates.RemoveRange(states));
	}

	public FSM SetTransitions(list<Transition> transitions)
	{
		return new FSM(StateCount, transitions, StartState, OkStates);
	}

	[Macro("Nemerle.Assertions.Requires:method:postscan", 0, "0 <= t.To && t.To < _stateCount && 0 <= t.From && t.From < _stateCount@")]
	public FSM AddTransition(Transition t)
	{
		if (0 > t.To || t.To >= _stateCount || 0 > t.From || t.From >= _stateCount)
		{
			throw new AssertionException("FSM\\FSM.n", 124, "0 <= t.To && t.To < _stateCount && 0 <= t.From && t.From < _stateCount", "The ``Requires'' contract of method `AddTransition' has been violated.".ToString());
		}
		return new FSM(StateCount, new list<Transition>.Cons(t, Transitions), StartState, OkStates);
	}

	public Tuple<FSM, int, Set<int>> IncludeFSM(FSM fsm)
	{
		_N_closureOf_IncludeFSM_14069 n_closureOf_IncludeFSM_ = new _N_closureOf_IncludeFSM_14069();
		n_closureOf_IncludeFSM_._N__N_closurised_this_ptr_14074 = this;
		list<Transition> transitions = fsm.Transitions;
		list<Transition> transitions2 = _transitions;
		Function<Transition, list<Transition>, list<Transition>> convert = new _N__N_lambda__14049__14076(n_closureOf_IncludeFSM_);
		list<Transition> transitions3 = transitions.Fold(transitions2, convert);
		checked
		{
			FSM field = new FSM(StateCount + fsm.StateCount, transitions3, StartState, OkStates);
			int field2 = fsm.StartState + StateCount;
			Set<int> okStates = fsm.OkStates;
			Set<int> acc = new Set<int>();
			Function<int, Set<int>, Set<int>> fn = new _N__N_lambda__14061__14090(n_closureOf_IncludeFSM_);
			return new Tuple<FSM, int, Set<int>>(field, field2, okStates.Fold(acc, fn));
		}
	}
}
