using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;

namespace Nemerle.Peg;

internal class Optimizer
{
	private sealed class _N_closureOf_CalcRulesWeights_17329
	{
		internal Grammar _N_grammar_17334;

		internal _N_closureOf_CalcRulesWeights_17329()
		{
		}
	}

	private sealed class _N_calcRuleWeight__17336 : Function<NameRef, Function<NameRef, option<int>>, option<int>>
	{
		[SpecialName]
		private _N_closureOf_CalcRulesWeights_17329 _N_CalcRulesWeights_closure_17340;

		public _N_calcRuleWeight__17336(_N_closureOf_CalcRulesWeights_17329 _N_CalcRulesWeights_closure_17340)
		{
			this._N_CalcRulesWeights_closure_17340 = _N_CalcRulesWeights_closure_17340;
		}

		[SpecialName]
		public sealed override option<int> apply(NameRef name, Function<NameRef, option<int>> getWeight)
		{
			option<Rule> option = null;
			option<RuleType> option2 = null;
			_N_closureOf_calcRuleWeight_17345 n_closureOf_calcRuleWeight_ = new _N_closureOf_calcRuleWeight_17345();
			n_closureOf_calcRuleWeight_._N_getWeight_17350 = getWeight;
			option = _N_CalcRulesWeights_closure_17340._N_grammar_17334.GetRule(name).Rule;
			option2 = _N_CalcRulesWeights_closure_17340._N_grammar_17334.GetRuleType(name);
			object result;
			if (option is option<Rule>.Some && option2 == option<RuleType>.None._N_constant_object)
			{
				Rule val = ((option<Rule>.Some)option).val;
				result = _N_calc_17353(n_closureOf_calcRuleWeight_, val);
			}
			else
			{
				result = option<int>.None._N_constant_object;
			}
			return (option<int>)result;
		}
	}

	private sealed class _N_closureOf_calcRuleWeight_17345
	{
		internal Function<NameRef, option<int>> _N_getWeight_17350;

		internal _N_closureOf_calcRuleWeight_17345()
		{
		}
	}

	private sealed class _N_closureOf_calc_17359
	{
		internal _N_closureOf_calc_17359()
		{
		}
	}

	private sealed class _N__N_lambda__17313__17386 : Function<Rule, option<int>, option<int>>
	{
		[SpecialName]
		private _N_closureOf_calcRuleWeight_17345 _N_calcRuleWeight_closure_17392;

		[SpecialName]
		private _N_closureOf_calc_17359 _N_calc_closure_17390;

		public _N__N_lambda__17313__17386(_N_closureOf_calc_17359 _N_calc_closure_17390, _N_closureOf_calcRuleWeight_17345 _N_calcRuleWeight_closure_17392)
		{
			this._N_calc_closure_17390 = _N_calc_closure_17390;
			this._N_calcRuleWeight_closure_17392 = _N_calcRuleWeight_closure_17392;
		}

		[SpecialName]
		public sealed override option<int> apply(Rule rule, option<int> weight)
		{
			return _N_add_17364(weight, _N_calc_17353(_N_calcRuleWeight_closure_17392, rule));
		}
	}

	private sealed class _N__N_lambda__17323__17405 : Function<NameRef, option<int>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__17323__17405 Instance = new _N__N_lambda__17323__17405();

		[SpecialName]
		public sealed override option<int> apply(NameRef _N_wildcard_17322)
		{
			return option<int>.None._N_constant_object;
		}
	}

	private sealed class _N_closureOf_OptimizeGrammar_17440
	{
		internal Grammar _N_grammar_17449;

		internal Map<NameRef, option<int>> _N_weights_17447;

		internal Map<NameRef, option<Rule>> _N_ruleMap_17445;

		internal _N_closureOf_OptimizeGrammar_17440()
		{
		}
	}

	private sealed class _N__N_lambda__17421__17451 : Function<NameRef, Function<NameRef, option<Rule>>, option<Rule>>
	{
		[SpecialName]
		private _N_closureOf_OptimizeGrammar_17440 _N_OptimizeGrammar_closure_17455;

		public _N__N_lambda__17421__17451(_N_closureOf_OptimizeGrammar_17440 _N_OptimizeGrammar_closure_17455)
		{
			this._N_OptimizeGrammar_closure_17455 = _N_OptimizeGrammar_closure_17455;
		}

		[SpecialName]
		public sealed override option<Rule> apply(NameRef _N__17419, Function<NameRef, option<Rule>> _N__17420)
		{
			return OptimizeRule(_N__17419, _N__17420, _N_OptimizeGrammar_closure_17455._N_grammar_17449, _N_OptimizeGrammar_closure_17455._N_weights_17447);
		}
	}

	private sealed class _N__N_lambda__17428__17460 : Function<NameRef, option<Rule>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__17428__17460 Instance = new _N__N_lambda__17428__17460();

		[SpecialName]
		public sealed override option<Rule> apply(NameRef _N_wildcard_17427)
		{
			//Discarded unreachable code: IL_0017
			throw new AssertionException("Optimizer\\Optimizer.OptimizeGrammar.n", 48, "", "");
		}
	}

	private sealed class _N__N_lambda__17434__17470 : Function<RuleDefinition, option<Rule>>
	{
		[SpecialName]
		private _N_closureOf_OptimizeGrammar_17440 _N_OptimizeGrammar_closure_17474;

		public _N__N_lambda__17434__17470(_N_closureOf_OptimizeGrammar_17440 _N_OptimizeGrammar_closure_17474)
		{
			this._N_OptimizeGrammar_closure_17474 = _N_OptimizeGrammar_closure_17474;
		}

		[SpecialName]
		public sealed override option<Rule> apply(RuleDefinition rd)
		{
			return _N_OptimizeGrammar_closure_17474._N_ruleMap_17445.Get(rd.Name);
		}
	}

	private sealed class _N_closureOf_OptimizeRule_17577
	{
		internal Function<NameRef, option<Rule>> _N_getOptimizedRule_17586;

		internal Map<NameRef, option<int>> _N_weights_17584;

		internal Function<Rule, Rule> _N_optimize_17582;

		internal _N_closureOf_OptimizeRule_17577()
		{
		}
	}

	private sealed class _N_optimize__17588 : Function<Rule, Rule>
	{
		[SpecialName]
		private _N_closureOf_OptimizeRule_17577 _N_OptimizeRule_closure_17592;

		public _N_optimize__17588(_N_closureOf_OptimizeRule_17577 _N_OptimizeRule_closure_17592)
		{
			this._N_OptimizeRule_closure_17592 = _N_OptimizeRule_closure_17592;
		}

		[SpecialName]
		public sealed override Rule apply(Rule r)
		{
			object result;
			while (true)
			{
				_N_closureOf_optimize_17597 n_closureOf_optimize_ = new _N_closureOf_optimize_17597();
				switch (Rule._N_GetVariantCodeSafe(r))
				{
				default:
					throw new MatchFailureException();
				case 0:
				{
					list<Rule> rules = ((Rule.Choice)r).rules;
					rules = rules.Map(_N_OptimizeRule_closure_17592._N_optimize_17582);
					list<Rule> list2 = rules;
					Function<Rule, list<Rule>> instance = _N__N_lambda__17490__17621.Instance;
					list<list<Rule>> l = list2.Map(instance);
					rules = l.Flatten();
					rules = _N_catFSM_17635(n_closureOf_optimize_, rules);
					if (rules is list<Rule>.Cons && (object)((list<Rule>.Cons)rules).tl == list<Rule>.Nil._N_constant_object)
					{
						Rule rule = ((list<Rule>.Cons)rules).hd;
						result = rule;
					}
					else
					{
						result = new Rule.Choice(r.Location, rules);
					}
					break;
				}
				case 1:
				{
					list<Rule> rules = ((Rule.Sequence)r).rules;
					rules = _N_optimizeNot_17650(n_closureOf_optimize_, rules);
					rules = rules.Map(_N_OptimizeRule_closure_17592._N_optimize_17582);
					list<Rule> list = rules;
					Function<Rule, list<Rule>> instance = _N__N_lambda__17527__17662.Instance;
					list<list<Rule>> l = list.Map(instance);
					rules = l.Flatten();
					rules = _N_catFSM_17676(n_closureOf_optimize_, rules);
					if (rules is list<Rule>.Cons && (object)((list<Rule>.Cons)rules).tl == list<Rule>.Nil._N_constant_object)
					{
						Rule rule = ((list<Rule>.Cons)rules).hd;
						result = rule;
					}
					else
					{
						result = new Rule.Sequence(r.Location, rules);
					}
					break;
				}
				case 2:
				{
					NameRef name = ((Rule.Call)r).name;
					int maxCount = ((Rule.Call)r).bindingPower;
					option<int> option = _N_OptimizeRule_closure_17592._N_weights_17584.Get(name);
					if (option is option<int>.Some)
					{
						int minCount = ((option<int>.Some)option).val;
						if (minCount < 20)
						{
							option<Rule> option2 = _N_OptimizeRule_closure_17592._N_getOptimizedRule_17586.apply(name);
							if (option2 is option<Rule>.Some && ((option<Rule>.Some)option2).val is Rule.Fsm)
							{
								Rule.Fsm fsm2 = (Rule.Fsm)((option<Rule>.Some)option2).val;
								result = fsm2;
							}
							else
							{
								result = new Rule.Call(r.Location, name, maxCount);
							}
							break;
						}
					}
					result = new Rule.Call(r.Location, name, maxCount);
					break;
				}
				case 3:
				{
					int maxCount = ((Rule.RepeatMin)r).minCount;
					Rule rule = ((Rule.RepeatMin)r).rule;
					rule = _N_OptimizeRule_closure_17592._N_optimize_17582.apply(rule);
					if (rule is Rule.Fsm)
					{
						FSM fsm = ((Rule.Fsm)rule).fsm;
						result = new Rule.Fsm(r.Location, FSMBuilder.RepeatMin(maxCount, fsm));
					}
					else
					{
						result = new Rule.RepeatMin(r.Location, maxCount, rule);
					}
					break;
				}
				case 4:
				{
					int minCount = ((Rule.RepeatMinMax)r).minCount;
					int maxCount = ((Rule.RepeatMinMax)r).maxCount;
					Rule rule = ((Rule.RepeatMinMax)r).rule;
					rule = _N_OptimizeRule_closure_17592._N_optimize_17582.apply(rule);
					if (rule is Rule.Fsm)
					{
						FSM fsm = ((Rule.Fsm)rule).fsm;
						result = new Rule.Fsm(r.Location, FSMBuilder.RepeatMinMax(minCount, maxCount, fsm));
					}
					else
					{
						result = new Rule.RepeatMinMax(r.Location, minCount, maxCount, rule);
					}
					break;
				}
				case 5:
				{
					list<RangeSet> seq = ((Rule.Chars)r).chars;
					result = new Rule.Fsm(r.Location, FSMBuilder.Seq(seq));
					break;
				}
				case 6:
					result = (Rule.Fsm)r;
					break;
				case 7:
				{
					Rule rule;
					if (((Rule.Not)r).rule is Rule.Not)
					{
						rule = ((Rule.Not)((Rule.Not)r).rule).rule;
						r = new Rule.And(r.Location, rule);
						continue;
					}
					if (((Rule.Not)r).rule is Rule.And)
					{
						rule = ((Rule.And)((Rule.Not)r).rule).rule;
						r = new Rule.Not(r.Location, rule);
						continue;
					}
					rule = ((Rule.Not)r).rule;
					result = new Rule.Not(r.Location, _N_OptimizeRule_closure_17592._N_optimize_17582.apply(rule));
					break;
				}
				case 8:
				{
					Rule rule;
					if (((Rule.And)r).rule is Rule.Not)
					{
						rule = ((Rule.Not)((Rule.And)r).rule).rule;
						r = new Rule.Not(r.Location, rule);
						continue;
					}
					if (((Rule.And)r).rule is Rule.And)
					{
						rule = ((Rule.And)((Rule.And)r).rule).rule;
						r = new Rule.And(r.Location, rule);
						continue;
					}
					rule = ((Rule.And)r).rule;
					result = new Rule.And(r.Location, _N_OptimizeRule_closure_17592._N_optimize_17582.apply(rule));
					break;
				}
				case 9:
				{
					CaptureKind kind = ((Rule.Capture)r).kind;
					Rule rule = ((Rule.Capture)r).rule;
					result = new Rule.Capture(r.Location, kind, _N_OptimizeRule_closure_17592._N_optimize_17582.apply(rule));
					break;
				}
				case 10:
				{
					NameRef name = ((Rule.Scope)r).name;
					Rule rule = ((Rule.Scope)r).rule;
					result = new Rule.Scope(r.Location, name, _N_OptimizeRule_closure_17592._N_optimize_17582.apply(rule));
					break;
				}
				case 11:
					result = (Rule.Cut)r;
					break;
				}
				break;
			}
			return (Rule)result;
		}
	}

	private sealed class _N_closureOf_optimize_17597
	{
		internal _N_closureOf_optimize_17597()
		{
		}
	}

	private sealed class _N__N_lambda__17490__17621 : Function<Rule, list<Rule>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__17490__17621 Instance = new _N__N_lambda__17490__17621();

		[SpecialName]
		public sealed override list<Rule> apply(Rule _N_wildcard_4201)
		{
			object result;
			if (_N_wildcard_4201 is Rule.Choice)
			{
				list<Rule> list = ((Rule.Choice)_N_wildcard_4201).rules;
				result = list;
			}
			else
			{
				result = new list<Rule>.Cons(_N_wildcard_4201, list<Rule>.Nil._N_constant_object);
			}
			return (list<Rule>)result;
		}
	}

	private sealed class _N__N_lambda__17527__17662 : Function<Rule, list<Rule>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__17527__17662 Instance = new _N__N_lambda__17527__17662();

		[SpecialName]
		public sealed override list<Rule> apply(Rule _N_wildcard_4203)
		{
			object result;
			if (_N_wildcard_4203 is Rule.Sequence)
			{
				list<Rule> list = ((Rule.Sequence)_N_wildcard_4203).rules;
				result = list;
			}
			else
			{
				result = new list<Rule>.Cons(_N_wildcard_4203, list<Rule>.Nil._N_constant_object);
			}
			return (list<Rule>)result;
		}
	}

	public static Map<NameRef, option<int>> CalcRulesWeights(Grammar grammar)
	{
		_N_closureOf_CalcRulesWeights_17329 n_closureOf_CalcRulesWeights_ = new _N_closureOf_CalcRulesWeights_17329();
		n_closureOf_CalcRulesWeights_._N_grammar_17334 = grammar;
		Function<NameRef, Function<NameRef, option<int>>, option<int>> calc = new _N_calcRuleWeight__17336(n_closureOf_CalcRulesWeights_);
		list<NameRef> names = n_closureOf_CalcRulesWeights_._N_grammar_17334.Names;
		Function<NameRef, option<int>> instance = _N__N_lambda__17323__17405.Instance;
		return Util.GraphWalk(names, calc, instance);
	}

	public static Grammar OptimizeGrammar(Grammar grammar)
	{
		_N_closureOf_OptimizeGrammar_17440 n_closureOf_OptimizeGrammar_ = new _N_closureOf_OptimizeGrammar_17440();
		n_closureOf_OptimizeGrammar_._N_grammar_17449 = grammar;
		n_closureOf_OptimizeGrammar_._N_weights_17447 = CalcRulesWeights(n_closureOf_OptimizeGrammar_._N_grammar_17449);
		list<NameRef> names = n_closureOf_OptimizeGrammar_._N_grammar_17449.Names;
		Function<NameRef, Function<NameRef, option<Rule>>, option<Rule>> calc = new _N__N_lambda__17421__17451(n_closureOf_OptimizeGrammar_);
		Function<NameRef, option<Rule>> instance = _N__N_lambda__17428__17460.Instance;
		n_closureOf_OptimizeGrammar_._N_ruleMap_17445 = Util.GraphWalk(names, calc, instance);
		Grammar n_grammar_ = n_closureOf_OptimizeGrammar_._N_grammar_17449;
		Function<RuleDefinition, option<Rule>> fn = new _N__N_lambda__17434__17470(n_closureOf_OptimizeGrammar_);
		return n_grammar_.TransformRules(fn);
	}

	public static option<Rule> OptimizeRule(NameRef ruleName, Function<NameRef, option<Rule>> getOptimizedRule, Grammar grammar, Map<NameRef, option<int>> weights)
	{
		_N_closureOf_OptimizeRule_17577 n_closureOf_OptimizeRule_ = new _N_closureOf_OptimizeRule_17577();
		n_closureOf_OptimizeRule_._N_getOptimizedRule_17586 = getOptimizedRule;
		n_closureOf_OptimizeRule_._N_weights_17584 = weights;
		n_closureOf_OptimizeRule_._N_optimize_17582 = new _N_optimize__17588(n_closureOf_OptimizeRule_);
		option<Rule> rule = grammar.GetRule(ruleName).Rule;
		object result;
		if (rule is option<Rule>.Some)
		{
			Rule val = ((option<Rule>.Some)rule).val;
			result = new option<Rule>.Some(n_closureOf_OptimizeRule_._N_optimize_17582.apply(val));
		}
		else
		{
			if (rule != option<Rule>.None._N_constant_object)
			{
				throw new MatchFailureException();
			}
			result = option<Rule>.None._N_constant_object;
		}
		return (option<Rule>)result;
	}

	private static option<int> _N_calc_17353(_N_closureOf_calcRuleWeight_17345 _N_calcRuleWeight_cp_17352, Rule rule)
	{
		_N_closureOf_calc_17359 n_calc_closure_ = new _N_closureOf_calc_17359();
		Rule rule2 = rule;
		list<Rule> list;
		object obj;
		list<Rule> source;
		option<int>.Some ini;
		Function<Rule, option<int>, option<int>> convert;
		switch (Rule._N_GetVariantCodeSafe(rule2))
		{
		default:
			throw new MatchFailureException();
		case 0:
			list = ((Rule.Choice)rule2).rules;
			goto IL_0072;
		case 1:
			list = ((Rule.Sequence)rule2).rules;
			goto IL_0072;
		case 2:
		{
			NameRef name = ((Rule.Call)rule2).name;
			obj = _N_calcRuleWeight_cp_17352._N_getWeight_17350.apply(name);
			break;
		}
		case 3:
			rule2 = ((Rule.RepeatMin)rule2).rule;
			goto IL_0118;
		case 4:
			rule2 = ((Rule.RepeatMinMax)rule2).rule;
			goto IL_0118;
		case 7:
			rule2 = ((Rule.Not)rule2).rule;
			goto IL_0118;
		case 8:
			rule2 = ((Rule.And)rule2).rule;
			goto IL_0118;
		case 9:
			rule2 = ((Rule.Capture)rule2).rule;
			goto IL_0118;
		case 10:
			rule2 = ((Rule.Scope)rule2).rule;
			goto IL_0118;
		case 5:
		case 6:
		case 11:
			{
				obj = new option<int>.Some(0);
				break;
			}
			IL_0118:
			obj = _N_calc_17353(_N_calcRuleWeight_cp_17352, rule2);
			break;
			IL_0072:
			source = list;
			ini = new option<int>.Some(0);
			convert = new _N__N_lambda__17313__17386(n_calc_closure_, _N_calcRuleWeight_cp_17352);
			obj = source.Fold(ini, convert);
			break;
		}
		option<int> n_wildcard_ = (option<int>)obj;
		return _N_add_17364(n_wildcard_, new option<int>.Some(1));
	}

	private static option<int> _N_add_17364(option<int> _N_wildcard_4199, option<int> _N_wildcard_4200)
	{
		object result;
		if (_N_wildcard_4199 is option<int>.Some && _N_wildcard_4200 is option<int>.Some)
		{
			int val = ((option<int>.Some)_N_wildcard_4199).val;
			int val2 = ((option<int>.Some)_N_wildcard_4200).val;
			result = new option<int>.Some(checked(val + val2));
		}
		else
		{
			result = option<int>.None._N_constant_object;
		}
		return (option<int>)result;
	}

	private static list<Rule> _N_catFSM_17635(_N_closureOf_optimize_17597 _N_optimize_cp_17634, list<Rule> _N_wildcard_4202)
	{
		object result;
		while (true)
		{
			if (_N_wildcard_4202 is list<Rule>.Cons)
			{
				list<Rule> tl;
				if (((list<Rule>.Cons)_N_wildcard_4202).hd is Rule.Fsm)
				{
					Rule.Fsm fsm = (Rule.Fsm)((list<Rule>.Cons)_N_wildcard_4202).hd;
					if (((list<Rule>.Cons)_N_wildcard_4202).tl is list<Rule>.Cons)
					{
						FSM fsm2 = ((Rule.Fsm)((list<Rule>.Cons)_N_wildcard_4202).hd).fsm;
						if (((list<Rule>.Cons)((list<Rule>.Cons)_N_wildcard_4202).tl).hd is Rule.Fsm)
						{
							Rule.Fsm fsm3 = (Rule.Fsm)((list<Rule>.Cons)((list<Rule>.Cons)_N_wildcard_4202).tl).hd;
							FSM fsm4 = ((Rule.Fsm)((list<Rule>.Cons)((list<Rule>.Cons)_N_wildcard_4202).tl).hd).fsm;
							tl = ((list<Rule>.Cons)((list<Rule>.Cons)_N_wildcard_4202).tl).tl;
							_N_wildcard_4202 = new list<Rule>.Cons(new Rule.Fsm(fsm.Location + fsm3.Location, FSMBuilder.Choice(new list<FSM>.Cons(fsm2, new list<FSM>.Cons(fsm4, list<FSM>.Nil._N_constant_object)))), tl);
							continue;
						}
					}
				}
				Rule hd = ((list<Rule>.Cons)_N_wildcard_4202).hd;
				tl = ((list<Rule>.Cons)_N_wildcard_4202).tl;
				result = new list<Rule>.Cons(hd, _N_catFSM_17635(_N_optimize_cp_17634, tl));
				break;
			}
			if ((object)_N_wildcard_4202 == list<Rule>.Nil._N_constant_object)
			{
				result = list<Rule>.Nil._N_constant_object;
				break;
			}
			throw new MatchFailureException();
		}
		return (list<Rule>)result;
	}

	private static list<Rule> _N_optimizeNot_17650(_N_closureOf_optimize_17597 _N_optimize_cp_17649, list<Rule> rules)
	{
		object result;
		while (true)
		{
			if (rules is list<Rule>.Cons)
			{
				list<Rule> tl;
				if (((list<Rule>.Cons)rules).hd is Rule.Not && ((Rule.Not)((list<Rule>.Cons)rules).hd).rule is Rule.Chars && ((Rule.Chars)((Rule.Not)((list<Rule>.Cons)rules).hd).rule).chars is list<RangeSet>.Cons && (object)((list<RangeSet>.Cons)((Rule.Chars)((Rule.Not)((list<Rule>.Cons)rules).hd).rule).chars).tl == list<RangeSet>.Nil._N_constant_object)
				{
					RangeSet hd = ((list<RangeSet>.Cons)((Rule.Chars)((Rule.Not)((list<Rule>.Cons)rules).hd).rule).chars).hd;
					if (((list<Rule>.Cons)rules).tl is list<Rule>.Cons)
					{
						if (((list<Rule>.Cons)((list<Rule>.Cons)rules).tl).hd is Rule.Not)
						{
							if (((Rule.Not)((list<Rule>.Cons)((list<Rule>.Cons)rules).tl).hd).rule is Rule.Chars && ((Rule.Chars)((Rule.Not)((list<Rule>.Cons)((list<Rule>.Cons)rules).tl).hd).rule).chars is list<RangeSet>.Cons && (object)((list<RangeSet>.Cons)((Rule.Chars)((Rule.Not)((list<Rule>.Cons)((list<Rule>.Cons)rules).tl).hd).rule).chars).tl == list<RangeSet>.Nil._N_constant_object)
							{
								RangeSet hd2 = ((list<RangeSet>.Cons)((Rule.Chars)((Rule.Not)((list<Rule>.Cons)((list<Rule>.Cons)rules).tl).hd).rule).chars).hd;
								tl = ((list<Rule>.Cons)((list<Rule>.Cons)rules).tl).tl;
								rules = new list<Rule>.Cons(new Rule.Not(new Rule.Chars(new list<RangeSet>.Cons(hd.Sum(hd2), list<RangeSet>.Nil._N_constant_object))), tl);
								continue;
							}
						}
						else if (((list<Rule>.Cons)((list<Rule>.Cons)rules).tl).hd is Rule.Chars)
						{
							RangeSet hd2 = ((list<RangeSet>.Cons)((Rule.Chars)((Rule.Not)((list<Rule>.Cons)rules).hd).rule).chars).hd;
							if (((Rule.Chars)((list<Rule>.Cons)((list<Rule>.Cons)rules).tl).hd).chars is list<RangeSet>.Cons && (object)((list<RangeSet>.Cons)((Rule.Chars)((list<Rule>.Cons)((list<Rule>.Cons)rules).tl).hd).chars).tl == list<RangeSet>.Nil._N_constant_object)
							{
								hd = ((list<RangeSet>.Cons)((Rule.Chars)((list<Rule>.Cons)((list<Rule>.Cons)rules).tl).hd).chars).hd;
								tl = ((list<Rule>.Cons)((list<Rule>.Cons)rules).tl).tl;
								rules = new list<Rule>.Cons(new Rule.Chars(new list<RangeSet>.Cons(hd.Sub(hd2), list<RangeSet>.Nil._N_constant_object)), tl);
								continue;
							}
						}
					}
				}
				Rule hd3 = ((list<Rule>.Cons)rules).hd;
				tl = ((list<Rule>.Cons)rules).tl;
				result = new list<Rule>.Cons(hd3, _N_optimizeNot_17650(_N_optimize_cp_17649, tl));
				break;
			}
			if ((object)rules == list<Rule>.Nil._N_constant_object)
			{
				result = list<Rule>.Nil._N_constant_object;
				break;
			}
			throw new MatchFailureException();
		}
		return (list<Rule>)result;
	}

	private static list<Rule> _N_catFSM_17676(_N_closureOf_optimize_17597 _N_optimize_cp_17675, list<Rule> _N_wildcard_4204)
	{
		object result;
		while (true)
		{
			if (_N_wildcard_4204 is list<Rule>.Cons)
			{
				list<Rule> tl;
				if (((list<Rule>.Cons)_N_wildcard_4204).hd is Rule.Fsm)
				{
					Rule.Fsm fsm = (Rule.Fsm)((list<Rule>.Cons)_N_wildcard_4204).hd;
					if (((list<Rule>.Cons)_N_wildcard_4204).tl is list<Rule>.Cons)
					{
						FSM fsm2 = ((Rule.Fsm)((list<Rule>.Cons)_N_wildcard_4204).hd).fsm;
						if (((list<Rule>.Cons)((list<Rule>.Cons)_N_wildcard_4204).tl).hd is Rule.Fsm)
						{
							Rule.Fsm fsm3 = (Rule.Fsm)((list<Rule>.Cons)((list<Rule>.Cons)_N_wildcard_4204).tl).hd;
							FSM fsm4 = ((Rule.Fsm)((list<Rule>.Cons)((list<Rule>.Cons)_N_wildcard_4204).tl).hd).fsm;
							tl = ((list<Rule>.Cons)((list<Rule>.Cons)_N_wildcard_4204).tl).tl;
							_N_wildcard_4204 = new list<Rule>.Cons(new Rule.Fsm(fsm.Location + fsm3.Location, FSMBuilder.Seq(new list<FSM>.Cons(fsm2, new list<FSM>.Cons(fsm4, list<FSM>.Nil._N_constant_object)))), tl);
							continue;
						}
					}
				}
				Rule hd = ((list<Rule>.Cons)_N_wildcard_4204).hd;
				tl = ((list<Rule>.Cons)_N_wildcard_4204).tl;
				result = new list<Rule>.Cons(hd, _N_catFSM_17676(_N_optimize_cp_17675, tl));
				break;
			}
			if ((object)_N_wildcard_4204 == list<Rule>.Nil._N_constant_object)
			{
				result = list<Rule>.Nil._N_constant_object;
				break;
			}
			throw new MatchFailureException();
		}
		return (list<Rule>)result;
	}
}
