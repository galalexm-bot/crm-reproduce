using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler;
using Nemerle.Core;

namespace Nemerle.Peg;

public static class GrammarTyper
{
	private sealed class _N_closureOf_AddArgumentCaptures_15564
	{
		internal Grammar _N_grammar_15573;

		internal Typer _N_typer_15571;

		internal Function<Rule, Rule> _N_removeRedundant_15569;

		internal _N_closureOf_AddArgumentCaptures_15564()
		{
		}
	}

	private sealed class _N__N_lambda__15426__15592 : Function<RuleType, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__15426__15592 Instance = new _N__N_lambda__15426__15592();

		[SpecialName]
		public sealed override bool apply(RuleType _N__15425)
		{
			return _N__15425 is RuleType.Void;
		}
	}

	private sealed class _N__N_lambda__15450__15651 : Function<Rule, Nemerle.Builtins.Tuple<Rule, RuleType>>
	{
		[SpecialName]
		private _N_closureOf_AddArgumentCaptures_15564 _N_AddArgumentCaptures_closure_15655;

		public _N__N_lambda__15450__15651(_N_closureOf_AddArgumentCaptures_15564 _N_AddArgumentCaptures_closure_15655)
		{
			this._N_AddArgumentCaptures_closure_15655 = _N_AddArgumentCaptures_closure_15655;
		}

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<Rule, RuleType> apply(Rule _N__15449)
		{
			return _N_addCaptures_15625(_N_AddArgumentCaptures_closure_15655, _N__15449);
		}
	}

	private sealed class _N__N_lambda__15476__15689 : Function<Rule, RuleType, Rule>
	{
		[SpecialName]
		public static readonly _N__N_lambda__15476__15689 Instance = new _N__N_lambda__15476__15689();

		[SpecialName]
		public sealed override Rule apply(Rule rule, RuleType _N_wildcard_15475)
		{
			return rule;
		}
	}

	private sealed class _N__N_lambda__15487__15699 : Function<Rule, Nemerle.Builtins.Tuple<Rule, RuleType>>
	{
		[SpecialName]
		private _N_closureOf_AddArgumentCaptures_15564 _N_AddArgumentCaptures_closure_15703;

		public _N__N_lambda__15487__15699(_N_closureOf_AddArgumentCaptures_15564 _N_AddArgumentCaptures_closure_15703)
		{
			this._N_AddArgumentCaptures_closure_15703 = _N_AddArgumentCaptures_closure_15703;
		}

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<Rule, RuleType> apply(Rule _N__15486)
		{
			return _N_addCaptures_15625(_N_AddArgumentCaptures_closure_15703, _N__15486);
		}
	}

	private sealed class _N__N_lambda__15493__15708 : Function<RuleType, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__15493__15708 Instance = new _N__N_lambda__15493__15708();

		[SpecialName]
		public sealed override bool apply(RuleType ty)
		{
			return !(ty is RuleType.None);
		}
	}

	private sealed class _N__N_lambda__15498__15723 : Function<Rule, RuleType, RuleType>
	{
		[SpecialName]
		public static readonly _N__N_lambda__15498__15723 Instance = new _N__N_lambda__15498__15723();

		[SpecialName]
		public sealed override RuleType apply(Rule _N__15721, RuleType _N__15722)
		{
			return _N__15722;
		}
	}

	private sealed class _N__N_lambda__15504__15740 : Function<Rule, RuleType, Rule>
	{
		[SpecialName]
		public static readonly _N__N_lambda__15504__15740 Instance = new _N__N_lambda__15504__15740();

		[SpecialName]
		public sealed override Rule apply(Rule _N__15738, RuleType _N__15739)
		{
			return _N__15738;
		}
	}

	private sealed class _N_removeRedundant__15774 : Function<Rule, Rule>
	{
		[SpecialName]
		private _N_closureOf_AddArgumentCaptures_15564 _N_AddArgumentCaptures_closure_15778;

		public _N_removeRedundant__15774(_N_closureOf_AddArgumentCaptures_15564 _N_AddArgumentCaptures_closure_15778)
		{
			this._N_AddArgumentCaptures_closure_15778 = _N_AddArgumentCaptures_closure_15778;
		}

		[SpecialName]
		public sealed override Rule apply(Rule rule)
		{
			object result;
			switch (Rule._N_GetVariantCodeSafe(rule))
			{
			default:
				throw new MatchFailureException();
			case 0:
			{
				list<Rule> list = ((Rule.Choice)rule).rules;
				result = new Rule.Choice(rule.Location, list.Map(_N_AddArgumentCaptures_closure_15778._N_removeRedundant_15569));
				break;
			}
			case 1:
			{
				list<Rule> list = ((Rule.Sequence)rule).rules;
				result = new Rule.Sequence(rule.Location, list.Map(_N_AddArgumentCaptures_closure_15778._N_removeRedundant_15569));
				break;
			}
			case 3:
			{
				int minCount = ((Rule.RepeatMin)rule).minCount;
				Rule rule2 = ((Rule.RepeatMin)rule).rule;
				result = new Rule.RepeatMin(rule2.Location, minCount, _N_AddArgumentCaptures_closure_15778._N_removeRedundant_15569.apply(rule2));
				break;
			}
			case 4:
			{
				int minCount = ((Rule.RepeatMinMax)rule).minCount;
				int maxCount = ((Rule.RepeatMinMax)rule).maxCount;
				Rule rule2 = ((Rule.RepeatMinMax)rule).rule;
				result = new Rule.RepeatMinMax(rule2.Location, minCount, maxCount, _N_AddArgumentCaptures_closure_15778._N_removeRedundant_15569.apply(rule2));
				break;
			}
			case 7:
			{
				Rule rule2 = ((Rule.Not)rule).rule;
				result = new Rule.Not(rule2.Location, RemoveAllCaptures(rule2));
				break;
			}
			case 8:
			{
				Rule rule2 = ((Rule.And)rule).rule;
				result = new Rule.And(rule2.Location, RemoveAllCaptures(rule2));
				break;
			}
			case 9:
			{
				Rule rule2;
				if (((Rule.Capture)rule).kind is CaptureKind.Argument)
				{
					if (((CaptureKind.Argument)((Rule.Capture)rule).kind).retType is RuleType.Chars)
					{
						rule2 = ((Rule.Capture)rule).rule;
						result = new Rule.Capture(rule2.Location, new CaptureKind.Argument(new RuleType.Chars()), RemoveAllCaptures(rule2));
						break;
					}
					if (((CaptureKind.Argument)((Rule.Capture)rule).kind).retType is RuleType.None)
					{
						rule2 = ((Rule.Capture)rule).rule;
						result = new Rule.Capture(rule2.Location, new CaptureKind.Argument(new RuleType.None()), RemoveAllCaptures(rule2));
						break;
					}
					if (((CaptureKind.Argument)((Rule.Capture)rule).kind).retType is RuleType.Void)
					{
						rule2 = ((Rule.Capture)rule).rule;
						result = new Rule.Capture(rule2.Location, new CaptureKind.Argument(new RuleType.Void()), RemoveAllCaptures(rule2));
						break;
					}
				}
				CaptureKind kind = ((Rule.Capture)rule).kind;
				rule2 = ((Rule.Capture)rule).rule;
				result = new Rule.Capture(rule2.Location, kind, _N_AddArgumentCaptures_closure_15778._N_removeRedundant_15569.apply(rule2));
				break;
			}
			case 10:
			{
				NameRef name = ((Rule.Scope)rule).name;
				Rule rule2 = ((Rule.Scope)rule).rule;
				result = new Rule.Scope(rule2.Location, name, _N_AddArgumentCaptures_closure_15778._N_removeRedundant_15569.apply(rule2));
				break;
			}
			case 2:
			case 5:
			case 6:
			case 11:
				result = rule;
				break;
			}
			return (Rule)result;
		}
	}

	private sealed class _N__N_lambda__15552__15801 : Function<RuleDefinition, option<Rule>>
	{
		[SpecialName]
		private _N_closureOf_AddArgumentCaptures_15564 _N_AddArgumentCaptures_closure_15805;

		public _N__N_lambda__15552__15801(_N_closureOf_AddArgumentCaptures_15564 _N_AddArgumentCaptures_closure_15805)
		{
			this._N_AddArgumentCaptures_closure_15805 = _N_AddArgumentCaptures_closure_15805;
		}

		[SpecialName]
		public sealed override option<Rule> apply(RuleDefinition rd)
		{
			RuleDefinitionType ruleDefinitionType = null;
			option<Rule> option = null;
			ruleDefinitionType = rd.ResultType;
			option = rd.Rule;
			RuleType retType;
			Rule val;
			if (ruleDefinitionType is RuleDefinitionType.Typed)
			{
				if (option is option<Rule>.Some)
				{
					retType = ((RuleDefinitionType.Typed)ruleDefinitionType).ty;
					val = ((option<Rule>.Some)option).val;
					goto IL_0040;
				}
			}
			else if (ruleDefinitionType is RuleDefinitionType.Extention && option is option<Rule>.Some)
			{
				NameRef name = ((RuleDefinitionType.Extention)ruleDefinitionType).name;
				val = ((option<Rule>.Some)option).val;
				retType = _N_getType_15606(_N_AddArgumentCaptures_closure_15805, name);
				goto IL_0040;
			}
			object result = rd.Rule;
			goto IL_00e6;
			IL_00e6:
			return (option<Rule>)result;
			IL_0040:
			Nemerle.Builtins.Tuple<Rule, RuleType> tuple = _N_addCaptures_15625(_N_AddArgumentCaptures_closure_15805, val);
			val = tuple.Field0;
			RuleType field = tuple.Field1;
			val = _N_AddArgumentCaptures_closure_15805._N_removeRedundant_15569.apply(val);
			result = new option<Rule>.Some(new Rule.Capture(val.Location, new CaptureKind.Handler(rd.Name, field, retType), val));
			goto IL_00e6;
		}
	}

	private sealed class _N__N_lambda__15825__15839 : Function<RuleType, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__15825__15839 Instance = new _N__N_lambda__15825__15839();

		[SpecialName]
		public sealed override bool apply(RuleType ty)
		{
			return !(ty is RuleType.Void);
		}
	}

	private sealed class _N_closureOf_RuleTypeToNType_15876
	{
		internal Typer _N_typer_15883;

		internal Function<RuleType, TypeVar> _N_ruleTypeToNType_15881;

		internal _N_closureOf_RuleTypeToNType_15876()
		{
		}
	}

	private sealed class _N_ruleTypeToNType__15885 : Function<RuleType, TypeVar>
	{
		[SpecialName]
		private _N_closureOf_RuleTypeToNType_15876 _N_RuleTypeToNType_closure_15889;

		public _N_ruleTypeToNType__15885(_N_closureOf_RuleTypeToNType_15876 _N_RuleTypeToNType_closure_15889)
		{
			this._N_RuleTypeToNType_closure_15889 = _N_RuleTypeToNType_closure_15889;
		}

		[SpecialName]
		public sealed override TypeVar apply(RuleType _N_wildcard_4197)
		{
			object result;
			if (_N_wildcard_4197 is RuleType.List)
			{
				RuleType ty = ((RuleType.List)_N_wildcard_4197).ty;
				result = new FixedType.Class(_N_RuleTypeToNType_closure_15889._N_typer_15883.Manager.LookupTypeInfo("System.Collections.Generic.List", 1), new list<TypeVar>.Cons(_N_RuleTypeToNType_closure_15889._N_ruleTypeToNType_15881.apply(ty), list<TypeVar>.Nil._N_constant_object));
			}
			else if (_N_wildcard_4197 is RuleType.Option)
			{
				RuleType ty = ((RuleType.Option)_N_wildcard_4197).ty;
				if (IsOptimizableOptionType(ty))
				{
					goto IL_016f;
				}
				ty = ((RuleType.Option)_N_wildcard_4197).ty;
				result = new FixedType.Class(_N_RuleTypeToNType_closure_15889._N_typer_15883.Manager.LookupTypeInfo("Nemerle.Core.option", 1), new list<TypeVar>.Cons(_N_RuleTypeToNType_closure_15889._N_ruleTypeToNType_15881.apply(ty), list<TypeVar>.Nil._N_constant_object));
			}
			else if (_N_wildcard_4197 is RuleType.Tuple)
			{
				list<RuleType> list = ((RuleType.Tuple)_N_wildcard_4197).types;
				Function<RuleType, bool> instance = _N__N_lambda__15864__15910.Instance;
				list<TypeVar> list2 = list.MapFiltered(instance, _N_RuleTypeToNType_closure_15889._N_ruleTypeToNType_15881);
				if (list2 is list<TypeVar>.Cons && (object)((list<TypeVar>.Cons)list2).tl == list<TypeVar>.Nil._N_constant_object)
				{
					TypeVar hd = ((list<TypeVar>.Cons)list2).hd;
					result = hd;
				}
				else
				{
					result = new FixedType.Tuple(list2);
				}
			}
			else if (_N_wildcard_4197 is RuleType.NType)
			{
				FixedType ty2 = ((RuleType.NType)_N_wildcard_4197).ty;
				result = ty2;
			}
			else
			{
				if (_N_wildcard_4197 is RuleType.Chars)
				{
					goto IL_016f;
				}
				if (_N_wildcard_4197 is RuleType.None)
				{
					throw new AssertionException("Grammar\\GrammarTyper.Utils.n", 48, "", "");
				}
				if (!(_N_wildcard_4197 is RuleType.Void))
				{
					throw new MatchFailureException();
				}
				result = new FixedType.Void();
			}
			goto IL_01d6;
			IL_01d6:
			return (TypeVar)result;
			IL_016f:
			result = new FixedType.Class(_N_RuleTypeToNType_closure_15889._N_typer_15883.Manager.LookupTypeInfo("Nemerle.Peg.NToken", 0), list<TypeVar>.Nil._N_constant_object);
			goto IL_01d6;
		}
	}

	private sealed class _N__N_lambda__15864__15910 : Function<RuleType, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__15864__15910 Instance = new _N__N_lambda__15864__15910();

		[SpecialName]
		public sealed override bool apply(RuleType ty)
		{
			return !(ty is RuleType.Void);
		}
	}

	private sealed class _N_static_proxy_15950 : Function<Rule, Rule>
	{
		[SpecialName]
		public static readonly _N_static_proxy_15950 single_instance = new _N_static_proxy_15950();

		[SpecialName]
		public sealed override Rule apply(Rule _N_sp_parm_15957)
		{
			return RemoveAllCaptures(_N_sp_parm_15957);
		}

		private _N_static_proxy_15950()
		{
		}
	}

	private sealed class _N__N_lambda__15962__15969 : Function<RuleDefinition, option<Rule>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__15962__15969 Instance = new _N__N_lambda__15962__15969();

		[SpecialName]
		public sealed override option<Rule> apply(RuleDefinition rd)
		{
			option<Rule> rule = rd.Rule;
			object result;
			if (rule is option<Rule>.Some)
			{
				Rule val = ((option<Rule>.Some)rule).val;
				result = new option<Rule>.Some(RemoveAllCaptures(val));
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
	}

	private sealed class _N_closureOf_CheckLeftRec_16430
	{
		internal Grammar _N_grammar_16439;

		internal Hashtable<Rule, bool> _N_memoize_16437;

		internal list<NameRef> _N_recRules_16435;

		internal _N_closureOf_CheckLeftRec_16430()
		{
		}
	}

	private sealed class _N_closureOf_hasLeftRecImpl_16448
	{
		internal Set<NameRef> _N_visited_16455;

		internal list<NameRef> _N_path_16453;

		internal _N_closureOf_hasLeftRecImpl_16448()
		{
		}
	}

	private sealed class _N__N_lambda__16038__16460 : Function<Rule, bool>
	{
		[SpecialName]
		private _N_closureOf_CheckLeftRec_16430 _N_CheckLeftRec_closure_16466;

		[SpecialName]
		private _N_closureOf_hasLeftRecImpl_16448 _N_hasLeftRecImpl_closure_16464;

		public _N__N_lambda__16038__16460(_N_closureOf_hasLeftRecImpl_16448 _N_hasLeftRecImpl_closure_16464, _N_closureOf_CheckLeftRec_16430 _N_CheckLeftRec_closure_16466)
		{
			this._N_hasLeftRecImpl_closure_16464 = _N_hasLeftRecImpl_closure_16464;
			this._N_CheckLeftRec_closure_16466 = _N_CheckLeftRec_closure_16466;
		}

		[SpecialName]
		public sealed override bool apply(Rule _N__16037)
		{
			return _N_hasLeftRecImpl_16442(_N_CheckLeftRec_closure_16466, _N__16037, _N_hasLeftRecImpl_closure_16464._N_visited_16455, _N_hasLeftRecImpl_closure_16464._N_path_16453);
		}
	}

	private sealed class _N__N_lambda__16129__16551 : Function<NameRef, string>
	{
		[SpecialName]
		public static readonly _N__N_lambda__16129__16551 Instance = new _N__N_lambda__16129__16551();

		[SpecialName]
		public sealed override string apply(NameRef x)
		{
			return Convert.ToString(x);
		}
	}

	private static bool _debug;

	static GrammarTyper()
	{
		_debug = true;
	}

	public static Grammar AddArgumentCaptures(Grammar grammar, Typer typer)
	{
		_N_closureOf_AddArgumentCaptures_15564 n_closureOf_AddArgumentCaptures_ = new _N_closureOf_AddArgumentCaptures_15564();
		n_closureOf_AddArgumentCaptures_._N_grammar_15573 = grammar;
		n_closureOf_AddArgumentCaptures_._N_typer_15571 = typer;
		n_closureOf_AddArgumentCaptures_._N_removeRedundant_15569 = new _N_removeRedundant__15774(n_closureOf_AddArgumentCaptures_);
		Grammar n_grammar_ = n_closureOf_AddArgumentCaptures_._N_grammar_15573;
		Function<RuleDefinition, option<Rule>> fn = new _N__N_lambda__15552__15801(n_closureOf_AddArgumentCaptures_);
		return n_grammar_.TransformRules(fn);
	}

	public static bool IsOptimizableOptionType(RuleType ty)
	{
		int result;
		if (ty is RuleType.Tuple)
		{
			list<RuleType> list = ((RuleType.Tuple)ty).types;
			list<RuleType> list2 = list;
			Function<RuleType, bool> instance = _N__N_lambda__15825__15839.Instance;
			list = list2.Filter(instance);
			result = ((list is list<RuleType>.Cons && ((list<RuleType>.Cons)list).hd is RuleType.Chars && (object)((list<RuleType>.Cons)list).tl == list<RuleType>.Nil._N_constant_object) ? 1 : 0);
		}
		else
		{
			result = 0;
		}
		return (byte)result != 0;
	}

	public static TypeVar RuleTypeToNType(RuleType ruleType, Typer typer)
	{
		_N_closureOf_RuleTypeToNType_15876 n_closureOf_RuleTypeToNType_ = new _N_closureOf_RuleTypeToNType_15876();
		n_closureOf_RuleTypeToNType_._N_typer_15883 = typer;
		n_closureOf_RuleTypeToNType_._N_ruleTypeToNType_15881 = new _N_ruleTypeToNType__15885(n_closureOf_RuleTypeToNType_);
		return n_closureOf_RuleTypeToNType_._N_ruleTypeToNType_15881.apply(ruleType);
	}

	public static Rule RemoveAllCaptures(Rule curRule)
	{
		object result;
		while (true)
		{
			Rule rule;
			switch (Rule._N_GetVariantCodeSafe(curRule))
			{
			default:
				throw new MatchFailureException();
			case 0:
			{
				list<Rule> list = ((Rule.Choice)curRule).rules;
				result = new Rule.Choice(curRule.Location, list.Map(_N_static_proxy_15950.single_instance));
				break;
			}
			case 1:
			{
				list<Rule> list = ((Rule.Sequence)curRule).rules;
				result = new Rule.Sequence(curRule.Location, list.Map(_N_static_proxy_15950.single_instance));
				break;
			}
			case 3:
			{
				int minCount = ((Rule.RepeatMin)curRule).minCount;
				rule = ((Rule.RepeatMin)curRule).rule;
				result = new Rule.RepeatMin(curRule.Location, minCount, RemoveAllCaptures(rule));
				break;
			}
			case 4:
			{
				int minCount = ((Rule.RepeatMinMax)curRule).minCount;
				int maxCount = ((Rule.RepeatMinMax)curRule).maxCount;
				rule = ((Rule.RepeatMinMax)curRule).rule;
				result = new Rule.RepeatMinMax(curRule.Location, minCount, maxCount, RemoveAllCaptures(rule));
				break;
			}
			case 7:
				rule = ((Rule.Not)curRule).rule;
				result = new Rule.Not(curRule.Location, RemoveAllCaptures(rule));
				break;
			case 8:
				rule = ((Rule.And)curRule).rule;
				result = new Rule.And(curRule.Location, RemoveAllCaptures(rule));
				break;
			case 9:
				goto IL_0159;
			case 10:
			{
				NameRef name = ((Rule.Scope)curRule).name;
				rule = ((Rule.Scope)curRule).rule;
				result = new Rule.Scope(curRule.Location, name, RemoveAllCaptures(rule));
				break;
			}
			case 2:
			case 5:
			case 6:
			case 11:
				result = curRule;
				break;
			}
			break;
			IL_0159:
			rule = ((Rule.Capture)curRule).rule;
			curRule = rule;
		}
		return (Rule)result;
	}

	public static Grammar RemoveAllCaptures(Grammar grammar)
	{
		Function<RuleDefinition, option<Rule>> instance = _N__N_lambda__15962__15969.Instance;
		return grammar.TransformRules(instance);
	}

	public static void Check(Grammar grammar)
	{
		CheckLeftRec(grammar);
		CheckLeftRecLiteralOrder(grammar);
	}

	public static void CheckLeftRec(Grammar grammar)
	{
		_N_closureOf_CheckLeftRec_16430 n_closureOf_CheckLeftRec_ = new _N_closureOf_CheckLeftRec_16430();
		n_closureOf_CheckLeftRec_._N_grammar_16439 = grammar;
		n_closureOf_CheckLeftRec_._N_memoize_16437 = new Hashtable<Rule, bool>();
		Stopwatch stopwatch = Stopwatch.StartNew();
		List<list<NameRef>> list = new List<list<NameRef>>();
		list<NameRef> list2 = n_closureOf_CheckLeftRec_._N_grammar_16439.Names;
		while (list2 is list<NameRef>.Cons)
		{
			NameRef hd = ((list<NameRef>.Cons)list2).hd;
			list<NameRef> list3 = ((list<NameRef>.Cons)list2).tl;
			NameRef name = hd;
			option<Rule> rule = n_closureOf_CheckLeftRec_._N_grammar_16439.GetRule(name).Rule;
			if (rule is option<Rule>.Some)
			{
				Rule val = ((option<Rule>.Some)rule).val;
				if (_N_hasLeftRecImpl_16442(n_closureOf_CheckLeftRec_, val, new Set<NameRef>(), null))
				{
					list.Add(n_closureOf_CheckLeftRec_._N_recRules_16435);
				}
			}
			list2 = list3;
		}
		if (((ICollection)list).IsEmpty())
		{
			return;
		}
		list<NameRef> list4 = list.NFirst();
		IEnumerator<list<NameRef>> enumerator = list.Skip(1).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				list<NameRef> current = enumerator.Current;
				list<NameRef> list5 = current;
				if (new HashSet<NameRef>(list4).IsSupersetOf(new HashSet<NameRef>(list5)))
				{
					list4 = list5;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		list<NameRef> list6 = list4;
		while (list6 is list<NameRef>.Cons)
		{
			NameRef hd2 = ((list<NameRef>.Cons)list6).hd;
			list<NameRef> list7 = ((list<NameRef>.Cons)list6).tl;
			NameRef nameRef = hd2;
			Nemerle.Compiler.Location location = nameRef.Location;
			IEnumerable<NameRef> source = list4;
			Function<NameRef, string> instance = _N__N_lambda__16129__16551.Instance;
			Message.Error(location, "A left recursion is detected for the following rules: " + string.Join(", ", source.MapToArray(instance)) + ".");
			list6 = list7;
		}
	}

	public static void CheckLeftRecLiteralOrder(Grammar _grammar)
	{
	}

	private static RuleType _N_optimizeType_15575(RuleType ty)
	{
		object result;
		if (ty is RuleType.List)
		{
			if (((RuleType.List)ty).ty is RuleType.Chars)
			{
				goto IL_007e;
			}
			if (((RuleType.List)ty).ty is RuleType.None)
			{
				goto IL_00e6;
			}
			if (((RuleType.List)ty).ty is RuleType.Void)
			{
				goto IL_0113;
			}
		}
		else if (ty is RuleType.Option)
		{
			if (((RuleType.Option)ty).ty is RuleType.Chars)
			{
				goto IL_007e;
			}
			if (((RuleType.Option)ty).ty is RuleType.None)
			{
				goto IL_00e6;
			}
			if (((RuleType.Option)ty).ty is RuleType.Void)
			{
				goto IL_0113;
			}
		}
		else if (ty is RuleType.Tuple)
		{
			if ((object)((RuleType.Tuple)ty).types == list<RuleType>.Nil._N_constant_object)
			{
				goto IL_00e6;
			}
			list<RuleType> list = ((RuleType.Tuple)ty).types;
			Function<RuleType, bool> instance = _N__N_lambda__15426__15592.Instance;
			if (list.ForAll(instance))
			{
				goto IL_0113;
			}
			if (((RuleType.Tuple)ty).types is list<RuleType>.Cons && (object)((list<RuleType>.Cons)((RuleType.Tuple)ty).types).tl == list<RuleType>.Nil._N_constant_object)
			{
				RuleType hd = ((list<RuleType>.Cons)((RuleType.Tuple)ty).types).hd;
				result = hd;
				goto IL_0182;
			}
		}
		result = ty;
		goto IL_0182;
		IL_007e:
		result = new RuleType.Chars();
		goto IL_0182;
		IL_0113:
		result = new RuleType.Void();
		goto IL_0182;
		IL_00e6:
		result = new RuleType.None();
		goto IL_0182;
		IL_0182:
		return (RuleType)result;
	}

	private static RuleType _N_getType_15606(_N_closureOf_AddArgumentCaptures_15564 _N_AddArgumentCaptures_cp_15605, NameRef name)
	{
		option<RuleType> ruleType = _N_AddArgumentCaptures_cp_15605._N_grammar_15573.GetRuleType(name);
		object result;
		if (ruleType is option<RuleType>.Some)
		{
			RuleType val = ((option<RuleType>.Some)ruleType).val;
			result = val;
		}
		else
		{
			result = new RuleType.Chars();
		}
		return (RuleType)result;
	}

	private static Nemerle.Builtins.Tuple<Rule, RuleType> _N_makeRes_15618(_N_closureOf_AddArgumentCaptures_15564 _N_AddArgumentCaptures_cp_15617, Rule rule, RuleType ty)
	{
		RuleType ruleType = _N_optimizeType_15575(ty);
		return new Nemerle.Builtins.Tuple<Rule, RuleType>(new Rule.Capture(rule.Location, new CaptureKind.Argument(ruleType), rule), ruleType);
	}

	private static Nemerle.Builtins.Tuple<Rule, RuleType> _N_addCaptures_15625(_N_closureOf_AddArgumentCaptures_15564 _N_AddArgumentCaptures_cp_15624, Rule rule)
	{
		Nemerle.Builtins.Tuple<Rule, RuleType> result;
		while (true)
		{
			Rule rule2;
			switch (Rule._N_GetVariantCodeSafe(rule))
			{
			default:
				throw new MatchFailureException();
			case 0:
			{
				list<Rule> list = ((Rule.Choice)rule).rules;
				if (list.IsEmpty)
				{
					throw new AssertionException("Grammar\\GrammarTyper.AddArgumentCaptures.n", 59, "!rules.IsEmpty", "");
				}
				list<Rule> list2 = list;
				Function<Rule, Nemerle.Builtins.Tuple<Rule, RuleType>> convert = new _N__N_lambda__15450__15651(_N_AddArgumentCaptures_cp_15624);
				list<Nemerle.Builtins.Tuple<Rule, RuleType>> list3 = list2.Map(convert);
				RuleType field = list3.Head.Field1;
				if (field is RuleType.None)
				{
					list<Nemerle.Builtins.Tuple<Rule, RuleType>> list4 = list3;
					while (list4 is list<Nemerle.Builtins.Tuple<Rule, RuleType>>.Cons)
					{
						Nemerle.Builtins.Tuple<Rule, RuleType> tuple = ((list<Nemerle.Builtins.Tuple<Rule, RuleType>>.Cons)list4).hd;
						list4 = ((list<Nemerle.Builtins.Tuple<Rule, RuleType>>.Cons)list4).tl;
						rule2 = tuple.Field0;
						RuleType field2 = tuple.Field1;
						if (!(field2 is RuleType.None) && 0 == 0)
						{
							Message.Error(rule2.Location, "The return type of rule '" + Convert.ToString(RemoveAllCaptures(rule2)) + "' is '" + Convert.ToString(field2) + "', but require has no type. All entries in one OrderedChoice must have same return type.");
						}
						list4 = list4;
					}
				}
				else
				{
					list<Nemerle.Builtins.Tuple<Rule, RuleType>> list4 = list3;
					while (list4 is list<Nemerle.Builtins.Tuple<Rule, RuleType>>.Cons)
					{
						Nemerle.Builtins.Tuple<Rule, RuleType> tuple = ((list<Nemerle.Builtins.Tuple<Rule, RuleType>>.Cons)list4).hd;
						list4 = ((list<Nemerle.Builtins.Tuple<Rule, RuleType>>.Cons)list4).tl;
						rule2 = tuple.Field0;
						RuleType field2 = tuple.Field1;
						if (field2 is RuleType.None)
						{
							Message.Error(rule2.Location, "The rule '" + Convert.ToString(RemoveAllCaptures(rule2)) + "' has no return type, but require type is '" + Convert.ToString(field) + "'. All entries in one OrderedChoice must have same return type.");
						}
						else if (!RuleTypeToNType(field2, _N_AddArgumentCaptures_cp_15624._N_typer_15571).Equals(RuleTypeToNType(field, _N_AddArgumentCaptures_cp_15624._N_typer_15571)))
						{
							Message.Error(rule2.Location, "The return type of rule '" + Convert.ToString(RemoveAllCaptures(rule2)) + "' is '" + Convert.ToString(field2) + "', but require type is '" + Convert.ToString(field) + "'. All entries in one OrderedChoice must have same return type.");
						}
						list4 = list4;
					}
				}
				list<Nemerle.Builtins.Tuple<Rule, RuleType>> list5 = list3;
				Function<Rule, RuleType, Rule> instance = _N__N_lambda__15476__15689.Instance;
				list = list5.Map(instance);
				result = _N_makeRes_15618(_N_AddArgumentCaptures_cp_15624, new Rule.Choice(rule.Location, list), field);
				break;
			}
			case 1:
			{
				if (((Rule.Sequence)rule).rules is list<Rule>.Cons && (object)((list<Rule>.Cons)((Rule.Sequence)rule).rules).tl == list<Rule>.Nil._N_constant_object)
				{
					goto IL_02ea;
				}
				list<Rule> list = ((Rule.Sequence)rule).rules;
				list<Rule> list6 = list;
				Function<Rule, Nemerle.Builtins.Tuple<Rule, RuleType>> convert = new _N__N_lambda__15487__15699(_N_AddArgumentCaptures_cp_15624);
				list<Nemerle.Builtins.Tuple<Rule, RuleType>> list3 = list6.Map(convert);
				list<Nemerle.Builtins.Tuple<Rule, RuleType>> list7 = list3;
				Function<Rule, RuleType, RuleType> instance2 = _N__N_lambda__15498__15723.Instance;
				list<RuleType> list8 = list7.Map(instance2);
				Function<RuleType, bool> instance3 = _N__N_lambda__15493__15708.Instance;
				list<RuleType> types = list8.Filter(instance3);
				list<Nemerle.Builtins.Tuple<Rule, RuleType>> list9 = list3;
				Function<Rule, RuleType, Rule> instance = _N__N_lambda__15504__15740.Instance;
				list = list9.Map(instance);
				Nemerle.Compiler.Location loc = ((!list.IsEmpty) ? Nemerle.Compiler.Location.EnclosingLocation(list) : Nemerle.Compiler.Location.Default);
				RuleType.Tuple ty = new RuleType.Tuple(loc, types);
				result = _N_makeRes_15618(_N_AddArgumentCaptures_cp_15624, new Rule.Sequence(rule.Location, list), ty);
				break;
			}
			case 2:
			{
				NameRef name = ((Rule.Call)rule).name;
				int maxCount = ((Rule.Call)rule).bindingPower;
				result = _N_makeRes_15618(_N_AddArgumentCaptures_cp_15624, new Rule.Call(rule.Location, name, maxCount), _N_getType_15606(_N_AddArgumentCaptures_cp_15624, name));
				break;
			}
			case 3:
			{
				int maxCount = ((Rule.RepeatMin)rule).minCount;
				rule2 = ((Rule.RepeatMin)rule).rule;
				Nemerle.Builtins.Tuple<Rule, RuleType> tuple = _N_addCaptures_15625(_N_AddArgumentCaptures_cp_15624, rule2);
				rule2 = tuple.Field0;
				RuleType field = tuple.Field1;
				result = _N_makeRes_15618(_N_AddArgumentCaptures_cp_15624, new Rule.RepeatMin(rule2.Location, maxCount, rule2), new RuleType.List(field));
				break;
			}
			case 4:
				if (((Rule.RepeatMinMax)rule).minCount == 0 && ((Rule.RepeatMinMax)rule).maxCount == 1)
				{
					rule2 = ((Rule.RepeatMinMax)rule).rule;
					Nemerle.Builtins.Tuple<Rule, RuleType> tuple = _N_addCaptures_15625(_N_AddArgumentCaptures_cp_15624, rule2);
					rule2 = tuple.Field0;
					RuleType field = tuple.Field1;
					result = _N_makeRes_15618(_N_AddArgumentCaptures_cp_15624, new Rule.RepeatMinMax(rule2.Location, 0, 1, rule2), new RuleType.Option(field));
				}
				else
				{
					int minCount = ((Rule.RepeatMinMax)rule).minCount;
					int maxCount = ((Rule.RepeatMinMax)rule).maxCount;
					rule2 = ((Rule.RepeatMinMax)rule).rule;
					Nemerle.Builtins.Tuple<Rule, RuleType> tuple = _N_addCaptures_15625(_N_AddArgumentCaptures_cp_15624, rule2);
					rule2 = tuple.Field0;
					RuleType field = tuple.Field1;
					result = _N_makeRes_15618(_N_AddArgumentCaptures_cp_15624, new Rule.RepeatMinMax(rule2.Location, minCount, maxCount, rule2), new RuleType.List(field));
				}
				break;
			case 5:
			{
				list<RangeSet> chars = ((Rule.Chars)rule).chars;
				result = _N_makeRes_15618(_N_AddArgumentCaptures_cp_15624, new Rule.Chars(rule.Location, chars), new RuleType.Chars());
				break;
			}
			case 6:
			{
				FSM fsm = ((Rule.Fsm)rule).fsm;
				result = _N_makeRes_15618(_N_AddArgumentCaptures_cp_15624, new Rule.Fsm(rule.Location, fsm), new RuleType.Chars());
				break;
			}
			case 9:
				throw new AssertionException("Grammar\\GrammarTyper.AddArgumentCaptures.n", 107, "", "");
			case 10:
			{
				NameRef name = ((Rule.Scope)rule).name;
				rule2 = ((Rule.Scope)rule).rule;
				Nemerle.Builtins.Tuple<Rule, RuleType> tuple = _N_addCaptures_15625(_N_AddArgumentCaptures_cp_15624, rule2);
				rule2 = tuple.Field0;
				RuleType field = tuple.Field1;
				result = _N_makeRes_15618(_N_AddArgumentCaptures_cp_15624, new Rule.Scope(rule2.Location, name, rule2), field);
				break;
			}
			case 7:
			case 8:
			case 11:
				result = new Nemerle.Builtins.Tuple<Rule, RuleType>(rule, new RuleType.None());
				break;
			}
			break;
			IL_02ea:
			rule2 = ((list<Rule>.Cons)((Rule.Sequence)rule).rules).hd;
			rule = rule2;
		}
		return result;
	}

	private static bool _N_hasLeftRecImpl_16442(_N_closureOf_CheckLeftRec_16430 _N_CheckLeftRec_cp_16441, Rule rule, Set<NameRef> visited, list<NameRef> path)
	{
		_N_closureOf_hasLeftRecImpl_16448 n_closureOf_hasLeftRecImpl_ = new _N_closureOf_hasLeftRecImpl_16448();
		n_closureOf_hasLeftRecImpl_._N_visited_16455 = visited;
		n_closureOf_hasLeftRecImpl_._N_path_16453 = path;
		bool flag = false;
		bool value = false;
		if (_N_CheckLeftRec_cp_16441._N_memoize_16437.TryGetValue(rule, out value))
		{
			return value;
		}
		Function<Rule, bool> function = new _N__N_lambda__16038__16460(n_closureOf_hasLeftRecImpl_, _N_CheckLeftRec_cp_16441);
		Function<Rule, bool> function2 = function;
		int num;
		switch (Rule._N_GetVariantCodeSafe(rule))
		{
		default:
			throw new MatchFailureException();
		case 0:
		{
			list<Rule> list4 = ((Rule.Choice)rule).rules;
			num = (list4.Exists(function2) ? 1 : 0);
			break;
		}
		case 1:
		{
			list<Rule> list = ((Rule.Sequence)rule).rules;
			bool flag2 = false;
			list<Rule> list2 = list;
			while (true)
			{
				if (list2 is list<Rule>.Cons)
				{
					Rule hd = ((list<Rule>.Cons)list2).hd;
					list<Rule> list3 = ((list<Rule>.Cons)list2).tl;
					Rule rule9 = hd;
					if (function2.apply(rule9))
					{
						flag2 = true;
						break;
					}
					if (!_N_CheckLeftRec_cp_16441._N_grammar_16439.IsOptional(rule9))
					{
						flag2 = false;
						break;
					}
					list2 = list3;
					continue;
				}
				flag2 = false;
				break;
			}
			num = (flag2 ? 1 : 0);
			break;
		}
		case 2:
		{
			NameRef name = ((Rule.Call)rule).name;
			option<Rule> rule8 = _N_CheckLeftRec_cp_16441._N_grammar_16439.GetRule(name).Rule;
			if (rule8 is option<Rule>.Some)
			{
				Rule val = ((option<Rule>.Some)rule8).val;
				if (n_closureOf_hasLeftRecImpl_._N_visited_16455.Contains(name))
				{
					if (n_closureOf_hasLeftRecImpl_._N_path_16453 == null)
					{
						num = (_N_hasLeftRecImpl_16442(_N_CheckLeftRec_cp_16441, val, n_closureOf_hasLeftRecImpl_._N_visited_16455, new list<NameRef>.Cons(name, list<NameRef>.Nil._N_constant_object)) ? 1 : 0);
					}
					else if (n_closureOf_hasLeftRecImpl_._N_path_16453.Last.Equals(name))
					{
						_N_CheckLeftRec_cp_16441._N_recRules_16435 = n_closureOf_hasLeftRecImpl_._N_path_16453.Reverse();
						num = 1;
					}
					else
					{
						num = (_N_hasLeftRecImpl_16442(_N_CheckLeftRec_cp_16441, val, n_closureOf_hasLeftRecImpl_._N_visited_16455, new list<NameRef>.Cons(name, n_closureOf_hasLeftRecImpl_._N_path_16453)) ? 1 : 0);
					}
				}
				else
				{
					num = (((!(n_closureOf_hasLeftRecImpl_._N_path_16453 == null)) ? _N_hasLeftRecImpl_16442(_N_CheckLeftRec_cp_16441, val, n_closureOf_hasLeftRecImpl_._N_visited_16455.Add(name), new list<NameRef>.Cons(name, n_closureOf_hasLeftRecImpl_._N_path_16453)) : _N_hasLeftRecImpl_16442(_N_CheckLeftRec_cp_16441, val, n_closureOf_hasLeftRecImpl_._N_visited_16455.Add(name), null)) ? 1 : 0);
				}
			}
			else
			{
				if (rule8 != option<Rule>.None._N_constant_object)
				{
					throw new MatchFailureException();
				}
				num = 0;
			}
			break;
		}
		case 3:
			if (((Rule.RepeatMin)rule).minCount == 0)
			{
				Rule rule10 = ((Rule.RepeatMin)rule).rule;
				num = (function2.apply(rule10) ? 1 : 0);
			}
			else
			{
				Rule rule11 = ((Rule.RepeatMin)rule).rule;
				num = (function2.apply(rule11) ? 1 : 0);
			}
			break;
		case 4:
			if (((Rule.RepeatMinMax)rule).minCount == 0)
			{
				Rule rule6 = ((Rule.RepeatMinMax)rule).rule;
				num = (function2.apply(rule6) ? 1 : 0);
			}
			else
			{
				Rule rule7 = ((Rule.RepeatMinMax)rule).rule;
				num = (function2.apply(rule7) ? 1 : 0);
			}
			break;
		case 5:
		case 6:
			num = 0;
			break;
		case 7:
		{
			Rule rule5 = ((Rule.Not)rule).rule;
			num = (function2.apply(rule5) ? 1 : 0);
			break;
		}
		case 8:
		{
			Rule rule4 = ((Rule.And)rule).rule;
			num = (function2.apply(rule4) ? 1 : 0);
			break;
		}
		case 9:
		{
			Rule rule3 = ((Rule.Capture)rule).rule;
			num = (function2.apply(rule3) ? 1 : 0);
			break;
		}
		case 10:
		{
			Rule rule2 = ((Rule.Scope)rule).rule;
			num = (function2.apply(rule2) ? 1 : 0);
			break;
		}
		case 11:
			num = 0;
			break;
		}
		bool flag3 = (byte)num != 0;
		_N_CheckLeftRec_cp_16441._N_memoize_16437[rule] = flag3;
		return flag3;
	}
}
